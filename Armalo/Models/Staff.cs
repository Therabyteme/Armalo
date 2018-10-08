using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdStaff { get; set; }
        public string Nom { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Evento> Evento { get; set; }
    }
}
