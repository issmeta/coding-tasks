using System;

namespace task_1_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstValue, secondValue;
                string action;

                Console.WriteLine("Введите первое число.");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число.");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1.Сложение.");
                Console.WriteLine("2.Вычитание.");
                Console.WriteLine("3.Умножение.");
                Console.WriteLine("4.Деление.");
                Console.WriteLine("5.Возведение в квадрат(В квадрат возводиться первое число).");
                action = Console.ReadLine();

                if (action == "1")
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "2")
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "3")
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "4")
                {
                    if (secondValue == 0)
                        Console.WriteLine("На 0 делить нельзя! Введите другое число.");
                    else
                        Console.WriteLine("Ответ:");
                    Console.WriteLine(firstValue / secondValue);
                }
                else if (action == "5")
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(firstValue * firstValue);
                }
                else
                {
                    Console.WriteLine("Ошибка! Неизвестное действие!");
                }
            }
        }
    }
}


