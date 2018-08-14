using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace APIARMALO.Controllers
{
    public class ConectarBD
    {
        private ConectarBD()
        {

        }
        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }
        private static ConectarBD _instance = null;
        public static ConectarBD Instance()
        {
            if (_instance == null)
                _instance = new ConectarBD();
            return _instance;
        }
        public bool IsConnect()
        {
            if(Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("",databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();

            }
            return true;
        }
        public void Close()
        {
            connection.Close();
        }
    }
}