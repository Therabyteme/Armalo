using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armalo.Models
{
    public class RetroAlimentacion
    {
        public int Id { get; set; }
        public int general { get; set; }
        public int organizacion { get; set; }
        public int puntualidad { get; set; }
        public int agenda { get; set; }
        public int organizadores { get; set; }
        public string Descripcion { get; set; }
        public int IdEvent { get; set; }

    }
}
