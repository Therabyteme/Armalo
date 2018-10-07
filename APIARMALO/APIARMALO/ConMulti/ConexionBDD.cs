using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIARMALO.Models;
using MySql.Data.MySqlClient;
using APIARMALO.Models;

namespace APIARMALO.ConMulti
{
    

    public class ConexionBDD : IUsuariosBDD
    {
        static MySqlConnection db = null;
        public static MySqlConnection Conectar()
        {
            if(db == null)
            {
                
                
            }
            return db;
           
        }
        static List<Evento> Eventos = new List<Evento>();
        static List<Agenda> Agendas = new List<Agenda>();
        static List<Usuarios> Usuariosl = new List<Usuarios>();
        static List<Historia_de_eventos_org> histo1 = new List<Historia_de_eventos_org>();
        static List<Historia_de_eventos_usr> histo2 = new List<Historia_de_eventos_usr>();
        static List<Publicidad> Publicidads = new List<Publicidad>();
        static List<Staff> Staffs = new List<Staff>();
        static List<Lista_de_asistentes> Listas = new List<Lista_de_asistentes>();
        public bool Agregar_Evento(Evento evento)
        {
            
        }
        public void Agregar_Agenda(Agenda agenda)
        {
            Agendas.Add(agenda);
        }
        public void Agregar_Historia_1(Historia_de_eventos_org historia_De_Eventos_Org)
        {
            histo1.Add(historia_De_Eventos_Org);
        }
        public void Agregar_Historia_2(Historia_de_eventos_usr historia_De_Eventos_Usr)
        {
            histo2.Add(historia_De_Eventos_Usr);
        }
        public void Agregar_Staff(Staff staff)
        {
            Staffs.Add(staff);
        }
        public void Agregar_Lista(Lista_de_asistentes lista_De_Asistentes)
        {
            Listas.Add(lista_De_Asistentes);
        }
        public void Agregar_Usuarios(Usuarios usuarios)
        {
            Usuariosl.Add(usuarios);
        }
        public void Agregar_Publicidad(Publicidad publicidad)
        {
            Publicidads.Add(publicidad);
        }
        


        public IEnumerable<Evento> GetEventos()
        {
            return Eventos;
        }
        public IEnumerable<Agenda> GetAgendas()
        {
            return Agendas;
        }
        public IEnumerable<Usuarios> GetUsuarios()
        {
            return Usuariosl;
        }
        public IEnumerable<Staff> GetStaffs()
        {
            return Staffs;
        }
        public IEnumerable<Publicidad> GetPublicidads()
        {
            return Publicidads;
        }
        public IEnumerable<Lista_de_asistentes> GetLista_De_Asistentes()
        {
            return Listas;
        }
        public IEnumerable<Historia_de_eventos_org> GetHistoria_De_Eventos_Orgs()
        {
            return histo1;
        }
        public IEnumerable<Historia_de_eventos_usr> GetHistoria_De_Eventos_Usrs()
        {
            return histo2;
        }

        public Usuarios Find(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Evento evento)
        {
            throw new NotImplementedException();
        }
    }
}