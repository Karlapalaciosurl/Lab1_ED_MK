using System;
using LstDoblementeEnlazada;

namespace tstLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDobleEnl<string> lista = new ListaDobleEnl<string>();

            Nodo<string> nodo1 = new Nodo<string>();
            nodo1.first_name = "Mariela";
            nodo1.last_name = "Torres";

            Nodo<string> nodo2 = new Nodo<string>();
            nodo2.first_name = "Gianluca";
            nodo2.last_name = "Bellaco";

            Nodo<string> nodo3 = new Nodo<string>();
            nodo3.first_name = "Karla";
            nodo3.last_name = "Palacios";


            lista.InsertarEnLista(lista.nodoRaiz, lista.nodoRaiz, nodo1);
            lista.InsertarEnLista(lista.nodoRaiz, lista.nodoRaiz, nodo2);
            lista.InsertarEnLista(lista.nodoRaiz, lista.nodoRaiz, nodo3);

            lista.BuscarEnLista(lista.nodoRaiz,"nombre,apellido", "Mariela,Torres");

            Console.WriteLine(lista.nodoRaiz);
            Console.ReadLine();
        }
    }
}
