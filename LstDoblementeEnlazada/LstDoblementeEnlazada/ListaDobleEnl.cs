using System;
using System.Collections.Generic;
using System.Text;

namespace LstDoblementeEnlazada
{
    public class ListaDobleEnl<T> : IBusquedas<T>
    {
        //Nodo Raiz de la lista doblemente enlazada

        public Nodo<T> nodoRaiz { get; set; }
        public Nodo<T> nodoRaizBusqueda { get; set; }

        public List<Nodo<T>> listaBusqueda = new List<Nodo<T>>();

        public ListaDobleEnl()
        {
            nodoRaiz = null;
        }

        //Metodo para contar la cantidad de Nodos actuales en la lista
        public int cantidadElementos()
        {
            int cantidadNodos = 0;
            Nodo<T> nodoContador = nodoRaiz;

            while (nodoContador != null)
            {
                nodoContador = nodoContador.nodoSiguiente;
                cantidadNodos++;
            }

            return cantidadNodos;
        }


        //Metodo para insertar de manera recursiva los nodos en la lista
        public void InsertarEnLista(Nodo<T> nodoAnterior, Nodo<T> nodoActual, Nodo<T> nodoEntrante)
        {
            if (nodoEntrante != null)
            {

                if (nodoRaiz == null)
                {
                    nodoRaiz = nodoEntrante;
                }
                else {
                    if (nodoActual == null)
                    {
                        nodoActual = nodoEntrante;

                        if (nodoAnterior != null)
                        {
                            nodoActual.nodoAnterior = nodoAnterior;
                            nodoAnterior.nodoSiguiente = nodoActual;
                        }
                    }
                    else
                    {
                        InsertarEnLista(nodoActual, nodoActual.nodoSiguiente, nodoEntrante);
                    }

                }

            }
        }



        public void BuscarEnLista(Nodo<T> raiz, string tipoBusqueda, string busqueda)
        {
            switch (tipoBusqueda)
            {
                case "nombre,apellido":
                    {
                        busquedaNombre_Apellido(raiz,busqueda);
                    }
                    break;
            }
        }

        public void busquedaNombre_Apellido(Nodo<T> raiz, string busqueda)
        {
 
           

            if (raiz != null)
            {
                while (raiz != null)
                {
                    

                    DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(raiz.nombre_Apellido);
                    string nombre_apellido = delegadoGen(raiz.first_name + "|" + raiz.last_name);
                    if (nombre_apellido == busqueda)
                    {
                        listaBusqueda.Add(raiz);
                    }

                    raiz = raiz.nodoSiguiente;
                }
            }
        }

        public void busquedaPosicion(string busqueda)
        {
            Nodo<T> nodoContador = new Nodo<T>();

            while (nodoContador != null)
            {
                nodoContador = nodoContador.nodoSiguiente;

                DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(nodoContador.nombre_Apellido);
                string nombre_apellido = delegadoGen(nodoContador.first_name + "|" + nodoContador.last_name);
                if (nombre_apellido == busqueda)
                {
                    listaBusqueda.Add(nodoContador);
                }
            }
        }

        public void busquedaSalario(int busqueda)
        {
            Nodo<T> nodoContador = nodoRaiz;

            while (nodoContador != null)
            {
                nodoContador = nodoContador.nodoSiguiente;

                DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(nodoContador.nombre_Apellido);
                string nombre_apellido = delegadoGen(nodoContador.first_name + "|" + nodoContador.last_name);
                //if (nombre_apellido == busqueda)
                //{
                //    listaBusqueda.Add(nodoContador);
                //}
            }
        }

        public void busquedaClub(string busqueda)
        {
            Nodo<T> nodoContador = nodoRaiz;

            while (nodoContador != null)
            {
                nodoContador = nodoContador.nodoSiguiente;

                DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(nodoContador.nombre_Apellido);
                string nombre_apellido = delegadoGen(nodoContador.first_name + "|" + nodoContador.last_name);
                if (nombre_apellido == busqueda)
                {
                    listaBusqueda.Add(nodoContador);
                }
            }
        }

    }
}
