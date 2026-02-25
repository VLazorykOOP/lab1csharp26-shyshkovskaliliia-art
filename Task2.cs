using System;

namespace Lab1
{
    internal class Task2
    {
        public static void Run()
        {
            Console.Write("Input a = ");
            int a = int.Parse(Console.ReadLine());
            string result = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);

            Console.WriteLine("\nНатисніть Enter для повернення в меню...");
            Console.ReadLine();
            Console.Clear();
            Menu.Run();
        }
    }
}