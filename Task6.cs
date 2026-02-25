using System;

namespace Lab1
{
    internal class Task6
    {
        public static void Run()
        {
            Console.Write("Input x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input y = ");
            double y = double.Parse(Console.ReadLine());
            double z = ((1.0 / (x * y)) + (1.0 / (x * x + 1))) * (x + y);
            Console.WriteLine("Result = " + z);

            Console.WriteLine("\nНатисніть Enter для повернення в меню...");
            Console.ReadLine();
            Console.Clear();
            Menu.Run();
        }
    }
}