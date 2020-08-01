using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
              Мельников Сергей
            */

            int sum = 0;
            int num = 0;

            do
            {
                Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum = sum + num;

            } while (num != 0);

            Console.WriteLine("Сумма нечетных чисел равна " + sum);
            Console.ReadLine();
        }
    }
}
        