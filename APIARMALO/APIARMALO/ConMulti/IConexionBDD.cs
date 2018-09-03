using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIARMALO.Models;

namespace APIARMALO.ConMulti
{
    public interface IUsuariosBDD
    {
        /*interfaz para hacer que el api pueda conectarse a 
         * otras bases de datos (de similar tipo)
         * haciendo de la api mas flexible*/
        void Agregar_Usuarios(Usuarios usuarios);
        IEnumerable<Usuarios> GetUsuarios();
        //pendiente de fix, no probado
        Usuarios Find(int Id);
        void Remove(int Id);
        void Update(Evento evento);

    }
    public interface IAgendaBDD
    {
        void Agregar_Agenda(Agenda agenda);
        IEnumerable<Agenda> GetAgendas();
        Agenda Find(int Id);
        void Remove(int Id);
        void Update(Agenda agenda);
    }
    public interface IEventoBDD
    {
        void Agregar_Evento(Evento evento);
        IEnumerable<Evento> GetEventos();
        Evento Find(int ID);
        void Remove(int ID);
        void Update(Evento evento);
    }
    public interface IHistoria_1BDD
    {
        void Agregar_Historia_1(Historia_de_eventos_org historia_De_Eventos_Org);
        IEnumerable<Historia_de_eventos_org> GetHistoria_De_Eventos_Orgs();
        Historia_de_eventos_org Find(int ID);
        void Remove(int ID);
        void Update(Historia_de_eventos_org histo1);
    }
    public interface IHistoria_2BDD
    {
        void Agregar_Historia_2(Historia_de_eventos_usr de_Eventos_Usr);
        IEnumerable<Historia_de_eventos_usr> GetHistoria_De_Eventos_Usrs();
        Historia_de_eventos_usr Find(int ID);
        void Remove(int ID);
        void Update(Historia_de_eventos_usr histo2);
    }
    public interface IListaBDD
    {
        void Agregar_Lista(Lista_de_asistentes lista);
        IEnumerable<Lista_de_asistentes> GetLista_De_Asistentes();
        Lista_de_asistentes Find(int ID);
        void Remove(int ID);
        void Update(Lista_de_asistentes lista);
    }
    public interface IPublicidadBDD
    {
        void Agregar_Publicidad(Publicidad publicidad);
        IEnumerable<Publicidad> GetPublicidads();
        Publicidad Find(int ID);
        void Remove(int ID);
        void Update(Publicidad publicidad);
    }
    public interface IStaffBDD
    {
        void Agregar_Staff(Staff staff);
        IEnumerable<Staff> GetStaffs();
        Staff Find(int ID);
        void Remove(int ID);
        void Update(Staff staff);
    }

}