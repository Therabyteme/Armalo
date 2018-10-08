using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armalo.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int id_evento { get; set; }
        public ICollection<EventoTags> EventoTags { get; set; }
    }
}
