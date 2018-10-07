using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Data.Entity;

namespace APIARMALO.Models
{
    public class General
    {
        
    }
    public class Conexion : DbContext
    {
        public Conexion() : base(nameOrConnectionString: "armalo")
        { }
            public virtual DbSet<Servicios> Servicios {get; set;}
        
    }
    public class Agenda
    {
        [JsonProperty(PropertyName = "id_agenda")]
        public int id_agenda { get; set; }
        [JsonProperty (PropertyName = "Eventos")]
        public string Eventos { get; set; }
    }

    public class Evento
    {
        [JsonProperty(PropertyName = "ID_EVENT")]
        public int ID_EVENT { get; set; }
        [JsonProperty(PropertyName = "ID_LISTA")]
        public int ID_LISTA { get; set; }
        [JsonProperty(PropertyName = "ID_ORG")]
        public int ID_ORG { get; set; }
        [JsonProperty(PropertyName = "Ubicacion")]
        public string Ubicacion { get; set; }
        [JsonProperty(PropertyName = "Tipo")]
        public int Tipo { get; set; }
        [JsonProperty(PropertyName = "CUPO_MAX")]
        public int CUPO_MAX { get; set; }
        [JsonProperty(PropertyName = "CUPO_OCU")]
        public int CUPO_OCU { get; set; }
        [JsonProperty(PropertyName = "Agenda")]
        public int Agenda { get; set; }
        [JsonProperty (PropertyName = "Staff")]
        public int Staff { get; set; }
    }
    public class Historia_de_eventos_org
    {
        [JsonProperty(PropertyName = "ID_ORG")]
        public int ID_ORG { get; set; }
        [JsonProperty(PropertyName = "ID_EVENT")]
        public int ID_EVENT { get; set; }
    }

    public class Historia_de_eventos_usr
    {
        [JsonProperty(PropertyName = "ID_USR")]
        public int ID_USR { get; set; }
        [JsonProperty (PropertyName = "ID_EVENT")]
        public int ID_EVENT { get; set; }
    }
    public class Lista_de_asistentes
    {
        [JsonProperty(PropertyName ="ID_LISTA")]
        public int ID_LISTA { get; set; }
        [JsonProperty(PropertyName ="ID_USR")]
        public int ID_USR { get; set; }
        [JsonProperty (PropertyName ="ID_EVENT")]
        public int ID_EVENT { get; set; }
    }
    public class Publicidad
    {
        [JsonProperty(PropertyName = "ID_EVENT")]
        public int ID_EVENT { get; set; }
        [JsonProperty(PropertyName ="ID_ADMIN")]
        public int ID_ADMIN { get; set; }
        [JsonProperty(PropertyName ="Monto")]
        public int Monto { get; set; }
        [JsonProperty(PropertyName = "Duracion")]
        public int Duracion { get; set; }
        [JsonProperty(PropertyName = "Fecha")]
        public DateTime Fecha { get; set; }
    }
    public class Staff
    {
        [JsonProperty(PropertyName ="ID_STAFF")]
        public int ID_STAFF { get; set; }
        [JsonProperty(PropertyName ="ID_USR")]
        public int ID_USR { get; set; }
    }

    public class Usuarios
    {
        [JsonProperty(PropertyName = "ID_USR")]
        public int ID_USR { get; set; }
        [JsonProperty(PropertyName = "Resume")]
        public string Resume { get; set; }
        [JsonProperty(PropertyName ="TipoUSR")]
        public int TipoUSR { get; set; }
        [JsonProperty(PropertyName ="Nombre_USR")]
        public string Nombre_USR { get; set; }
        [JsonProperty(PropertyName ="Pass")]
        public string Pass { get; set; }
    }
        
  /*  public class Status
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
        [JsonProperty(PropertyName = "nombre")]
        public string evento { get; set; }
        [JsonProperty(PropertyName = "ubicacion")]
        public string ubicacion { get; set; }
        [JsonProperty(PropertyName = "cupo_max")]
        public int cupo_max { get; set; }
        [JsonProperty (PropertyName = "Fecha")]
        public DateTime Fecha { get; set; }
        [JsonProperty(PropertyName = "id_lista")]
        public int id_lista { get; set; }
        [JsonProperty(PropertyName = "Staff")]
        public int staff { get; set; }

        }
    public class Moderar
    {
        [JsonProperty(PropertyName = "id_event")]
        public int id_event { get; set; }
        [JsonProperty(PropertyName = "id_admin")]
        public int id_admin { get; set; }
        [JsonProperty(PropertyName = "estado")]
        public int estado { get; set; }
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
        [JsonProperty(PropertyName = "ID_USR")]
        public int ID_USR;
        [JsonProperty(PropertyName = "ID_EVENT")]
        public int ID_EVENT;
        [JsonProperty(PropertyName = "CUPO_OCU")]
        public int CUPO_OCU { get; set; }
        [JsonProperty (PropertyName = "CUPO_MAX")]
        public int CUPO_MAX { get; set; }
    }
    public class Anunciar
    {
        [JsonProperty(PropertyName = "ID_EVENT")]
        public int ID_EVENT { get; set; }
        [JsonProperty(PropertyName = "Monto")]
        public int Monto { get; set; }
        [JsonProperty(PropertyName = "Duracion")]
        public int Duracion { get; set; }
        [JsonProperty(PropertyName = "Fecha")]
        public DateTime Fecha { get; set; }
    }
    public class Invitar
    {

    }

    public class HistoriaCliente
    {
        [JsonProperty(PropertyName = "ID_USR")]
        public int ID_USR { get; set; }
        [JsonProperty(PropertyName = "ID_EVENT")]
        public int ID_EVENT { get; set; }
    }

    public class HistoriaOrador
    {
        [JsonProperty(PropertyName = "ID_USR")]
        public int ID_USR { get; set; }
        [JsonProperty(PropertyName ="ID_EVENT")]
        public int ID_EVENT { get; set; }
    }
    */
   
}