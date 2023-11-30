using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class SecondPart
    {
        private readonly int[,] matrix;

        public SecondPart(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows) + " or " + nameof(cols));
            }

            matrix = new int[rows, cols];

            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
            for (int i = 0; i < random.Next(0, 19); i++)
                matrix[random.Next(0, matrix.GetLength(0)), random.Next(0, matrix.GetLength(1))] = 0;

        }
        public int[,] Matrix
        {
            get
            {
                return matrix;
            }
        }
        public int GetFirstColsWithZero()
        {
            int result = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        result = j + 1;
                        break;
                    }
                }
            }
            return result;
        }
        public int RowCharacteristic(int[,] matrix, int row)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[row, i] < 0 && matrix[row, i] % 2 == 0)
                {
                    sum += matrix[row, i];
                }
            }
            return sum;
        }
        public void SwapRows(int[,] m, int row1, int row2)
        {
            for (int i = 0; i < m.GetLength(1); i++)
            {
                int tmp = m[row1, i];
                m[row1, i] = m[row2, i];
                m[row2, i] = tmp;
            }
        }
        public void OrderRows(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = i + 1; j < m.GetLength(0); j++)
                    if (RowCharacteristic(m, i) < RowCharacteristic(m, j))
                        SwapRows(m, i, j);
        }
    }
}
