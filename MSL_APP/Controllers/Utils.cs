using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSL_APP.Models;
using MSL_APP.Utils;
using System.Text;

namespace MSL_APP.Controllers
{
    public class Utils : Controller
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        public Utils(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();

        }

        public FileResult Descargar()
        {

            string text = "";
            foreach (Logs item in Storage.Instance.logs)
            {
                text += (item.estructuraLog() + Environment.NewLine); 

            }
            

            return File(Encoding.UTF8.GetBytes(text), "text/plain", "Logs_App.txt");
        }
    }
}
