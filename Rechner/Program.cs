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
					//Aufruf Methode DecFrac
					Operator(fraction, fraction2,decision,0,0);
					break;

				//Auswahl: Grundrechnung
				case 2:
					//Zuweisung der Zahlen eins und zwei
					double num1 = UserInput.UserBasic();
					double num2 = UserInput.UserBasic();
					//Aufruf Methode DecBasic
					Operator(null,null,decision,num1, num2);
					break;

				default:
					//Ruft Abfrage der Rechnungsart durch Aufruf der Main erneut auf
					Main(new string [1]);
					break;
			}
			//Aufruf der Methode Again
			Again();
		}

		static void Operator(Fraction frac, Fraction frac2, int decision, double num1, double num2)
		{
			//Ausgabe Frage zu Opperator
			Console.Write("Geben sie ihren Rechenoperator ein:(+,-,*,/)\n> ");
			switch (Convert.ToChar(Console.ReadLine()))
			{
				case '+':
					if (decision == 1)
					{
						//Aufruf der Bruchaddition
						frac.AddFrac(frac2);
						frac.ShortFrac();
						frac.Print();
					}
					else if (decision == 0)
					{
						//Aufruf der Addition mit Ausgabe
						Console.WriteLine(BasicArithmeticOperation.Addition(num1, num2));
					}
					break;
				case '-':
					if (decision == 1)
					{
						//Aufruf der Bruchsubtraktion
						frac.SubFrac(frac2);
						frac.ShortFrac();
						frac.Print();
					}
					else if(decision == 2)
					{
						Console.WriteLine(BasicArithmeticOperation.Subtraction(num1, num2));
					}
					break;
				case '*':
					if(decision == 1)
					{
						//Aufruf der Bruchmultiplikation
						frac.MultiplyFrac(frac2);
						frac.ShortFrac();
						frac.Print();
					}
					else if (decision == 2)
					{
						Console.WriteLine(BasicArithmeticOperation.Multiply(num1, num2));
					}
					break;
				case '/':
					if (decision == 1)
					{
						//Aufruf der Bruchdivision
						frac.DivFrac(frac2);
						frac.ShortFrac();
						frac.Print();
					}
					else if (decision == 2)
					{
						Console.WriteLine(BasicArithmeticOperation.Division(num1, num2));
					}			
					break;
				default:
					//Wenn falscher Opperator
					Console.WriteLine("Fehlerhafter Opperator!");
					Environment.Exit(1);
					break;
			}
		}

		//Abfrage ob nochmal gerechnet werden soll
		public static void Again()
		{
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
