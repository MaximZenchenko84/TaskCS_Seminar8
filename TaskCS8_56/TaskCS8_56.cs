// Урок 8. Задача 56.
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

using System;

namespace TaskCS8_56
{
    class TaskCS8_56
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк прямоугольного двумерного массива,\nзаполненного целыми числами");
            int mRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов (не равное числу введенных строк) \nпрямоугольного двумерного массива, заполненного целыми числами");
            int nColumns = int.Parse(Console.ReadLine());
            if ( (mRows == nColumns) || (mRows <= 0) || (nColumns <= 0) )
            {
                Console.WriteLine("Неверный ввод (массив квадратный или размерность отрицательная)\n");
                return;
            }
            int[,] array = new int[mRows, nColumns]; // объявление исходного массива 
            int[] arraySums = new int[mRows]; // массив значений сумм по каждой строке исходного массива
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
            Console.Write("\n");

             // Цикл формирования массива сумм по строкам
            for (int i = 0; i < mRows; i++)
            {
                arraySums[i] = 0;
                for (int j = 0; j < nColumns; j++)
                {
                    arraySums[i] += array[i, j];
                }
            }
            // нахождение номера строки с наименьшей суммой элементов
            int rowMinSum = 0; // номер строки с наименьшей суммой элементов
            for (int i = 1; i < mRows; i++)
            { rowMinSum = (arraySums[i - 1] > arraySums[i]) ? i : rowMinSum; }

            Console.WriteLine("\nНомер строки с наименьшей суммой элементов: " + rowMinSum + "\n");
        }
    }
}
