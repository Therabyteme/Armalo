using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Publicidad
    {
        public int? IdEvent { get; set; }
        public int? IdAdmin { get; set; }
        public int? Monto { get; set; }
        public int? Duracion { get; set; }
        public DateTime? Fecha { get; set; }
        public int Id { get; set; }

        public Usuarios IdAdminNavigation { get; set; }
        public Evento IdEventNavigation { get; set; }
    }
}
