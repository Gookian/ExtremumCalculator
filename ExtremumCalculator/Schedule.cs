using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System;

namespace ExtremumCalculator
{
    /// <summary>
    /// Класс компонента который отрисовывает график функции.
    /// </summary>
    public partial class Schedule : UserControl
    {
        private Font font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Regular, GraphicsUnit.Pixel);
        private SolidBrush colorFont = new SolidBrush(Color.BlueViolet);
        private SolidBrush defaultColor = new SolidBrush(Color.Transparent);
        private Pen lightLine = new Pen(Color.LightGray, 1f);
        private Pen greyLine = new Pen(Color.Gray, 1f);
        private Pen penColor = new Pen(Color.BlueViolet, 2f);
        private PointF[] points = { new PointF(0, 0), new PointF(0, 0) };
        private PointF center;
        private Size size;
        private int gridSize = 20;

        public List<PointF> pointsRoot = new List<PointF>();

        /// <summary>
        /// Свойство: точки для отрисовки функции.
        /// </summary>
        [DisplayName("Points")]
        [Description("Точки графика функции")]
        public PointF[] Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
                Refresh();
            }
        }

        /// <summary>
        /// Свойство: размер компонента.
        /// </summary>
        [DisplayName("Size")]
        [Description("Размер")]
        public new Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                Width = value.Width;
                Height = value.Height;
                Refresh();
            }
        }

        /// <summary>
        /// Свойство: размер сетки.
        /// </summary>
        [DisplayName("gridSize")]
        [Description("Размер сетки")]
        public int GridSize
        {
            get
            {
                return gridSize;
            }

            set
            {
                gridSize = value;
                Refresh();
            }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Schedule()
        {
            InitializeComponent();
            InitializeGraphics();
            InitializePen();

            center = new PointF(size.Width / 2, size.Height / 2);

            this.Resize += ResizeControl;
        }

        /// <summary>
        /// Инициализация графики.
        /// </summary>
        private void InitializeGraphics()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
        }

        /// <summary>
        /// Инициализация карандаша.
        /// </summary>
        private void InitializePen()
        {
            penColor.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            penColor.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
        }

        /// <summary>
        /// Метод приобразует координаты графика к центру.
        /// </summary>
        /// <param name="offsetX">Смещение по X.</param>
        /// <param name="offsetY">Смещение по Y.</param>
        /// <returns></returns>
        private PointF[] CoordinatesCenterShift(float offsetX, float offsetY)
        {
            PointF[] pointsBuffer = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                pointsBuffer[i] = new PointF(points[i].X + offsetX, points[i].Y + offsetY);
            }
            return pointsBuffer;
        }

        /// <summary>
        /// Метод отрисовывает сетку.
        /// </summary>
        /// <param name="graphics">Графический объект.</param>
        private void DrawGrid(Graphics graphics)
        {
            for (int i = 0; i < center.X / gridSize; i++)
            {
                float w1 = graphics.MeasureString(Convert.ToString(-i - 1), font).Width;
                float h1 = graphics.MeasureString(Convert.ToString(-i - 1), font).Height;
                float w2 = graphics.MeasureString(Convert.ToString(i + 1), font).Width;
                float h2 = graphics.MeasureString(Convert.ToString(i + 1), font).Height;

                if (i % 5 < 4)
                {
                    graphics.DrawLine(lightLine, new PointF(gridSize * -i + center.X - gridSize, 0), new PointF(gridSize * -i + center.X - gridSize, Height));
                    graphics.DrawLine(lightLine, new PointF(gridSize * i + center.X + gridSize, 0), new PointF(gridSize * i + center.X + gridSize, Height));
                }
                else
                {
                    graphics.DrawLine(greyLine, new PointF(gridSize * -i + center.X - gridSize, 0), new PointF(gridSize * -i + center.X - gridSize, Height));
                    graphics.DrawLine(greyLine, new PointF(gridSize * i + center.X + gridSize, 0), new PointF(gridSize * i + center.X + gridSize, Height));

                    graphics.FillRectangle(defaultColor, gridSize * -i + center.X - gridSize - w1 / 2, center.Y, w1, h1);
                    graphics.FillRectangle(defaultColor, gridSize * i + center.X + gridSize - w2 / 2, center.Y, w2, h2);

                    graphics.DrawString(Convert.ToString(-i - 1), font, colorFont, new PointF(gridSize * -i + center.X - gridSize - w1 / 2, center.Y));
                    graphics.DrawString(Convert.ToString(i + 1), font, colorFont, new PointF(gridSize * i + center.X + gridSize - w2 / 2, center.Y));
                }
            }

            for (int i = 0; i < center.Y / gridSize; i++)
            {
                float w1 = graphics.MeasureString(Convert.ToString(-i - 1), font).Width;
                float h1 = graphics.MeasureString(Convert.ToString(-i - 1), font).Height;
                float w2 = graphics.MeasureString(Convert.ToString(i + 1), font).Width;
                float h2 = graphics.MeasureString(Convert.ToString(i + 1), font).Height;

                if (i % 5 < 4)
                {
                    graphics.DrawLine(lightLine, new PointF(0, gridSize * -i + center.Y - gridSize), new PointF(Width, gridSize * -i + center.Y - gridSize));
                    graphics.DrawLine(lightLine, new PointF(0, gridSize * i + center.Y + gridSize), new PointF(Width, gridSize * i + center.Y + gridSize));
                }
                else
                {
                    graphics.DrawLine(greyLine, new PointF(0, gridSize * -i + center.Y - gridSize), new PointF(Width, gridSize * -i + center.Y - gridSize));
                    graphics.DrawLine(greyLine, new PointF(0, gridSize * i + center.Y + gridSize), new PointF(Width, gridSize * i + center.Y + gridSize));

                    graphics.FillRectangle(defaultColor, center.X - w2, gridSize * -i + center.Y - gridSize - h2 / 2, w2, h2);
                    graphics.FillRectangle(defaultColor, center.X - w1, gridSize * i + center.Y + gridSize - h1 / 2, w1, h1);

                    graphics.DrawString(Convert.ToString(i + 1), font, colorFont, new PointF(center.X - w2, gridSize * -i + center.Y - gridSize - h2 / 2));
                    graphics.DrawString(Convert.ToString(-i - 1), font, colorFont, new PointF(center.X - w1, gridSize * i + center.Y + gridSize - h1 / 2));
                }
            }
        }

        /// <summary>
        /// Метод отрисовывает оси координат.
        /// </summary>
        /// <param name="graphics">Графический объект.</param>
        private void DrawAxes(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color.Red, 1f), new PointF(center.X, Height), new PointF(center.X, 0));
            graphics.DrawLine(new Pen(Color.Blue, 1f), new PointF(0, center.Y), new PointF(Width, center.Y));
        }

        /// <summary>
        /// Метод отрисовывает все корни функции.
        /// </summary>
        /// <param name="graphics">Графический объект.</param>
        private void DrawPointsRoot(Graphics graphics)
        {
            float radius = 3;
            PointF pointBuffer;
            foreach (PointF point in pointsRoot)
            {
                pointBuffer = new PointF(point.X * gridSize + center.X, point.Y * -gridSize + center.Y);
                graphics.FillEllipse(new SolidBrush(Color.Green), new RectangleF(pointBuffer.X - radius, pointBuffer.Y - radius, radius * 2, radius * 2));
            }
        }

        /// <summary>
        /// Метод обнавляет размеры компонента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResizeControl(object sender, EventArgs e)
        {
            size.Width = this.Width;
            size.Height = this.Height;

            center = new Point(this.Width / 2, this.Height / 2);
        }

        /// <summary>
        /// Переопределенный метод отрисовки.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            graphics.Clear(this.BackColor);

            DrawGrid(graphics);
            DrawAxes(graphics);

            graphics.DrawLines(penColor, CoordinatesCenterShift(center.X, center.Y));

            DrawPointsRoot(graphics);
        }
    }
}
