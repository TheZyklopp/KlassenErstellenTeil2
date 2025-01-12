# KlassenErstellenTeil2
## Program.cs
```csharp
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
```
## Punkt.cs
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenErstellenTeil1
{
    internal class Punkt
    {
        //teil1
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Punkt(double x, double y, double z)
        {
            //Initialisiert die XYZ werte.
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Punkt()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public double AbstandZu(Punkt endPunkt)
        {
            return Math.Sqrt(Math.Pow(endPunkt.X - this.X, 2) + Math.Pow(endPunkt.Y - this.Y, 2) + Math.Pow(endPunkt.Z - this.Z, 2));
        }

        public static double AbstandZwischen(Punkt startPunkt, Punkt endPunkt)
        {
            return Math.Sqrt(Math.Pow(endPunkt.X - startPunkt.X, 2) + Math.Pow(endPunkt.Y - startPunkt.Y, 2) + Math.Pow(endPunkt.Z - startPunkt.Z, 2));
        }

        //Klasse erstellen2
        //teil1
        public Vektor BildeVektor(Punkt endPunkt)
        {
            double vx = (endPunkt.X - this.X);
            double vy = (endPunkt.Y - this.Z);
            double vz = (endPunkt.Z - this.Z);

            return new Vektor(vx, vy, vz);
        }

        public static Vektor BildeVektor(Punkt startPunkt, Punkt endPunkt)
        {
            double vx = (endPunkt.X - startPunkt.X);
            double vy = (endPunkt.Y - startPunkt.Z);
            double vz = (endPunkt.Z - startPunkt.Z);

            return new Vektor(vx, vy, vz);
        }

        public Vektor AlsVektor()
        {
            return new Vektor(X, Y, Z);
        }

        //überschreibt die ausgabe.(kann man auch anders nennen)
        public override string ToString()
        {
            return $"{X} {Y} {Z}";
        }
    }
}
```
## Vektor.cs
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenErstellenTeil1
{
    internal class Vektor
    {
        // Teil 2
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vektor(double x, double y, double z)
        {
            // Initialisiert die XYZ-Werte.
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Parameterloser Konstruktor
        public Vektor()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        //addiere
        public Vektor Addiere (params Vektor[] summanden)
        {
            double sumX = x, sumY = y, sumZ = z;
            foreach (var v in summanden)
            {
                sumX += v.X;
                sumY += v.Y;
                sumZ += v.Z;
            }
            return new Vektor(sumX, sumY, sumZ);
        }
        //Subtrrahiere
        public Vektor Subtrahiere(params Vektor[] subtrahenden)
        {
            double diffX = x, diffY = y, diffZ = z;
            foreach (var v in subtrahenden)
            {
                diffX -= v.X;
                diffY -= v.Y;
                diffZ -= v.Z;
            }
            return new Vektor(diffX, diffY, diffZ);
        }
        //Multipliziere
        public Vektor MultipliziereSkalar(double skalarfaktor)
        {
            return new Vektor(x * skalarfaktor, y * skalarfaktor, z * skalarfaktor);
        }
        //Kreutprodukt
        public Vektor BildeKreuzprodukt(Vektor b)
        {
            double produktX = (this.Y * b.Z) - (this.Z * b.Y);
            double produktY = (this.Z * b.X) - (this.X * b.Z);
            double produktZ = (this.X * b.Y) - (this.Y * b.X);
            return new Vektor (produktX,produktY,produktZ);
        }

        public double BerechneSkalarprodukt(Vektor b)
        {
            return (b.X * this.x) + (b.Y * this.y) + (b.Z * this.z);
        }

        public static double BerechneSkalarprodukt(Vektor a, Vektor b)
        {
            return (b.X * a.x) + (b.Y * a.y) + (b.Z * a.z);
        }

        public override string ToString()
        {
            return $"{x} {y} {z}";
        }

        // Methode AlsPunkt: Gibt einen Punkt zurück (Punkt-Klasse vorausgesetzt)
        public Punkt AlsPunkt()
        {
            return new Punkt(x, y, z);
        }
    }
}
```
## Linie.cs
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenErstellenTeil1
{
    internal class Linie
    {
        public Punkt StartPunkt { get; set; }
        public Punkt EndPunkt { get; set; }
        public Linie(Punkt startPunkt, Punkt endPunkt)
        {
            StartPunkt = startPunkt;
            EndPunkt = endPunkt;
        }
        // Parameterloser Konstruktor
        public Linie()
        {
            StartPunkt = new Punkt();
            EndPunkt = new Punkt();
        }
        public double Laenge
        {
            get
            {
                return Math.Sqrt(
                    Math.Pow(EndPunkt.X - StartPunkt.X, 2) +
                    Math.Pow(EndPunkt.Y - StartPunkt.Y, 2) +
                    Math.Pow(EndPunkt.Z - StartPunkt.Z, 2)
                );
            }
        }

        public Linie VerschiebeUmVektor(Vektor verschiebeVektor)
        {
            Punkt neuerStartPunkt = new Punkt(
                StartPunkt.X + verschiebeVektor.X,
                StartPunkt.Y + verschiebeVektor.Y,
                StartPunkt.Z + verschiebeVektor.Z
            );

            Punkt neuerEndPunkt = new Punkt(
                EndPunkt.X + verschiebeVektor.X,
                EndPunkt.Y + verschiebeVektor.Y,
                EndPunkt.Z + verschiebeVektor.Z
            );

            return new Linie(neuerStartPunkt, neuerEndPunkt);
        }
        public override string ToString()
        {
            return $"{StartPunkt} und {EndPunkt}";
        }

    }
}
```
