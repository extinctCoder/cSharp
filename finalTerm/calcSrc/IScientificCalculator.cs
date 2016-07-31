using System;

namespace Test
{
    interface IScientificCalculator: IBasicCalculator
    {
        double XtoY(double x, double y);
    }
}
