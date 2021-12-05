using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConwaysGame.Testing
{
    [TestClass]
    public class GenerationTests
    {
        [TestMethod]
        public void Nenhuma_Geracao_Futura()
        {
            //Arrange
            bool expected = false;
            var generation = Generation.For(0);

            //Act
            var actual = generation.Next();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Possui_Geracoes_Futuras()
        {
            //Arrange
            int expected = 2;
            var generation = Generation.For(expected);

            //Act
            var actual = 0;
            while(generation.Next())
                actual++;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
