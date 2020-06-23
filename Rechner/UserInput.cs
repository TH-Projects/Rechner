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
			int	Eingabe = Modechoose();
			//Konsole berreinigen
			Console.Clear();
			//Rückgabe der Eingabe
			return Eingabe;
		}

		public static int Modechoose()
		{
			//Zuweisung der Eingabe zu Variable
			string Eingabe = Console.ReadLine();
			//Abfrage ob Eingabe ein Zeichen lang
			if (Eingabe.Length == 1)
			{
				try
				{
					//Rückgabe der Einagbe
					return Convert.ToInt32(Eingabe);
				}
				catch (FormatException)
				{
					ExceptionHandling.FormExMessage();
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
		public static Bruch UserBruch()
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
				ExceptionHandling.FormExMessage();
				return null;
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExceptionHandling.ExMessage();
				return null;
			}
			//Rückgabe des Arrays
			return CreateBruch(temp);
		}

		//Erstellung des Bruches
		private static Bruch CreateBruch(int[] temp)
		{
			return new Bruch(temp[0], temp[1]);
		}

		//Benutzereingabe für Grundrechnung
		public static double UserGrund()
		{
			//Eingabeaufforderung
			Console.Write("Geben sie ihre Zahl ein!:\n> ");
			double Zahl;
			try
			{
				//Zuweisung der Eingabe zu Variable
				Zahl = Convert.ToDouble(Console.ReadLine());
			}
			//Exeption handling, wenn Format-Exception aufritt
			catch (FormatException)
			{
				ExceptionHandling.FormExMessage();
				return 0;
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExceptionHandling.ExMessage();
				return 0;
			}
			//Rückgabe Zahl
			return Zahl;
		}

		public static int Repeat()
		{
			//Ausgabe Frage
			Console.Write("Wollen sie nochmal rechnen? Ja(1) Nein(2)\n> ");
			int Eingabe=Modechoose();
			switch (Eingabe)
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