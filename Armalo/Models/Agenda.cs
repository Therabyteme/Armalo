using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Agenda
    {
        public Agenda()
        {
        }

        public int IdAgenda { get; set; }
        public string Eventos { get; set; }

        public ICollection<Items> Item { get; set; }
    }
}
