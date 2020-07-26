using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
            по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            
            Мельников Сергей
            */

            Console.WriteLine("Добрый день! Давайте с Вами расчитаем индекс массы Вашего тела.");
            Double m;
            Double h;

            Console.WriteLine("Укажите Ваш вес: ");        
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Укажите Ваш рост: ");
            h = Convert.ToDouble(Console.ReadLine());

            Double I = m / (h * h);
            var result = Math.Round(I, 5);
            
            Console.WriteLine("Индекс массы Вашего тела равен " + result);
            Console.ReadLine();

        }
    }
}
