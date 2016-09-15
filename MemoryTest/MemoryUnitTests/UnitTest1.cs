using System;
using MemoryLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemoryUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
           

            //Act
            

            //Assert
            
        }
    }
    [TestClass]
    public class ResetBoard
    {
        

        [TestMethod]
        public void ResetBoardShouldCreatePositionInfoForAllBoardPositions()
        {
            //Arrange via setup
            MemoryGame _Resettest = new MemoryGame(4,4);
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
    }
}
