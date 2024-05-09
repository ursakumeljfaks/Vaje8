using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor2D
{
    public class Vektor2D
    {
        private double _x;
        private double _y;

        public Vektor2D(double x, double y)
        {
            X = x;
            Y = y;
        }   

        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static Vektor2D operator +(Vektor2D v1, Vektor2D v2)
        {
            double xKomponenta = v1.X + v2.X;
            double yKomponenta = v1.Y + v2.Y;
            return new Vektor2D(xKomponenta, yKomponenta);
        }

        public static Vektor2D operator -(Vektor2D v1, Vektor2D v2)
        {
            double xKomponenta = v1.X - v2.X;
            double yKomponenta = v1.Y - v2.Y;
            return new Vektor2D(xKomponenta, yKomponenta);
        }

        public static double operator *(Vektor2D v1, Vektor2D v2)
        {
            double xKomponenta = v1.X * v2.X;
            double yKomponenta = v1.Y * v2.Y;
            return xKomponenta + yKomponenta;
        }

        public static double operator /(Vektor2D v1, Vektor2D v2)
        {
            throw new Exception("Vektorji nimajo standardne operacije deljenje!");
        }

        public int CompareTo(Vektor2D other)
        {
            double thisVektor = this.Norma();
            double otherVektor = other.Norma();
            return thisVektor.CompareTo(otherVektor);
        }

        public double Norma()
        {
            return Math.Sqrt(X * X + Y * Y);
        }


    }
}
