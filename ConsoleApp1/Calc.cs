using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Calc
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double RestOfDivide(double num1, double num2)
        {
            return num1 % num2;
        }
        public static double Divide(double num1, double num2)
        {
            while ( num2 == 0)
            {
                Console.WriteLine("Can not divide by zero!");
                return 0;
            }
            return num1 / num2;
        }
        public static double Sqrt(double num1)
        {
            return Math.Sqrt(num1);
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
            List<string> operatorsWithOneArgument = new List<string> { "sqrt", "!" };

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
