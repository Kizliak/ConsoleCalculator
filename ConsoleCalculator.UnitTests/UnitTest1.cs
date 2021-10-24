using NUnit.Framework;
using ConsoleCalculator;

namespace ConsoleCalculator.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (10,2,12)]
        [TestCase (0,0,0)]
        [TestCase (0,1,1)]
        [TestCase (1,0,1)]
        [TestCase (-10,-2,-12)]
        [TestCase (-1,2,1)]
        //[TestCase (-1,-2,0)]
        public void PlusArgumentsTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Plus(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 8)]
        [TestCase(2, 0, 2)]
        [TestCase(0, 2, -2)]
        [TestCase(-10, -2, -8)]
        // [TestCase(-10, -2, -0)]
        public void MinusArgumentTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Minus(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(4, 2, 2)]
        [TestCase(0, 2, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(5, 1, 5)]
        [TestCase(-6, 2, -3)]
        //[TestCase(2, 2, 0)]
        public void DivideArgumentTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Divide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 1)]
        [TestCase(4, 2, 0)]
        [TestCase(1, 1, 0)]
        [TestCase(-4, 2, 0)]
        //[TestCase(2, 2, 2)]
        public void RestOfDivideArgumentTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.RestOfDivide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 3, 6)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        [TestCase(-4, 2, -8)]
        [TestCase(0, 2, 0)]
        //[TestCase(0, 2, 2)]
        public void MultiplyArgumentTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Multiply(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(8, 40320)]
        [TestCase(0, 1)]
        [TestCase(2, 2)]
        public void FactorialArgumentTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Factorial(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1, 1)]
        [TestCase(-1, -1, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 25)]
        [TestCase(-5, 2, 25)]
        [TestCase(-5, 3, -125)]
        public void PowerArgumentTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Power(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(9, 3)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(-9, -3)]
        public void SqrtArgumentTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.SqrtNewthon(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}