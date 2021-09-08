using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_3_Ex_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Объявление значений двумерного массива
            int[,] matrix = new int[,]
                {
                    { 0, 1, 2, 3},
                    { 4, 5, 6, 7}
                };
            //Запуск цикла по перебору значений индекса строк
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Запуск цикла по перебору индекса столбцов
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Вывод значение элемента массива и переход на новую строчку
                    Console.Write($" {matrix[i, j]} ");
                    Console.WriteLine();

                    // Запуск цикла с предусловием для печати нужного количества пробелов перед следующим элементом массива
                    int n = matrix.Length - (i * matrix.GetLength(1) + j + 1);
                    while (n < matrix.Length)
                    {
                        Console.Write(" ");
                        n++;
                    }
                }
            }
        }
    }
}
