using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ArtemihinND.Sprint1.Task6.V18.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Артемихин Н. Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Артемихин Никита Дмитриевич | ПКТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Работа со строками класс String                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            if (IsNaturalNumber(input))
            {
                Console.WriteLine("Строка является натуральным числом.");
            }
            else
            {
                Console.WriteLine("Строка НЕ является натуральным числом.");
            }
        }

        static bool IsNaturalNumber(string str)
        {
            
            if (string.IsNullOrWhiteSpace(str))
                return false;

            
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            
            if (int.TryParse(str, out int number))
            {
                return number > 0;
            }

            return false;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            string input = Console.ReadLine();



        }
    }
}
