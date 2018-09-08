using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class HistoriaDeEventosOrg
    {
        public int IdOrg { get; set; }
        public int IdEvent { get; set; }

        public Evento IdEventNavigation { get; set; }
    }
}
