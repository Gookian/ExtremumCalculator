using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtremumCalculator
{
    public partial class ApplicationForm : Form
    {
        private IExtremumMethod method = new GoldenSection();
        private CalculatorExtremum calculator = new CalculatorExtremum();
        private Func<double, double> function = Function1;
        private bool isFindMin = true;
        private double a = -1;
        private double b = 1;
        private double esp = 0.1;
        private double result = 0;
        private int sizeGrid = 20;

        public ApplicationForm()
        {
            InitializeComponent();
            schedule1.GridSize = sizeGrid;
            schedule1.Points = GetPointF(function, -8f, 8f, schedule1.GridSize, 0.001f);
        }
        
        private static double Function1(double x)
        {
            return Math.Pow(x, 2);
        }

        private static double Function2(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
        }

        public static PointF[] GetPointF(Func<double, double> func, float a, float b, float step, float esp)
        {
            List<PointF> pointsList = new List<PointF>();
            for (float i = a; i <= b; i += esp)
            {
                if (func(i) < 4000000 && func(i) > -4000000)
                    pointsList.Add(new PointF(i * step, -(float)func(i) * step));
            }
            PointF[] points = new PointF[pointsList.Count];
            for (int i = 0; i < pointsList.Count; i++)
            {
                points[i] = pointsList[i];
            }
            return points;
        }

        private void radioGoldSection_CheckedChanged(object sender, EventArgs e)
        {
            method = new GoldenSection();
        }

        private void radioHalfDivision_CheckedChanged(object sender, EventArgs e)
        {
            method = new HalfDivision();
        }

        private void radioFunction1_CheckedChanged(object sender, EventArgs e)
        {
            function = Function1;
        }

        private void radioFunction2_CheckedChanged(object sender, EventArgs e)
        {
            function = Function2;
        }

        private void radioMin_CheckedChanged(object sender, EventArgs e)
        {
            isFindMin = true;
        }

        private void radioMax_CheckedChanged(object sender, EventArgs e)
        {
            isFindMin = false;
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                a = Convert.ToDouble(textBoxA.Text);
                error.Text = "";
            }
            catch
            {
                error.Text = "Значение в поле A введено не верно (числа с плавающей точкой вводятся через \",\")";
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBoxB.Text);
                error.Text = "";
            }
            catch
            {
                error.Text = "Значение в поле B введено не верно (числа с плавающей точкой вводятся через \",\")";
            }
        }

        private void textBoxEPS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                esp = Convert.ToDouble(textBoxEPS.Text);
                error.Text = "";
            }
            catch
            {
                error.Text = "Значение в поле EPS введено не верно (числа с плавающей точкой вводятся через \",\")";
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            schedule1.pointsRoot.Clear();
            schedule1.Refresh();

            if (isFindMin == true)
            {
                result = calculator.GetMin(function, a, b, esp, method);
            }
            else
            {
                result = calculator.GetMax(function, a, b, esp, method);
            }

            schedule1.GridSize = sizeGrid;
            schedule1.Points = GetPointF(function, -8f, 8f, schedule1.GridSize, 0.001f);
            schedule1.pointsRoot.Add(method.GetPoint());
            schedule1.Refresh();

            labelResult.Text = String.Format("x: {0}\nf({0}) = {1}", result, function(result));
        }

        private void barGrid_Scroll(object sender, EventArgs e)
        {
            sizeGrid = barGrid.Value;

            schedule1.GridSize = sizeGrid;
            schedule1.Points = GetPointF(function, -8f, 8f, schedule1.GridSize, 0.001f);
            schedule1.pointsRoot.Add(method.GetPoint());
            schedule1.Refresh();

            labelGrid.Text = Convert.ToString(sizeGrid);
        }
    }
}
