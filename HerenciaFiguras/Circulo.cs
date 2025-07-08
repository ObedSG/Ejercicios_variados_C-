using HerenciaFigura;

public class Circulo : Figura
{

    private double _radio;

    public Circulo()
    {
        _radio = 0; // Valor predeterminado
        _centroX = 0; // Valor predeterminado
        _centroY = 0;
    }

    public Circulo(int centroX, int centroY, double radio)
    {
        _centroX = centroX;
        _centroY = centroY;
        _radio = radio;
    }

    public double Radio
    {
        get { return _radio; }
        set { _radio = value; }
    }

    public override string obtenerInformacion() => $"centroX: {centroX}, centroY: {centroY}, Radio: {Radio}";

    public void obtenerInformacion(ref string informacion)
    {
        informacion = base.obtenerInformacion() + $", Radio: {Radio}";
    }

    public new string CalcularArea()
    {
        double area= Math.PI* Math.Pow(Radio, 2); // Area del círculo
        return $"Area: {area.ToString("0.00")}";
    }


}