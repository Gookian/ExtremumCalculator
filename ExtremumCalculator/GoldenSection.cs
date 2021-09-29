using System;
using System.Drawing;

namespace ExtremumCalculator
{
    class GoldenSection : IExtremumMethod
    {
        private const double PHI = 1.6180339887498948482;

        private PointF coord = Point.Empty;
        
        /// <summary>
        /// Свойство: коорднаты минимума или максимума
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
        /// Метод поиска максимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="eps">Заданная точность.</param>
        /// <returns>Метод возвращает значение максимуа функции с заданной точностью.</returns>
        public double GetMax(Func<double, double> func, double a, double b, double eps)
        {
            double x1;
            double x2;

            while (!(Math.Abs(b - a) < eps))
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;

                if (func(x1) <= func(x2))
                    a = x1;
                else
                    b = x2;
            }

            coord = new PointF((float)(a + b) / 2, (float)func((a + b) / 2));

            return (a + b) / 2;
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
            double x1;
            double x2;

            while (!(Math.Abs(b - a) < eps))
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;

                if (func(x1) >= func(x2))
                    a = x1;
                else
                    b = x2;
            }

            coord = new PointF((float)(a + b) / 2, (float)func((a + b) / 2));

            return (a + b) / 2;
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
