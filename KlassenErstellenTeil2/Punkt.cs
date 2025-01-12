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