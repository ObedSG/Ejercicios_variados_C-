using System;

namespace FabricaMotocicletas
{
    
    class Program
    {
        static void Main()
       {
            Console.WriteLine("\n\n\t\t Programa para simular fabrica de motocicletas");

            MotocicletDeportiva miMotoDeportiva = new(50, "4 tiempos", 500, true, 750, 250,
            "Moto bien vergas", 50);

            System.Console.WriteLine($"La velocidad actual de la moto es: {miMotoDeportiva.GetVelocidadActual()}\n");

            System.Console.WriteLine("acelerando.... run run");

            miMotoDeportiva.Acelerar();
            System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");

            miMotoDeportiva.Acelerar();
                        System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");

            miMotoDeportiva.Acelerar();
                        System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");

            miMotoDeportiva.Acelerar();
                        System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");


            System.Console.WriteLine("el precio: " + miMotoDeportiva.GetPrecio());
            System.Console.WriteLine(miMotoDeportiva.ToString());
            System.Console.WriteLine(miMotoDeportiva.GetDescripcion());

            System.Console.WriteLine("\n\n frenando moto... ihiiihihihg");

            miMotoDeportiva.Frenar();
                        System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");

            miMotoDeportiva.Frenar(); 
                        System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");
            
            
            System.Console.WriteLine("acelerando errorprueba");
                        miMotoDeportiva.Acelerar();
            miMotoDeportiva.Acelerar();
            miMotoDeportiva.Acelerar();
            System.Console.WriteLine($" max velocidad: {miMotoDeportiva.GetVelocidadActual()}");
            miMotoDeportiva.Acelerar();

            miMotoDeportiva.Frenar();
            miMotoDeportiva.Frenar();
            miMotoDeportiva.Frenar();
            miMotoDeportiva.Frenar();
            miMotoDeportiva.Frenar();
                                    System.Console.WriteLine($"velocidad actual: {miMotoDeportiva.GetVelocidadActual()}");

            miMotoDeportiva.Frenar();




            


            




        }
    }
}

