/*Дано двовимірний масив А цілих чисел розміру р*n, який заповнено випадковим
чином. Побудувати масив масивів В, у якому в рядку містяться від'ємні числа з рядків
масиву А. Визначити, скільки елементів у кожному рядку масиву В менше числа N,
заданого користувачем. У додатку використовувати функцію побудови масиву масивів,
функцію виведення масиву масивів, функцію розв'язання поставленої задачі.*/

using System;
using System.Collections.Generic;

namespace Lab_1_butok
{
    class Program
    {
        static Random rand = new Random();

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter p:");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[p, n];


            Console.WriteLine("Array A:");
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rand.Next(-20, 10);
                    Console.Write($"{A[i, j]}");
                }
                Console.WriteLine();
            }

            List<List<int>> B = new List<List<int>>();

            for (int i = 0; i < p; i++)
            {
                List<int> negativeRow = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] < 0)
                    {
                        negativeRow.Add(A[i, j]);
                    }
                }
                B.Add(negativeRow);
            }


            Console.WriteLine("Negative array B:");
            for (int i = 0; i < B.Count; i++)
            {
                if (B[i].Count > 0)
                {
                    for (int j = 0; j < B[i].Count; j++)
                    {
                        Console.Write($"{B[i][j]} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No negative numbers in this row.");
                }
            }


            Console.WriteLine("Enter N:");
            int N = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < B.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < B[i].Count; j++)
                {
                    if (B[i][j] < N)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Row {i + 1}: {count} elements are less than {N}");
            }
        }
    }
}

