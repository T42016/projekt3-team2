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

        [TestMethod]
        public void ResetBoardShouldSetDrawsToZero()
        {
            //Arrange

            //Act
            _Resettest.ResetBoard();

            //Assert
            Assert.AreEqual(_Resettest.Draws == 0, true);

        }
        [TestMethod]
        public void ResetBoardShouldSetAllCoordinatesToNotOpen()
        {
            //Arrange via Setup

            //Act
            _Resettest.ResetBoard();

            //Assert
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    Assert.AreEqual(false, _Resettest.GetCoordinate(x, y).IsOpen);
                }
            }
            Assert.IsNotNull(_Resettest.GetCoordinate(0, 0));
        }
    }
}
