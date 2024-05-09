using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulomek
{
    public class Ulomek : IComparable<Ulomek>
    {
        private int _stevec;
        private int _imenovalec;

        public Ulomek(int st, int im)
        {
            this.Stevec = st;
            this.Imenovalec = im;
        }

        private int Stevec
        {
            get { return _stevec; }
            set 
            { 
                if (value > 0 && _imenovalec < 0)
                {
                    _stevec = -value;
                    _imenovalec = Math.Abs(_imenovalec);
                }
                else if (value < 0 && _imenovalec < 0)
                {
                    _stevec = Math.Abs(value);
                    _imenovalec = Math.Abs(_imenovalec);
                }
                else
                {
                    _stevec = value;
                }
            }
        }

        private int Imenovalec
        {
            get { return _imenovalec; }
            set
            {
                if (value == 0) { throw new DivideByZeroException(); }
                else if (value < 0 && _stevec > 0)
                {
                    _stevec = -_stevec;
                    _imenovalec = Math.Abs(value);
                }
                else if (value < 0 && _stevec < 0)
                {
                    _stevec = -_stevec;
                    _imenovalec = -value;
                }
                else { _imenovalec = value; }

            }
        }

        public static Ulomek operator +(Ulomek ulomek1, Ulomek ulomek2)
        {
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Imenovalec;
            int noviStevec = ulomek1.Stevec * ulomek2.Imenovalec + ulomek2.Stevec * ulomek1.Imenovalec;
            return new Ulomek(noviStevec, noviImenovalec);
        }

        public static Ulomek operator *(Ulomek ulomek1, Ulomek ulomek2)
        {
            int noviStevec = ulomek1.Stevec * ulomek2.Stevec;
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Imenovalec;
            return new Ulomek(noviStevec, noviImenovalec);
        }

        public static Ulomek operator -(Ulomek ulomek1, Ulomek ulomek2)
        {
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Imenovalec;
            int noviStevec = ulomek1.Stevec * ulomek2.Imenovalec - ulomek2.Stevec * ulomek1.Imenovalec;
            return new Ulomek(noviStevec, noviImenovalec);
        }

        public static Ulomek operator /(Ulomek ulomek1, Ulomek ulomek2)
        {
            int noviStevec = ulomek1.Stevec * ulomek2.Imenovalec;
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Stevec;
            return new Ulomek(noviStevec, noviImenovalec);
        }

        public int CompareTo(Ulomek other)
        {
            double thisUlomek = (double)this.Stevec / this.Imenovalec;
            double otherUlomek = (double)other.Stevec / other.Imenovalec;
            return thisUlomek.CompareTo(otherUlomek);
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int ost = a % b;
                a = b;
                b = ost;
            }
            return a;
        }

        public void Okrajsaj()
        {
            int gcd = GCD(Stevec, Imenovalec);

            Stevec /= gcd;
            Imenovalec /= gcd;
        }

        public override string ToString()
        {
            if (Imenovalec == 1) 
            {
                return $"{Stevec}";
            }
            else if (Stevec == 0)
            {
                return "0";
            }
            else if (Math.Abs(Stevec) == Math.Abs(Imenovalec))
            {
                if (Stevec < 0 && Imenovalec > 0) { return "-1"; }
                if (Stevec > 0 && Imenovalec < 0) { return "-1"; }
                else { return "1"; }
            }
            else
            {
                return $"{Stevec}/{Imenovalec}";
            }
            
        }

    }
}
