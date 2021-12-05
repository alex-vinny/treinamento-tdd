using NUnit.Framework;

namespace ConwaysGame.Testing
{
    public class GenerationTests
    {
        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public void Nenhuma_Geracao_Futura()
        {
            //Arrange
            var generation = Generation.For(0);

            //Act
            var actual = generation.Next();

            //Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Possui_Geracoes_Futuras()
        {
            //Arrange
            int expected = 2;
            var generation = Generation.For(expected);

            //Act
            var actual = 0;
            while (generation.Next())
                actual++;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}