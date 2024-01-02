using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab1;

namespace lab1Tests
{
    [TestClass]
    public class FirstPartTest
    {
        [TestMethod]
        public void Vector_ReturnsInitializedArray()
        {
            // Arrange
            int length = 5;
            var firstPart = new FirstPart(length);

            // Act
            var vector = firstPart.Vector;

            // Assert
            Assert.AreEqual(length, vector.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ThrowsExceptionWhenLengthIsZero()
        {
            // Arrange
            int length = 0;

            // Act
            var firstPart = new FirstPart(length);

            // Assert
            // Expecting an ArgumentOutOfRangeException to be thrown
        }

        [TestMethod]
        public void CountN_ReturnsCorrectCount()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int n = 3;
            var firstPart = new FirstPart(array.Length);
            Array.Copy(array, (Array)firstPart.Vector, array.Length);

            // Act
            int count = firstPart.count_N(n);

            // Assert
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void SortByAscending_SortsArray()
        {
            // Arrange
            int[] array = { 3, 1, 4, 2, 5 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5 };
            var firstPart = new FirstPart(array.Length);
            Array.Copy(array, (Array)firstPart.Vector, array.Length);

            // Act
            firstPart.SortByAscending();

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, (System.Collections.ICollection)firstPart.Vector);
        }

        [TestMethod]
        public void GetMultiplicationBetweenMaxEnd_ReturnsCorrectMultiplication()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            var firstPart = new FirstPart(array.Length);
            Array.Copy(array, (Array)firstPart.Vector, array.Length);

            // Act
            int multiplication = firstPart.GetMultiplicationBetweenMaxEnd();

            // Assert
            Assert.AreEqual(4 * 5, multiplication);
        }
    }
}
