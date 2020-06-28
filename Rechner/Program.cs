using System;

namespace Rechner
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Abfrage der Rechnungsart
			int decision = UserInput.UserOption();
			switch (decision)
			{
				//Auswahl: Bruchrechnen
				case 1:
					//Erstellung Bruch eins
					Fraction fraction = UserInput.UserFrac();
					//Erstellung Bruch zwei
					Fraction fraction2 = UserInput.UserFrac();
					//Aufruf Methode AuswBruch
					DecFrac(fraction, fraction2);
					break;

				//Auswahl: Grundrechnung
				case 2:
					//Zuweisung der Zahlen eins und zwei
					double num1 = UserInput.UserBasic();
					double num2 = UserInput.UserBasic();
					//Aufruf Methode AuswGrund
					DecBasic(num1, num2);
					break;

				default:
					//Ruft Abfrage der Rechnungsart durch aufruf der Main erneit auf
					Main(new string [1]);
					break;
			}
			//Aufruf der Methode Nochmal()
			Again();
		}

		static void DecFrac(Fraction frac, Fraction frac2)
		{
			//Ausgabe Frage zu Opperator
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/)\n> ");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					//Aufruf der Bruchaddition
					frac.AddFrac(frac2);
					frac.ShortFrac();
					frac.Print();
					break;
				case '-':
					//Aufruf der Bruchsubtraktion
					frac.SubFrac(frac2);
					frac.ShortFrac();
					frac.Print();
					break;
				case '*':
					//Aufruf der Bruchmultiplikation
					frac.MultiplyFrac(frac2);
					frac.ShortFrac();
					frac.Print();
					break;
				case '/':
					//Aufruf der Bruchdivision
					frac.DivFrac(frac2);
					frac.ShortFrac();
					frac.Print();
					break;
				default:
					//Wenn falscher Opperator
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
		}

		static void DecBasic(double Zahl1, double Zahl2)
		{
			//Ausgabe Frage nach Opperator
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/)\n> ");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					//Aufruf der Addition mit Ausgabe
					Console.WriteLine(BasicArithmeticOperation.Addition(Zahl1, Zahl2));
					break;
				case '-':
					//Aufruf der Subtraktion mit Ausgabe
					Console.WriteLine(BasicArithmeticOperation.Subtraction(Zahl1, Zahl2));
					break;
				case '*':
					//Aufruf der Multiplikation mit Ausgabe
					Console.WriteLine(BasicArithmeticOperation.Multiply(Zahl1, Zahl2));
					break;
				case '/':
					//Aufruf der Division mit Ausgabe
					Console.WriteLine(BasicArithmeticOperation.Division(Zahl1, Zahl2));
					break;
				default:
					//Wenn falscher Opperator
					Console.WriteLine("Fehlerhafter Opperator!");
					break;
			}
		}

		//Abfrage ob nochmal gerechnet werden soll
		public static void Again()
		{
			//Erstellung Objekt von der Klasse UserInput
			UserInput userInput = new UserInput();
			//Zuweisung der Benutzereingabe zu einer Variablen
			int answ = UserInput.Repeat();
			switch (answ)
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
					Again();
					break;
			}
		}
	}
}
