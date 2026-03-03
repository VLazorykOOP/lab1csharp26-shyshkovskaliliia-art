using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Tests
{
    public static class Task1
    {
        public static double CalcArea(double p)
        {
            double a = p / 3;
            return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
        }
    }
}
