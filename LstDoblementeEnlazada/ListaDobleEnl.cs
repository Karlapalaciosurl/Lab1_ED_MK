using System;
using System.Collections.Generic;
using System.Text;

namespace LstDoblementeEnlazada
{
    public class ListaDobleEnl<T> : IBusquedas<T>
    {
        //Nodo Raiz de la lista doblemente enlazada

        public Nodo<T> nodoRaiz { get; set; }
    
        public int elementos { get; set; }
        public List<Nodo<T>> listaBusqueda = new List<Nodo<T>>();

        public ListaDobleEnl()
        {
            nodoRaiz = null;
        }

        //Metodo para contar la cantidad de Nodos actuales en la lista
        public void cantidadElementos()
        {
            int cantidadNodos = 0;
            Nodo<T> nodoContador = nodoRaiz;

            while (nodoContador != null)
            {
                nodoContador = nodoContador.nodoSiguiente;
                cantidadNodos++;
            }

            elementos =  cantidadNodos;
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
                case "posicion":
                    {
                        busquedaPosicion(raiz, busqueda);
                    }
                    break;
                case "salario":
                    {
                        busquedaSalario(raiz, double.Parse(busqueda));
                    }
                    break;
                case "club":
                    {
                        busquedaClub(raiz, busqueda);
                    }
                    break;
            }
        }

        public void busquedaNombre_Apellido(Nodo<T> raiz, string busqueda)
        {
            List<Nodo<T>> listaB = new List<Nodo<T>>();
            if (raiz != null)
            {
                while (raiz != null)
                {
                    

                    DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(raiz.nombre_Apellido);
                    string nombre_apellido = delegadoGen(raiz.first_name + "|" + raiz.last_name);
                    if (nombre_apellido == busqueda)
                    {
                        listaB.Add(raiz);
                    }

                    raiz = raiz.nodoSiguiente;
                }

                listaBusqueda = listaB;
            }
        }

        public void busquedaPosicion(Nodo<T> raiz, string busqueda)
        {
            if (raiz != null)
            {
                List<Nodo<T>> listaB = new List<Nodo<T>>();
                while (raiz != null)
                {


                    DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(raiz.toString);
                    string posicion = delegadoGen(raiz.position.ToString());
                    if (posicion == busqueda)
                    {
                        listaB.Add(raiz);
                    }

                    raiz = raiz.nodoSiguiente;
                }

                listaBusqueda = listaB;
            }
        }

        public void busquedaSalario(Nodo<T> raiz, double busqueda)
        {

            if (raiz != null)
            {
                List<Nodo<T>> listaB = new List<Nodo<T>>();
                while (raiz != null)
                {

                    DelegadoGenericoInt<string> delegadoGen = new DelegadoGenericoInt<string>(raiz.StringToInt);
                    double salario = delegadoGen((raiz.base_salary).ToString());
                    if (salario == busqueda)
                    {
                        listaB.Add(raiz);
                    }

                    raiz = raiz.nodoSiguiente;
                }

                listaBusqueda = listaB;
            }
        }

        public void busquedaClub(Nodo<T> raiz, string busqueda)
        {
            if (raiz != null)
            {
                List<Nodo<T>> listaB = new List<Nodo<T>>();
                while (raiz != null)
                {

                    DelegadoGenerico<string> delegadoGen = new DelegadoGenerico<string>(raiz.toString);
                    string posicion = delegadoGen(raiz.club.ToString());
                    if (posicion == busqueda)
                    {
                        listaB.Add(raiz);
                    }

                    raiz = raiz.nodoSiguiente;
                }

                listaBusqueda = listaB;
            }
        }


        public void eliminarJugar(Nodo<T> raiz, Nodo<T> jugador) {
            if (raiz != null && jugador != null)
            {  
                while (raiz != null)
                {

                    if (jugador == raiz)
                    {
                        Nodo<T> nodoSiguiente = jugador.nodoSiguiente;
                        Nodo<T> nodoAnterior = jugador.nodoAnterior;


                        //Solo existe este elemento en la lista
                        if (nodoAnterior == null && nodoSiguiente == null)
                        {
                            nodoRaiz = null;
                        }
                        else {

                            // Se encuentra entre nodos
                            if (nodoSiguiente != null && nodoAnterior != null)
                            {
                                nodoAnterior.nodoSiguiente = nodoSiguiente;
                                nodoSiguiente.nodoAnterior = nodoAnterior;
                            }
                            else {
                                //Es el primer de la lista
                                if (nodoAnterior == null)
                                {
                                    nodoRaiz = nodoSiguiente;
                                    nodoRaiz.nodoAnterior = null;
                                }
                                // Es el ultimo de la lista
                                if (nodoSiguiente == null)
                                {
                                    nodoAnterior.nodoSiguiente = null;

                                }

                            }
                            
                        }

                        
  

                    }

                    raiz = raiz.nodoSiguiente;
                }

            }
        }
    }
}
