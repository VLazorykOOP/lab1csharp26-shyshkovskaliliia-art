using System;

namespace Lab1
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Run();
        }

        public static void Run()
        {
            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("Лабораторна №1 C#");
                Console.WriteLine("1. Площа рівностороннього трикутника");
                Console.WriteLine("2. Перевірка парності числа");
                Console.WriteLine("3. Перевірка точки в області");
                Console.WriteLine("4. Дні до кінця місяця");
                Console.WriteLine("5. Різниця двох чисел");
                Console.WriteLine("6. Обчислення виразу");
                Console.WriteLine("0. Вихід");
                Console.Write("Оберіть номер завдання: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    ShowErrorMessage("Помилка вводу! Введіть ціле число.");
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 1: Task1.Run(); break;
                    case 2: Task2.Run(); break;
                    case 3: Task3.Run(); break;
                    case 4: Task4.Run(); break;
                    case 5: Task5.Run(); break;
                    case 6: Task6.Run(); break;
                    case 0:
                        Console.WriteLine("Завершення роботи. До зустрічі!");
                        return;
                    default:
                        ShowErrorMessage("Такого пункту не існує. Спробуйте ще раз.");
                        continue;
                }

                Console.WriteLine("\n-------------------------------------");
                Console.WriteLine("Натисніть будь-яку клавішу для повернення в меню...");
                Console.ReadKey();
            }
        }

        private static void ShowErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("Натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }

}
