using System;

public class UTILITY
{
    public void Swap<T>(ref T mov1, ref T mov2)
    {
        T tem = mov1;
        mov1 = mov2;
        mov2 = tem;

    }

}

public class Program
{
    static void Main()
    {
        UTILITY Mi_clase = new UTILITY();
        var v1 = "hola";
        var v2 = "como";


        Console.WriteLine($"Antes. v1: {v1} v2: {v2}");

        Mi_clase.Swap(ref v1, ref v2);

        Console.WriteLine($"Despues. v1: {v1} v2: {v2}");

    }
}
