using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;
using MSL_APP.Utils;
using Microsoft.AspNetCore.Http;

namespace MSL_APP.Controllers
{
    public class JugadorController : Controller
    {
        public IActionResult listaArtesanal()
        {
            return View(Storage.Instance.listaArtesanal);

        }


        public ActionResult Buscar() {

            return View();
        }

        public ActionResult buscarJugadorArtesanal(IFormCollection data)
        {
            string tipoBusqueda = data["tipoBusqueda"];
            string busqueda = data["Busqueda"];

            Storage.Instance.listaArtesanal.BuscarEnLista(Storage.Instance.listaArtesanal.nodoRaiz,
                               tipoBusqueda, busqueda);


            return View("RespuestaBusqueda", Storage.Instance.listaArtesanal.listaBusqueda);
        }


        [HttpGet]
        public ActionResult eliminarJugadorArtesanal(string jugador)
        {
            Nodo<string> jugadorEncontrado = Storage.Instance.listaArtesanal.listaBusqueda.Find(x => (x.first_name + "," + x.last_name) == jugador);

            Storage.Instance.listaArtesanal.eliminarJugar(Storage.Instance.listaArtesanal.nodoRaiz, jugadorEncontrado);


            return RedirectToAction("listaArtesanal", "Jugador");
        }

        [HttpGet]
        public ActionResult editarJugadorArtesanal(string jugador)
        {
            Nodo<string> jugadorEncontrado = Storage.Instance.listaArtesanal.listaBusqueda.Find(x => (x.first_name + "," + x.last_name) == jugador);

            return View("editarJugador", jugadorEncontrado);
        }

        [HttpPost]
        public ActionResult cambiarJugador(IFormCollection data)
        {
            Nodo<string> jugadorEncontrado = Storage.Instance.listaArtesanal.listaBusqueda.Find(x => (x.first_name + "," + x.last_name) == data["first_name"]+","+ data["last_name"]);

            jugadorEncontrado.base_salary = data["salary"];
            jugadorEncontrado.club = data["club"];
            return RedirectToAction("listaArtesanal", "Jugador");
        }
    }
}
