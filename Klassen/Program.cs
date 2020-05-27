using System;

namespace Rechner
{
	class Program
	{
		static void Main(string[] args)
		{	
			UserInput userInput = new UserInput();
			int Decision = userInput.UserOption();
			switch (Decision)
			{
				case 1:
					Bruch bruch = userInput.UserBruch();
					Bruch bruch2 = userInput.UserBruch();
					AuswBruch(bruch, bruch2);
					break;
				case 2:
					break;
			}			
			Console.ReadKey();
		} 
		static void AuswBruch(Bruch bruch, Bruch bruch2)
		{
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
		}
	} 
}