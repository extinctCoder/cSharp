using System;

namespace Calculator
{
    public class BasicCalculator : IBasicCalculator
    {
        public double sum(double x, double y)
        {
            return x + y;
        }

        public double sub(double x, double y)
        {
            return x - y;
        }

        public double multiply(double x, double y)
        {
            return x * y;
        }

        public double div(double x, double y)
        {
            return x / y;
        }
    }
}