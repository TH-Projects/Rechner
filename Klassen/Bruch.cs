﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rechner
{
	class Bruch
	{
		//Definition der Bruchkomponenten
		int Nenner = 1;
		int Zaehler = 1;
		public Bruch(int Zaeler, int Nenner)
		{
			//Abfrage zur Vorbeugungen von unnötigen Schritten, da Rechnen mit Null als Nenner unnötig
			if (Nenner != 0)
			{
				this.Zaehler = Zaeler;
				this.Nenner = Nenner;
			}
			else
			{
				//Ausgabe das ein Fehler vorliegt
				Console.WriteLine("Fehler");
			}
		}

		//Ausgabe Bruch
		public void Print()
		{
			//Ausgabe
			Console.WriteLine("{0}/{1}", Zaehler, Nenner);
		}

		//Addition von Brüchen
		public void AddBruch(Bruch bruch2)
		{
			//Abfrage zur Vermeidung unnötiger Schritte
			if (Nenner == bruch2.Nenner)
			{
				Zaehler += bruch2.Zaehler;
			}
			else
			{
				//Aufruf der Bruchanpassung um Brüche auf gleichen Nenner zu bringen
				Bruchanpassung(bruch2);
				//Addtion der Brüche
				Zaehler += bruch2.Zaehler;
			}
		}

		//Subtraktion von Brüchen
		public void SubBruch(Bruch bruch2)
		{
			//Abfrage zur Vermeidung unnötiger Schritte
			if (Nenner == bruch2.Nenner)
			{
				Zaehler -= bruch2.Zaehler;
			}
			else
			{
				//Aufruf der Bruchanpassung um Brüche auf gleichen Nenner zu bringen
				Bruchanpassung(bruch2);
				//Subtraktion der Brüche
				Zaehler -= bruch2.Zaehler;
			}
		}
		private void Bruchanpassung(Bruch bruch2)
		{
			//Zwischenspeicherung des Nenners, da dieser Verändert wird
			int tempnenn = Nenner;
			//Nennermultiplikation 
			Nenner *= bruch2.Nenner;
			//Multiplikation mit den Nenner des zweiten Bruches
			Zaehler *= bruch2.Nenner;
			//Nennermultiplikation mit Zwischengespeichertem Nenner des ersten Bruches
			bruch2.Nenner *= tempnenn;
			//Nennermultiplikation mit Zwischengespeichertem Nenner des ersten Bruches
			bruch2.Zaehler *= tempnenn;
		}

		//Multiplikation von Brüchen
		public void Multibruch(Bruch bruch2)
		{
			//Einfach Zähler mal Zähler und Nenner mal Nenner
			Nenner *= bruch2.Nenner;
			Zaehler *= bruch2.Zaehler;
		}

		//Division von Brüchen
		public void DivBruch(Bruch bruch2)
		{
			try
			{
				//Zwischenspeicherung des Zählers, da dieser Verändert wird
				int tempzael = bruch2.Zaehler;
				//Vertauschung von Nenner und Zähler des zweiten Bruches
				bruch2.Zaehler = bruch2.Nenner;
				bruch2.Nenner = tempzael;
				//Einfach Zähler mal Zähler und Nenner mal Nenner
				Nenner *= bruch2.Nenner;
				Zaehler *= bruch2.Zaehler;
			}
			//Exception handling, falls versucht wurde durch 0 zu teilen
			catch (DivideByZeroException)
			{
				Console.WriteLine("Es kann nicht durch 0 geteilt werden!\nBitte starten sie das Programm erneut!");
				Console.ReadKey();
			}
			//Exception handling, falls andere exception
			catch (Exception)
			{
				Console.WriteLine("Fehler! Bitte starten sie das Programm neu.");
				Console.ReadKey();
			}
		}
	}
}
