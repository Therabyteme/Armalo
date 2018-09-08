using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Agenda
    {
        public Agenda()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdAgenda { get; set; }
        public string Eventos { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
