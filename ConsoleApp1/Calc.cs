using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Calc
    {
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Substract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double RestOfDivide(double x, double y)
        {
            return x % y;
        }

        public static double Divide(double x, double y)
        {
            while (y == 0)
            {
                Console.WriteLine("Can not divide by zero!");
                return 0;
            }
            return x / y;
        }

        public static double Factorial(double x)
        {
            double factorial = x;

            if (x == 0)
            {
                return 1;
            }

            for (var i = x - 1; i > 1; i--)
            {
                factorial *= i;

            }
            return factorial;
        }

        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Stepen(double x, double y)
        {
            double temp = 1;
            for (double i = 0; i < y; i++)
                temp *= x;
            return temp;
        }

        static public double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoubleInput = double.TryParse(numberString, out double numberDouble);
            while(!isDoubleInput)
            {
                Console.WriteLine("Wrong input! Try again: ");
                numberString = Console.ReadLine();
                isDoubleInput = double.TryParse(numberString, out numberDouble);
            }
            return numberDouble;
        }

        static public bool OperatorInput(out string mathOperator) // К оператору можно будет добраться в нашем Мейне.
        {
            mathOperator = Console.ReadLine();
            List<string> operatorsWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorsWithOneArgument = new List<string> { "sqrt", "!", "S"};

            while (true)
            {
                if(operatorsWithSecondArgument.Contains(mathOperator))
                {
                    return true; // Нужно спросить второе число.
                }
                else if(operatorsWithOneArgument.Contains(mathOperator))
                {
                    return false; // Ввод второго числа пропускаем.
                }

                Console.WriteLine();
                Console.WriteLine("Wrong input! Try again: ");
            }
        }
    }
}
