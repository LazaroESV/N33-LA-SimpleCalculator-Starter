using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        [TestInitialize]

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "5";

            // Action
            double? convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "*";

            // Action
            double? convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.IsNull(convertedNumber);
        }

        [TestCleanup]
        public void Cleanup() { }
    }
}
