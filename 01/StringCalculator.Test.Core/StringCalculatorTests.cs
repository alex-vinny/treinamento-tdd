using NUnit.Framework;

namespace StringCalculators.Testing
{
    public class StringCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringVazia_Retornar_Zero()
        {
            //Arrange
            int expected = 0;
            var calculator = new StringCalculator();

            //Act
            var actual = calculator.Add("");

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}