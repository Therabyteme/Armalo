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
    public class Status
    {
        [JsonProperty(PropertyName = "codigo")]
        public int codigo { get; set; }
        [JsonProperty(PropertyName = "mensaje")]
        public string mensaje { get; set; }
        [JsonProperty(PropertyName ="status")]
        public string status { get; set; }
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

    public class CrearEvento
        {
        
        }
    public class Moderar
    {

    }
    
    public class CrearStaff
    {

    }

    public class TransferTicket
    {

    }

    public class CrearAgenda
    {

    }
    public class Asistir
    {

    }
    public class Anunciar
    {

    }
    public class Invitar
    {

    }

    public class HistoriaCliente
    {
        [JsonProperty(PropertyName = "ID_USR")]
        public string ID_USR { get; set; }
        [JsonProperty(PropertyName = "ID_EVENT")]
        public string ID_EVENT { get; set; }
    }
}