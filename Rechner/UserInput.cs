using System;


namespace Rechner
{
	class UserInput
	{
		//Auswahl was gerrechnet werden soll
		public static int UserOption()
		{
			try
			{
				//Frage nach Eingabe
				Console.WriteLine("Was wollen sie Rechnen?\nBruchrechnen(1)\nRechnen mit Grundrechenarten(2) ");
				//Zuweisung der Eingabe zu Variable
				int Eingabe = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
				//Abwarten
				Console.ReadKey();
				//Konsole berreinigen
				Console.Clear();
				//Rückgabe der Eingabe
				return Eingabe;
			}
			//Exeption handling, wenn Format-Exception aufritt
			catch (FormatException)
			{
				FormExMessage();
				return 0;
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExMessage();
				return 0;
			}
		}

		//Benutzereingabe des Bruches
		public static Bruch UserBruch()
		{
			try
			{
				//Erstellung eines Arrays zum speichern der Bruchwerte
				int[] temp = new int[2];
				//Eingabeaufforderung für den Zähler
				Console.Write("Geben sie den Zaeler des Bruches ein: \n");
				//Zuweisung zu Array index 0
				temp[0] = Convert.ToInt32(Console.ReadLine());
				//Eigabeaufforderung für den Nenner
				Console.Write("Geben sie den Nenner des Bruches ein: \n");
				//Zuweisung zu Array index 1
				temp[1] = Convert.ToInt32(Console.ReadLine());
				//Rückgabe des Arrays
				return CreateBruch(temp);
			}
			//Exeption handling, wenn Format-Exception aufritt
			catch (FormatException)
			{
				FormExMessage();
				return null;
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExMessage();
				return null;
			}
		}
		//Erstellung des Bruches
		private static Bruch CreateBruch(int[] temp)
		{
			//Erstellung des Bruches
			Bruch bruch = new Bruch(temp[0], temp[1]);
			//Rüchgabe des Bruches
			return bruch;
		}
		//Benutzereingabe für Grundrechnung
		public static double UserGrund()
		{
			try
			{
				//Eingabeaufforderung
				Console.Write("Geben sie ihre Zahl ein!: \n");
				//Zuweisung der Eingabe zu Variable
				double Zahl = Convert.ToDouble(Console.ReadLine());
				//Rückgabe Zahl
				return Zahl;
			}
			//Exeption handling, wenn Format-Exception aufritt
			catch (FormatException)
			{
				FormExMessage();
				return 0;
			}
			//Exception handling, falls andere Exception
			catch (Exception)
			{
				ExMessage();
				return 0;
			}
		}
		public static int Repeat()
		{
			//Ausgabe Frage
			Console.WriteLine("Wollen sie noch mehr rechnen? Y/N");
			//Zuweisung der Antwort zu Variable
			char Eingabe = Convert.ToChar(Console.ReadLine());
			try
			{
				//Bei Eingabe y/Y wird 1 returnt
				if (Eingabe == 'y' || Eingabe == 'Y')
				{
					return 1;
				}
				//Bei Eingabe n/N wird 2 returnt
				else if (Eingabe == 'n' || Eingabe == 'N')
				{
					return 2;
				}
			}
			//Allgemeines Exeption handling
			catch (Exception)
			{
				//Aufrug Methode ExMessage()
				ExMessage();
			}
			return 0;
		}

		//Nachricht bei Format-Exception
		public static void FormExMessage()
		{
			//Output Nachricht
			Console.WriteLine("Es liegt ein Fehler bei der Eingabe vor!\nBitte starten sie das Programm erneut!");
			Console.ReadKey();
			//Beendigung des Programms
			Environment.Exit(1);
		}
		//Nachricht bei DivisionbyZero Exception
		public static void DivZeroExMessage()
		{
			//Ausgabe Nachricht
			Console.WriteLine("Es kann nicht durch 0 geteilt werden!\nBitte starten sie das Programm erneut!");
			Console.ReadKey();
			//Beendingung des Programms
			Environment.Exit(1);
		}
		//Nachricht bei anderer Exception
		public static void ExMessage()
		{
			//Ausgabe Message
			Console.WriteLine("Fehler! Bitte starten sie das Programm neu.");
			Console.ReadKey();
			//Beendigung des Programms
			Environment.Exit(1);
		}
	}
}