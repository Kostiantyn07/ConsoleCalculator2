using NUnit.Framework;
using ConsoleApp1;



namespace ConsoleCalculatorUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
           
        [TestCase(10, 2, 12)]
        [TestCase(-10, 12, 2)]
        [TestCase(0, 2, 2)]
        [TestCase(1, -2, -1)]
        public void AdditionTest (double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Sum(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(40, 2, 38)]
        [TestCase(8, 8, 0)]
        [TestCase(43, 0, 43)]
        [TestCase(43, 53, -10)]
        public void SubstractionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Substract(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 10)]
        [TestCase(10, 5, 50)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 0, 0)]
        public void MultiplicationTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Multiply(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 6, 4.0)]
        public void RestOfDivide(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.RestOfDivide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(12, 2, 6)]
        [TestCase(-10, 2, -5)]
        [TestCase(4, 2, 2)]
        [TestCase(0, 0, 0)]
        public void Divide(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Divide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}