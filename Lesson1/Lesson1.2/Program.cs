using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            
            Мельников Сергей
            */

            double x1, y1, x2, y2;

            Console.WriteLine("Введите значение координаты x1");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты y1");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты x2");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение координаты y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            var result = Math.Round(r, 2);

            Console.WriteLine("Расстояние между точками равно " + result);
            Console.ReadLine();
            


        }
    }
}
