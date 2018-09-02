using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIARMALO.Models;

namespace APIARMALO.ConMulti
{
    public interface IConexionBDD
    {
        /*interfaz para hacer que el api pueda conectarse a 
         * otras bases de datos (de similar tipo)
         * haciendo de la api mas flexible*/
        void Agregar_Agenda(Agenda agenda);
        void Agregar_Evento(Evento evento);
        void Agregar_Historia_1(Historia_de_eventos_org historia_De_Eventos_Org);
        void Agregar_Historia_2(Historia_de_eventos_usr de_Eventos_Usr);
        void Agregar_Lista(Lista_de_asistentes lista);
        void Agregar_Publicidad(Publicidad publicidad);
        void Agregar_Staff(Staff staff);
        void Agregar_Usuarios(Usuarios usuarios);
        IEnumerable<Agenda> GetAgendas();
        IEnumerable<Evento> GetEventos();
        IEnumerable<Historia_de_eventos_org> GetHistoria_De_Eventos_Orgs();
        IEnumerable<Historia_de_eventos_usr> GetHistoria_De_Eventos_Usrs();
        IEnumerable<Lista_de_asistentes> GetLista_De_Asistentes();
        IEnumerable<Publicidad> GetPublicidads();
        IEnumerable<Staff> GetStaffs();
        IEnumerable<Usuarios> GetUsuarios();
        //pendiente de fix, no probado
       /* Evento Find(int Id);
        void Remove(int Id);
        void Update();*/

    }
}