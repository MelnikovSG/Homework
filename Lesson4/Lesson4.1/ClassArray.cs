using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson4._1
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
        /// Конструктор, который создает массив и заполняет его данными из файла
        /// </summary>
        /// <param name="filename">Имя файла, в котором находятся данные</param>
        public ClassArray(string filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                int length = int.Parse(sr.ReadLine());
                array = new int[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = int.Parse(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        /// <summary>
        /// Конструктор, заполняющий массив с определенным шагом
        /// </summary>
        /// <param name="length">Длинна массива</param>
        /// <param name="step">Шаг с которым заполняется массив</param>
        public ClassArray(int length, int step, int start) : this(length)
        {
            array[0] = start;
            for (int i = 1; i < length; i++)
            {
                array[i] = array[i - 1] + step;
            }
        }

        /// <summary>
        /// Свойство возвращающее сумму элементов массива
        /// </summary>
        public int SumOfArray
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                    sum += array[i];
                return sum;
            }
        }
        /// <summary>
        /// Метод, меняющий каждого элемента массива знак
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = -array[i];
        }

        /// <summary>
        /// Метод умножения каждого элемента массива на число
        /// </summary>
        /// <param name="mult">Чисо на которое хотим умножить</param>
        public void Multi(int mult)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] *= mult;
        }

        /// <summary>
        /// Свойство нахождения максимального элемента массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (max < array[i]) max = array[i];
                return max;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int maxCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max) maxCount++;
                }
                return maxCount;
            }
        }


        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        public void ShowArray(string msg)
        {
            try
            {
                Console.WriteLine(msg);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine(); Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Метод записи массива в файл
        /// </summary>
        /// <param name="filename">Имя файла, в который будут записаны данные массива</param>
        public void WriteFile(string filename)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename);
                sw.WriteLine(array.Length);
                for (int i = 0; i < array.Length; i++)
                    sw.WriteLine(array[i]);
                Console.WriteLine("Данные успешно сохранены");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}
