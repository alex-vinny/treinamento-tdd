using NUnit.Framework;

namespace ConwaysGame.Testing
{
    public class EvolveTests
    {
        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public void Evolucao_Sem_Nenhum_Grupo_Celulas()
        {
            //Arrange
            Cell[] cells = null;

            //Act
            var evolucao = new Evolve(cells);

            //Assert
            Assert.That(evolucao.AllHaveDied, Is.True);
        }
    }
}