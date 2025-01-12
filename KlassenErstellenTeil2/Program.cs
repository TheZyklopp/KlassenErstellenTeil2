using System;
namespace KlassenErstellenTeil1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teil1
            //X, Y, Z
            Punkt endPunkt = new Punkt(3, 2, 4);
            Punkt startPunkt = new Punkt(2, 1, 2);

            //schreibt die werte nochmal aus. Benutzt die ToString methode.
            Console.WriteLine($"startPunkt{startPunkt.ToString()}");
            Console.WriteLine($"endPunkt{endPunkt.ToString()}");

            //Methode1 startPunkt = this
            double abstand = startPunkt.AbstandZu(endPunkt);
            Console.WriteLine($"{abstand}");
            //Methode2
            double zwichen = Punkt.AbstandZwischen(startPunkt, endPunkt);
            Console.WriteLine(zwichen);

            //klassenerstellen2
            //BildeVektor
            Vektor berechenevektor = startPunkt.BildeVektor(endPunkt);
            Console.WriteLine($"Der Vektor ist: {berechenevektor}");
            //methodoe2
            Vektor berechenevektorr = Punkt.BildeVektor(startPunkt, endPunkt);
            Console.WriteLine($"Der Vektor ist: {berechenevektorr}");

            //Teil2
            Vektor a = new Vektor(3, 2, 4);
            Vektor b = new Vektor(6, 4, 6);

            Console.WriteLine($"Vektor a {a.ToString()}");
            Console.WriteLine($"vektor b {b.ToString()}");

            double skalar = a.BerechneSkalarprodukt(b);
            Console.WriteLine(skalar);

            double skalar2 = Vektor.BerechneSkalarprodukt(a, b);
            Console.WriteLine(skalar2);

            Vektor kreuzprodukt = a.BildeKreuzprodukt(b);
            Console.WriteLine($"Kreuzprodukt ist: {kreuzprodukt}");

            double skalarfaktor = 2;
            Vektor skalarMultiplizierterVektor = a.MultipliziereSkalar(skalarfaktor);
            Console.WriteLine($"Skalarmultiplikation von {a} mit {skalarfaktor}: {skalarMultiplizierterVektor}");

            // Addition von Vektoren
            Vektor summe = a.Addiere(b);
            Console.WriteLine($"Addition von {a}, {b}: {summe}");

            // Subtraktion von Vektoren
            Vektor differenz = a.Subtrahiere(b);
            Console.WriteLine($"Subtraktion von {a}, {b}: {differenz}");



            //teil3
            Punkt StartPunkt = new Punkt(1, 5, 6);
            Punkt EndPunkt = new Punkt(4, 6, 8);


            // Erstellen einer Linie und Berechnung der Länge
            Linie linie = new Linie(StartPunkt, EndPunkt);
            double linienLaenge = linie.Laenge;
            Console.WriteLine($"Länge der Linie: {linienLaenge}");

            // Erstellen eines Vektors zum Verschieben
            Vektor verschiebeVektor = new Vektor(1, 1, 1);
            // Verschieben der Linie um den Vektor
            Linie verschobeneLinie = linie.VerschiebeUmVektor(verschiebeVektor);
            Console.WriteLine($"Verschobene Linie: {verschobeneLinie}");
        }
    }
}

