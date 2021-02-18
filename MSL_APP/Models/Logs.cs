using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSL_APP.Models
{
    public class Logs
    {
        public string operacion { get; set; }
        public string tiempo { get; set; }
        public string tipoLista { get; set; }


        public string estructuraLog() {
            return "TIPO DE OPERACION: " + operacion + " TIEMPO TRANSCURRIDO: " + tiempo + " TIPO DE LISTA: " + tipoLista;
        }
    }
}
