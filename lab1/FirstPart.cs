using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class FirstPart
    {
        private readonly int[] array;

        public FirstPart(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            var random = new Random();

            array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }

        public IReadOnlyList<int> Vector
        {
            get
            {
                return array;
            }
        }

        public int count_N(int N)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > N)
                {
                    count++;
                }
            }
            return count;
        }
        public void SortByAscending()
        {
            Array.Sort(array);
        }
        public int GetMultiplicationBetweenMaxEnd()
        {
            int max = array.Max();

            var maxIndex = Array.IndexOf(array, max);

            int mul = 1;

            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                mul *= array[i];
            }

            return mul;
        }
    }
}