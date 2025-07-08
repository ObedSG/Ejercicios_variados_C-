using System; 



public class Program
{
    static void Main()
    {
        int resultado_suma = 0;
        int resultado_resta = 0;

        Calculadora mi_calculadora = new();
        mi_calculadora.calcular(10, 4, out resultado_suma, out resultado_resta);

        Console.WriteLine($"Suma: {resultado_Suma}, Resta: {resultado_Resta}");

    }




}


public class Calculadora
{
    public void calcular(int a, int b, out int suma, out int resta)
    {
        suma = a + b;
        resta = a - b;
    }

}