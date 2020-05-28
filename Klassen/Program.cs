using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class Program
	{
		static void Main(string[] args)
		{
			double Zahl1 = 0;
			double Zahl2 = 0;
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
					Zahl1 = userInput.UserGrund();
					Zahl2 = userInput.UserGrund();
					AuswGrund(Zahl1, Zahl2);
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
		static void AuswGrund(double Zahl1,double Zahl2)
		{
			Grundrechenarten Rechnen = new Grundrechenarten(Zahl1, Zahl2);
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/) \n");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					Console.WriteLine(Rechnen.Addition(Zahl1,Zahl2));
					break;
				case '-':
					Console.WriteLine(Rechnen.Subtraktion(Zahl1, Zahl2));
					break;
				case '*':
					Console.WriteLine(Rechnen.Multiplikation(Zahl1, Zahl2));
					break;
				case '/':
					Console.WriteLine(Rechnen.Division(Zahl1, Zahl2));
					break;
				default:
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
		}
	}
} 