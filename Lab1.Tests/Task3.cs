using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Tests
{
    public static class Task3    
    {
        public static string CheckPoint(float x, float y)
        {
            if (x * x + y * y < 81 && x > 0)
                return "Так (всередині)";
            else if ((x * x + y * y == 81 && x >= 0) || (x == 0 && y <= 9 && y >= -9))
                return "На межі";
            else
                return "Ні (поза областю)";
        }
    }
}
