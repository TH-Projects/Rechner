using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rechner
{
	class UserInput
	{
		public UserInput()
		{
		}

		//Hier wird Augewählt was gerrechnet werden soll
		public int UserOption()
		{
			int Eingabe;
			try
			{
				//Frage nach Eingabe
				Console.WriteLine("Was wollen sie Rechnen?\nBruchrechnen(1)\nRechnen mit Grundrechenarten(2) ");
				//Zuweisung der Eingabe zu Variable
				Eingabe = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
				//Abwarten
				Console.ReadKey();
				//Konsole berreinigen
				Console.Clear();
				//Rückgabe des Ergebnisses der Eingabe
				return Eingabe;
			}
			//Exeption handling, wenn Format exeption aufritt
			catch (FormatException)
			{
				FormExMessage();
				return 0;
			}
			//Exception handling, falls andere exception
			catch (Exception)
			{
				ExMessage();
				return 0;
			}
		}

		//Benutzereingabe des Bruches
		public Bruch UserBruch()
		{
			try
			{
				//Erstellung eines Arrays zum speichern der Bruchwerte
				int[] temp = new int[2];
				//Eingabeaufforderung für den Zaeler
				Console.Write("Geben sie den Zaeler des Bruches ein: \n");
				//Zuweisung zu ArrayIndex[0]
				temp[0] = Convert.ToInt32(Console.ReadLine());
				//Eigabeaufforderung für Nenner
				Console.Write("Geben sie den Nenner des Bruches ein: \n");
				//Zuweisung zu Arrayindex[1]
				temp[1] = Convert.ToInt32(Console.ReadLine());
				//Rückgabe des Arrays
				return CreateBruch(temp);
			}
			//Exeption handling, wenn Format exeption aufritt
			catch (FormatException)
			{
				FormExMessage();
				return null;
			}
			//Exception handling, falls andere exception
			catch (Exception)
			{
				ExMessage();
				return null;
			}
		}
		//Erstellung des Bruches
		private Bruch CreateBruch(int[] temp)
		{
			//Erstellung...was sonst
			Bruch bruch = new Bruch(temp[0], temp[1]);
			//Rüchgabe des Bruches an Program.cs
			return bruch;
		}
		//Benutzereingabe für Grundrechnung
		public double UserGrund()
		{
			try
			{
				double Zahl;
				//Eingabeaufforderung
				Console.Write("Geben sie ihre Zahl ein!: \n");
				//Zuweisung der Eingabe zu Variable
				Zahl = Convert.ToDouble(Console.ReadLine());
				//Rückgabe Zahl
				return Zahl;
			}
			//Exeption handling, wenn Format exeption aufritt
			catch (FormatException)
			{
				FormExMessage();
				return 0;
			}
			//Exception handling, falls andere exception
			catch (Exception)
			{
				ExMessage();
				return 0;
			}
		}
		public int Repeat()
		{
			//Deklariation von Variable für Benutzereingabe
			char Eingabe = ' ';
			//Output Frage
			Console.WriteLine("Wollen sie noch mehr rechnen? Y/N");
			//Zuweisung der Antwort zu Variable
			Eingabe = Convert.ToChar(Console.ReadLine());
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

		//Message bei FormatException
		public void FormExMessage()
		{
			//Output Nachricht
			Console.WriteLine("Es liegt ein Fehler bei der Eingabe vor!\nBitte starten sie das Programm erneut!");
			Console.ReadKey();
			//Beendingung des programms
			Environment.Exit(1);
		}
		//Message bei DivisionbyZero Exception
		public void DivZeroExMessage()
		{
			//Output Nachricht
			Console.WriteLine("Es kann nicht durch 0 geteilt werden!\nBitte starten sie das Programm erneut!");
			Console.ReadKey();
			//Beendingung des programms
			Environment.Exit(1);
		}
		//Message bei anderer Exception
		public void ExMessage()
		{
			//Output Message
			Console.WriteLine("Fehler! Bitte starten sie das Programm neu.");
			Console.ReadKey();
			//Beendigung des programms
			Environment.Exit(1);
		}
	}
}