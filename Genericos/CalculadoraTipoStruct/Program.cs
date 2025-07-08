using System;
using System.Collections.Generic;

public class Calculadora<T> where T : struct, IComparable<T>

{
    public T Sumar(T a, T b)
    {
        dynamic X = a;
        dynamic Y = b;

        return X + Y;
    }

    public T Restar(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }

    public T Dividir(T a, T b)
    {
        dynamic X = a;
        dynamic Y = b;
        if (Y == 0)
        {
            throw new DivideByZeroException("No es posible dividir por 0");
        }

        return X / Y;
    }

    public T Multiplicar(T a, T b)
    {
        dynamic X = a;
        dynamic Y = b;

        return X * Y;
    }

    public T NumeroMayor(T a, T b)
    {
        dynamic X = a;
        dynamic Y = b;

        dynamic mayor = X;
        if (Y > X)
            mayor = Y;
        return mayor;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Calculadora<int> calculadoraEnteros = new Calculadora<int>();
        Console.WriteLine("Suma: " + calculadoraEnteros.Sumar(5, 3));
        Console.WriteLine("Resta: " + calculadoraEnteros.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + calculadoraEnteros.Multiplicar(5, 3));
        Console.WriteLine("División: " + calculadoraEnteros.Dividir(5, 3));

        List<int> listaEnteros = new List<int> { 5, 30 };
        Console.WriteLine("Máximo elemento en la lista: " + calculadoraEnteros.NumeroMayor(listaEnteros[0], listaEnteros[1]));

        Calculadora<double> calculadoraDoubles = new Calculadora<double>();
        Console.WriteLine("Suma: " + calculadoraDoubles.Sumar(5.5, 3.3));
        Console.WriteLine("Resta: " + calculadoraDoubles.Restar(5.5, 3.3));
        Console.WriteLine("Multiplicación: " + calculadoraDoubles.Multiplicar(5.5, 3.3));
        Console.WriteLine("División: " + calculadoraDoubles.Dividir(5.5, 9));

        List<double> listaDoubles = new List<double> { 5.5, 3.3, 8.8, 2.2, 10.1 };
        Console.WriteLine("Máximo elemento en la lista: " + calculadoraDoubles.NumeroMayor(listaDoubles[4], listaDoubles[2]));
    }
}