using System;
using System.Reflection.Metadata;

namespace BarajaEspañola
{

	//PROGRAMA PARA GENERAR CARTAS DE LA BARAJA; SE MUESTRAN TODAS LAS CARTAS INICIALMENTE, DESPUES SE BARAJEAN SE ACOMODADN EN POSICIONES
	//ALEATORIAS DEL ARREGLO Y FINALMENTE PUEDES BUSCAR UN VALOR DE CARTA Y TE DEVOLVERA QUE TIPO DE CARTA ES Y SU POSICION EN EL ARREGLO DE TIPOS CARTA-
	class Program
	{
		
		static void Main()
		{
			System.Console.WriteLine("\n\tprograma para generar la baraja española: ");
			System.Console.WriteLine(" Valores de 48 cartas: ");
			
			string[] losPalos = ["oros", "copas", "espadas", "bastos"];
			string[] losValores = 
			[
				"unos",
				"dos",
				"tres",
				"cuatro",
				"cinco",
				"seis",
				"siete",
				"ocho",
				"nueve",
				"sota",
				"caballero",
				"rey"
			];
			
			System.Console.WriteLine("Los palos de la baraja son: ");
			foreach (string item in losPalos)
				System.Console.WriteLine($"{item} ");
			System.Console.WriteLine();
			
			System.Console.WriteLine("Los valores de la baraja son: ");
			foreach (string item in losValores)
				System.Console.WriteLine(item+ " ");
			System.Console.WriteLine();
				
				
				int totalCartas = losPalos.Length * losValores.Length;

			Carta[] baraja = new Carta[totalCartas];

			//inicializamos la baraja
			int contadorCarta=0;


			for(int i=0; i<losPalos.Length; i++)
				{
					for(int j=0; j<losValores.Length; j++)
					{
						baraja[contadorCarta]=new Carta
						{
							Valor = losValores[j],
							Palo = losPalos[i]
						};
						contadorCarta++;
					}
				}
			System.Console.WriteLine("baraja inicializada");

	//consulta de numero de carta
			int numeroCarta=1;

			do
			{
				try 
				{
					System.Console.WriteLine("ingrasa el nuemero de carta que deseas consultar");
					numeroCarta = int.Parse(Console.ReadLine());
					
					if(numeroCarta >= 1 && numeroCarta <= 48)
					{
						System.Console.WriteLine($"La carta NO. {numeroCarta} es: {baraja[numeroCarta-1].Valor} de {baraja[numeroCarta-1].Palo}");
					}
						else 
							if(numeroCarta != 0)
								System.Console.WriteLine("\nIngresaste un numero fuera del rango, intenta nuevamente\n\n");
				}

				catch(FormatException Error)
				{
					System.Console.WriteLine("ingresaste un dato no numerico, intenta de nuevo\n\n");
					System.Console.WriteLine($"Error. {Error.Message}\n\n");
				}

			} while (numeroCarta !=0);

			Console.WriteLine("fin de la visualizacion ");

			Console.WriteLine("la baraja ordenada queda asi: ");
				VisualizarBaraja(baraja);



			Console.WriteLine("AHORA MEZCLAREMOS LAS CARTAS:");
				int cantVeces=0;
				bool datoCorrecto =false;

				while (datoCorrecto==false)
				{
					Console.WriteLine("\n¿Cunatas veces quieres mezclar?");

					datoCorrecto = int.TryParse(Console.ReadLine(), out cantVeces);

					if(datoCorrecto==false || cantVeces<0)
						{
							Console.WriteLine("datos invalidaos repita nuevamente");
							System.Console.WriteLine(datoCorrecto);
							datoCorrecto=false;
						}
					else
					{
						if(cantVeces==0)
						{
							System.Console.WriteLine("no se realizaran mezclas");
						}
						else
						{
							System.Console.WriteLine($"Mezclando la baraja {cantVeces} de veces");
							MezclarBaraja(baraja,cantVeces);
							System.Console.WriteLine("TERMINANDO DE MEZCLAR");

							System.Console.WriteLine("\t CARTAS ACOMODADAS ALEATORIAMENTE");
							VisualizarBaraja(baraja);

						}

					}
				}	

				//ahora buscaremos la posicion de la carta dado unos valores 
				string valorCarta= "oro";
				bool Salir= false;

				System.Console.WriteLine("VERIFICANDO DONDE QUEDARON LAS CARTAS DE UN VALOR ESPECIFICO");

				do
				{

					System.Console.WriteLine("escribe un tipo de palo que quieras buscar");
					valorCarta = Console.ReadLine()!.ToLower();
					if(valorCarta== "" || valorCarta == "salir")
						Salir=true;
					
					if(ValidaDatos(valorCarta, losValores))
					{
						for(int i=0; i<baraja.Length; i++)
						{
							if(baraja[i].Valor== valorCarta)
								Console.WriteLine($"Carta[{i+1}] valor: {baraja[i].Valor} de {baraja[i].Palo}");

						}
					}
					else
					{
						if(Salir!=true)
							System.Console.WriteLine("INGRESASTE DATO INCORRECTO REPITE NUEVAMENTE");
					}

				}while(Salir==false);

					System.Console.WriteLine("EJECUCION FINALIZADA");

			
			
				}

		static bool ValidaDatos(string valor, string[] Arrvalores)
		{
			bool valido=false;
				for(int i=0; i<Arrvalores.Length;i++)
				{
					if(Arrvalores[i]== valor)
					valido= true;
				}
			return valido;
		}

		static void VisualizarBaraja(Carta[] baraja)
		{

			for(int i=0; i<baraja.Length; i++)
			{
				System.Console.WriteLine($"Posicion (Carta): {i+1} es {baraja[i].Valor}  de {baraja[i].Palo}");

			}

		}


		//METODO PARA MEZCLAR BARAJA
		static void MezclarBaraja(Carta[] baraja, int cantVeces)
		{
			Random random = new();
			Carta cartaTemporal;
			int posicionAleatoria;
			
			for(int vez=1; vez< cantVeces; vez++)
			{
				for(int i=0; i<baraja.Length;i++)
				{
					posicionAleatoria = random.Next(0, baraja.Length);
					
					cartaTemporal= baraja[i];
					baraja[i]=baraja[posicionAleatoria];
					baraja[posicionAleatoria]= cartaTemporal;

				}
			}
		}
	
	}

	
}