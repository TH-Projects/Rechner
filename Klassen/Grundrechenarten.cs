using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class Grundrechenarten
	{
		double Zahl1 = 0;
		double Zahl2 = 0;
		double Ergebnis = 0;
		public Grundrechenarten(double Zahl1,double Zahl2,double Ergebnis)
		{
			this.Zahl1 = Zahl1;
			this.Zahl2 = Zahl2;
			this.Ergebnis = Ergebnis;
		}
		public void Print(double Ergebnis)
		{
			Console.WriteLine(Ergebnis);
		}
	}
}
