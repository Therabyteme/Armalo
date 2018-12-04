using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http;

namespace Armalo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManualController : ControllerBase
    {
        // GET: api/Manual
        [HttpGet]
        public  IActionResult Get(int id)
        {

             var stream = new FileStream(@"C:\Users\Brandon\Downloads\CISSP 8 Domains.pdf", FileMode.Open);

                  return File(stream, "placeholder/png", "CISSP 8 Domains.pdf");
          





        }


        // POST: api/Manual
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Manual/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
