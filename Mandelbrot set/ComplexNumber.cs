using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot_set
{
    class ComplexNumber
    {
        public double a;    //Real number
        public double b;    //Complex number    //i^2 = -1

        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void square()    //OG form (a+bi)^2    //a takes the form (a^2-b^2) & b takes the form (2abi)  
        {
            double tempA = Math.Pow(a, 2) - Math.Pow(b, 2);
            b = 2.0 * a * b;
            a = tempA;
        }

        public double magnitude()   //Calculates the magnitude of some complex number
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public void add(ComplexNumber c)    //Adds
        {
            a += c.a;
            b += c.b;
        }

    }
}
