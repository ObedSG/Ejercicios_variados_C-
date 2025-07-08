
using System;

// Declaración del delegado
public delegate int OperacionMatematica(int a, int b);



public class Calculadora
{
    // Método que realiza una operación matemática utilizando un delegado
    public static void RealizarOperacion(int x, int y, OperacionMatematica operacion)
    {
        int resultado = operacion(x, y);
        Console.WriteLine("El resultado de la operación es: " + resultado);
    }
}

class Programq
{
    // Método para sumar dos números
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        // Crear una instancia del delegado y asociarla al método Sumar
        OperacionMatematica operacion = Sumar;

        // Utilizar el delegado para realizar una suma
        Calculadora.RealizarOperacion(5, 3, operacion); // Imprimirá "El resultado de la operación es: 8"
    }
}