using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Task1
    {
        public static void Run()
        {
            Console.Write("p= ");
            double p = double.Parse(Console.ReadLine());
            double a = p / 3;
            double area = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
            Console.WriteLine("area= " + area);

            Console.WriteLine("\nНатисніть Enter для повернення в меню..."); 
            Console.ReadLine();
            Console.Clear(); 
            Menu.Run();
        }
    }
}
