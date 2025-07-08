using System;

public class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("\t\tPROGRAMA PARA SIMULAR USO DE GENERICOS\n");
       

        ListaGenerica<string> listaGstrings = new ListaGenerica<string>(4);
        Console.WriteLine("\tMostramos lista de geenricos inicializados, vacio ");
        listaGstrings.mostrarListaGenerica();

        Console.WriteLine("\tGenerico con strings");
        listaGstrings.Agregar("obed");
        listaGstrings.Agregar("carlos");
        listaGstrings.Agregar("martha");

        listaGstrings.mostrarListaGenerica();
        Console.WriteLine();

        ListaGenerica<int> listaGints = new ListaGenerica<int>(4);
        Console.WriteLine("lista generica vacia");
        listaGints.mostrarListaGenerica();
        Console.WriteLine();

        listaGints.Agregar(1);
        listaGints.Agregar(2);
        listaGints.Agregar(3);
        listaGints.Agregar(4);
        Console.WriteLine("lista de int con valores");
        listaGints.mostrarListaGenerica();

    }
}

public class ListaGenerica <T>
{
    T[] ArregloGenericos;
    // int tamañoLista;
    int contador;
    
    public ListaGenerica(int tam)
    {
       ArregloGenericos = new T[tam];
        contador = 0;
    }

    public T[] Agregar(T element)
    {
        ArregloGenericos[contador] = element;
        contador++;

        return ArregloGenericos;
    }

    public void mostrarListaGenerica()
    {
        foreach (var item in ArregloGenericos)
        {
            Console.Write($"{item} ");
        }
    }




}