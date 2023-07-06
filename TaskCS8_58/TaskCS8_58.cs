// Урок 8. Задача 58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

using System;

namespace TaskCS8_58
{
    class TaskCS8_58
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа нахождения произведения двух матриц.\nВведите размерность матриц ");
            int mDim = int.Parse(Console.ReadLine());

            int[,] array1 = new int[mDim, mDim]; // объявление матрицы1 
            int[,] array2 = new int[mDim, mDim]; // объявление матрицы2 
            int[,] arrayResult = new int[mDim, mDim]; // объявление матрицы результата

            // инициализация нулями матрицы результата
            for (int i = 0; i < mDim; i++)
                for (int j = 0; j < mDim; j++)
                { arrayResult[i,j] = 0;}

            // циклы задания элементов первой матриц и вывода на консоль
            for (int i = 0; i < mDim; i++)
            {
                for (int j = 0; j < mDim; j++)
                {
                    Console.Write("a1[" + (i) + "," + (j) + "]=");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }

            for (int i = 0; i < mDim; i++)
            {
                for (int j = 0; j < mDim; j++)
                {
                    Console.Write("a2[" + (i) + "," + (j) + "]=");
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }

            Console.WriteLine("Введенная матрица1:");
            for (int i = 0; i < mDim; i++)
            {
                for (int j = 0; j < mDim; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.WriteLine("Введенная матрица2:");
            for (int i = 0; i < mDim; i++)
            {
                for (int j = 0; j < mDim; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            // цикл вычисления произведения
            for (int k = 0; k < mDim; k++)
            {
                for (int m = 0; m < mDim; m++)
                {
                    for (int l = 0; l < mDim; l++)
                    {
                        arrayResult[k, m] += array1[k, l] * array2[l, m];
                    }
                 }
            }

            Console.WriteLine("Произведение двух матриц:");
            for (int i = 0; i < mDim; i++)
            {
                for (int j = 0; j < mDim; j++)
                {
                    Console.Write(arrayResult[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
