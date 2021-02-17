using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDoblementeEnlazada
{
    public interface IBusquedas
    {
        void busquedaNombre_Apellido(string busqueda);
        void busquedaPosicion(string busqueda);
        void busquedaSalario(int busqueda);
        void busquedaClub(string busqueda);

    }
}
