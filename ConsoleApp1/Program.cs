using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple console calculator\n");
            Console.Write("Input first operand: ");
            double firstOperand = Calc.NumInput();
            double secondOperand = 0;
            Console.WriteLine();

            Console.Write("Input operator (+ - * / % sqrt ^ !): ");
            bool isSecondNeed = Calc.OperatorInput(out string mathOperator);
            if (isSecondNeed)
            {
                Console.Write("Input second operand: ");
                secondOperand = Calc.NumInput();
                Console.WriteLine();
            }

            double result = 0;
            switch (mathOperator)
            {
                case "+":
                    result = Calc.Plus(firstOperand, secondOperand);
                    break;
                case "-":
                    result = Calc.Minus(firstOperand, secondOperand);
                    break;
                case "*":
                    result = Calc.Multiply(firstOperand, secondOperand);
                    break;
                case "/":
                    result = Calc.Divide(firstOperand, secondOperand);
                    break;
                case "%":
                    result = Calc.RestOfDivide(firstOperand, secondOperand);
                    break;
                case "sqrt":
                    result = Calc.SqrtNewthon(firstOperand);
                    break;
                case "^":
                    result = Calc.Power(firstOperand, secondOperand);
                    break;
                case "!":
                    result = Calc.Factorial(firstOperand);
                    break;
            }

            Console.WriteLine($"Your result is {result}");
            Console.ReadLine();
        }
    }
}
