using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();

            Assert.IsNotNull(calculator);
        }
        [TestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow(3,3,6)]

        public void AddTest(int x, int y, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(x,y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Subtract(4, 1);

            Assert.AreEqual(3, actual);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(4, 2);

            Assert.AreEqual(8, actual);
        }
        [TestMethod]
        public void DivideTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(6, 2);

            Assert.AreEqual(3, actual);
        }
        [TestMethod]
        public void DivideByZeroTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(1, 0);

            Assert.IsNull(actual);
        }
    }
}