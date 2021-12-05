using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConwaysGame.Testing
{
    [TestClass]
    public class EvolveTests
    {
        [TestMethod]
        public void Evolucao_Sem_Nenhum_Grupo_Celulas()
        {
            //Arrange
            Cell[] cells = null;

            //Act
            var evolucao = new Evolve(cells);

            //Assert
            Assert.IsTrue(evolucao.AllHaveDied);
        }
    }
}
