using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Item
    {
        public Item()
        {
            Agendas = new HashSet<Agenda>();
        }

        public int IdItem { get; set; }
        public string Actividad { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
