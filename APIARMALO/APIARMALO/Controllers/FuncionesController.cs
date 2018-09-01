using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using MySql.Data.MySqlClient;
using APIARMALO.Models;
using System.Web.Mvc;
namespace APIARMALO.Controllers
{
    public class FuncionesController : Controller
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
        public ActionResult MostrarHistoriaCliente() //metodo que consume el api para mostrar los eventos a los que fue el usuario anteriormente
        {
            ConectarBD con = ConectarBD.Connectar();
            HistoriaCliente cli = new HistoriaCliente();

            var ID_USR = Request.Headers["ID_USR"].ToString();
            var ID_EVENT = Request.Headers["ID_EVENT"].ToString();

            Servicios ser = new Servicios();
            HistoriaCliente historiaCliente = ser.listacliente(ID_USR, ID_EVENT);
            return Json(historiaCliente, JsonRequestBehavior.AllowGet);

           
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
