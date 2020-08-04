
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDataWithExeption
{
    class Program
        {
            static void Main(string[] args)
            {
             // Задание 2
             //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
             //Сами числа и сумму вывести на экран, используя tryParse;
             //Мельников Сергей
            

                int sum = 0;
                string num = "0";
                int n;
                Console.WriteLine("Вас приветствует программа подсчета суммы нечетных чисел. Вводите числа по одному. Для завершения введите 0");

            do
                {
                    Console.WriteLine("Введите число:");
                    num = (Console.ReadLine());
                    int.TryParse(num, out n);                                        
                                      
                    if (n > 0 && n % 2 == 1)
                    sum += n;

                } while (n != 0);

                Console.WriteLine("Сумма нечетных чисел равна " + sum);
                Console.ReadLine();
            }
        }
    }