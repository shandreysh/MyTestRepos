using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsoleAppPrj
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1) Сложить два числа.");
            Console.WriteLine("2) Вычесть два числа.");
            Console.WriteLine("...");
            Console.Write("Выберите действие:");
        }

        static void AddTwoNumbers()
        {
            Console.Write("Введите первое число:");
            string num1Str;
            num1Str = Console.ReadLine();
            Console.Write("Введите второе число:");
            string num2Str;
            num2Str = Console.ReadLine();

            //Преобразуем строки в числа
            double num1;
            num1 = Convert.ToDouble(num1Str);
            double num2;
            num2 = Convert.ToDouble(num1Str);

            //Производим вычиления
            double res;
            res = num1 + num2;

            //Отображаем результат
            Console.WriteLine("Результат сложения - " + res.ToString());

            //Остановка выполнения программы
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            //Печатаем в консоли меню для пользователя
            PrintMenu();

            string Action;
            //Пользователь вводит текст
            Action = Console.ReadLine();

            //Console.WriteLine("Action is - " + Action);
            //Console.ReadLine();

            //Принимаем решение
            if (Action == "1")
            {
                AddTwoNumbers();
            }
            if (Action == "2")
            {
                //SubtractTwoNumbers();
            }
            if (Action == "3")
            {
                //SubtractTwoNumbers();
            }
        }
    }
}
