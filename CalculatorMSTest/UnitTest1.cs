using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorMSTest
{
    [TestClass]
    public class UnitTest1
    {
        CalculatorUnderTest calculator;

        [TestInitialize]
        public void Initialize()
        {
            calculator = new CalculatorUnderTest();
        }

        [TestMethod]
        public void TestAdd()
        {
            //setup
            double valueInput1 = 8;
            double valueInput2 = 5;
            double expectedOutput = 13;

            //running the test
            double result = calculator.Add(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestMinus()
        {
            //setup
            double valueInput1 = 15;
            double valueInput2 = 3;
            double expectedOutput = 12;

            //running the test
            double result = calculator.Minus(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            //setup
            double valueInput1 = 6;
            double valueInput2 = 2;
            double expectedOutput = 12;

            //running the test
            double result = calculator.Multiply(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            //setup
            double valueInput1 = 10;
            double valueInput2 = 2;
            double expectedOutput = 5;

            //running the test
            double result = calculator.Divide(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestCleanup]
        public void CleanUp()
        {
            calculator = null;
        }
    }
}
