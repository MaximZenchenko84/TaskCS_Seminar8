// Урок 8. Задача 54.
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

using System;

namespace TaskCS8_54
{
    class TaskCS8_54
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк двумерного массива,\nзаполненного целыми числами");
            int mRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов двумерного массива,\nзаполненного целыми числами");
            int nColumns = int.Parse(Console.ReadLine());
            int[,] array = new int[mRows, nColumns]; // объявление массива 
            // цикл задания элементов массива и вывода на консоль
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    Console.Write("a[" + (i) + "," + (j) + "]=");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }
            Console.WriteLine("Введенный массив:");

            // цикл вывода на экран введенного массива
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }

            // цикл по строкам
            for (int k = 0; k<mRows; k++)
            {
                // цикл сортировки
                for (int i = 0; i < nColumns; i++)
                {
                    int currentMax = array[k, i];
                    int indexMax = i;
                    for (int j = i; j < nColumns; j++) // нахождение текущего максимума
                    {
                        if (array[k,j] > currentMax)
                        {
                            currentMax = array[k,j];
                            indexMax = j;
                        }
                    }
                    // перемещение максимума в начало текущей строки 
                    array[k,indexMax] = array[k,i];
                    array[k,i] = currentMax;
                }
            }
            Console.WriteLine("\nОтсортированный массив:");
            // цикл вывода на экран отсортированного массива
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }

        }
    }
}
