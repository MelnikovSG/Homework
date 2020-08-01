using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static int MinNumbers()
        {
            /*
            Написать метод, возвращающий минимальное из трёх чисел.
            Мельников Сергей
           */

            int firstN, secondN, thirdN;

            Console.WriteLine("Введите первое число: ");
            firstN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            secondN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            thirdN = Convert.ToInt32(Console.ReadLine());

            int min;

            if(firstN < secondN && firstN < thirdN)
            {
                min = firstN;
            } else if (secondN < thirdN && secondN < firstN)
            {
                min = secondN;
            } else
            {
                min = thirdN;
            }
            return min;

        }
        static void Main(string[] args)
        {

            Console.WriteLine($"Наименьшее из трех чисел равно {MinNumbers()}");
            Console.ReadLine();
            
        }
    }
}
