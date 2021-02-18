using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;
using MSL_APP.Utils;

namespace MSL_APP.Controllers
{
    public class JugadorController : Controller
    {
        public IActionResult listaArtesanal()
        {
            return View(Storage.Instance.listaArtesanal);

        }
    }
}
