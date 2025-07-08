using System;
using System.Collections.Generic;

namespace GENERICOS
{
    public static class Busqueda 
    {

        public  static bool Buscar_Elemento<T>( List<T> lista, T elemento)
        {
            
            return lista.Contains(elemento);
        }
    } 
}