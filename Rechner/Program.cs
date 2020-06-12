using System;


namespace Rechner
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Abfrage der Rechnungsart
			int Decision = UserInput.UserOption();
			switch (Decision)
			{
				//Auswahl: Bruchrechnen
				case 1:
					//Erstellung Bruch eins
					Bruch bruch = UserInput.UserBruch();
					//Erstellung Bruch zwei
					Bruch bruch2 = UserInput.UserBruch();
					//Aufruf Methode AuswBruch
					AuswBruch(bruch, bruch2);
					break;

				//Auswahl: Grundrechnung
				case 2:
					//Zuweisung der Zahlen eins und zwei
					double Zahl1 = UserInput.UserGrund();
					double Zahl2 = UserInput.UserGrund();
					//Aufruf Methode AuswGrund
					AuswGrund(Zahl1, Zahl2);
					break;

				default:
					Main(new string [1]);
					break;
			}
			Nochmal();
		}
		static void AuswBruch(Bruch bruch, Bruch bruch2)
		{
			//Ausgabe Frage zu Opperator
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
		static void AuswGrund(double Zahl1, double Zahl2)
		{
			//Ausgabe Frage nach Opperator
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/) \n");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					//Aufruf der Addition mit Ausgabe
					Console.WriteLine(Grundrechenarten.Addition(Zahl1, Zahl2));
					break;
				case '-':
					//Aufruf der Subtraktion mit Ausgabe
					Console.WriteLine(Grundrechenarten.Subtraktion(Zahl1, Zahl2));
					break;
				case '*':
					//Aufruf der Multiplikation mit Ausgabe
					Console.WriteLine(Grundrechenarten.Multiplikation(Zahl1, Zahl2));
					break;
				case '/':
					//Aufruf der Division mit Ausgabe
					Console.WriteLine(Grundrechenarten.Division(Zahl1, Zahl2));
					break;
				default:
					//Wenn falscher Opperator
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
		}
		//Abfrage ob nochmal gerechnet werden soll
		public static void Nochmal()

		{
			//Erstellung Objekt von der Klasse UserInput
			UserInput userInput = new UserInput();
			//Zuweisung der Benutzereingabe zu einer Variablen
			int antw = UserInput.Repeat();

			switch (antw)
			{
				//Wenn eins, wird die Main-Methode wiederholt
				case 1:
					Main(new string [1]);
					break;
				//Wenn zwei beendigung des Programms
				case 2:
					Environment.Exit(1);
					break;
				//Bei Fehler wird Abfrage wiederholt
				default:
					Console.WriteLine("Fehler!");
					//Erneuter Aufruf der Nochmal()-Methode
					Nochmal();
					break;
			}
		}
	}
}
