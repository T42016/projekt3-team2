using System;
using MemoryLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemoryUnitTests
{
    [TestClass]
    public class ClickCoordinate
    {
        [TestMethod]
        public void ClickCoordinateShouldOpenCoordinate()
        {
            //Arange
            MemoryGame game = new MemoryGame(5, 5);

            //Act
            game.ClickCoordinate(0, 0);

            //Assert
            Assert.AreEqual(true, game.GetCoordinate(0, 0).IsOpen);
        }

        [TestMethod]
        public void ClickCoordinateShouldFindPair()
        {
            //Arange
            MemoryGame game = new MemoryGame(1, 2);

            //Act
            game.ClickCoordinate(0, 0);
            game.ClickCoordinate(0, 1);

            //Assert
            Assert.AreEqual(true, game.GetCoordinate(0, 0).IsFound);
        }

        [TestMethod]
        public void ClickCoordinateShouldAddToDraws()
        {
            //Arange
            MemoryGame game = new MemoryGame(5, 5);

            //Act
            game.ClickCoordinate(0, 0);
            game.ClickCoordinate(0, 1);

            //Assert
            Assert.AreEqual(1, game.Draws);
        }

        [TestMethod]
        public void ClickCoordinateShouldNotAddToDrawsYet()
        {
            //Arange
            MemoryGame game = new MemoryGame(5, 5);

            //Act
            game.ClickCoordinate(0, 0);

            //Assert
            Assert.AreEqual(0, game.Draws);
        }


    }
}
