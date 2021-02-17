using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDoblementeEnlazada
{
    class ListaDobleEnlazada<T>:IBusquedas
    {
        //Nodo Raiz de la lista doblemente enlazada
        
        public Nodo<T> nodoRaiz { get; set; }
        public Nodo<T> nodoRaizBusqueda { get; set; }

        public List<Nodo<T>> listaBusqueda { get; set; }

        public ListaDobleEnlazada() {
            nodoRaiz = null;
        }

        //Metodo para contar la cantidad de Nodos actuales en la lista
        public int cantidadElementos() {
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
        public void InsertarEnLista(Nodo<T> nodoActual, Nodo<T> nodoEntrante) {
            if (nodoEntrante != null)
            {

                if (nodoActual == null)
                {
                    nodoActual = nodoEntrante;
                    nodoActual.nodoAnterior = nodoEntrante.nodoAnterior;
                    nodoActual.nodoSiguiente = nodoEntrante.nodoSiguiente;
                }
                else {
                    InsertarEnLista(nodoActual.nodoSiguiente, nodoEntrante);
                }
                
            }
        }

        

        public void BuscarEnLista(string tipoBusqueda, string busqueda) {
            switch (tipoBusqueda)
            {
                case "nombre,apellido": {
                        busquedaNombre_Apellido(busqueda);
                    }
                break;
            }
        }

        public void busquedaNombre_Apellido(string busqueda)
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

        public void busquedaPosicion(string busqueda)
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
