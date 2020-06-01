using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class Grundrechenarten
	{
		//Definition der Komponenten zum Rechnen
		double Zahl1 = 0;
		double Zahl2 = 0;
		public Grundrechenarten(double Zahl1,double Zahl2)
		{
			//Zuweisung der Variablen zum späteren Objekt
			this.Zahl1 = Zahl1;
			this.Zahl2 = Zahl2;
		}

		//Addition
		public double Addition(double Zahl1, double Zahl2)
		{
			//Rückgabe der addierten Zahlen
			return Zahl1 + Zahl2;
		}

		//Subtraktion
		public double Subtraktion(double Zahl1, double Zahl2)
		{
			//Rückgabe der subtrahierten Zahlen
			return Zahl1 - Zahl2;
		}

		//Multiplikation
		public double Multiplikation(double Zahl1, double Zahl2)
		{
			//Rückgabe der multiplizierten Zahlen
			return Zahl1 * Zahl2;
		}

		//Division
		public double Division(double Zahl1, double Zahl2)
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
