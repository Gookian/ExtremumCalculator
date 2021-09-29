using System;
using System.Drawing;

namespace ExtremumCalculator
{
    /// <summary>
    /// Интерфейс для реализации метода вычисления.
    /// </summary>
    interface IExtremumMethod
    {
        /// <summary>
        /// Метод поиска максимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="eps">Заданная точность.</param>
        /// <returns>Метод возвращает значение максимуа функции с заданной точностью.</returns>
        double GetMax(Func<double, double> func, double a, double b, double eps);

        /// <summary>
        /// Метод поиска минимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="eps">Заданная точность.</param>
        /// <returns>Метод возвращает значение минимума функции с заданной точностью.</returns>
        double GetMin(Func<double, double> func, double a, double b, double eps);

        /// <summary>
        /// Метод получения точки найденного минимума или максимума функции.
        /// </summary>
        /// <returns>Метод возвращает точку.</returns>
        PointF GetPoint();
    }
}
