/*Propósito:
----------
- Demostrar conceptos de clase, objeto, encapsulación, propiedades
- Crear un objeto "MaquinaVenta" que contiene un arreglo de "Ubicacion"
- Implementar funciones para inicializar ubicaciones, validar y acceder a ellas
- Implementar algoritmo para abastecer las ubicaciones con productos
- Visualizar cuales de las posiciones tienen productos abastecidos
- Implementar algoritmo para realizar venta de producto.
- Visualizar cuanto vendió y cuantos productos se vendieron

Tarea: Implementar el control de excepciones requerido para cuando se ingresan valores numéricos
       desde consola.

Características de la máquina:

 - La maquina tiene 6 filas, 10 columnas para un total de 60 ubicaciones posibles de venta
 - La máquina sabe cuanto ha vendido
 - La máquina sabe cuantos productos ha vendido.

Caracteristicas de la ubicación:
 - Identificacion
 - Nombre de producto
 - Valor
 - Cantidad
 
 */


using System;
using System.Diagnostics;
namespace MaquinaExpendedora
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("\t\tPrograma para simular utilizacion de maquina expendedora de comida\n");
            System.Console.WriteLine("La maquina expendedora tiene 6 fila y 10 columas");

            MaquinaVenta miMaquina = new();

            Console.WriteLine($"El valor vendido actual es de: {miMaquina.ValorVentas:n}");
            System.Console.WriteLine($"La cantidad vendida actual es de {miMaquina.CantidadVentas:n}");


            // foreach(var i in miMaquina.LasUbicaciones)
            // {
            //     System.Console.WriteLine($"id: {i.Identificacion}, cantida: {i.Cantidad}, nombre producto: {i.NombreProducto}, Valor: {i.Valor}");
            // }

            System.Console.WriteLine("\n\tPROCESO DE ABASTECIMIENTO");

            bool seguirAbasteciendo = true;

            while (seguirAbasteciendo)
            {


                System.Console.WriteLine("INFRESA LA IDENTIFICACION PARA ABASTECER: A...F y 0...9. ej: A8, F4... ");
                Console.Write("--");
                string idParaAbastecer = Console.ReadLine()!.ToUpper();
                if (miMaquina.ValidaUbicacion(idParaAbastecer))
                {
                    int iAbastecer = miMaquina.ObtieneIndiceUbicacion(idParaAbastecer);

                    System.Console.WriteLine($"Ingresa nombre de productro para la ubicaion en {idParaAbastecer}");
                    miMaquina.LasUbicaciones[iAbastecer].NombreProducto = Console.ReadLine()!;

                    System.Console.WriteLine($"Ingresa cantidad de producto para la ubicacion en {idParaAbastecer}");
                    miMaquina.LasUbicaciones[iAbastecer].Cantidad = int.Parse(Console.ReadLine()!);

                    System.Console.WriteLine($"Ingresa el precio del producto parra la ubicaion en {idParaAbastecer}");
                    miMaquina.LasUbicaciones[iAbastecer].Valor = int.Parse(Console.ReadLine()!);
      
                    System.Console.WriteLine("\t\tQUIERES SEGUIR ABASTECIENDO: (S,s / N,n)");
                    char Sigue = char.Parse(Console.ReadLine()!.ToUpper());
                    if (Sigue == 'N')
                        seguirAbasteciendo = false;

                }

                else
                {
                    System.Console.WriteLine("EL VALOR INGRESADO NO ES VALIDO, REPITA DE NUEVO");
                }





            }




        }




    }
}