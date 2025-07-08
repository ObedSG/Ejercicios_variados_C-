using System;
using System.Text.RegularExpressions;

public class EXregulares
{
    static void Main()
    {
        System.Console.WriteLine("\n\n\t\tEJEMPLOS DE EXPLESIONES REGULARES");

        string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
        string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
                           "Abraham Adams", "Ms. Nicole Norris" };


        foreach (string name in names)
            System.Console.WriteLine($" {name}, ");
        System.Console.WriteLine();

        foreach (string name in names)
            Console.WriteLine(Regex.Replace(name, pattern, String.Empty));



            Console.Clear();

            System.Console.WriteLine("\t\tEJEMPLO 2");
        
        string pattern2="()"

    }


}
