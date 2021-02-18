using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;
using MSL_APP.Utils;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using MSL_APP.Models;

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
                
                //Inicio reloj
                Stopwatch timeMeasure = new Stopwatch();
                timeMeasure.Start();
                
                
                Storage.Instance.listaArtesanal.BuscarEnLista(Storage.Instance.listaArtesanal.nodoRaiz,
                                   tipoBusqueda, busqueda);

                //Finalizacion Reloj
                timeMeasure.Stop();

                Logs log = new Logs { 
                     operacion = "Buscar Jugador",
                     tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                     tipoLista = "Lista Artesanal"

                };

                Storage.Instance.logs.Add(log);

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
                            //Inicio reloj
                            Stopwatch timeMeasure = new Stopwatch();
                            timeMeasure.Start();

                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.first_name+","+x.last_name) == busqueda);

                            //Finalizacion Reloj
                            timeMeasure.Stop();

                            Logs log = new Logs
                            {
                                operacion = "Buscar Jugador por nombre,apellido",
                                tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                                tipoLista = "Lista C#"

                            };

                            Storage.Instance.logs.Add(log);
                        }
                        break;
                    case "posicion":
                        {
                            //Inicio reloj
                            Stopwatch timeMeasure = new Stopwatch();
                            timeMeasure.Start();

                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.position) == busqueda);

                            //Finalizacion Reloj
                            timeMeasure.Stop();

                            Logs log = new Logs
                            {
                                operacion = "Buscar Jugador por Posicion",
                                tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                                tipoLista = "Lista C#"

                            };

                            Storage.Instance.logs.Add(log);
                        }
                        break;
                    case "salario":
                        {
                            //Inicio reloj
                            Stopwatch timeMeasure = new Stopwatch();
                            timeMeasure.Start();

                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.base_salary) == busqueda);

                            //Finalizacion Reloj
                            timeMeasure.Stop();

                            Logs log = new Logs
                            {
                                operacion = "Buscar Jugador por salario",
                                tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                                tipoLista = "Lista C#"

                            };

                            Storage.Instance.logs.Add(log);
                        }
                        break;
                    case "club":
                        {
                            //Inicio reloj
                            Stopwatch timeMeasure = new Stopwatch();
                            timeMeasure.Start();

                            listaEncontrados = Storage.Instance.listaCSharp.FindAll(x => (x.club) == busqueda);

                            //Finalizacion Reloj
                            timeMeasure.Stop();

                            Logs log = new Logs
                            {
                                operacion = "Buscar Jugador por club",
                                tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                                tipoLista = "Lista C#"

                            };

                            Storage.Instance.logs.Add(log);
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

                //Inicio reloj
                Stopwatch timeMeasure = new Stopwatch();
                timeMeasure.Start();

                Storage.Instance.listaArtesanal.eliminarJugar(Storage.Instance.listaArtesanal.nodoRaiz, jugadorEncontrado);

                //Finalizacion Reloj
                timeMeasure.Stop();

                Logs log = new Logs
                {
                    operacion = "Eliminar Jugador",
                    tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                    tipoLista = "Lista Artesanal"

                };

                Storage.Instance.logs.Add(log);

                return RedirectToAction("listaArtesanal", "Jugador");
            }
            else
            {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaCSharp.Find(x => (x.first_name + "," + x.last_name) == jugador);


                //Inicio reloj
                Stopwatch timeMeasure = new Stopwatch();
                timeMeasure.Start();

                Storage.Instance.listaCSharp.Remove(jugadorEncontrado);

                //Finalizacion Reloj
                timeMeasure.Stop();

                Logs log = new Logs
                {
                    operacion = "Eliminar Jugador",
                    tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                    tipoLista = "Lista C#"

                };

                Storage.Instance.logs.Add(log);

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

                //Inicio reloj
                Stopwatch timeMeasure = new Stopwatch();
                timeMeasure.Start();


                jugadorEncontrado.base_salary = data["salary"];
                jugadorEncontrado.club = data["club"];

                //Finalizacion Reloj
                timeMeasure.Stop();

                Logs log = new Logs
                {
                    operacion = "Editar Jugador",
                    tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                    tipoLista = "Lista Artesanal"

                };

                Storage.Instance.logs.Add(log);

                return RedirectToAction("listaArtesanal", "Jugador");
            }
            else {
                Nodo<string> jugadorEncontrado = Storage.Instance.listaCSharp.Find(x => (x.first_name + "," + x.last_name) == data["first_name"] + "," + data["last_name"]);

                //Inicio reloj
                Stopwatch timeMeasure = new Stopwatch();
                timeMeasure.Start();

                jugadorEncontrado.base_salary = data["salary"];
                jugadorEncontrado.club = data["club"];


                //Finalizacion Reloj
                timeMeasure.Stop();

                Logs log = new Logs
                {
                    operacion = "Editar Jugador",
                    tiempo = timeMeasure.Elapsed.TotalMilliseconds.ToString() + " ms",
                    tipoLista = "Lista C#"

                };

                Storage.Instance.logs.Add(log);

                return RedirectToAction("listaCSharp", "Jugador");
            }
                
        }
    }
}
