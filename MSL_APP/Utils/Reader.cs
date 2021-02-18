using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LstDoblementeEnlazada;

namespace MSL_APP.Utils
{
    public class Reader
    {
        public Reader(string ruta)
        {
            string[] lineasCsv = File.ReadAllLines(ruta);
            readerLineByLine(lineasCsv);

        }

        bool isFirstLine = true;

        public void readerLineByLine(string[] lineasCsv)
        {

            foreach (var linea in lineasCsv)
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue;
                }

                var lineaDeDatos = linea.Split(',');
                
           

                Nodo<string> nodo = new Nodo<string>
                {
                    club = lineaDeDatos[0],
                    last_name = lineaDeDatos[1],
                    first_name = lineaDeDatos[2],
                    position = lineaDeDatos[3],
                    base_salary = lineaDeDatos[4],
                    guaranteed_compensation = lineaDeDatos[5],
                };


                if (Storage.Instance.tipoLista == "lista artesanal")
                {
                    Storage.Instance.listaArtesanal.InsertarEnLista(Storage.Instance.listaArtesanal.nodoRaiz,
                        Storage.Instance.listaArtesanal.nodoRaiz, nodo);
                }
                if (Storage.Instance.tipoLista == "lista C#")
                {
                    
                    Storage.Instance.listaCSharp.Add(nodo);
                }
                

               


            }
        }
    }
}
