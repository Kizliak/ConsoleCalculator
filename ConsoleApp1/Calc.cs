using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class Calc
   {
        public static double SqrtNewthon(double x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                bool minus = false;
                if (x < 0)
                {
                    minus = true;
                }
                double tmp = x > 0 ? x : -x;
                x = tmp;
                while (true)
                {
                    double t = (x / tmp + tmp) / 2;
                    if (Math.Abs(tmp - t) < 1E-10)
                    {
                        return minus == true ? -tmp : tmp;
                    }
                    tmp = t;
                }
            }
        }

        public static double Power(double x, double y)
        {
            if (x == 0 & y == 0)
            {
                Console.WriteLine("I am not able to power up zero to zero!");
                Console.ReadLine();
                System.Environment.Exit(0);
                return 0;
            }
            double result = x;
            if (Convert.ToInt32(y) == 0)
            {
                result = 1;
            }
            else if (y > 0)
            {
                for (int i = 1; i < Convert.ToInt32(y); i++)
                {
                    result *= x;
                }
            }
            else
            {
                for (int i = Convert.ToInt32(y); i < 0; i++)
                {
                    result *= x;
                }
                result = 1 / result;
            }
            return result;
        }

        public static double Factorial(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else if (x < 0)
            {
                Console.WriteLine("Positive numbers only, can not calculate factorial!");
                Console.ReadLine();
                System.Environment.Exit(0);
                return 0;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

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
