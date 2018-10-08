using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armalo.Models
{
    public class EventoTags
    {
        public int IdEvent { get; set; }
        public int IdTag { get; set; }
        public Tags tag { get; set; }
    }
}
