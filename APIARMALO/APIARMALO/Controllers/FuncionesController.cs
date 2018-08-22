using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;

namespace APIARMALO.Controllers
{
    public class FuncionesController : ApiController
    {
        [Route ("/Evento/AgregarEvento"),HttpPost]
        public void AgregarEvento() //metodo que consume el api para agregar eventos
        {

        }
        [Route("/Usuario/AgregarUsuario"), HttpPost]
        public void RegistrarUsuario() //metodo que consume el api para crear usuarios
        {

        }
        [Route("/Administracion/Moderar"),HttpGet]
        public void ModerarEvento() //metodo que consume el api para moderar eventos
        {

        }
        [Route ("/Evento/RemoverEvento"),HttpDelete]
        public void RemoverEvento() //metodo que consume el api para quitar eventos
        {

        }
        [Route ("/Usuario/HistoriaUser"),HttpGet]
        public void MostrarHistoriaCliente() //metodo que consume el api para mostrar los eventos a los que fue el usuario anteriormente
        {

        }
        [Route ("/Usuario/HistoriaOrg"),HttpGet]
        public void MostrarHistoriaOrador() //metodo que consume el api para mostrar los eventos que el charlista dio anteriormente
        {

        }
        [Route ("/Administracion/Promo"),HttpPost]
        public void PromocionarEvento() //metodo que consume el api para promocionar los eventos en armalo!
        {

        }
        [Route ("/Usuario/Transfer"),HttpPut]
        public void TransferirTaquilla() //metodo que consume el api para transferir los cupos
        {

        }
        [Route ("/Usuario/Quit"),HttpDelete]
        public void RenunciarCupo()
        {

        }
        [Route ("/Evento/CrearStaff"),HttpPost]
        public void CrearStaff()
        {

        }
        [Route ("/Evento/VerAgenda"),HttpGet]
        public void VerAgenda()
        {

        }
        [Route ("/Evento/CrearAgenda"),HttpPost]
        public void CrearAgenda()
        {

        }
        [Route ("/Evento/VerStaff"),HttpGet]
        public void VerStaff()
        {

        }
        [Route ("/Usuario/Resume"),HttpGet]
        public void VerResume()
        {
            
        }
        [Route ("/Evento/TomarCupo"),HttpPost]
        public void TomarCupo()
        {

        }
            }
}
