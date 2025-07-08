using System;

public class Program
{
    static void Main()
    {
        string[] NomBarrios = new string[5];
        int i = 0;

        Console.Clear();
        System.Console.WriteLine("\t\t BIENVENIDO A LA EMPRESA de galletas Panda’s Cookie Factory");
        Console.WriteLine("\nINTRODUCE EL NOMBRE DE LOS 5 BARRIOS\n");


        while (i < NomBarrios.Length)
        {
            System.Console.Write($"Barrio {i + 1}:  ");

            string? datoCorrecto = Console.ReadLine();

            if (datoCorrecto?.Length > 0)
            {
                NomBarrios[i] = datoCorrecto;
                i++;
            }
            else
                Console.WriteLine("Dato incorrecto");
        }

        Random aleatorio = new();
        Pedidos[] misPedidos = new Pedidos[100];

        for (i = 0; i < misPedidos.Length; i++)
        {
            misPedidos[i] = new();
            misPedidos[i].nomBarrio = NomBarrios[aleatorio.Next(NomBarrios.Length)];
            misPedidos[i].cantGalletasPedido = aleatorio.Next(10, 101);
        }

        int[] cantPedidos = TotalizaPedidosBarrio(misPedidos, NomBarrios);
        int[] cantGalletas = TotalizaGalletasBarrio(misPedidos, NomBarrios);
        float[] calculaPromedio = CalculoPromedioBarrio(cantGalletas, cantPedidos, NomBarrios);


        System.Console.WriteLine("\n\t\tVISUALIZANDO LOS RESULTADOS\n");

        for (i = 0; i < NomBarrios.Length; i++)
        {
            System.Console.WriteLine($"Barrio {i + 1}: {NomBarrios[i].ToUpper()}. cantidad de pedidos: {cantPedidos[i]}");
            Console.WriteLine($"cantidad de galletas total: {cantGalletas[i]:n}. Calculo Promedio: {calculaPromedio[i]}");
            System.Console.WriteLine();

        }

        System.Console.WriteLine("\n\tIMPRESION DE PROMEDIOS SIN ORDENAR");
        foreach (var h in calculaPromedio)
            Console.Write($"{h}, ");



        System.Console.WriteLine("\n\n\tIMPRESION DE PROMEDIOS  ORDENADOS DE FORMA DESCENDENTE");
        MejorPromedio(calculaPromedio);
        foreach (var f in calculaPromedio)
            Console.Write($" {f}, ");
        Console.ReadKey();

    }

    static int[] TotalizaPedidosBarrio(Pedidos[] pedidos, string[] nomBarrios)
    {
        int[] totalPedidosPorBarrio = new int[nomBarrios.Length];

        //inicializamos el arreglo creado
        for (int i = 0; i < totalPedidosPorBarrio.Length; i++)
            totalPedidosPorBarrio[i] = 0;


        for (int i = 0; i < pedidos.Length; i++)
        {
            for (int j = 0; j < nomBarrios.Length; j++)
            {
                if (pedidos[i].nomBarrio == nomBarrios[j])
                {
                    totalPedidosPorBarrio[j]++;
                }
            }
        }

        return totalPedidosPorBarrio;
    }

    static int[] TotalizaGalletasBarrio(Pedidos[] misPedidos, string[] NomBarrios)
    {
        int[] cantGalletasBarrio = new int[NomBarrios.Length];
        int i, j;

        for (i = 0; i < cantGalletasBarrio.Length; i++)
            cantGalletasBarrio[i] = 0;

        for (i = 0; i < misPedidos.Length; i++)
        {
            for (j = 0; j < NomBarrios.Length; j++)
            {
                if (misPedidos[i].nomBarrio == NomBarrios[j])
                {
                    cantGalletasBarrio[j] += misPedidos[i].cantGalletasPedido;
                }
            }
        }

        return cantGalletasBarrio;
    }

    static float[] CalculoPromedioBarrio(int[] cantGalletas, int[] cantPedidos, string[] nombresBarrios)
    {
        float[] PromedioBarrio = new float[nombresBarrios.Length];

        for (int i = 0; i < PromedioBarrio.Length; i++)
            PromedioBarrio[i] = 0;

        for (int i = 0; i < PromedioBarrio.Length; i++)
            PromedioBarrio[i] = ((float)cantGalletas[i] / cantPedidos[i]);


        return PromedioBarrio;
    }
    static void MejorPromedio(float[] calculaPromedio)
    {
        float aux;

        for (int i = 0; i < calculaPromedio.Length - 1; i++)
        {
            for (int j = 0; j < calculaPromedio.Length - 1; j++)
            {
                aux = calculaPromedio[j];
                if (calculaPromedio[j] < calculaPromedio[j + 1])
                {
                    aux = calculaPromedio[j];
                    calculaPromedio[j] = calculaPromedio[j + 1];
                    calculaPromedio[j + 1] = aux;

                }

            }
        }

    }




}