using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using APIARMALO.Models;

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
        public HistoriaCliente listacliente(string ID_USR)
        {
            string Conexion = "server = localhost;database = armalo;uid=root;pwd=Sadie1996;";
            string Query = "select * from armalo.historia_de_eventos_usuario;";
            MySqlConnection conn = new MySqlConnection(Conexion);
            Status st = new Status();
            HistoriaCliente cli = new HistoriaCliente();
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            try
            {
                conn.Open();
            }
            catch
            {
                try
                {
                    conn.Close();
                }
                catch
                {

                }
                cli.ID_USR = "";
                cli.ID_EVENT = "";
                st.mensaje = "Error en la conexión con la base de datos";
                return listacliente(ID_USR);
            }
            return listacliente(ID_USR);
        }
        public HistoriaOrador listaorador(string USR_ID)
        {
            return listaorador;
        }
    }
}