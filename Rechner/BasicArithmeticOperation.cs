using System;

namespace Rechner
{
	class BasicArithmeticOperation
	{
		//Addition
		public static double Addition(double num1, double num2)
		{
			//Rückgabe der addierten Zahlen
			return num1 + num2;
		}

		//Subtraktion
		public static double Subtraction(double num1, double num2)
		{
			//Rückgabe der subtrahierten Zahlen
			return num1 - num2;
		}

		//Multiplikation
		public static double Multiply(double num1, double num2)
		{
			//Rückgabe der multiplizierten Zahlen
			return num1 * num2;
		}

		//Division
		public static double Division(double num1, double num2)
		{
			//Abfrage, da nicht duch null geteilt werden kann
			if (num2 != 0)
			{
				//Rückgabe der dividierten Zahlen
				return num1 / num2;
			}
			else
			{
				//Ausgabe, dass Fehler vorliegt
				Console.WriteLine("Durch 0 teilen ist nicht möglich");
				//Warten, dass Fehlermeldung gelesen werden kann
				Console.ReadKey();
				Console.Clear();
				//Zuweisung der Zahlen eins und zwei
				num1 = UserInput.UserBasic();
				num2 = UserInput.UserBasic();
				//Rekursiever Aufruf der Division mit neuen Zahlen
				return Division(num1, num2);
			}
		}
	}
}
