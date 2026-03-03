using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Tests
{
    public static class Task6
    {
        public static double CalcZ(double x, double y)
        {
            return ((1.0 / (x * y)) + (1.0 / (x * x + 1))) * (x + y);
        }
    }
}
