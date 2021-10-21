using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class Calc
   {
       public static double Plus(double x, double y)
        {
            return x + y;
        }

        public static double Minus(double x, double y)
        {
            return x - y;
        }

        public static double RestOfDivide(double x, double y)
        {
            return x % y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        static public double Divide(double x, double y)
        {
            while (y == 0)
            {
                Console.WriteLine("Can not divide by zero!");
                return 0;
            }
            return x / y;
        }
        static public double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoubleInput = Double.TryParse(numberString, out double numberDouble);
            while (!isDoubleInput)
            {
                Console.WriteLine("Wrong input " + numberDouble + "! Try again:");
                numberString = Console.ReadLine();
                isDoubleInput = Double.TryParse(numberString, out numberDouble);
            }
            return numberDouble;
        }

        static public bool OperatorInput(out string mathOperator)
        {
            mathOperator = Console.ReadLine();
            List<string> operatorsWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorsWithOneArgument = new List<string> {"sqrt", "!"};

            while (true)
            {
                if (operatorsWithSecondArgument.Contains(mathOperator))
                {
                    return true; //нужно спросить второе число
                }
                else if (operatorsWithOneArgument.Contains(mathOperator))
                {
                    return false; //ввод второго числа пропускаем
                }

                Console.WriteLine();
                Console.WriteLine("Wrong input! Try again:");
            }
        }
    }
}
