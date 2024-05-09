using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Valj
{
    public class Valj : IComparable<Valj>
    {
        private double _r;
        private double _h;
        public Valj(double r, double h)
        {
            R = r;
            H = h;
        }

        private double R
        {
            get { return _r; }
            set
            {
                if (value < 0) { throw new Exception("Radij ne more biti negativen!"); }
                _r = value;
            }
        }

        private double H
        {
            get { return _h; }
            set
            {
                if (value < 0) { throw new Exception("Višina ne more biti negativna!"); }
                _h = value;
            }
        }

        public double Ploscina()
        {
            return 2 * Math.PI * R * R + 2 * Math.PI * R * H;
        }

        public double Obseg()
        {
            return 2 * Math.PI * R;
        }

        public double Prostornina()
        {
            return Math.PI * R * R * H;
        }
        /// <summary>
        /// sešteti dva valja pomeni, da dobimo njuno skupno prostornino
        /// </summary>
        /// <param name="v1">prvi valj</param>
        /// <param name="v2">drugi valj</param>
        /// <returns>število skupne prostornine</returns>
        public static double operator +(Valj v1, Valj v2)
        {
            return v1.Prostornina() + v2.Prostornina();
        }

        /// <summary>
        /// odštevanje dveh valjev pomeni, da valju z večjo prostornino odštejemo prostornino manjšega.
        /// </summary>
        /// <param name="v1">prvi valj</param>
        /// <param name="v2">drugi valj</param>
        /// <returns>število razlike prostornin</returns>
        public static double operator -(Valj v1, Valj v2)
        {
            return Math.Abs(v1.Prostornina() - v2.Prostornina());
        }

        public static double operator *(Valj v1, Valj v2)
        {
            throw new Exception("Valjev se ne da množiti!");
        }

        public static double operator /(Valj v1, Valj v2)
        {
            throw new Exception("Valjev se ne da deliti!");
        }

        public int CompareTo(Valj other)
        {
            double thisValj = this.Prostornina();
            double otherValj = other.Prostornina();
            return thisValj.CompareTo(otherValj);
        }

        public override string ToString()
        {
            if (R == 0 && H == 0)
            {
                return "Točka(0,0)";
            }
            if (R == 0) { return $"Palica({H})"; }
            if (H == 0) { return $"Krog({R})"; }
            
            return $"Valj({R}, {H})";
        }

    }
}
