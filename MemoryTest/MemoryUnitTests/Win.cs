using System;
using MemoryLogic;
using MemoryTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemoryUnitTests
{
    [TestClass]
    public class Win
    {
        [TestMethod]
        public void WinsWhenAllPairsAreDiscovered()
        {
            //Arrange
            MemoryGame game = new MemoryGame(1, 2);

            //Act
            game.ClickCoordinate(0, 1);
            game.ClickCoordinate(0, 0);

            //Assert
            Assert.AreEqual(game.Points, game.Maxpoints);
        }

        [TestMethod]
        public void MaxPointsIsSetCorrect()
        {
            //Arrange
            MemoryGame game = new MemoryGame(3, 3);

            //Act
            

            //Assert
            Assert.AreEqual(game.Maxpoints, game.SizeX*game.SizeY/2);
        }
        
    }
}
