using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_3_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var PhoneBook = new [,]
                {
                    { "Иванов", "Петров", "Сидоров", "Андреев", "Гаврилов"},
                    { "+7 (901) 111-1111", "+7 (902) 222-2222", "+7 (903) 333-3333", "+7 (904) 444-4444", "+7 (905) 555-5555"}
                };

            // Запуск цикла по перебору индекса столбцов
            for (int i = 0; i < PhoneBook.GetLength(1); i++)
            {
                // Запуск цикла по перебору индекса строк
                for (int j = 0; j < PhoneBook.GetLength(0); j++)
                {
                    //Вывод значение элемента массива и установка 4-х пробелов
                    System.Console.Write($" {PhoneBook[j, i]} ");
                    System.Console.Write("    ");


                }
                System.Console.WriteLine();
            }

        }
    }
}
