using System;

namespace Lab1
{
    internal class Task3
    {
        public static void Run()
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y < 81 && x > 0)
                Console.WriteLine("Так (всередині)");
            else if ((x * x + y * y == 81 && x >= 0) || (x == 0 && y<=9 && y>=-9))
                Console.WriteLine("На межі");
            else
                Console.WriteLine("Ні (поза областю)");

            Console.WriteLine("\nНатисніть Enter для повернення в меню...");
            Console.ReadLine();
            Console.Clear();
            Menu.Run();
        }
    }
}
