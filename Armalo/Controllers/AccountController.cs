﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
namespace Armalo.Controllers
{
    [Route("api/account/")]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("/api/account/login/")]
        public async Task<object> Login([FromBody] LoginDto model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Usuario, model.Contrasena, false, false);

            if (result.Succeeded)
            {
                var appUser = _userManager.Users.SingleOrDefault(r => r.UserName == model.Usuario);
                return await GenerateJwtToken(model.Usuario, appUser);
            }

            throw new ApplicationException("INVALID_LOGIN_ATTEMPT");
        }
        
        [HttpPost]
        [Route("/api/account/register/")]
        public async Task<object> Register([FromBody] RegisterDto model)
        {
            var user = new IdentityUser
            {
                UserName = model.Usuario,
                Email = model.Email,
               
            };
            var result = await _userManager.CreateAsync(user, model.Contrasena);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return await GenerateJwtToken(model.Email, user);
            }
            else
            {
                throw new ApplicationException("UNKNOWN_ERROR");
            }
            
        }

        private async Task<object> GenerateJwtToken(string email, IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        
        public class LoginDto
        {
            [Required]
            public string Usuario { get; set; }

            [Required]
            public string Contrasena { get; set; }

        }
        
        public class RegisterDto
        {
            [Required]
            public string Email { get; set; }
            [Required]
            public string Usuario { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
            public string Contrasena { get; set; }
        }
    }
}
