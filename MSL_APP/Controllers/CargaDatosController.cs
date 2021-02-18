using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSL_APP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;

namespace MSL_APP.Controllers
{
    public class CargaDatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public ActionResult cargaManual() {
            return View();
        }

        public ActionResult cargaArchivo()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(IFormCollection collection)
        {
            string tipoCarga = collection["tipoCarga"];
            switch (tipoCarga)
            {
                case "carga manual":
                    {
                        Storage.Instance.tipoLista = tipoCarga;
                        return RedirectToAction("cargaManual", "CargaDatos");
                    }

                    break;
                case "carga por archivo":
                    {
                        Storage.Instance.tipoLista = tipoCarga;
                        return RedirectToAction("cargaArchivo", "CargaDatos");
                    }
                    break;
                default:
                    return View();
                    break;

            }
        }


        [HttpPost]
        public ActionResult DatosManuales(IFormCollection collection)
        {
            string club = collection["club"];
            string apellido = collection["last_name"];
            string nombre = collection["first_name"];
            string posicion = collection["position"];
            string salario = collection["salary"];
            string compensacion = collection["compensation"];

            Nodo<string> nodoJugador = new Nodo<string> {
                club = club,
                first_name = nombre,
                last_name = apellido,
                position = posicion,
                base_salary = salario,
                guaranteed_compensation = compensacion
            
            };

            Storage.Instance.listaArtesanal.InsertarEnLista(
                Storage.Instance.listaArtesanal.nodoRaiz,
                Storage.Instance.listaArtesanal.nodoRaiz,
                nodoJugador);

            Storage.Instance.listaArtesanal.cantidadElementos();
            
            return RedirectToAction("cargaManual","CargaDatos");
        }
    }
    
}
