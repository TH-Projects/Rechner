using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class Bruch
	{
		int Nenner = 1;
		int Zaeler = 1;
		public Bruch(int Zaeler, int Nenner)
		{
			if (Nenner != 0)
			{
				this.Zaeler = Zaeler;
				this.Nenner = Nenner;
			}
			else
			{
				Console.WriteLine("Fehler");
			}
		}
		public void Print()
		{
			Console.WriteLine("{0}/{1}", Zaeler, Nenner);
		}
		public void AddBruch(Bruch bruch2)
		{
			if (Nenner == bruch2.Nenner)
			{
				Zaeler += bruch2.Zaeler;
			}
			else
			{
				int tempnenn = Nenner;
				Nenner *= bruch2.Nenner;
				Zaeler *= bruch2.Nenner;
				bruch2.Nenner *= tempnenn;
				bruch2.Zaeler *= tempnenn;
				Zaeler += bruch2.Zaeler;
			}
		}
		public void SubBruch(Bruch bruch2)
		{
			if (Nenner == bruch2.Nenner)
			{
				Zaeler -= bruch2.Zaeler;
			}
			else
			{
				int tempnenn = Nenner;
				Nenner *= bruch2.Nenner;
				Zaeler *= bruch2.Nenner;
				bruch2.Nenner *= tempnenn;
				bruch2.Zaeler *= tempnenn;
				Zaeler -= bruch2.Zaeler;
			}
		}
		public void Multibruch(Bruch bruch2)
		{
			Nenner *= bruch2.Nenner;
			Zaeler *= bruch2.Zaeler;
		}
		public void DivBruch(Bruch bruch2)
		{
			int tempzael = bruch2.Zaeler;
			bruch2.Zaeler = bruch2.Nenner;
			bruch2.Nenner = tempzael;
			Nenner *= bruch2.Nenner;
			Zaeler *= bruch2.Zaeler;
		}
	}
}
