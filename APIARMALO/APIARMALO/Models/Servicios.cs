using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace APIARMALO.Models
{
    public class Servicios
    {
       
        public String Host { get; set; }
        public String Port { get; set; }
        public String InsertUser { get; set; }
        public String UpdateUser { get; set; }
        public String SelectUser { get; set; }
        public String DataBase { get; set; }
        public String InsertUserPwd { get; set; }
        public String UpdateUserPwd { get; set; }
        public String SelectUserPwd { get; set; }

        
        public void verevento()
        {
            string Conexion = "server = localhost;database = armalo;uid=root;pwd=Sadie1996;";
            string Query = "select * from armalo.evento;";
            MySqlConnection conn = new MySqlConnection(Conexion);
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;
            


            
        }
        public HistoriaCliente listacliente(string ID_USR, string ID_EVENT)
        {
            string Conexion = "server = localhost;database = armalo;uid=root;pwd=Sadie1996;";
            string Query = "select * from armalo.historia_de_eventos_usuario;";
            MySqlConnection conn = new MySqlConnection(Conexion);
            Status st = new Status();
            HistoriaCliente cli = new HistoriaCliente();
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            return listacliente(ID_USR, ID_EVENT);
        }

    }
}