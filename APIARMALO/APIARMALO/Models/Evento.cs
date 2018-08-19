using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIARMALO.Models
{
    public class Evento
    {
        public int ID_EVENT { get; set; }
        public int ID_LISTA { get; set; }
        public int ID_ORG { get; set; }
        public string Ubicacion { get; set; }
        public int Tipo { get; set; }
        public int CUPO_MAX { get; set; }
        public int CUPO_OCU { get; set; }
        public DateTime FECHA { get; set; }
        public int ESTADO { get; set; }
    }
}