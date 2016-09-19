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
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoZeros()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 0)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoOnes()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 1)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoTwoes()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 2)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoThrees()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 3)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoFours()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 4)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoFives()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 5)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoSixes()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 6)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void ResetBoardShouldCheckIfValueHaveTwoSevens()
        {
            //Arrange via setup

            //Act
            _Resettest.ResetBoard();
            int count = 0;
            for (int y = 0; y < _Resettest.SizeY; y++)
            {
                for (int x = 0; x < _Resettest.SizeX; x++)
                {
                    if (_Resettest.GetCoordinate(x, y).Value == 7)
                        count++;
                }
            }

            //Assert
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void ResetBoardShouldSetDrawsToZero()
        {
            //Arrange
            MemoryGame game = new MemoryGame(2, 2);
            //Act

            //Assert
            Assert.AreEqual(game.Draws == 0, true);
        }

        [TestMethod]
        public void ResetBoardShouldSetPointsToZero()
        {
            //Arrange
            MemoryGame game = new MemoryGame(2, 2);
            //Act

            //Assert
            Assert.AreEqual(game.Points == 0, true);
        }
    }
}
