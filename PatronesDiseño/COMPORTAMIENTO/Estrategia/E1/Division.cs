namespace ESTRATEGIA
{
    public class Division : IEstrategia
    {
        public double Operacion(double a, double b)
        {
            double r=0;
            try
            {
                r =a/b;
            }
            catch(DivideByZeroException eror)
            {
                System.Console.WriteLine("ERROR NO ES POSIBLE DIVIDIR POR 0");
                System.Console.WriteLine(eror.Message);
            }
            catch
            {   
                System.Console.WriteLine("error de parametros");

            }

            return r;
        }
    }
}