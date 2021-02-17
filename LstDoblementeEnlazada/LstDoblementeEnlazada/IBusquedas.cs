using System;
using System.Collections.Generic;
using System.Text;

namespace LstDoblementeEnlazada
{
    public interface IBusquedas<T>
    {
        public void busquedaNombre_Apellido(Nodo<T> raiz, string busqueda);
        public void busquedaPosicion(string busqueda);
        public void busquedaSalario(int busqueda);
        public void busquedaClub(string busqueda);
    }
}
