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
        /*  private ConectarBD()
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
          }*/
    public ConectarBD()
        {
            //Metodo para definir la conexion con la base de datos de armalo
            string conexion = "server = localhost;database = armalo;uid=root;pwd=Sadie1996;";
            MySqlConnection conn = new MySqlConnection(conexion);
            //el nombre de usuario, el server y la clave deben ser cambiados
            //cuando este montada en el servidor, para que lo prueben en su computadora, solo cambien al nombre de usuario y a su clave en mysql workbench
            try
            {
                conn.Open();
                System.Diagnostics.Debug.WriteLine("Conectado Exitosamente!!");
                conn.Close();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("No se pudo conectar");
            }
        }

    }
    
}