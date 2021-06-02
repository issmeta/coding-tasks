using System;

namespace task_1_calculator
{
    class Program
    {
        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new Exception("Деление на ноль");
            return x / y;
        }

        static double Power(double x, double power)
        {
            return Math.Pow(x, power);
        }

        static double Calculate(double x, string operation, double y)
        {
            switch (operation)
            {
                case "+":
                    return Add(x, y);
                case "-":
                    return Subtract(x, y);
                case "*":
                    return Multiply(x, y);
                case "/":
                    return Divide(x, y);
                case "^":
                    return Power(x, y);
                default:
                    throw new Exception("Недопустимая операция");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число, операцию и второе число через Enter.");

                try
                {
                    Console.WriteLine("Ответ: " +
                        Calculate(double.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine())));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}


