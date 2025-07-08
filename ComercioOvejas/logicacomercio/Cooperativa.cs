/*
    LA COOPERATIVA TIENE ATRIBUTOS 
    CREA UN ARREGLO DE CLASE OVEJA (ABSTRACTA) 
        SE INICIALIZAN EN EL CONSTRUCTOR Y LLAMAN UNA FUNCION VOID PARA INICIALIZAR EL ARREGLO DE OVEJAS, 
*/


using System;

namespace LogicaComercio
{
    public class Cooperativa
    {

        //Zona de atributos
        private double valorComision;
        private double comisionObtenida;

        private double precioLana;
        private double precioLeche;

        private double cantidadKgsLana;
        private double cantidadLtsLeche;
        private double gananciaGranjero;

        private int cantidadOvejas;
        private Oveja[] lasOvejas;
        //FIN ZONA DE ATRIBUTOS

        //ZONA DE CONSTRUCTOR
        public Cooperativa(int cantidadOvejas)
        {
            this.cantidadOvejas = cantidadOvejas;
            valorComision = 0.05f;
            comisionObtenida = 0;
            precioLana = 1200;
            precioLeche = 1750;
            cantidadKgsLana = 0;
            cantidadLtsLeche = 0;
            gananciaGranjero = 0;

            lasOvejas = new Oveja[cantidadOvejas];

            //Aqui se inicializa el arreglo de Ovejas
            InicializaLasOvejas();
        }


        //funcion para inicializar el arreglo de ovejas(abstracta) y se instancia con sus clases derivadas
        private void InicializaLasOvejas()
        {
            Random aleatorio = new();
            string[] losSexos = ["macho", "hembra"];
            string elSexo;
            int elPeso, laEdad;
            double laCantidadLeche;

            for (int i = 0; i < lasOvejas.Length; i++)
            {
                elSexo = losSexos[aleatorio.Next(losSexos.Length)];
                elPeso = aleatorio.Next(1, 181);
                laEdad = aleatorio.Next(1, 145);


                // 0: ovejeLechera,  1: ovejaLanuda 
                switch (aleatorio.Next(2))
                {
                    case 0:
                        laCantidadLeche = aleatorio.NextDouble() * 3.5f;

                        //el arreglo se paso por referencia de modo que afectara saliendo del constructor
                        lasOvejas[i] = new OvejaLechera(elSexo, elPeso, laEdad, laCantidadLeche);
                        break;
                    case 1:

                        lasOvejas[i] = new OvejaLanuda(elSexo, elPeso, laEdad);
                        break;
                }
            }
        }

        public void ContabilizaProduccion()
        {
            cantidadKgsLana = 0;
            cantidadLtsLeche = 0;

            foreach (Oveja unaOveja in lasOvejas)
            {
                if (unaOveja.GetEsApta() && unaOveja.GetSexo() == "macho")
                    cantidadKgsLana += unaOveja.GetProduccion();
                if (unaOveja.GetEsApta() && unaOveja.GetSexo() == "hembra")
                    cantidadLtsLeche += unaOveja.GetProduccion();
            }
        }

        public void calculaComision()
        {
            gananciaGranjero = precioLana * cantidadKgsLana +
                               precioLeche * cantidadLtsLeche;
            comisionObtenida = gananciaGranjero * valorComision;
        }

        public override string ToString()
        {
            string resultado = $"Esta cooperativa cobra {(valorComision * 100).ToString(".00")} % de comision \n" +
            $" y se paga el kg de lana a {precioLana} y el litro de leche a {precioLeche}";

            return resultado;
        }

        public int CalculaCantidadOvejasAptas()
        {
            int cantOvejas = 0;

            foreach (Oveja unaOveja in lasOvejas)
            {
                if (unaOveja.GetEsApta())
                    cantOvejas++;
            }
            return cantOvejas;
        }

        public string VisualizarResultadosComercio()
        {
            int cantidadOvejasApatas = CalculaCantidadOvejasAptas();
            float porcentajeOvejasAptas = ((float)cantidadOvejasApatas / cantidadOvejas) *100;

            string resultadoComercio = $"Del total de {cantidadOvejas} ovejas, "+
                                       $"solo {cantidadOvejasApatas} fueron aptas, " +
                                       $"Equivalente al {porcentajeOvejasAptas.ToString(".00")}% ";

            resultadoComercio += $"\n La produccion consistio en {cantidadKgsLana.ToString(".00")} kg de lana " +
            $"y {cantidadLtsLeche.ToString(".00")} lts de leche";

            resultadoComercio += $"\n\n El granjero obtuvo {(gananciaGranjero - comisionObtenida).ToString(".00") }$ y " +
                        $"La cooperativa obtuvo {comisionObtenida.ToString(".00")} de comision";
            

            return  resultadoComercio;
        }
    }
}
