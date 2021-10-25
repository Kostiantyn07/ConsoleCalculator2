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
            Console.WriteLine("Simple console calculator!\n");
            Console.Write("Input first operand: ");
            double firstOperand = Calc.NumInput();
            Console.WriteLine();

            Console.WriteLine("Input operator (+ - * / %): ");
            bool isSecondNeed = Calc.OperatorInput(out string mathOperator);
            double secondOperand = 0;
            if (isSecondNeed = true)
            {
                Console.WriteLine("Input second operand: ");
                secondOperand = Calc.NumInput();
                Console.WriteLine();
            }

            double result = 0;
            switch (mathOperator)
            {
                case "+":

                    result = Calc.Sum(firstOperand, secondOperand);
                    break;
                case "-":

                    result = Calc.Substract(firstOperand, secondOperand);
                    break;

                case "/":

                    result = Calc.Divide(firstOperand, secondOperand);
                    break;

                case "*":

                    result = Calc.Multiply(firstOperand, secondOperand);
                    break;
                case "%":

                    result = Calc.RestOfDivide(firstOperand, secondOperand);
                    break;
                case "!":

                    result = Calc.Factorial(firstOperand);
                    break;
                case "X":

                    result = Calc.SqrtX(firstOperand, secondOperand);
                    break;
                case "Y":

                    result = Calc.DegreeY(firstOperand, secondOperand);
                    break;
                case "E":

                    result = Calc.Square(firstOperand);
                    break;
                case "T":

                    result = Calc.Sqrt(firstOperand);
                    break;
                    
                case "K":

                    result = Calc.(firstOperand, secondOperand);
                    break;
                default:
                    Console.WriteLine("No such opertor");
                    break;
            }
            Console.WriteLine($"Yoyr result is: {result}");
        }
    }
}
