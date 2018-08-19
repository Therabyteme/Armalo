using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIARMALO.Models
{
    public class Usuarios
    {
        public int USR_ID { get; set; }
        public string Resume { get; set; }
        public int TipoUSR { get; set; }
        public string Nombre_USR { get; set; }
    }
}