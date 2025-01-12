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