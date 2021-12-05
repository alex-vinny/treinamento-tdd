using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RomanNumerals.Testing
{
    [TestClass]
    public class RomanNumeralTests
    {
        [TestMethod]
        public void Converter_Unidade_Para_Romano()
        {
            //Arrange
            string expected = "I";
            var converter = new RomanNumeral();

            //Act
            var actual = converter.Convert(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
