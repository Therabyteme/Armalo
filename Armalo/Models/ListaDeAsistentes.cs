using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class ListaDeAsistentes
    {
        public ListaDeAsistentes()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdLista { get; set; }
        public int? IdUsr { get; set; }
        public int IdEvent { get; set; }
        public string nombre { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
