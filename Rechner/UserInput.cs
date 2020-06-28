using System;

namespace Rechner
{
	class UserInput
	{
		//Auswahl was gerrechnet werden soll
		public static int UserOption()
		{
			//Frage nach Eingabe
			Console.Write("Was wollen sie Rechnen?\nBruchrechnen(1)\nRechnen mit Grundrechenarten(2)\n> ");
			//Aufruf der Modechoose Methode und zuweisung des Rückgabewerts
			int	input = Modechoose();
			//Konsole berreinigen
			Console.Clear();
			//Rückgabe der Eingabe
			return input;
		}

		public static int Modechoose()
		{
			//Zuweisung der Eingabe zu Variable
			string input = Console.ReadLine();
			//Abfrage ob Eingabe ein Zeichen lang
			if (input.Length == 1)
			{
				try
				{
					//Rückgabe der Einagbe
					return Convert.ToInt32(input);
				}
				catch (FormatException)
				{
					ExceptionMessage.FormExMessage();
					return 0;
				}
			}
			else
			{
				Console.Write("Die Eingabe darf nur ein Zeichen lang sein!\nBitte Eingabe erneut versuchen!\n> ");
				//Neustart der Abfrgae
				return Modechoose();
			}
		}

		//Benutzereingabe des Bruches
		public static Fraction UserFrac()
		{
			//Erstellung eines Arrays zum speichern der Bruchwerte
			int[] temp = new int[2];
			//Eingabeaufforderung für den Zähler
			Console.Write("Geben sie den Zaeler des Bruches ein:\n> ");
			try
			{
				//Zuweisung zu Array index 0
				temp[0] = Convert.ToInt32(Console.ReadLine());
				//Eigabeaufforderung für den Nenner
				Console.Write("Geben sie den Nenner des Bruches ein:\n> ");
				//Zuweisung zu Array index 1
				temp[1] = Convert.ToInt32(Console.ReadLine());
			}
			//Exeption handling, wenn Format-Exception aufritt
			catch (FormatException)
			{
				ExceptionMessage.FormExMessage();
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExceptionMessage.ExMessage();
			}
			//Rückgabe des Arrays
			return CreateFrac(temp);
		}

		//Erstellung des Bruches
		private static Fraction CreateFrac(int[] temp)
		{
			return new Fraction(temp[0], temp[1]);
		}

		//Benutzereingabe für Grundrechnung
		public static double UserBasic()
		{
			//Eingabeaufforderung
			Console.Write("Geben sie ihre Zahl ein!:\n> ");
			double num;
			try
			{
				//Zuweisung der Eingabe zu Variable
				num = Convert.ToDouble(Console.ReadLine());
			}
			//Exeption handling, wenn Format-Exception aufritt
			catch (FormatException)
			{
				ExceptionMessage.FormExMessage();
				return 0;
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExceptionMessage.ExMessage();
				return 0;
			}
			//Rückgabe Zahl
			return num;
		}

		public static int Repeat()
		{
			//Ausgabe Frage
			Console.Write("Wollen sie nochmal rechnen? Ja(1) Nein(2)\n> ");
			int input = Modechoose();
			switch (input)
			{
				case 1:
					return 1;
				case 2:
					return 2;
				default:
					Console.WriteLine("Ungültige Eingabe");
					return 0;
			}
		}
	}
}