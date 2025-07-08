using Genericos;

namespace Pila_T
{
    public class Program
    {
        public static void Main()
        {
            Pila<string> MiPila = new(4);
            MiPila.push("aA");
            MiPila.push("eE");
            MiPila.push("rR");
               MiPila.push("ds");
            MiPila.push("l");
 

            System.Console.WriteLine($"El valor del top PIla es: {MiPila.peak()}");

            MiPila.pop();
            System.Console.WriteLine($"El valor del top PIla es: {MiPila.peak()}");
           // System.Console.WriteLine();

        }

    }
}