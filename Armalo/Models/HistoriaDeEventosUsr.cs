using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class HistoriaDeEventosUsr
    {
        public int? IdUsr { get; set; }
        public int? IdEvent { get; set; }
        public int Id { get; set; }

        public Evento IdEventNavigation { get; set; }
    }
}
