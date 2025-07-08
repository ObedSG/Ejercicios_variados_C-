public class PRODUCTO : IComparable<PRODUCTO>
{
    private int _precio;

    public string nombre { get; set; }

    public int precio
    {
        get => _precio;
        set
        {
            if (value < 0)
                throw new ArgumentException("No puede ser menor a 0 el precio");
            else
                _precio = value;
        }
    }





    public PRODUCTO(string nom, int pre)
    {
        precio = pre;
        nombre = nom;
    }

    public int CompareTo(PRODUCTO other)
    {
        return precio.CompareTo(other.precio);
    }
}

public class Tienda
{
    public List<PRODUCTO> lista_Productos { get; set; } = new();

    public void Obtener_lista_Ordenada_Precios()
    {
        lista_Productos.Sort((p1, p2) => p2.precio.CompareTo(p1.precio));
        Console.WriteLine("Imprimiendo lista ordenada\n");

        foreach (var item in lista_Productos)
        {
            Console.WriteLine($"Nombre: {item.nombre},  Precio: {item.precio}");

        }

        //return lista_Productos; 

    }

}

public class Program
{
    static void Main()
    {
        Tienda mi_Tiendita = new Tienda();
        mi_Tiendita.lista_Productos.Add(new PRODUCTO("computadora", 5600));
        mi_Tiendita.lista_Productos.Add(new PRODUCTO("Xbox", 3500));
        mi_Tiendita.lista_Productos.Add(new PRODUCTO("Cariñosa", 1500));
        mi_Tiendita.lista_Productos.Add(new PRODUCTO("Telefono", 3000));
        mi_Tiendita.lista_Productos.Add(new PRODUCTO("Television", 6000));

        mi_Tiendita.Obtener_lista_Ordenada_Precios();
    }
}