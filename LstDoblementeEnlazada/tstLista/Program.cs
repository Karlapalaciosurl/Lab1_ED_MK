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
            nodo1.club = "CHI";
            nodo1.first_name = "Mariela";
            nodo1.last_name = "Torres";
            nodo1.position = "F";
            nodo1.base_salary = "225000.0";

            Nodo<string> nodo2 = new Nodo<string>();
            nodo2.club = "CHI";
            nodo2.first_name = "Gianluca";
            nodo2.last_name = "Bellaco";
            nodo2.position = "D-M";
            nodo2.base_salary = "225000.0";

            Nodo<string> nodo3 = new Nodo<string>();
            nodo3.club = "CHV";
            nodo3.first_name = "Karla";
            nodo3.last_name = "Palacios";
            nodo3.position = "F";
            nodo3.base_salary = "225000.0";


            lista.InsertarEnLista(lista.nodoRaiz, lista.nodoRaiz, nodo1);
            lista.InsertarEnLista(lista.nodoRaiz, lista.nodoRaiz, nodo2);
            lista.InsertarEnLista(lista.nodoRaiz, lista.nodoRaiz, nodo3);

            lista.BuscarEnLista(lista.nodoRaiz,"nombre,apellido", "Mariela,Torres");

            Console.WriteLine(lista.nodoRaiz);

            lista.BuscarEnLista(lista.nodoRaiz, "salario", "225000.0");
            Console.WriteLine(lista.nodoRaiz);

            lista.BuscarEnLista(lista.nodoRaiz, "posicion", "F");
            Console.WriteLine(lista.nodoRaiz);
            Console.ReadLine();
        }
    }
}
