using System;
using LogicaComercio;


namespace ComercioOvejas
{
    public class Program
    {
       public static void Main(string[] args)
        {
            
            Console.WriteLine("Programa para simular el comercio de Ovejas");

            int cantidadOvejas =0;
            bool datoCorrecto = false; //bandera boolena
            
            do
            {
                
                try
                {
                    Console.Write("Ingresa la cantidad de Ovejas a procesar en la Cooperativa: ");
                    cantidadOvejas = int.Parse(Console.ReadLine()!);

                    if (cantidadOvejas > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad de ovejas debe ser un entero positivo. Intenta nuevamente");
                }
                catch (FormatException)
                {
                    Console.WriteLine("El dato ingresado no tiene el formato requerido. Intenta nuevamente");
                }
            }
            while (!datoCorrecto); //porque bandera no es true

            Console.WriteLine("\n Llevando las ovejas a la cooperativa...");

                Cooperativa miCoop = new Cooperativa(cantidadOvejas);

                miCoop.ContabilizaProduccion();

                miCoop.calculaComision();

                //miCoop.CalculaCantidadOvejasAptas();
                System.Console.WriteLine(miCoop.ToString());
                System.Console.WriteLine();
                System.Console.WriteLine(miCoop.VisualizarResultadosComercio());

        }
    }
}