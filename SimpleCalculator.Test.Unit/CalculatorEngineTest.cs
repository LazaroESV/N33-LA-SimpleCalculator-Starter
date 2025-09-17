using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestInitialize]


        [TestMethod]
        public void Add()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Action
            double? result = _calculatorEngine.Calculate("+", number1, number2);

            // Assert
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void Subtract()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Action
            double? result = _calculatorEngine.Calculate("-", number1, number2);

            // Assert
            Assert.AreEqual(-1, result);

        }

        [TestMethod]
        public void Multiply()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Action
            double? result = _calculatorEngine.Calculate("*", number1, number2);

            // Assert
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void Divide()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Action
            double? result = _calculatorEngine.Calculate("/", number1, number2);

            // Assert
            Assert.AreEqual(0.5, result);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Cannot divide by zero")]
        public void DivideByZero()
        {
            // Arrange
            int number1 = 1;
            int number2 = 0;

            // Action
            double? result = _calculatorEngine.Calculate("/", number1, number2);
        }

        [TestMethod]
        public void Modulus()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Action
            double? result = _calculatorEngine.Calculate("%", number1, number2);

            // Assert
            Assert.AreEqual(1, result);

        }

        [TestCleanup]
        public void Cleanup(){ }
    }
}
