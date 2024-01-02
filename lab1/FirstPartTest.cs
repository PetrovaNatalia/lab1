using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab1;

namespace lab1Tests
{
    [TestClass]
    public class FirstPartTest
    {
        [TestMethod]
        public void CountN_Should_Return_Correct_Count()
        {
            // Arrange
            var firstPart = new FirstPart(5);
            firstPart.Vector = new[] { 1, 2, 3, 4, 5 };

            // Act
            var count = firstPart.count_N(3);

            // Assert
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void SortByAscending_Should_Sort_Array_By_Ascending_Order()
        {
            // Arrange
            var firstPart = new FirstPart(5);
            firstPart.Vector = new[] { 4, 2, 5, 1, 3 };

            // Act
            firstPart.SortByAscending();

            // Assert
            Assert.AreEqual(1, firstPart.Vector[0]);
            Assert.AreEqual(2, firstPart.Vector[1]);
            Assert.AreEqual(3, firstPart.Vector[2]);
            Assert.AreEqual(4, firstPart.Vector[3]);
            Assert.AreEqual(5, firstPart.Vector[4]);
        }

        [TestMethod]
        public void GetMultiplicationBetweenMaxEnd_Should_Return_Correct_Result()
        {
            // Arrange
            var firstPart = new FirstPart(6);
            firstPart.Vector = new[] { 1, 2, 3, 4, 5, 6 };

            // Act
            var result = firstPart.GetMultiplicationBetweenMaxEnd();

            // Assert
            Assert.AreEqual(6 * 5 * 4, result);
        }
    }
}
