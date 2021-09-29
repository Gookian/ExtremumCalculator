using System;
using System.Drawing;

namespace ExtremumCalculator
{
    interface IExtremumMethod
    {
        double GetMax(Func<double, double> func, double a, double b, double eps);

        double GetMin(Func<double, double> func, double a, double b, double eps);

        PointF GetPoint();
    }
}
