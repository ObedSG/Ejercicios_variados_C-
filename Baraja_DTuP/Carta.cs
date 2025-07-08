namespace BarajaEspañola

{
	public class Carta
	{

		private string palo;
		private string valor;

		public Carta()
		{
			palo = "";
			valor = "";
		}

		public string Palo
		{
			get => palo;
			set {palo = value;}
		}
		
		public string Valor 
		{
			get => valor;
			set {valor = value;}
		}
		




	}
}