using System;


namespace Rechner
{
	class Grundrechenarten
	{
		//Addition
		public static double Addition(double Zahl1, double Zahl2)
		{
			//Rückgabe der addierten Zahlen
			return Zahl1 + Zahl2;
		}

		//Subtraktion
		public static double Subtraktion(double Zahl1, double Zahl2)
		{
			//Rückgabe der subtrahierten Zahlen
			return Zahl1 - Zahl2;
		}

		//Multiplikation
		public static double Multiplikation(double Zahl1, double Zahl2)
		{
			//Rückgabe der multiplizierten Zahlen
			return Zahl1 * Zahl2;
		}

		//Division
		public static double Division(double Zahl1, double Zahl2)
		{
			//Abfrage, da nicht duch null geteilt werden kann
			if (Zahl2 != 0)
			{
				//Rückgabe der dividierten Zahlen
				return Zahl1 / Zahl2;
			}
			else
			{
				//Ausgabe, dass Fehler vorliegt
				Console.WriteLine("Durch 0 teilen ist nicht möglich");
				//Warten, dass Fehlermeldung gelesen werden kann
				Console.ReadKey();
				Console.Clear();
				UserInput Input = new UserInput();
				//Zuweisung der Zahlen eins und zwei
				Zahl1 = Input.UserGrund();
				Zahl2 = Input.UserGrund();
				//Rekursiever Aufruf der Division mit neuen Zahlen
				return Division(Zahl1, Zahl2);
			}
		}
	}
}
