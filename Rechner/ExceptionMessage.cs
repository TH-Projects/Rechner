using System;

namespace Rechner
{
	class ExceptionMessage
	{
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
