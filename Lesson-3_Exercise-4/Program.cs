using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Battleship =  {
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "X", "O", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "X", "X", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "O", "X", "O", "O", "X", "X", "X", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O",},
            };

            for (int i = 0; i < Battleship.GetLength(1); i++)
            {
                // Запуск цикла по перебору индекса стобцов
                for (int j = 0; j < Battleship.GetLength(0); j++)
                {
                    // Запуск цикла по перебору индекса строк и Вывод значение элемента массива одной строки в одну строчку
                    System.Console.Write($" {Battleship[i, j]} ");
                }
                // Переход курсора на новую строчку
                System.Console.WriteLine();
            }
        }
    }
}
