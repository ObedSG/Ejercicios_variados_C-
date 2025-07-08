using System;
using ESTRATEGIA;
class Program

{
    static void Main()
    {
        IEstrategia miEstrategia = new Suma(); //por defecto

        string opcion = string.Empty;
        double r = 0;

        System.Console.WriteLine("\n\n 1- SUMA. 2- RESTA. 3- DIVISION. 4- SALIR");
        opcion = Console.ReadLine()!;
        while (validaOpcion(opcion) && opcion != "4")
        {

            System.Console.Write("VALOR A:  ");
            double A = double.Parse(Console.ReadLine()!);

            System.Console.Write("VALOR B:  ");
            double B = double.Parse(Console.ReadLine()!);


            if (opcion == "1" || opcion == "2" || opcion == "3")
            {
                switch (opcion)
                {
                    case "1":
                        miEstrategia = new Suma();
                        r = miEstrategia.Operacion(A, B);
                        System.Console.WriteLine($"operacion es: {r} ");
                        break;

                    case "2":
                        miEstrategia = new Resta();
                        r = miEstrategia.Operacion(A, B);
                        System.Console.WriteLine($"operacion es: {r} ");
                        break;

                    case "3":
                        miEstrategia = new Division();
                        r = miEstrategia.Operacion(A, B);
                        System.Console.WriteLine($"operacion es: {r} ");
                        break;
                    case "4":
                        break;

                    default:
                        System.Console.WriteLine("no introduciste el valor pedido");
                        break;
                }
            }
            else
                Console.WriteLine("no introduciste el formato requerido");
        }
    }

    static bool validaOpcion(string res)
    {
        bool r = false;
        if (res == "1" || res == "2" || res == "3")
            r = true;
            
        return r;

    }
}