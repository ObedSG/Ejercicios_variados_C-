using System;

namespace FabricaMotocicletas
{
    public class MotocicletDeportiva: Motocicleta, IVendible
    {
        private string tipoMotor;
        private int peso;
        private Boolean frenosDisco;

        public MotocicletDeportiva(int velocidadMaxima, string tipoMotor, int peso, bool frenosDisco, 
                int potenciaMotor, double precio, string descripcion, 
                double capacidadTanque): base(velocidadMaxima, capacidadTanque, potenciaMotor, precio)
        {
            this.tipoMotor = tipoMotor;
            this.peso = peso;
            this.frenosDisco = frenosDisco;
            this.descripcion = descripcion;
        }

        public override void Acelerar()
        {
            if(velocidadActual+ 10 <= velocidadMaxima )
                velocidadActual += 10;
            else
                System.Console.WriteLine("NO puede exceder el limite de velocidad");                

        }

        public override void Frenar()
        {
            if((velocidadActual - 10 ) > 0)
                velocidadActual -=10;
            else
                System.Console.WriteLine("no puedes bajar mas la velocidad");
        }

        public double GetPrecio() => precio;

        public string GetDescripcion() => descripcion;

        


    }
}