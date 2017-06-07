using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostFix;

namespace PostFixTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculate_ShouldReturnCorrectResult()
        {
            // Arrange
            var c = new Calculator();

            // Act
            var res = c.Calculate(new[] {"4", "10", "14", "*", "+", "6", "-"});

            // Assert
            Assert.AreEqual("138", res);
        }

        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod]
        public void Calculate_ForMalformedExpression_ShouldThrowException()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Calculate(new[] {"4", "%"});
        }

        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void Calculate_ForInvalidOperation_ShouldThrowException()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Calculate(new[] { "4", "6", "^" });
        }
    }
}
