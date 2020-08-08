using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    class ClassArray
    {
        public int[] array; // поле массив

        /// <summary>
        /// Конструктор инициализации массива
        /// </summary>
        /// <param name="length">Длина массива</param>
        public ClassArray(int length)
        {
            array = new int[length];
        }

        /// <summary>
        /// Конструктор заполняющий массив случайными числами
        /// </summary>
        /// <param name="length">длинна массива</param>
        /// <param name="min">минимальноке число</param>
        /// <param name="max">максимальное числа</param>
        public ClassArray(int length, int min, int max) :
            this(length) //обращение к конструктору для инициализации массива
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
        }

        /// <summary>
        /// Печать массива
        /// </summary>
        public void ShowArray()
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Метод находящий количество пар элементов массива, в которых хотя бы одно число делится на 3
        /// </summary>
        /// <returns>Количество пар, в которых хотя бы одно число делится на 3 </returns>
        public int PairOfDivThree()
        {
            int pairCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                    pairCount++;
            return pairCount;
        }
    }
}
