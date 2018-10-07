using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Armalo.Models;
using MySqlConnector;
using MySql.Data.MySqlClient;
namespace Armalo
{
    public class db : IDisposable
    {
        private readonly MySqlConnection dab;
        private Func<string, string, string> getString;

        public db (string ConnectionString)
        {
            dab = new MySqlConnection(ConnectionString);
            dab.OpenAsync().GetAwaiter().GetResult();
        }

        public db(Func<string, string, string> getString)
        {
            this.getString = getString;
        }

        public void Dispose()
        {
            dab.Close();
        }
    }
   
}