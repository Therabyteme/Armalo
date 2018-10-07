using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Items
    {
        public Items()
        {
        }

        public int IdItem { get; set; }
        public int IdAgenda { get; set; }
        public string Actividad { get; set; }

    }
}
