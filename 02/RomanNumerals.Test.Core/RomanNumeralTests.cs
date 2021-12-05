using NUnit.Framework;

namespace RomanNumerals.Testing
{
    public class RomanNumeralTests
    {
        [SetUp]
        public void Setup()
        {            
        }

        [Test]
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