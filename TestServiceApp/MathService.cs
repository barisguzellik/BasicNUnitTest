using System;

namespace TestServiceApp
{
    public class MathService
    {
        public double Addition(double n1,double n2)
        {
            return n1 + n2;
        }
        public double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Multiplication(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Division(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
