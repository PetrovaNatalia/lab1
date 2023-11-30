using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1:");
            Console.Write("Введите размер массива: ");

            int size = int.Parse(Console.ReadLine());

            var firstPart = new FirstPart(size);

            Console.Write("Введите N: ");

            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Исходный массив: ");
            PrintVector(firstPart.Vector);

            Console.WriteLine("Сумма элементов больше N: " + firstPart.count_N(N));
            Console.WriteLine("Произведение элементов после Max: " + firstPart.GetMultiplicationBetweenMaxEnd());

            firstPart.SortByAscending();
            Console.WriteLine("После сортировки:");
            PrintVector(firstPart.Vector);

            Console.WriteLine("Часть 2:");

            var secondPart = new SecondPart(4, 5);
            PrintMatrix(secondPart.Matrix);

            Console.WriteLine("Первый столбец содержащий 0: " + secondPart.GetFirstColsWithZero());

            Console.WriteLine("Матрица, отсортированная в соответствиии с характеристиками строк: ");
            secondPart.OrderRows(secondPart.Matrix);

            PrintMatrix(secondPart.Matrix);
        }

        static void PrintVector(IEnumerable<int> vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} \t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

