namespace HerenciaFigura
{
    public class Figura
    {
        protected int _centroX, _centroY;

        //constructor Predeterminado
        public Figura()
        {
            _centroX = 0;
            _centroY = 0;
        }

        //Sobrecarga del constructor con parametros
        public Figura(int centroX, int centroY)
        {
            _centroX = centroX;
            _centroY = centroY;
        }

        //Propiedades
        public int centroX
        {
            get
            {
                return _centroX;
            }
            set
            {
                _centroX = value;
            }

        }

        public int centroY
        {
            get { return _centroY; }
            set { _centroY = value; }
        }

        //obtener informacion d ela figura
        public virtual string obtenerInformacion() => $"centroX: {centroX}, centroY: {centroY}";

        //metodo virtual para calcular el area
        public  string CalcularArea()
        {
            return "soy la figura base"; // Por defecto, devuelve 0.0, se debe sobreescribir en las clases derivadas
        }
    }
}