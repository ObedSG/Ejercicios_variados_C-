using System;

class Program
{
	static void Main()
	{
		ALMACEN_OBJETOS<float>  Obje_Strings = new ALMACEN_OBJETOS <float> (4);
		// Obje_Strings.IngresarObjeto("pepe");
		// Obje_Strings.IngresarObjeto("FER");
		// Obje_Strings.IngresarObjeto("MONICA");
		// Obje_Strings.IngresarObjeto("felipe");
		
		// Obje_Strings.IngresarObjeto(new EMPLEADO(1200));
		// Obje_Strings.IngresarObjeto(new EMPLEADO(1500));
		// Obje_Strings.IngresarObjeto(new EMPLEADO(1700));
		// Obje_Strings.IngresarObjeto(new EMPLEADO(2000));
		// EMPLEADO salarioEmpl = Obje_Strings.GetObjeto(2);
		
		// System.Console.WriteLine (salarioEmpl.getSalario());
	
			// Obje_Strings.IngresarObjeto(12);
			// Obje_Strings.IngresarObjeto(10);
			// Obje_Strings.IngresarObjeto(30);
			// Obje_Strings.IngresarObjeto(11282);
			
			// System.Console.WriteLine(Obje_Strings.GetObjeto(0));
			// System.Console.WriteLine(Obje_Strings.GetObjeto(1));
			// System.Console.WriteLine(Obje_Strings.GetObjeto(2));
			// System.Console.WriteLine(Obje_Strings.GetObjeto(3));
			
			
			
			//*******************************************************************+
	//PARTE 2
	
	int[] arrInt = {1,2,3,4,5,6};
	double[] arrDouble = {1.34,3.232, 4.2324, 5.231, 9.2};
	char[] arrChar = {'h','o','l','a'};
	
	System.Console.WriteLine("IMPRIMIENDO ARRINT: ");
		imprimirArreglo(arrInt);
		
	System.Console.WriteLine("IMPRIMIENDO arrDouble: ");
		imprimirArreglo(arrDouble);
		
	System.Console.WriteLine("IMPRIMIENDO arrChar: ");
		imprimirArreglo(arrChar);	
		
		
	System.Console.WriteLine();
	System.Console.WriteLine("/t/t IMprimiendo con metodo generico" );

		
			T_ImprimirArreglo(arrInt);
			T_ImprimirArreglo(arrDouble);
			T_ImprimirArreglo(arrChar);
			
	}
	
	
		
		static void imprimirArreglo(int[] i)
		{
			foreach(var o in i )
			{
				System.Console.Write(o+"");
			}
			System.Console.WriteLine();
		} 	
	static void imprimirArreglo(double[] i)
		{
			foreach(var o in i )
			{
				System.Console.Write(o+"");
			}
			System.Console.WriteLine();
		} 	
		
		static void imprimirArreglo(char[] i)
		{
			foreach(var o in i )
			{
				System.Console.Write(o+"");
			}
			System.Console.WriteLine();
		} 	
		
		static void T_ImprimirArreglo <T> (T[] arrTipo)
		{
			foreach (var item in arrTipo)
			{
				System.Console.Write(item +" ");
			}
			System.Console.WriteLine();
		}
	
			
	
}



class ALMACEN_OBJETOS<T>
{
	private T[] mis_objeto;
	private int cantidad=0;
	
	public ALMACEN_OBJETOS (int c)
	{
		mis_objeto = new T[c];
	}
	
	public void IngresarObjeto(T obj)
	{
		mis_objeto[cantidad] = obj; 
		
		cantidad++;
		
	}
	
	public T GetObjeto(int z)
	{
		return mis_objeto[z];
		 
	}
	
}

public class EMPLEADO
{
	private double salario;
	
	public EMPLEADO(double s)
	{
		salario=s;
	}
	
	public double getSalario()
	{
		return salario;
	}
}