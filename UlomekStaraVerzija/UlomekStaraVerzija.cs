using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlomekStaraVerzija
{
    public class UlomekStaraVerzija
    {

        private int _stevec;
        private int _imenovalec;

        public UlomekStaraVerzija(int st, int im)
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

        public static UlomekStaraVerzija operator +(UlomekStaraVerzija ulomek1, UlomekStaraVerzija ulomek2)
        {
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Imenovalec;
            int noviStevec = ulomek1.Stevec * ulomek2.Imenovalec + ulomek2.Stevec * ulomek1.Imenovalec;
            return new UlomekStaraVerzija(noviStevec, noviImenovalec);
        }

        public static UlomekStaraVerzija operator *(UlomekStaraVerzija ulomek1, UlomekStaraVerzija ulomek2)
        {
            int noviStevec = ulomek1.Stevec * ulomek2.Stevec;
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Imenovalec;
            return new UlomekStaraVerzija(noviStevec, noviImenovalec);
        }

        public static UlomekStaraVerzija operator -(UlomekStaraVerzija ulomek1, UlomekStaraVerzija ulomek2)
        {
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Imenovalec;
            int noviStevec = ulomek1.Stevec * ulomek2.Imenovalec - ulomek2.Stevec * ulomek1.Imenovalec;
            return new UlomekStaraVerzija(noviStevec, noviImenovalec);
        }

        public static UlomekStaraVerzija operator /(UlomekStaraVerzija ulomek1, UlomekStaraVerzija ulomek2)
        {
            int noviStevec = ulomek1.Stevec * ulomek2.Imenovalec;
            int noviImenovalec = ulomek1.Imenovalec * ulomek2.Stevec;
            return new UlomekStaraVerzija(noviStevec, noviImenovalec);
        }

        public int CompareTo(UlomekStaraVerzija other)
        {
            double thisUlomek = (double)this.Stevec / this.Imenovalec;
            double otherUlomek = (double)other.Stevec / other.Imenovalec;
            return thisUlomek.CompareTo(otherUlomek);
        }

        public override string ToString()
        {
            return $"{Stevec}/{Imenovalec}";

        }
    }
}
