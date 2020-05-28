using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class UserInput
	{
		public UserInput()
		{
		}
		public int UserOption()
		{
			int Eingabe;
			Console.WriteLine("Was wollen sie Rechnen?\nBruchrechnen(1)\nRechnen mit Grundrechenarten(2) ");
			Eingabe = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
			return Eingabe;
		}
		public Bruch UserBruch()
		{
			int[] temp = new int[4];
			Console.Write("Geben sie den Zaeler des Bruches ein: \n");
			temp[0] = Convert.ToInt32(Console.ReadLine());
			Console.Write("Geben sie den Nenner des Bruches ein: \n");
			temp[1] = Convert.ToInt32(Console.ReadLine());
			return CreateBruch(temp);
		}
		private Bruch CreateBruch(int[] temp)
		{
			Bruch bruch = new Bruch(temp[0], temp[1]);
			return bruch;
		}
		public double UserGrund()
		{
			double Zahl;
			Console.Write("\nGeben sie ihre Zahl ein!: ");
			Zahl = Convert.ToDouble(Console.ReadLine());
			return Zahl;
		}
	}
}
