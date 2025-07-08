using System;

public class CAJA<T> where T : class
{
    private T dato_Caja;

    public T Dato_Caja
    {
        get { return dato_Caja; }
        set { dato_Caja = value; }
    }
    public void Agregar(T item)
    {
        Dato_Caja = item;

    }

    public void Mostrar()
    {
        if(Dato_Caja is null)
            System.Console.WriteLine("no hay nada que mostrar agraga algo nuevo");
        else    
        System.Console.WriteLine($"Contenido de la caja: {Dato_Caja} y su tipo es: {typeof(T)}");

    }

}


public class Program
{
    public static void Main()
    {
        CAJA<string> Caja_enteros = new();
        Caja_enteros.Agregar("10");
        Caja_enteros.Mostrar();
    }

}


