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
        public void DivideTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Divide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(64, 8)]  // Корень
        [TestCase(2, 15)] //try catch Отдельный метод, который проверяет отдельные значения(ловит ошибку, тест прошел)
        [TestCase(1, 1)]
        [TestCase(256, 16)]
        public void RootTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Sqrt(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 120)]
        [TestCase(4, 24)]
        [TestCase(2, 2)]
        [TestCase(0, 1)]
        public void FactorialTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Factorial(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
       
        [TestCase(2, 1, 2)]    //Степень
        [TestCase(8, 3, 512)]
        [TestCase(3, 8, 6561)]
        [TestCase(1, 10, 1)]
        public void DegreeTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Stepen(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}