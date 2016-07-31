using System;

namespace Calculator
{
    internal interface IBasicCalculator
    {
        double sum(double x, double y);

        double sub(double x, double y);

        double multiply(double x, double y);

        double div(double x, double y);
    }
}