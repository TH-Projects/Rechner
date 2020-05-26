using System;

namespace Rechner
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] WBruch = new int[4];
			WBruch = BenBruch();
			
			Bruch bruch = new Bruch(WBruch[0], WBruch[1]);
			Bruch bruch2 = new Bruch(WBruch[2], WBruch[3]);
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/) \n");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					bruch.AddBruch(bruch2);
					bruch.Print();
					break;
				case '-':
					bruch.SubBruch(bruch2);
					bruch.Print();
					break;
				case '*':
					bruch.Multibruch(bruch2);
					bruch.Print();
					break;
				case '/':
					bruch.DivBruch(bruch2);
					bruch.Print();
					break;
				default:
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
			Console.ReadKey();
		} 
		static int[] BenBruch()
		{
			int[] temp = new int[4];
			Console.Write("Bruchrechnung\nGeben sie den Zaeler des ersten Bruches ein: \n");
			temp[0] = Convert.ToInt32(Console.ReadLine());
			Console.Write("Geben sie den Nenner des ersten Bruches ein: \n");
			temp[1] = Convert.ToInt32(Console.ReadLine());
			Console.Write("Geben sie den Zaeler des zweiten Bruches ein: \n");
			temp[2] = Convert.ToInt32(Console.ReadLine());
			Console.Write("Geben sie den Nenner des zweiten Bruches ein: \n");
			temp[3] = Convert.ToInt32(Console.ReadLine());
			return temp;
		}
	} 
}
