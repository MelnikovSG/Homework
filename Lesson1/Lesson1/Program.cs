using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
            В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.

            Мельников Сергей*/

            string firstName, lastName, age, height, weight;

            Console.WriteLine("Добрый день! Это анкета пользователя ученика образовательного портала Geekbrains. Далее необходимо ввести Ваши данные.");

            Console.WriteLine("Введите Ваше имя:");
            firstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            lastName = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст:");
            age = Console.ReadLine();

            Console.WriteLine("Введите Ваш рост:");
            height = Console.ReadLine();

            Console.WriteLine("Введите Ваш вес:");
            weight = Console.ReadLine();

            // задание а)

            Console.WriteLine("Проверьте свои данные: " + firstName + " " + lastName + ", " + age + ", " + height + ", " + weight + ".");
            Console.ReadLine();

            // задание б)

            // Не могу разобраться почему не работает
            /*
            string person = firstName + lastName + age + height + weight;
            string result = String.Format("{0: # #, #, #, #.}", person);
            Console.WriteLine(result);
            Console.ReadLine();
            */

            // задание в)

            string result = $"{firstName} {lastName}, {age}, {height}, {weight}.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
