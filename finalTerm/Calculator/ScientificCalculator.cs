using System;

namespace Calculator
{
    public class ScientificCalculator : BasicCalculator, IScientificCalculator
    {
        double IBasicCalculator.sum(double x, double y)
        {
            return -101;
        }

        /*public double sum(double x, double y)
        {
            return -50;
        }*/

        public double XtoY(double x, double y)
        {
            for (int i = 1; i < y; ++i)
            {
                x = x * x;
            }

            return x;
        }
    }
}