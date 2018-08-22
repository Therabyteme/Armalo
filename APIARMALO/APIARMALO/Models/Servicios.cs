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
        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
        public String Host { get; set; }
        public String Port { get; set; }
        public String InsertUser { get; set; }
        public String UpdateUser { get; set; }
        public String SelectUser { get; set; }
        public String DataBase { get; set; }
        public String InsertUserPwd { get; set; }
        public String UpdateUserPwd { get; set; }
        public String SelectUserPwd { get; set; }

      /*  public string evento()
        {
            string evento = "";
            MySqlCommand cmd = conn.CreateCommand();
            conn.CommandText = "SELECT * FROM armalo.eventos;"+evento;

            try
            {
                conn.Open();
            } catch(Exception ex)
            {
                
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

            }
            return evento;
        }*/

    }
}