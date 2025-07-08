using System;
using System.Security.Cryptography;


public enum tipos_bonus {bajo= 100, medio= 200, alto= 500};

class Program
{
	static void Main()
	{
		
		empleado pepe = new empleado(tipos_bonus.alto, 1200);

		System.Console.WriteLine("EL SALARIO MAS EL BONUS DE PEPE ES: "+pepe.getBonus);
		
	}
		
}

 class empleado
{
	private decimal salario, bonus;

	public empleado(tipos_bonus bunus, decimal salario)
	{
		this.bonus= (decimal) bunus;
		this.salario= salario; 
	}

		public decimal getBonus => salario + bonus;
	  
}

