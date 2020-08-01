using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
{
    class Program
    {
        static int CountN()
        {
            /* Написать метод подсчета количества цифр числа.
               Мельников Сергей
            */

            int n;

            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (n != 0)
            {
                n = n/10;
                count++;
                
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Количество цифр в числе равно {CountN()}");
            Console.ReadLine();
        }
    }
}
