using System;

namespace LogicaComercio
{

    public class OvejaLechera: Oveja
    {
        private double litrosLeche;


        //constructores sobrecargados

        public OvejaLechera() :base()
        {
            litrosLeche = 0;

        }

        public OvejaLechera(string sex, int pes, int eda, double ltsLeche)
        {
            sexo= sex;
            peso= pes;
            edad= eda;
            litrosLeche = ltsLeche;

            //heredan campos de la clase abstracta (protected)
            EvaluaSiEsApta();
        }



        
        public  double GetLitrosLeche()
        {
            return litrosLeche;
        }

        public void SetLitrosLeche(double ltsLeche)
        {
            litrosLeche = ltsLeche;
        }


        //Metoto: EvaluaSiEsApta()

        public override void EvaluaSiEsApta()
        {
            double CantidadLecheKilos = litrosLeche / 1.046f;
            if(edad >= 24 && edad <= 84 && peso >= 35 && sexo == "hembra" && CantidadLecheKilos >= 0.75f)
            esApta = true;
        }

        public override double GetProduccion()
        {
            return litrosLeche;
        }

        public override string ToString()
        {
            string resultado = $"Oveja {sexo}, peso: {peso}, edad:{edad}, " +
                $"cantidada de leche: {litrosLeche.ToString("00.00")}Lts ";

            if(esApta)
                resultado += "EsApta";
            else 
                resultado += "NoEsApta";
            return resultado;

                
        }


    }

}