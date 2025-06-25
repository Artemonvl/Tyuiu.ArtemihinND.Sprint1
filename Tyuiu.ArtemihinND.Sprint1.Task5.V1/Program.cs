using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ArtemihinND.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Артемихин Н. Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Артемихин Никита Дмитриевич | ПКТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расчёт расстояния между двумя точками (x1, y1) и (x2, y2)");

            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int distance = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками: {distance}");
            Console.ReadKey();
        }
    }
}
