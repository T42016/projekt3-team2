using System;
using MemoryLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemoryUnitTests
{
    [TestClass]
    public class MemoryGameTest
    {
        [TestInitialize]
        public void Start()
        {
            
        }
        [TestMethod]
        public void ConstructorShouldSetSizeX()
        {
            //Arrange
            var game = new MemoryGame(2, 2);

            //Act


            //Assert
            Assert.AreEqual(2 , game.SizeX);
        }
        [TestMethod]
        public void ConstructorShouldSetSizeY()
        {
            //Arrange
            var game = new MemoryGame(2, 2);

            //Act


            //Assert
            Assert.AreEqual(2, game.SizeY);
        }
        [TestMethod]
        public void ConstructorShouldSetRightSizeX()
        {
            //Arrange
            var game = new MemoryGame(3, 2);

            //Act


            //Assert
            Assert.AreEqual(3, game.SizeX);
        }
        [TestMethod]
        public void ConstructorShouldSetRightSizeY()
        {
            //Arrange
            var game = new MemoryGame(2, 3);

            //Act


            //Assert
            Assert.AreEqual(3, game.SizeY);
        }
        [TestMethod]
        public void ConstructorShouldCallMethodResetBoard()
        {
            //Arrange
            

            //Act
            

            //Assert


        }
    }
}
