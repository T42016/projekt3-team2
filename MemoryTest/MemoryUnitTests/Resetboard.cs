using System;
using MemoryLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemoryUnitTests
{
    [TestClass]
    public class ResetBoard
    {
        MemoryGame _Resettest = new MemoryGame(4, 4);

        [TestMethod]
        public void ResetBoardShouldCreatePositionInfoForAllBoardPositions()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();

            //Assert
            Assert.IsNotNull(_Resettest.GetCoordinate(0, 0));

            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    Assert.IsInstanceOfType(_Resettest.GetCoordinate(x, y), typeof(PositionInfo));
                }
            }
        }
        [TestMethod]
        public void ResetBoardShouldInitializePositionInfoWithX()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();

            //Assert
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    Assert.AreEqual(x, _Resettest.GetCoordinate(x, y).X);
                }
            }
            Assert.IsNotNull(_Resettest.GetCoordinate(0, 0));
        }
        [TestMethod]
        public void ResetBoardShouldInitializePositionInfoWithY()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();

            //Assert
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    Assert.AreEqual(y, _Resettest.GetCoordinate(x, y).Y);
                }
            }
            Assert.IsNotNull(_Resettest.GetCoordinate(0, 0));
        }
    }
}
