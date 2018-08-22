using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using Newtonsoft.Json;

namespace APIARMALO.Models
{
    public class General
    {
    }
    public class Login
    {
        [JsonProperty(PropertyName = "usuario")]
        public string usuario { get; set; }
        [JsonProperty(PropertyName = "contrasena")]
        public string contrasena { get; set; }
    }
    public class CrearUsuario
    {

        [JsonProperty(PropertyName = "nombre")]
        public string usuario { get; set; }
        [JsonProperty(PropertyName = "contrasena")]
        public string contrasena { get; set; }
        [JsonProperty(PropertyName = "correo")]
        public string correo { get; set; }
        [JsonProperty(PropertyName = "nivel")]
        public string nivel { get; set; }
    }

}