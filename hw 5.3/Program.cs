using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 3.  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            Console.Write("Укажите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Укажите минимальное значение массива: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Укажите максимальное значение массива: ");
            int max = Convert.ToInt32(Console.ReadLine());

            double[] copyArr = CreateArr(size, min, max);
            ShowArray(copyArr);
            SearchNum(copyArr);
            Console.ReadKey();
        }
        static double[] CreateArr(int size, int min, int max)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++) array[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), 2);
            return array;
        }
        static void SearchNum(double[] array)
        {
            double min_num = array[0];
            double max_num = array[0];

            for (int j = 0; j < array.Length; j++)
            {
                if (min_num > array[j])
                    min_num = array[j];
                else if (max_num < array[j])
                    max_num = array[j];
            }
            Console.Write($"{min_num} - минмальное, {max_num} - максимальное.");
            Console.WriteLine();
        }
        static void ShowArray(double[] array)
        {
            for (int k = 0; k < array.Length; k++)
                Console.Write(array[k] + " ");
            Console.WriteLine();
        }
    }
}
