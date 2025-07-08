using System;

public class Program
{

    static void Main()
    {

        Console.Clear();
        Console.WriteLine($"\t\tPrograma para juicio contra rick por pendejo");

        int cantP = 0, cantT = 0, cantF = 0, i = 1, n = 4;

        char[] tipoSituacion = new char[n + 1];

        double calP = 0, calT = 0, calF = 0;

        while (i <= n)
        {
            try
            {

                System.Console.Write($"QUE TIPO DE MALTRATO ES LA SITUACION {i}: ");
                char resultado = char.Parse(Console.ReadLine()!.ToUpper());

                if (resultado == 'P' || resultado == 'T' || resultado == 'F')
                {
                    if (resultado == 'P')
                    {
                        cantP++;
                        tipoSituacion[i] = resultado;
                        Console.Write("\nIntroduce el nivel de calificacion 1-10, pueden ser decmales: ");

                        double calAUX = double.Parse(Console.ReadLine()!);
                        System.Console.WriteLine();
                        calP += calAUX;


                        i++;
                    }
                    if (resultado == 'T')
                    {
                        cantT++;
                        tipoSituacion[i] = resultado;
                        Console.Write("\nIntroduce el nivel de calificacion 1-10, pueden ser decmales: ");

                        double calAUX = double.Parse(Console.ReadLine()!);
                        System.Console.WriteLine();
                        calT += calAUX;


                        i++;
                    }
                    if (resultado == 'F')
                    {
                        cantF++;
                        tipoSituacion[i] = resultado;
                        Console.Write("\nIntroduce el nivel de calificacion 1-10, pueden ser decmales: ");

                        double calAUX = double.Parse(Console.ReadLine()!);
                        System.Console.WriteLine();
                        calF += calAUX;


                        i++;
                    }


                }
                else
                {
                    System.Console.WriteLine("\tno introduciste un valor valido intente nuevamente: ");
                }
            }
            catch (FormatException error)
            {
                System.Console.WriteLine("NO INTRODUCISTE FORMATO VALIDO");
                System.Console.WriteLine($"ERROR. {error.Message}");
            }

        }

        double promedioP = 0, promedioT = 0, promedioF = 0;
        promedioP = (calP / (n * 10)) * 100;
    System.Console.WriteLine($"CANTIDA PARA P: {cantP}, Promedio general: {promedioP}\n");

        promedioT = (calT / (n * 10)) * 100;
    System.Console.WriteLine($"CANTIDA PARA T: {cantT}, Promedio general: {promedioT}\n");

        promedioF = (calF / (n * 10)) * 100;
        System.Console.WriteLine($"CANTIDA PARA F: {cantF}, Promedio general: {promedioF}\n");

        System.Console.WriteLine();
        System.Console.Write("Tipos: ");
        foreach (char item in tipoSituacion)
        {
            
            System.Console.Write($"{item} ");
        }
        System.Console.WriteLine();


        if(promedioT >= 70 || promedioF >= 70)
        {
            System.Console.WriteLine("\t RECOMIENDA CASTIGO MAXIMO PARA EL PENDEJO DE RICK");
        }
        else
        System.Console.WriteLine("\tPAGO DE FIANZA GALATICA");

        








    }
}