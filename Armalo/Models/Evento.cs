using System;
using System.Collections.Generic;

namespace Armalo.Models
{
    public partial class Evento
    {
        public Evento()
        {
            HistoriaDeEventosOrg = new HashSet<HistoriaDeEventosOrg>();
            HistoriaDeEventosUsr = new HashSet<HistoriaDeEventosUsr>();
            Publicidad = new HashSet<Publicidad>();
        }

        public int IdEvent { get; set; }
        public int? IdLista { get; set; }
        public int? IdOrg { get; set; }
        public string location { get; set; }
        public int Precio { get; set; }
        public int? Tipo { get; set; }
        public int CupoMax { get; set; }
        public int? CupoOcu { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
        public int? IdAgenda { get; set; }
        public int Staff { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Agenda AgendaNavigation { get; set; }
        public ListaDeAsistentes IdListaNavigation { get; set; }
        public ICollection<EventoTags> EventoTags { get; set; }
        public ICollection<RetroAlimentacion> retroAlimentaciones {get; set;}
        public Usuarios IdOrgNavigation { get; set; }
        public Staff StaffNavigation { get; set; }
        public ICollection<HistoriaDeEventosOrg> HistoriaDeEventosOrg { get; set; }
        public ICollection<HistoriaDeEventosUsr> HistoriaDeEventosUsr { get; set; }
        public ICollection<Publicidad> Publicidad { get; set; }
        public TimeSpan inicio { get; set; }
        public TimeSpan fin { get; set; }
    }
}
