using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;


namespace MSL_APP.Utils
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {

            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }

        // Instancia del tipo de estructura que se utilizara
        public string tipoLista = "";
        public string tipoCarga = "";

        public ListaDobleEnl<string> listaArtesanal = new ListaDobleEnl<string>();
        public List<Nodo<string>> listaCSharp = new List<Nodo<string>>();


    }
}
