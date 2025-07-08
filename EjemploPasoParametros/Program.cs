using System;

class TipoDeParametrosFUNCION
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("\n\t\tPROGRAMA PARA VERIFICAR TIPOS DE PARAMETROS A FUNCION");

        System.Console.WriteLine("INTRODUCE IN NUMERO");

        int n = int.Parse(Console.ReadLine()!);

        System.Console.WriteLine("\n\t numero antes incrementar a fancion por valor");
        System.Console.WriteLine(n);

        incrementarPORVALOR(n);
        System.Console.WriteLine($"valor fuera de la funcion: {n}");
        Console.ReadKey();

        System.Console.WriteLine($"\t2: paso por referencia el valor {n}");
        incrementarPORREFERENCIA(ref n);
                System.Console.WriteLine($"valor despues de funcion por referencia{n}\n\n");
            Console.ReadKey();

    Console.Clear();
        Console.WriteLine("3: paso por referencia con out");//SE DECLARA DENTRO DE LOS PARAMETROS A ENVIAR

        string msfinal= MoestrarFechasCON_OUT(out string ms1, out string ms2, out string ms3);
        System.Console.WriteLine($"mensaje con out de fechas: {msfinal}");
        Console.ReadKey();

        System.Console.WriteLine("funcion usando in por referencia");


        ms1="pepe";
        ms2 = "papa";
        ms3= "caca";

        muestraPOR_IN(in ms1, in ms2, in ms3);









    }

    static int incrementarPORVALOR(int n)
    {
        n += 5;
        System.Console.WriteLine($"dentro de la funcion: {n} ");
        return n;
    }

    static int incrementarPORREFERENCIA(ref int n)
    {
        n += 5;
        System.Console.WriteLine($"valor dentro de funcion por referencia {n}");
        return n;
    }

    static string MoestrarFechasCON_OUT(out string ms1, out string ms2, out string ms3)
    {
        ms1="enero ";
        ms2="mayo ";
        ms3="marzo ";
                Console.WriteLine($"{ms1} {ms2} {ms3}");


        return ms1+ms2+ms3;
    }

        static string muestraPOR_IN(in string ms1, in string ms2, in  string ms3)

        {
            System.Console.WriteLine($" dentro de funcion IN: {ms1} {ms2} {ms3}");

          return $" {ms1} {ms2} {ms3}";

        }



}