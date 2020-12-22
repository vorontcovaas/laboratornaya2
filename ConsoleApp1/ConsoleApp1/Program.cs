using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            double a = 0, b = 0, c = 0;
            while (menu == true)

            {
                Console.WriteLine("Выберите номер операции:");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. :");

                switch (Console.ReadLine())
                {
                    case "1"://+
                        Console.WriteLine("a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine(a + "+" + b + "=" + c);
                        break;

                    case "2"://вычитание
                        Console.WriteLine("a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine(a + "-" + b + "=" + c);
                        break;

                    case "3"://умножение
                        Console.WriteLine("a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine(a + "*" + b + "=" + c);
                        break;

                    case "4"://деление

                        Console.WriteLine("a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine(a + "/" + b + "=" + c);
                        break;

                    default:
                        Console.WriteLine("Ошибка, повторите ввод");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
