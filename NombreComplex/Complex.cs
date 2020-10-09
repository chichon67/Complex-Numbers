using System;

namespace NombreComplex
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginär { get; set; }


        public Complex(double real, double imaginär)
        {
            this.Real = real;
            this.Imaginär = imaginär;

        }

        public Complex(Complex complex)
        {

        }

        public static Complex operator +(Complex c1, Complex c2)
        {

            var real = c1.Real + c2.Real;
            var imaginär = c1.Imaginär + c2.Imaginär;

            return new Complex(real, imaginär);
        }


        public static Complex operator -(Complex c1, Complex c2)
        {

            var real = c1.Real - c2.Real;
            var imaginär = c1.Imaginär - c2.Imaginär;

            return new Complex(real, imaginär);
        }


        public static Complex operator *(Complex c1, Complex c2)
        {

            // (ac - bd) + (ad + bc)i

            return new Complex((c1.Real * c2.Real - c1.Imaginär * c2.Imaginär), (c1.Real * c2.Imaginär + c1.Imaginär * c2.Real));
        }


        public static Complex operator /(Complex c1, Complex c2)
        {
            double a = c1.Real;
            double c = c1.Real;
            double d = c2.Imaginär;
            double b = c1.Imaginär;

            // ((ac+bd)/(c^2+d^2) + (bc -ad)/(c^2+d^2))

            return new Complex((a * c + b * d) / (Math.Pow(c, 2) + Math.Pow(d, 2)), (b * c - a * d) / (Math.Pow(c, 2) + Math.Pow(d, 2)));



        }




        public override string ToString()
        {
            if (this.Imaginär > 0)
                return $"{Real} + {Imaginär}i";


            return $"{Math.Round(Real, 2)}  {Math.Round(Imaginär, 2)}i";


        }


    }
}
