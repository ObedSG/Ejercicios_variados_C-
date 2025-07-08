using HerenciaFigura;

public class Program
{
    public static void Main()
    {
        Circulo micirculo = new Circulo(1, 1, 3);
        Triangulo mitriangulo = new Triangulo(2, 2, 4, 5);

        string informacionCirculo = "";
        System.Console.WriteLine(micirculo.obtenerInformacion());
        System.Console.WriteLine($"Información del Círculo antes de REF:{informacionCirculo}");
        micirculo.obtenerInformacion(ref informacionCirculo);
        System.Console.WriteLine($"Información del Círculo después de REF:{informacionCirculo}");
        System.Console.WriteLine("---------------------------------");
        string informacionTriangulo = "";
        System.Console.WriteLine(mitriangulo.obtenerInformacion());
        System.Console.WriteLine($"Información del Triángulo antes de REF:{informacionTriangulo}");
        mitriangulo.obtenerInformacion(ref informacionTriangulo);
        System.Console.WriteLine($"Información del Triángulo después de REF:{informacionTriangulo}");
        System.Console.WriteLine("---------------------------------");
        System.Console.WriteLine(micirculo.CalcularArea());
        System.Console.WriteLine(mitriangulo.CalcularArea());
        System.Console.WriteLine("Presione una tecla para salir...");
        System.Console.ReadKey();


        //polimorfismo

        Figura figura1 = new Circulo(3, 3, 5);
        Figura figura2 = new Triangulo(4, 4, 6, 8);
        System.Console.WriteLine("Información de la figura 1:");
        System.Console.WriteLine(figura1.obtenerInformacion());
        System.Console.WriteLine($"Área de la figura 1: {figura1.CalcularArea()}");
        System.Console.WriteLine("Información de la figura 2:");
        System.Console.WriteLine(figura2.obtenerInformacion());
        System.Console.WriteLine($"Área de la figura 2: {figura2.CalcularArea()}");
        System.Console.WriteLine("Presione una tecla para salir...");
        System.Console.ReadKey();
    }
}