
// Задание 1. 
// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
// Мельников Сергей

namespace Complex
{
    public class CComplex
    {
        private double im;
        double re;

        /// <summary> Конструктор без параметров</summary>
        public CComplex()
        {
            im = 0;
            re = 0;
        }
        // Конструктор с параметрами
        // im - Мнимая часть
        // re - Вещественная часть
        
        public CComplex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        // Метод сложения с другим комплексным числом 
        // x2 - Комплексное число для сложения
        
        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        // Метод разности с другим комплексным числом 
        // x2 - Комплексное число для разности
        
        public CComplex Minus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        // Метод произведения с другим комплексным числом 
        // x2 - Комплексное число для произведения
       
        public CComplex Multi(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        // Свойство для мнимой части
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        //Метод представления комплексного числа в удобной форме
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }
}