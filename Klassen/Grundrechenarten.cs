using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class Grundrechenarten
	{
		double Zahl1 = 0;
		double Zahl2 = 0;
		public Grundrechenarten(double Zahl1,double Zahl2)
		{
			this.Zahl1 = Zahl1;
			this.Zahl2 = Zahl2;
		}
		public double Addition(double Zahl1, double Zahl2)
		{
			return Zahl1 + Zahl2;
		}
		public double Subtraktion(double Zahl1, double Zahl2)
		{
			return Zahl1 - Zahl2;
		}
		public double Multiplikation(double Zahl1, double Zahl2)
		{
			return Zahl1 * Zahl2;
		}
		public double Division(double Zahl1, double Zahl2)
		{
			if (Zahl2 != 0)
			{
				return Zahl1 / Zahl2;
			}
			else
			{
				Console.WriteLine("Durch 0 teilen ist nicht möglich");
				Division(Zahl1, Zahl2);
				return 0;
			}
		}
		
	}
}
