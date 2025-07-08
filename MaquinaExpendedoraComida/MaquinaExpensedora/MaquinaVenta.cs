using System;

namespace MaquinaExpendedora
{
    class MaquinaVenta
    {
        public Ubicacion[] LasUbicaciones { get; set; }
        public float ValorVentas { get; set; }
        public int CantidadVentas { get; set; }

        public MaquinaVenta()
        {
            ValorVentas = 0;
            CantidadVentas = 0;
            LasUbicaciones = new Ubicacion[1]; //iniciamos con una ubicacion

            InicializaUbicaciones();
        }
        ddfsef
            fuwbdbwk;


        private void InicializaUbicaciones()
        {
            string[] letrasIdentificacion = ["A", "B", "C", "D", "E", "F"];
            int posicionUbicacion = 0;

            LasUbicaciones = new Ubicacion[60];

            while (posicionUbicacion < LasUbicaciones.Length)
            {
                string IdArreglos;

                for (int i = 0; i < letrasIdentificacion.Length; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        IdArreglos = letrasIdentificacion[i] + j;

                        LasUbicaciones[posicionUbicacion] = new Ubicacion
                        {
                            Identificacion = IdArreglos,
                            NombreProducto = "",
                            Valor = 0,
                            Cantidad = 0
                        };

                        posicionUbicacion++;
                    }
                }
            }

        }


        public bool ValidaUbicacion(string datoUbicacion)
        {
            bool resultado = false;

            for (int i = 0; i < LasUbicaciones.Length; i++)
            {
                if (LasUbicaciones[i].Identificacion == datoUbicacion)
                    resultado = true;
            }

            return resultado;
        }

        public int ObtieneIndiceUbicacion(string datoUbicacion) //parametro es igual a su identificacion. ej: A7, F10, B3. etc...
        {
            int indice = -1;
            for (int i = 0; i < LasUbicaciones.Length; i++)
            {
                if (LasUbicaciones[i].Identificacion == datoUbicacion)
                    indice = i;
            }

            return indice;
        }

        public void RealizarVenta(string Id)
        {
            int indice = ObtieneIndiceUbicacion(Id);
            
            //Si hay cantidad disponible, se realiza la venta
            if(LasUbicaciones[indice].Cantidad > 0)
            {
                LasUbicaciones[indice].Cantidad--;
                ValorVentas += LasUbicaciones[indice].Valor;
                CantidadVentas++;
            }

            

        }




    }
}