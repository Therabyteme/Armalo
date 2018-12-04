using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armalo.Models
{
    public class Interaccion
    {
        public Interaccion()
        {
            Evento = new HashSet<Evento>();
        }
        public int? id { get; set; }
        public int id_event { get; set; }
        public string interaccion { get; set; }
        public ICollection<Evento> Evento {get;set;}
    }
}
