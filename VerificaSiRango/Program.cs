using System;

public class VerificaSiRango
{
    static void Main()
    {
        Console.Clear();
        System.Console.WriteLine("Programa para verificar si un numero esta dendtro de un rango dado");

        bool salir = false;

        int limInferior = 0, limSuperior = 0, numVerificar = 0;

        while (!salir)
        {
            try
            {
                System.Console.Write("\nINTRODUCE EL LIMITE INFERIOR: ");
                limInferior = int.Parse(Console.ReadLine()!);


                System.Console.Write("\nINTRODUCE EL LIMITE SUPERIOR: ");
                limSuperior = int.Parse(Console.ReadLine()!);

                System.Console.Write("\nINTRODUCE EL NUMERO A VERIFICAR: ");
                numVerificar = int.Parse(Console.ReadLine()!);

                salir = true;
            }
            catch (FormatException Error)
            {
                System.Console.WriteLine("\t NO INGRESASTE UN FORMATO CORRECTO, REPITE NUEVAMENTE \n");
                System.Console.WriteLine(Error.Message);
            }
        }

        int esValido = ComprobarSiRango(limInferior, numVerificar, limSuperior);

        if (esValido == 1)
        {
            System.Console.WriteLine("\n\n\t\t El numero si esta en un rango valido ");
        }
        if (esValido == 2)
            System.Console.WriteLine("\nNo est definido el rango de forma valida");
        if (esValido == 3)
            Console.WriteLine("\nNUMERO POR DEBAJO DEL LIMITE INFERIOR\n");
        if (esValido == 4)
            Console.WriteLine("\nNUMERO POR ENCIMA DEL LIMITE SUPERIOR \n");
    }


    static int ComprobarSiRango(int limInferior, int numVerificar, int limSuperior)
    {
        int resultado = 0;

        if (limInferior < limSuperior && numVerificar >= limInferior && numVerificar <= limSuperior)
            resultado = 1;

        else if (limSuperior < limInferior)
            resultado = 2;
        else if (limInferior < limSuperior && numVerificar < limInferior)
            resultado = 3;
        else if (limInferior < limSuperior && numVerificar > limSuperior)
            resultado = 4;



        return resultado;
    }



}