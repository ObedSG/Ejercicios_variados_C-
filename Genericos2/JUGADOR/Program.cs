using System;
using System.ComponentModel;

public class DEPORTISTA
{
    private string Nombre { get; set; }
    private int numero { get; set; }
    private string? knocauts { get; set; }
    private int peso { get; set; }
    private int QueEs { get; set; }

    public DEPORTISTA(string nombre, int Num, String KO, int KG, int Es)
    {
        Nombre = nombre;
        numero = Num;

        knocauts = KO;
        peso = KG;
        QueEs = Es;
    }


    public void EsDeportista()
    {
        System.Console.WriteLine("es deportista");
    }

    public void mostrarDatos()

    {
        if (QueEs == 0)
            System.Console.WriteLine($"Nombre: {Nombre} Numero: {numero}");

        else
            System.Console.WriteLine($"Knoc: {knocauts} KG: {peso}");

    }

}


public class JUGADOR : DEPORTISTA
{
    public string? nombre { get; set; }
    public int numero { get; set; }
    // int es = 0;

    public JUGADOR(string Nombre, int Num) : base(Nombre, Num, "", 0, 0)
    {
        nombre = Nombre;
        numero = Num;
    }

  
}


public class PELEADOR : DEPORTISTA
{
    private string? knocauts { get; set; }
    private int peso { get; set; }

    public PELEADOR(string kno, int kg) : base("", 0, kno, kg, 1)
    {
        knocauts = kno;
        peso = kg;
    }
  

}

public class EQUIPO<T> where T : DEPORTISTA
{
    private List<T> Lista_Equipo = new();

    public void Añadir(T deportista)
    {
        Lista_Equipo.Add(deportista);
    }

    public void Muestra_TODO_EQUIPO()
    {
        foreach (var i in Lista_Equipo)
        {
            i.mostrarDatos();
            
        }
        System.Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        EQUIPO<PELEADOR> P_Equipo_1 = new();
        P_Equipo_1.Añadir(new PELEADOR("2", 78));
        // P_Equipo_1.Añadir(new PELEADOR ("3", 92));

        EQUIPO<JUGADOR> J_Equipo_1 = new();
        J_Equipo_1.Añadir(new JUGADOR("Obed", 7));
        J_Equipo_1.Añadir(new JUGADOR("CARLOS", 8));

        P_Equipo_1.Muestra_TODO_EQUIPO();
        J_Equipo_1.Muestra_TODO_EQUIPO();

        // P_Equipo_1.


    }
}