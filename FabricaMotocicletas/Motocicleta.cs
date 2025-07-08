using System;

namespace FabricaMotocicletas
{

    public abstract class Motocicleta
    {
        protected int velocidadMaxima;
        protected double capacidadTanque;
        protected int potenciaMotor;
        protected int velocidadActual;
        protected double precio;
        protected string descripcion;


        //Zona de constructor

        public Motocicleta(int velocidadMaxima, double capacidadTanque, int potenciaMotor, double precop)
        {
            this.velocidadMaxima = velocidadMaxima;
            this.capacidadTanque = capacidadTanque;
            this.potenciaMotor = potenciaMotor;
            this.precio = precop;

            velocidadActual = 0;
            descripcion = string.Empty;
        }

        public int GetVelocidadMaxima() => velocidadMaxima;
        public int GetVelocidadActual() => velocidadActual;
        public void SetVelocidadMaxima(int vM)
        {
            if (vM <= 0)
                throw new ArgumentException("ERROR. No ES VALIDO VALORES MENORES O IGUALES A 0");
            else
                velocidadMaxima = vM;
        }

        public double GetCapacidadTanque() => capacidadTanque;

        public void SetCapacidadTanque(double cT)
        {
            if (cT <= 0)
                throw new ArgumentException("No es valido valores menores o iguales a 0");
            else
                capacidadTanque = cT;
        }

        public int GetPotenciaMotor() => potenciaMotor;

        public void SetPotenciaMotor(int SPM)
        {
            potenciaMotor = SPM;
        }

        public abstract void Acelerar();
        public abstract void Frenar();



    }


}