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

        public IActionResult listaCSharp()
        {
            return View(Storage.Instance.listaCSharp);

        }
        public IActionResult listaArtesanal()
        {
            return View(Storage.Instance.listaArtesanal);

        }


        public ActionResult Buscar() {

            return View();
        }

        public ActionResult buscarJugadorArtesanal(IFormCollection data)
        {
            if (Storage.Instance.tipoLista == "lista artesanal")
            {
                string tipoBusqueda = data["tipoBusqueda"];
                string busqueda = data["Busqueda"];

                Storage.Instance.listaArtesanal.BuscarEnLista(Storage.Instance.listaArtesanal.nodoRaiz,
                                   tipoBusqueda, busqueda);


                return View("RespuestaBusqueda", Storage.Instance.listaArtesanal.listaBusqueda);
            }
            else {

                string tipoBusqueda = data["tipoBusqueda"];
                string busqueda = data["Busqueda"];
                List<Nodo<string>> listaEncontrados = new List<Nodo<string>>();
                switch (tipoBusqueda)
                {
                    case "nombre,apellido":
                        {
                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.first_name+","+x.last_name) == busqueda);
                        }
                        break;
                    case "posicion":
                        {
                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.position) == busqueda);
                        }
                        break;
                    case "salario":
                        {
                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.base_salary) == busqueda);
                        }
                        break;
                    case "club":
                        {
                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.club) == busqueda);
                        }
                        break;
                }

                


                return View("RespuestaBusqueda", listaEncontrados);

            }
        }


        [HttpGet]
        public ActionResult eliminarJugador(string jugador)
        {

            if (Storage.Instance.tipoLista == "lista artesanal")
            {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaArtesanal.listaBusqueda.Find(x => (x.first_name + "," + x.last_name) == jugador);

                Storage.Instance.listaArtesanal.eliminarJugar(Storage.Instance.listaArtesanal.nodoRaiz, jugadorEncontrado);


                return RedirectToAction("listaArtesanal", "Jugador");
            }
            else
            {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaCSharp.Find(x => (x.first_name + "," + x.last_name) == jugador);

                Storage.Instance.listaCSharp.Remove(jugadorEncontrado);


                return RedirectToAction("listaCSharp", "Jugador");
            }
            
        }

        [HttpGet]
        public ActionResult editarJugador(string jugador)
        {

            if (Storage.Instance.tipoLista == "lista artesanal")
            {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaArtesanal.listaBusqueda.Find(x => (x.first_name + "," + x.last_name) == jugador);

                return View("editarJugador", jugadorEncontrado);
            }
            else {

                Nodo<string> jugadorEncontrado = Storage.Instance.listaCSharp.Find(x => (x.first_name + "," + x.last_name) == jugador);

                return View("editarJugador", jugadorEncontrado);
            }
           
        }

        [HttpPost]
        public ActionResult cambiarJugador(IFormCollection data)
        {

            if (Storage.Instance.tipoLista == "lista artesanal")
            {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaArtesanal.listaBusqueda.Find(x => (x.first_name + "," + x.last_name) == data["first_name"] + "," + data["last_name"]);

                jugadorEncontrado.base_salary = data["salary"];
                jugadorEncontrado.club = data["club"];
                return RedirectToAction("listaArtesanal", "Jugador");
            }
            else {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaCSharp.Find(x => (x.first_name + "," + x.last_name) == data["first_name"] + "," + data["last_name"]);
                jugadorEncontrado.base_salary = data["salary"];
                jugadorEncontrado.club = data["club"];
                return RedirectToAction("listaCSharp", "Jugador");
            }
                
        }
    }
}
