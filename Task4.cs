using System;

namespace Lab1
{
    internal class Task4
    {
        public static void Run()
        {
            Console.Write("Введіть номер дня: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість днів у місяці: ");
            int daysInMonth = int.Parse(Console.ReadLine());

            int remaining = daysInMonth - day;
            Console.WriteLine("До кінця місяця залишилось " + remaining + " днів.");

            Console.WriteLine("\nНатисніть Enter для повернення в меню...");
            Console.ReadLine();
            Console.Clear();
            Menu.Run();
        }
    }
}
