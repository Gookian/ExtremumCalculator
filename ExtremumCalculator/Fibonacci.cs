using System;
using System.Drawing;

namespace ExtremumCalculator
{
    /// <summary>
    /// Класс поиска экстумума методом фибоначи.
    /// </summary>
    class Fibonacci : IExtremumMethod
    {
        private PointF coord = Point.Empty;

        /// <summary>
        /// Свойство: коорднаты минимума или максимума.
        /// </summary>
        public PointF Coord
        {
            get
            {
                return coord;
            }

            private set
            {
                coord = value;
            }
        }

        /// <summary>
        /// Метод подсчета числа фибаначи.
        /// </summary>
        /// <param name="number">Порядковый номер числа.</param>
        /// <returns>Метод возвращает число фибоначи.</returns>
        private int Fib(int number)
        {
            if (number == 0) return 0; 
            if (number == 1) return 1; 

            return Fib(number - 1) + Fib(number - 2);
        }

        /// <summary>
        /// Метод поиска максимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="eps">Заданная точность.</param>
        /// <returns>Метод возвращает значение максимуа функции с заданной точностью.</returns>
        public double GetMax(Func<double, double> func, double a, double b, double eps)
        {
            // Реализации еще нет
            return 0;
        }

        /// <summary>
        /// Метод поиска минимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="eps">Заданная точность.</param>
        /// <returns>Метод возвращает значение минимума функции с заданной точностью.</returns>
        public double GetMin(Func<double, double> func, double a, double b, double eps)
        {
            // Реализации еще нет
            return 0;
        }

        /// <summary>
        /// Метод получения точки найденного минимума или максимума функции.
        /// </summary>
        /// <returns>Метод возвращает точку.</returns>
        public PointF GetPoint()
        {
            return coord;
        }
    }
}
