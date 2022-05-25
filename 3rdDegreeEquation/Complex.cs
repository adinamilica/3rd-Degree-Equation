using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDegreeEquation
{
    public struct Complex
    {
        private double x, y;

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            double eps = 1.0e-12;

            if (Math.Abs(y) < eps)             // z=real
                return string.Format("{0}", x);

            if (Math.Abs(x) < eps)             // z=imaginar
            {
                if (Math.Abs(y - 1) < eps)     //z=i
                    return "i";

                if (Math.Abs(y + 1) < eps)     //z=-i
                    return "-i";

                return string.Format("{0}i", y);

            }
            if (y > 0)
                return string.Format("{0}+{1}i", x, y);

            return string.Format("{0}{1}i", x, y);
        }


        public void show()
        {
            Console.WriteLine(this);
        }
        public double Ro
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
            set
            {
                x = value * Math.Cos(Theta);
                y = value * Math.Sin(Theta);
            }
        }
        public double Ro2
        {
            get
            {
                return x * x + y * y;
            }
        }
        public double Theta
        {
            get
            {
                return Math.Atan2(y, x);
            }
            set
            {
                x = Ro * Math.Cos(value);
                y = Ro * Math.Sin(value);
            }
        }
        public double Re
        {
            //accesarea partii reale, adica x

            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Im
        {
            //accesarea partii imaginare, adica y

            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }


        public Complex Conj
        {

            //conjugatul unui numar complex

            get
            {
                return new Complex(x, -y);
            }

            set
            {
                x = value.x;
                y = -value.y;
            }
        }


        public static Complex setRoTheta(double Ro, double theta)
        {
            //scrierea unui numar complex cu ajutorul lui ro sia lui theta stiuti

            return new Complex(Ro * Math.Cos(theta), Ro * Math.Sin(theta));
        }

        public static Complex setReIm(double x, double y)
        {
            return new Complex(x, y);
        }

        public static Complex operator +(Complex zst, Complex zdr)
        {
            return new Complex(zst.x + zdr.x, zst.y + zdr.y);
        }

        public static Complex operator +(Complex zst)
        {
            return new Complex(zst.x, zst.y);
        }


        public static Complex operator -(Complex zst, Complex zdr)
        {
            return new Complex(zst.x - zdr.x, zst.y - zdr.y);
        }
        public static Complex operator -(Complex zst)
        {
            return new Complex(-zst.x, -zst.y);
        }


        public static Complex operator *(Complex zst, Complex zdr)
        {
            return new Complex(zst.x * zdr.x - zst.y * zdr.y, zst.y * zdr.x + zst.x * zdr.y);
        }
        public static Complex operator /(Complex zst, Complex zdr)
        {
            double r = zdr.Ro2;
            if (r < 1.0e-12) return Complex.setRoTheta(Double.MaxValue, zst.Theta - zdr.Theta);
            return new Complex((zst.x * zdr.x + zst.y * zdr.y) / r, (zst.y * zdr.x - zst.x * zdr.y) / r);
        }



        public static implicit operator Complex(double x)
        {
            return new Complex(x, 0);
        }


        //compararea a doua numere complexe
        public static bool operator ==(Complex zst, Complex zdr)
        {
            return (zst - zdr).Ro2 < 1.0e-16;
        }
        public static bool operator !=(Complex zst, Complex zdr)
        {
            return (zst - zdr).Ro2 >= 1.0e-16;
        }



        public override bool Equals(object o)
        {
            if (o.GetType() != this.GetType()) return false;
            else return this == (Complex)o;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() + y.GetHashCode();
        }

        public Complex sqrt(double n)
        {
            Complex z1 = setReIm(0, 1);
            return (Math.Pow(Ro, 1 / n) * (Math.Cos((Theta + 2 * 3.14159) / n) + z1 * Math.Sin((Theta + 2 * 3.14159) / n)));
        }

        public Complex pow(double n)
        {
            Complex rez = 1;
            for (int i = 1; i <= n; i++)
                rez = rez * this;

            return rez;

        }

    }
}
