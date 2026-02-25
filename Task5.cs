using System;

namespace Lab1
{
    internal class Task5
    {
        public static int Calc(int a, int b)
        {
            return a - b;
        }

        public static void Run()
        {
            Console.Write("Введіть перше число: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int y = int.Parse(Console.ReadLine());

            int result = Calc(x, y);

            Console.WriteLine("Різниця = " + result);

            Console.WriteLine("\nНатисніть Enter для повернення в меню...");
            Console.ReadLine();
            Console.Clear();
            Menu.Run();
        }
    }
}
