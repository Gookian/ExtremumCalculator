using System;

namespace ExtremumCalculator
{
    /// <summary>
    /// Класс поиска экстумума.
    /// </summary>
    class CalculatorExtremum
    {
        private IExtremumMethod method;

        /// <summary>
        /// Свойство: метод поиска
        /// </summary>
        public IExtremumMethod Method
        {
            get
            {
                return method;
            }

            set
            {
                method = value;
            }
        }

        /// <summary>
        /// Конструктор класса по умолчанию.
        /// </summary>
        public CalculatorExtremum()
        {
            this.method = new GoldenSection();
        }

        /// <summary>
        /// Конструктор класса для задания метода поиска.
        /// </summary>
        /// <param name="method">Метод поиска</param>
        public CalculatorExtremum(IExtremumMethod method)
        {
            this.method = method;
        }

        /// <summary>
        /// Метод поиска максимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="esp">Заданная точность.</param>
        /// <returns>Метод возвращает значение максимума функции с заданной точностью.</returns>
        public double GetMax(Func<double, double> func, double a, double b, double esp)
        {
            return method.GetMax(func, a, b, esp);
        }

        /// <summary>
        /// Метод поиска максимума функции на заданом отрезке в зависимости от переданного метода поиска.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="esp">Заданная точность.</param>
        /// <param name="method">Метод поиска.</param>
        /// <returns>Метод возвращает значение максимума функции с заданной точностью.</returns>
        public double GetMax(Func<double, double> func, double a, double b, double esp, IExtremumMethod method)
        {
            return method.GetMax(func, a, b, esp);
        }

        /// <summary>
        /// Метод поиска минимума функции на заданом отрезке.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="esp">Заданная точность.</param>
        /// <returns>Метод возвращает значение минимума функции с заданной точностью.</returns>
        public double GetMin(Func<double, double> func, double a, double b, double esp)
        {
            return method.GetMin(func, a, b, esp);
        }

        /// <summary>
        /// Метод поиска минимума функции на заданом отрезке в зависимости от переданного метода поиска.
        /// </summary>
        /// <param name="func">Заданая функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="esp">Заданная точность.</param>
        /// <param name="method">Метод поиска.</param>
        /// <returns>Метод возвращает значение минимума функции с заданной точностью.</returns>
        public double GetMin(Func<double, double> func, double a, double b, double esp, IExtremumMethod method)
        {
            return method.GetMin(func, a, b, esp);
        }
    }
}
