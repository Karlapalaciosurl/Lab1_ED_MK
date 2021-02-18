using System.Web;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MSL_APP.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MSL_APP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IFormCollection collection)
        {
            string tipoLista = collection["TipoLista"];
            switch (tipoLista)
            {
                case "lista artesanal":
                    {
                        Storage.Instance.tipoLista = tipoLista;
                        return RedirectToAction("Index", "CargaDatos");
                    }
                   
                    break;
                case "lista C#":
                    {
                        Storage.Instance.tipoLista = tipoLista;
                        return RedirectToAction("Index", "CargaDatos");
                    }
                    break;
                default:
                    return View();
                    break;

            }
        }
    }
}
