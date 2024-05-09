using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksnoStevilo
{
    public class KompleksnoStevilo : IComparable<KompleksnoStevilo>
    {
        private double _realni;
        private double _imaginarni;

        public KompleksnoStevilo(double re, double im)
        {
            this.Realni = re;
            this.Imaginarni = im;
        }

        private double Realni
        {
            get { return _realni; }
            set { _realni = value; }
        }

        public double Imaginarni
        { 
            get { return _imaginarni; }
            set { _imaginarni = value; }
        }

        public void Konjugirano()
        {
            _imaginarni = -_imaginarni;
        }

        public static KompleksnoStevilo operator +(KompleksnoStevilo ks1, KompleksnoStevilo ks2)
        {
            double realniDel = ks1.Realni + ks2.Realni;
            double imaginarniDel = ks1.Imaginarni + ks2.Imaginarni;
            return new KompleksnoStevilo(realniDel, imaginarniDel);
        }

        public static KompleksnoStevilo operator -(KompleksnoStevilo ks1, KompleksnoStevilo ks2)
        {
            double realniDel = ks1.Realni - ks2.Realni;
            double imaginarniDel = ks1.Imaginarni - ks2.Imaginarni;
            return new KompleksnoStevilo(realniDel, imaginarniDel);
        }

        public static KompleksnoStevilo operator *(KompleksnoStevilo ks1, KompleksnoStevilo ks2)
        {
            double realniDel = ks1.Realni * ks2.Realni - ks1.Imaginarni * ks2.Imaginarni;
            double imaginarniDel = ks1.Realni * ks2.Imaginarni + ks1.Imaginarni * ks2.Realni;
            return new KompleksnoStevilo(realniDel, imaginarniDel);
        }

        public static KompleksnoStevilo operator /(KompleksnoStevilo ks1, KompleksnoStevilo ks2)
        {
            double skalar = Math.Pow(ks2.Realni, 2) + Math.Pow(ks2.Imaginarni, 2);
            if (skalar == 0)
            {
                throw new DivideByZeroException();
            }

            ks2.Konjugirano();
            double realniDel = ks1.Realni * ks2.Realni - ks1.Imaginarni * ks2.Imaginarni;
            double imaginarniDel = ks1.Realni * ks2.Imaginarni + ks1.Imaginarni * ks2.Realni;
            return new KompleksnoStevilo(realniDel / skalar, imaginarniDel / skalar);
        }

        public int CompareTo(KompleksnoStevilo other)
        {
            double thisKs = Math.Sqrt(Math.Pow(this.Realni,2) + Math.Pow(this.Imaginarni,2));
            double otherKs = Math.Sqrt(Math.Pow(other.Realni, 2) + Math.Pow(other.Imaginarni, 2));
            return thisKs.CompareTo(otherKs);
        }


        public override string ToString()
        {
            if (Realni == 0)
            {
                if (Imaginarni == 1) { return $"i"; }
                else if (Imaginarni == -1) { return $"-i"; }
                return $"{Imaginarni}i";
            }
            if (Imaginarni == 0)
            {
                return $"{Realni}";
            }
            if (Realni == 0 && Imaginarni == 0) { return "0"; }
            
            if (Imaginarni > 0)
            {
                if (Imaginarni == 1) { return $"{Realni}+i"; }
                return $"{Realni}+{Imaginarni}i";
            }
            else
            {
                if (Imaginarni == -1) { return $"{Realni}-i"; }
                return $"{Realni}-{-Imaginarni}i";
            }
        }

    }
}
