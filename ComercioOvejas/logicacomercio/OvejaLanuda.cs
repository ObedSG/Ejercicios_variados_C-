using System;

namespace LogicaComercio
{
    public class OvejaLanuda : Oveja
    {
        private double CantidadLana;

        public OvejaLanuda() : base()
        {
            CantidadLana = 0;
        }

        public OvejaLanuda(string sex, int pes, int eda)
        {
            sexo = sex;
            peso = pes;
            edad = eda;

            EvaluaSiEsApta();
        }

        public override double GetProduccion()
        {
            return CantidadLana;
        }
        // public void SetProducion(double CantidadLan)
        // {
        //     CantidadLana = CantidadLan;
        // }

        public double GetCantidadLana() => CantidadLana;

        public override void EvaluaSiEsApta()
        {
            if(peso >= 35)
                CantidadLana = peso * 0.2f;
            else
                CantidadLana = 0;

            if(edad>= 24 && edad<= 84 && peso >=35 && sexo =="macho")
                esApta =true;
        }

        public override string ToString()
        {
            string resultado = $"Oveja {sexo}, peso {peso}, edad{edad}, " +
            $"cantidad de Lana: {CantidadLana.ToString("00.00")} Kgs ";

            if(esApta)
                resultado += "EsApta";
            else
                resultado += "NoEsApta";

            return resultado; 
        }
        






    }
}