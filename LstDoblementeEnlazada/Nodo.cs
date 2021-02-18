using System;
using System.Collections.Generic;

namespace LstDoblementeEnlazada
{
    public delegate string DelegadoGenerico<T>(T t);
    public delegate double DelegadoGenericoInt<T>(T t);
    public class Nodo<T>
    {
        public T club { get; set; }
        public T last_name { get; set; }
        public T first_name { get; set; }
        public T position { get; set; }
        public T base_salary { get; set; }
        public T guaranteed_compensation { get; set; }

        public Nodo<T> nodoAnterior { get; set; }

        public Nodo<T> nodoSiguiente { get; set; }

        // Constructor
        public Nodo()
        {
            nodoAnterior = null;
            nodoSiguiente = null;

        }

        public  string nombre_Apellido(string fullName)
        {
            return fullName.Replace('|', ',');
        }

        public  double StringToInt(string guaranteed_compensation)
        {
            return Convert.ToDouble(guaranteed_compensation);
        }

        public string toString(string stringVariable)
        {
            return stringVariable;
        }
    }

    
}
