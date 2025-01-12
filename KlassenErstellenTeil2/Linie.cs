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