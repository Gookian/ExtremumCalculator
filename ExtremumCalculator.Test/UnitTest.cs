using NUnit.Framework;
using System;

namespace ExtremumCalculator.Test
{
    [TestFixture(0.000000001)]
    public class Tests
    {
        private CalculatorExtremum CE;

        public double EPS { get; set; }

        public Tests(double eps)
        {
            EPS = eps;
        }

        public double Function1(double x) => Math.Pow(x, 2);

        public double Function2(double x) => Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);

        [SetUp]
        public void Setup()
        {
            CE = new CalculatorExtremum();
        }

        [Test]
        public void GetMax_CalculateValueByMethodGoldenSection_MaxValue()
        {
            var result1 = CE.GetMax(Function1, -5, 7, EPS, new GoldenSection());
            var result2 = CE.GetMax(Function2, -5, 7, EPS, new GoldenSection());

            Assert.That(result1 >= (7 - EPS) && result1 <= (7 + EPS));
            Assert.That(result2 >= (7 - EPS) && result2 <= (7 + EPS));
        }

        [Test]
        public void GetMin_CalculateValueByMethodGoldenSection_MinValue()
        {
            var result1 = CE.GetMin(Function1, -8, -1.5, EPS, new GoldenSection());
            var result2 = CE.GetMin(Function2, -8, -1.5, EPS, new GoldenSection());

            Assert.That(result1 >= (-1.5 - EPS) && result1 <= (-1.5 + EPS));
            Assert.That(result2 >= (-1.5 - EPS) && result2 <= (-1.5 + EPS));
        }

        [Test]
        public void GetMax_CalculateValueByMethodHalfDivision_MaxValue()
        {
            var result1 = CE.GetMax(Function1, -10, 1, EPS, new HalfDivision());
            var result2 = CE.GetMax(Function2, -10, 1, EPS, new HalfDivision());

            Assert.That(result1 >= (-9.999999998 - EPS) && result1 <= (-9.999999998 + EPS));
            Assert.That(result2 >= (-5.138732567 - EPS) && result2 <= (-5.138732567 + EPS));
        }

        [Test]
        public void GetMin_CalculateValueByMethodHalfDivision_MinValue()
        {
            var result1 = CE.GetMin(Function1, 2, 3, EPS, new HalfDivision());
            var result2 = CE.GetMin(Function2, 2, 3, EPS, new HalfDivision());

            Assert.That(result1 >= (2.000000001 - EPS) && result1 <= (2.000000001 + EPS));
            Assert.That(result2 >= (2.000000001 - EPS) && result2 <= (2.000000001 + EPS));
        }
    }
}