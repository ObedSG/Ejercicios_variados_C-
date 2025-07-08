using HerenciaFigura;

public class Triangulo : Figura
{

    private int _altura, _base;

    public Triangulo()
    {
        _centroX = 0; // Valor predeterminado
        _centroY = 0;
        _altura = 0; // Valor predeterminado
        _base = 0; // Valor predeterminado      
    }

    public Triangulo(int centroX, int centroY, int bases, int altura)
    {
        _centroX = centroX;
        _centroY = centroY;
        this._base = bases;
        this._altura = altura;
    }
 

    public int Base
    {
        get { return _base; }
        set { _base = value; }
    }

    public int Altura
    {
        get { return _altura; }
        set { _altura = value; }    
    }

    public override string obtenerInformacion() => $"centroX: {centroX}, centroY: {centroY}, Altura: {Altura}, Base: {Base}";

    public void obtenerInformacion(ref string informacion)
    {
        informacion = base.obtenerInformacion() + $", Altura: {Altura}, Base: {Base}";
    }

    public new string CalcularArea()
    {
        float area = (1f* Altura * Base) / 2;
        return $"Area: {area.ToString("0.00")}";
    }


}