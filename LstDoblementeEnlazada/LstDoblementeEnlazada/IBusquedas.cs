using System;
using System.Collections.Generic;
using System.Text;

namespace LstDoblementeEnlazada
{
    public interface IBusquedas<T>
    {
        public void busquedaNombre_Apellido(Nodo<T> raiz, string busqueda);
        public void busquedaPosicion(Nodo<T> raiz, string busqueda);
        public void busquedaSalario(Nodo<T> raiz, double busqueda);
        public void busquedaClub(Nodo<T> raiz, string busqueda);
    }
}
