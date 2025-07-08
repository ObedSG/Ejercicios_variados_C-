using System;
using System.Runtime.Intrinsics.Arm;

public class Administracion
{
    static void Main()
    {
        Console.Clear();
        System.Console.WriteLine("\t\tAPLICACION DE ADMINISTRACIÓN\n\n");

        Console.WriteLine("Mabel define una meta de dinero a recoger y les asigna a todos, la ");
        Console.WriteLine("responsabilidad de recoger una cuota correspondiente a la cuarta parte ");
        Console.WriteLine("del meta. Los responsables: 1.Wendy, 2: Dipper, 3: Soos y 4: Mabel.\n\n");

        double valorMeta = 0;
        double cuotaWendy=0, cuotaMabel=0, cuotaDipper=0, cuotaSoos=0, cuotaObed=0;

        bool datoCorrecto = false;
        do
        {
            try
            {
                System.Console.WriteLine("INGRESA EL VALOR DE LA META DESEADA PARA LA APUESTA ");
                valorMeta = double.Parse(Console.ReadLine()!);
                if (valorMeta > 0)
                    datoCorrecto = true;
                else
                    System.Console.WriteLine("almenos el valor de la meta debe ser mayor de 0");

            }
            catch (FormatException error)
            {
                System.Console.WriteLine("ERROR. no ingresaste un formato correcto repite nuevamente");
                System.Console.WriteLine(error.Message);
            }



        } while (!datoCorrecto );

        System.Console.WriteLine(valorMeta);
        
        datoCorrecto =false;

        while(!datoCorrecto)
        {
            try
            {
                System.Console.WriteLine("ingresa el valor de MABEL:");
                cuotaMabel= double.Parse(Console.ReadLine()!);

                if(cuotaMabel >0)
                    datoCorrecto=true;
                else
                    System.Console.WriteLine("El valor de la cuota debe ser positivo");
            }

            catch(FormatException error)
            {
                System.Console.WriteLine("ERROR. ingresaste un formato no valido repite nuevamente");
                System.Console.WriteLine(error.Message);
            }

        }
         datoCorrecto =false;

        while(!datoCorrecto)
        {
            try
            {
                System.Console.WriteLine("ingresa el valor de DIPPER:");
                cuotaDipper= double.Parse(Console.ReadLine()!);

                if(cuotaDipper >0)
                    datoCorrecto=true;
                else
                    System.Console.WriteLine("El valor de la cuota debe ser positivo");
            }

            catch(FormatException error)
            {
                System.Console.WriteLine("ERROR. ingresaste un formato no valido repite nuevamente");
                System.Console.WriteLine(error.Message);
            }

        }

         datoCorrecto =false;

        while(!datoCorrecto)
        {
            try
            {
                System.Console.WriteLine("ingresa el valor de SOOS:");
                cuotaSoos= double.Parse(Console.ReadLine()!);

                if(cuotaSoos >0)
                    datoCorrecto=true;
                else
                    System.Console.WriteLine("El valor de la cuota debe ser positivo");
            }

            catch(FormatException error)
            {
                System.Console.WriteLine("ERROR. ingresaste un formato no valido repite nuevamente");
                System.Console.WriteLine(error.Message);
            }

        }

         datoCorrecto =false;

        while(!datoCorrecto)
        {
            try
            {
                System.Console.WriteLine("ingresa el valor de OBED:");
                cuotaObed= double.Parse(Console.ReadLine()!);

                if(cuotaObed >0)
                    datoCorrecto=true;
                else
                    System.Console.WriteLine("El valor de la cuota debe ser positivo");
            }

            catch(FormatException error)
            {
                System.Console.WriteLine("ERROR. ingresaste un formato no valido repite nuevamente");
                System.Console.WriteLine(error.Message);
            }

        }

        System.Console.WriteLine($"VALOR meta de CUOTAs: {valorMeta} Mabel:{cuotaMabel} dipper: {cuotaDipper} sos: {cuotaSoos}, Obed: {cuotaObed}");
        
        double cuotaAlcanzada= cuotaObed+cuotaDipper+cuotaMabel+cuotaSoos+cuotaWendy;

        if( cuotaAlcanzada >=valorMeta)
        {
            System.Console.WriteLine("\nBien hecho jefa alcanzaste tu meta de coutas");
            System.Console.WriteLine("\neres candidata al puesto\n");
            System.Console.WriteLine($"valor alcanzado de cuotas: {cuotaAlcanzada}");
        }

        else
        {
            System.Console.WriteLine("No lograste alcanzar tu meta de cuota");
            System.Console.WriteLine("No eres candidata a jefa");
            System.Console.WriteLine($"valor alcanzado de cuatas: {cuotaAlcanzada}");
        }

        



    }
}