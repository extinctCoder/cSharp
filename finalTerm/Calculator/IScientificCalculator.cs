using System;

namespace Calculator
{
    internal interface IScientificCalculator : IBasicCalculator
    {
        double XtoY(double x, double y);
    }
}