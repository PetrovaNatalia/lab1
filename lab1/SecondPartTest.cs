using lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Tests
{
    internal class SecondPartTest
    {
        [TestMethod]
        public void GetFirstColsWithZero_Test()
        {
            // Arrange
            int rows = 3;
            int cols = 3;
            var secondPart = new SecondPart(rows, cols);

            // Act
            int result = secondPart.GetFirstColsWithZero();

            // Assert
            Assert.AreEqual(cols, result);
        }

        [TestMethod]
        public void RowCharacteristic_Test()
        {
            // Arrange
            int[,] matrix = new int[,] { { -1, 2, -3 }, { 4, -5, 6 }, { -7, 8, 9 } };
            int row = 1;
            var secondPart = new SecondPart(3, 3);

            // Act
            int result = secondPart.RowCharacteristic(matrix, row);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void SwapRows_Test()
        {
            // Arrange
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int row1 = 0;
            int row2 = 2;
            var secondPart = new SecondPart(3, 3);

            // Act
            secondPart.SwapRows(matrix, row1, row2);

            // Assert
            Assert.AreEqual(7, matrix[row1, 0]);
            Assert.AreEqual(8, matrix[row1, 1]);
            Assert.AreEqual(9, matrix[row1, 2]);
            Assert.AreEqual(1, matrix[row2, 0]);
            Assert.AreEqual(2, matrix[row2, 1]);
            Assert.AreEqual(3, matrix[row2, 2]);
        }

        [TestMethod]
        public void OrderRows_Test()
        {
            // Arrange
            int[,] matrix = new int[,] { { 1, -2, 3 }, { -4, 5, -6 }, { 7, -8, 9 } };
            var secondPart = new SecondPart(3, 3);

            // Act
            secondPart.OrderRows(matrix);

            // Assert
            Assert.AreEqual(-4, matrix[0, 0]);
            Assert.AreEqual(5, matrix[1, 0]);
            Assert.AreEqual(7, matrix[2, 0]);
        }
    }
}
