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
			//Erstellung des Objekts UserInput
			UserInput userInput = new UserInput();
			
			//Aufruf der Abrage der Rechnungsart und Zuweisung zu einer Variablen
			int Decision = userInput.UserOption();
			switch (Decision)
			{
				//Auswahl: Bruchrechnen
				case 1:
					//Erstellung Bruch eins
					Bruch bruch = userInput.UserBruch();
					//Erstellung Bruch zwei
					Bruch bruch2 = userInput.UserBruch();
					//Aufruf Methode AuswBruch
					AuswBruch(bruch, bruch2);
					break;

				//Auswahl: Grundrechnung
				case 2:
					//Zuweisung der Zahlen eins und zwei
					Zahl1 = userInput.UserGrund();
					Zahl2 = userInput.UserGrund();
					//Aufruf Methode AuswGrund
					AuswGrund(Zahl1, Zahl2);
					break;
			}			
			//Damit Die scheiß Konsole nicht zu geht!!!
			Console.ReadKey();
		} 
		static void AuswBruch(Bruch bruch, Bruch bruch2)
		{
			//Das sollte man sich Wohl denken können
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/) \n");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					//Aufruf der Bruchaddition
					bruch.AddBruch(bruch2);
					//Ausgabe Bruch
					bruch.Print();
					break;
				case '-':
					//Aufruf der Bruchsubtraktion
					bruch.SubBruch(bruch2);
					//Ausgabe Bruch
					bruch.Print();
					break;
				case '*':
					//Aufruf der Bruchmultiplikation
					bruch.Multibruch(bruch2);
					//Ausgabe Bruch
					bruch.Print();
					break;
				case '/':
					//Aufruf der Bruchdivision
					bruch.DivBruch(bruch2);
					//Ausgabe Bruch
					bruch.Print();
					break;
				default:
					//Wenn falscher Opperator
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
		}
		static void AuswGrund(double Zahl1,double Zahl2)
		{
			//Erstellung des Objekts Grundrechnung
			Grundrechenarten Rechnen = new Grundrechenarten(Zahl1, Zahl2);
			//Mitlerweile solltest du es nicht wissen
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/) \n");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					//Aufruf der Addition mit Ausgabe
					Console.WriteLine(Rechnen.Addition(Zahl1,Zahl2));
					break;
				case '-':
					//Aufruf der Subtraktion mit Ausgabe
					Console.WriteLine(Rechnen.Subtraktion(Zahl1, Zahl2));
					break;
				case '*':
					//Aufruf der Multiplikation mit Ausgabe
					Console.WriteLine(Rechnen.Multiplikation(Zahl1, Zahl2));
					break;
				case '/':
					//Aufruf der Division mit Ausgabe
					Console.WriteLine(Rechnen.Division(Zahl1, Zahl2));
					break;
				default:
					//Wenn falscher Opperator
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
		}
	}
} 