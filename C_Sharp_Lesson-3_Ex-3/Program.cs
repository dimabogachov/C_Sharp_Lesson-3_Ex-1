using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_3_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запрос у пользователя ввода слова и сохранение его в тип string
            Console.WriteLine("Введите Слово");
            string Word = Console.ReadLine();

            //Перевод типа String  в массив типа char
            char[] Reverse = Word.ToCharArray();

            //Запуск цикла с перебором элементов массива типа char, индекс первого определяется как количество символов минус единица


            for (int i = Reverse.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write(Reverse[i]);// построчный вывод каждого символа строки

            }
            Console.WriteLine();
        }
    }
}
