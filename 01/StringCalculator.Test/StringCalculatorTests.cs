using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringCalculators
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void StringVazia_Retornar_Zero()
        {
            //Arrange
            int expected = 0;
            var calculator = new StringCalculator();

            //Act
            var actual = calculator.Add("");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
