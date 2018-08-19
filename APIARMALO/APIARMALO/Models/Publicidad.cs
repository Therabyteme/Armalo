using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIARMALO.Models
{
    public class Publicidad
    {
        public int ID_EVENT { get; set; }
        public int ID_ADMIN { get; set; }
        public int Monto { get; set; }
        public int Duracion { get; set; }
        public DateTime Fecha { get; set; }
    }
}