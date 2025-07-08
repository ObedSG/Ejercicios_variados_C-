 

namespace Genericos


{
	class Programa
	{
		static void Main()
		
		{
			ALMACEN_TRABAJADORES <Secretaria> Ingenieros = new ALMACEN_TRABAJADORES <Secretaria> (3);
			
			Ingenieros.agregar_Sueldo(new Secretaria(1200));
			Ingenieros.agregar_Sueldo(new Secretaria(324));
			Ingenieros.agregar_Sueldo(new Secretaria (2311));
			
			System.Console.WriteLine(Ingenieros.GetDatos(1).Salario());
			System.Console.WriteLine(Ingenieros.GetDatos(0).Salario());
			System.Console.WriteLine(Ingenieros.GetDatos(2).Salario());
			
			
		}
	}

	

	public interface ISueldo
	
		{
			public double Salario ();
		}
	
	
	public class ALMACEN_TRABAJADORES <T> where T:ISueldo
	{
		private T[] Mis_trabajadores;
		int i=0;
		
		public ALMACEN_TRABAJADORES(int z)
		
		{
			Mis_trabajadores= new T[z];
		}
		
		public void agregar_Sueldo(T s)
		{
			Mis_trabajadores[i]= s;
			i++;
		}
		
		public T GetDatos(int i)
		{
			return Mis_trabajadores[i];
		}
		
	
		
	} 
	
	
	
	public class Secretaria: ISueldo
	{
		private double salario; 
		public Secretaria (double s )
		{
			salario = s;
		}
		
		public double Salario ()
		{
			
			return salario;
		}
		
	}
		public class Ingeniero: ISueldo
	{
		private double salario; 
		public Ingeniero (double s )
		{
			salario = s;
		}
		
		public double Salario ()
		{
			
			return salario;
		}
		
		
		public class Estudiante
		{	private double sa;
		public Estudiante ( )
		{
			sa=0;
		}
		
		public string Salario ()
		{
			
			return $"Yo no tengo salario: {sa}";
		}
		
	}
		
	}
	
	
}