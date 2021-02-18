using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSL_APP.Utils;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;
using Microsoft.AspNetCore.Hosting;

namespace MSL_APP.Controllers
{
    public class CargaDatosController : Controller
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        public CargaDatosController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

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
                        Storage.Instance.tipoCarga = tipoCarga;
                        return RedirectToAction("cargaManual", "CargaDatos");
                    }

                    break;
                case "carga por archivo":
                    {
                        Storage.Instance.tipoCarga = tipoCarga;
                        return RedirectToAction("cargaArchivo", "CargaDatos");
                    }
                    break;
                default:
                    return View();
                    break;

            }
        }



        [HttpPost]
        public async Task<IActionResult> cargaArchivo(IFormFile file) {
           
            string csvFolder = Path.Combine(_hostingEnvironment.WebRootPath, "csv");
            var fileName = string.Empty;
            var path = string.Empty;
            string filePath = "";
            
            if (file.Length > 0)
            {
                filePath = Path.Combine(csvFolder, file.FileName);
                fileName = Path.GetFileName(file.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }

            Reader reader = new Reader(filePath);

            if (Storage.Instance.tipoLista == "lista artesanal")
            {
                return RedirectToAction("listaArtesanal", "Jugador");
            }
            else {
                return RedirectToAction("listaCSharp", "Jugador");
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

            if (Storage.Instance.tipoLista == "lista artesanal")
            {
                Storage.Instance.listaArtesanal.InsertarEnLista(
                Storage.Instance.listaArtesanal.nodoRaiz,
                Storage.Instance.listaArtesanal.nodoRaiz,
                nodoJugador);

                Storage.Instance.listaArtesanal.cantidadElementos();

                
            }
            else {
                Storage.Instance.listaCSharp.Add(nodoJugador);

              
            }
            return RedirectToAction("cargaManual", "CargaDatos");
        }
    }
    
}
