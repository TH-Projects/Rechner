using System;

namespace Rechner
{
	class Fraction
	{
		//Definition der Bruchkomponenten
		int denominator = 1;
		int counter = 1;
		public Fraction(int counter, int denominator)
		{

			//Abfrage zur Vorbeugungen von unnötigen Schritten, da Rechnen mit Null als Nenner unnötig
			if (denominator != 0)
			{
				this.counter = counter;
				this.denominator = denominator;
			}
			else
			{
				//Ausgabe, dass ein Fehler vorliegt
				Console.WriteLine("Fehler");
				Environment.Exit(0);
			}
		}

		//Ausgabe Bruch
		public void Print()
		{
			//Ausgabe
			Console.WriteLine("{0}/{1}", counter, denominator);
		}

		//Addition von Brüchen
		public void AddFrac(Fraction frac2)
		{
			//Abfrage zur Vermeidung unnötiger Schritte
			if (denominator == frac2.denominator)
			{
				counter += frac2.counter;
			}
			else
			{
				//Aufruf der Bruchanpassung um Brüche auf gleichen Nenner zu bringen
				AdjustFrac(frac2);
				//Addtion der Brüche
				counter += frac2.counter;
			}
		}

		//Subtraktion von Brüchen
		public void SubFrac(Fraction frac2)
		{
			//Abfrage zur Vermeidung unnötiger Schritte
			if (denominator == frac2.denominator)
			{
				counter -= frac2.counter;
			}
			else
			{
				//Aufruf der Bruchanpassung um Brüche auf gleichen Nenner zu bringen
				AdjustFrac(frac2);
				//Subtraktion der Brüche
				counter -= frac2.counter;
			}
		}

		private void AdjustFrac(Fraction frac2)
		{
			//Zwischenspeicherung des Nenners, da dieser Verändert wird
			int tempdeno = denominator;
			//Nennermultiplikation 
			denominator *= frac2.denominator;
			//Multiplikation mit den Nenner des zweiten Bruches
			counter *= frac2.denominator;
			//Nennermultiplikation mit zwischengespeichertem Nenner des ersten Bruches
			frac2.denominator *= tempdeno;
			//Zählermultiplikation mit zwischengespeichertem Nenner des ersten Bruches
			frac2.counter *= tempdeno;
		}

		//Multiplikation von Brüchen
		public void MultiplyFrac(Fraction frac2)
		{
			//Zähler mal Zähler und Nenner mal Nenner
			denominator *= frac2.denominator;
			counter *= frac2.counter;
		}

		//Division von Brüchen
		public void DivFrac(Fraction frac2)
		{
			if (frac2.counter != 0)
			{
				//Zwischenspeicherung des Zählers, da dieser verändert wird
				int tempcounter = frac2.counter;
				//Vertauschung von Nenner und Zähler des zweiten Bruches
				frac2.counter = frac2.denominator;
				frac2.denominator = tempcounter;
				//Einfach Zähler mal Zähler und Nenner mal Nenner
				denominator *= frac2.denominator;
				counter *= frac2.counter;
			}
			else
			{
				ExceptionMessage.DivZeroExMessage();
			}
		}

		public void ShortFrac()
		{
			//Größmöglicher gemeinsamer teiler wird ermittelt
			int LPD = (counter > denominator) ? counter : denominator;

			//Herunterzählende Schleife um tatsächlichen größten Teiler zu finden
			for(int i= LPD; i > int.MinValue; i--)
			{
				if(counter % i == 0 && denominator % i == 0)
				{
					counter = counter / i;
					denominator = denominator / i;
					break;
				}				
			}
		}
	}
}

