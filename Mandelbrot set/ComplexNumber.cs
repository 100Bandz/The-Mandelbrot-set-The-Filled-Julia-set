using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot_set
{   //The set of complex numbers c where fc(z) = x^2 + c and its iterates must be withing distance 2 from the center (0,0
    //Iterating 0 gives you two cases,
    //Case 1: the function outputs a value greater than 2, and thus blows up due to the distance from 0 gets arbitrarily large (goes to infinity)
    //Case 2: the function outputs a value less than 2, therefore its bounded to [-2,2]

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
