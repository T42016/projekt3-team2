using System;
using MemoryLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemoryUnitTests
{
    [TestClass]
    public class PositionInfoTest
    {
        private MemoryGame _underTest;

        [TestInitialize]

        public void Setup()
        {
            _underTest = new MemoryGame(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCoordinateShouldThrowExceptionForHighX()
        {
            //Arrange
            //Act
            _underTest.GetCoordinate(_underTest.SizeX, 0);

            //Assert


        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCoordinateShouldThrowExceptionForHighY()
        {
            //Arrange
            //Act
            _underTest.GetCoordinate(0, _underTest.SizeY);

            //Assert


        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCoordinateShouldThrowExceptionForNegativeX()
        {
            //Arrange
            //Act
            _underTest.GetCoordinate(-1, 0);

            //Assert


        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCoordinateShouldThrowExceptionForNegativeY()
        {
            //Arrange
            //Act
            _underTest.GetCoordinate(0, -1);

            //Assert
        }

        [TestMethod]
        public void GetCoordinateShouldReturnCorrectX()
        {
            //Arrange

            //Act

            //Assert

        }
    }
}
