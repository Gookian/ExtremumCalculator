
namespace ExtremumCalculator
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.barGrid = new System.Windows.Forms.TrackBar();
            this.labelGrid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEPS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioGoldSection = new System.Windows.Forms.RadioButton();
            this.radioHalfDivision = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioMin = new System.Windows.Forms.RadioButton();
            this.radioMax = new System.Windows.Forms.RadioButton();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioFunction1 = new System.Windows.Forms.RadioButton();
            this.radioFunction2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.schedule1 = new ExtremumCalculator.Schedule();
            ((System.ComponentModel.ISupportInitialize)(this.barGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // barGrid
            // 
            this.barGrid.Location = new System.Drawing.Point(338, 12);
            this.barGrid.Maximum = 1000;
            this.barGrid.Minimum = 3;
            this.barGrid.Name = "barGrid";
            this.barGrid.Size = new System.Drawing.Size(627, 45);
            this.barGrid.TabIndex = 1;
            this.barGrid.Value = 20;
            this.barGrid.Scroll += new System.EventHandler(this.barGrid_Scroll);
            // 
            // labelGrid
            // 
            this.labelGrid.AutoSize = true;
            this.labelGrid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrid.Location = new System.Drawing.Point(971, 12);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(25, 19);
            this.labelGrid.TabIndex = 2;
            this.labelGrid.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Входные данные:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите интервал: [";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(222, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = ",";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(157, 74);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(64, 26);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.Text = "-1";
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(236, 74);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(64, 26);
            this.textBoxB.TabIndex = 8;
            this.textBoxB.Text = "1";
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Точность:";
            // 
            // textBoxEPS
            // 
            this.textBoxEPS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEPS.Location = new System.Drawing.Point(92, 114);
            this.textBoxEPS.Name = "textBoxEPS";
            this.textBoxEPS.Size = new System.Drawing.Size(208, 26);
            this.textBoxEPS.TabIndex = 10;
            this.textBoxEPS.Text = "0,1";
            this.textBoxEPS.TextChanged += new System.EventHandler(this.textBoxEPS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Выбор метода нахождения:";
            // 
            // radioGoldSection
            // 
            this.radioGoldSection.AutoSize = true;
            this.radioGoldSection.Checked = true;
            this.radioGoldSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioGoldSection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioGoldSection.Location = new System.Drawing.Point(16, 19);
            this.radioGoldSection.Name = "radioGoldSection";
            this.radioGoldSection.Size = new System.Drawing.Size(191, 23);
            this.radioGoldSection.TabIndex = 12;
            this.radioGoldSection.TabStop = true;
            this.radioGoldSection.Text = "Метод золотого сечения";
            this.radioGoldSection.UseVisualStyleBackColor = true;
            this.radioGoldSection.CheckedChanged += new System.EventHandler(this.radioGoldSection_CheckedChanged);
            // 
            // radioHalfDivision
            // 
            this.radioHalfDivision.AutoSize = true;
            this.radioHalfDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioHalfDivision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioHalfDivision.Location = new System.Drawing.Point(15, 48);
            this.radioHalfDivision.Name = "radioHalfDivision";
            this.radioHalfDivision.Size = new System.Drawing.Size(223, 23);
            this.radioHalfDivision.TabIndex = 13;
            this.radioHalfDivision.Text = "Метод половинного деления";
            this.radioHalfDivision.UseVisualStyleBackColor = true;
            this.radioHalfDivision.CheckedChanged += new System.EventHandler(this.radioHalfDivision_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Что нужно найти:";
            // 
            // radioMin
            // 
            this.radioMin.AutoSize = true;
            this.radioMin.Checked = true;
            this.radioMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioMin.Location = new System.Drawing.Point(15, 19);
            this.radioMin.Name = "radioMin";
            this.radioMin.Size = new System.Drawing.Size(94, 23);
            this.radioMin.TabIndex = 15;
            this.radioMin.TabStop = true;
            this.radioMin.Text = "Минимум";
            this.radioMin.UseVisualStyleBackColor = true;
            this.radioMin.CheckedChanged += new System.EventHandler(this.radioMin_CheckedChanged);
            // 
            // radioMax
            // 
            this.radioMax.AutoSize = true;
            this.radioMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioMax.Location = new System.Drawing.Point(15, 48);
            this.radioMax.Name = "radioMax";
            this.radioMax.Size = new System.Drawing.Size(97, 23);
            this.radioMax.TabIndex = 16;
            this.radioMax.Text = "Максимум";
            this.radioMax.UseVisualStyleBackColor = true;
            this.radioMax.CheckedChanged += new System.EventHandler(this.radioMax_CheckedChanged);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuild.Location = new System.Drawing.Point(106, 543);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(99, 39);
            this.buttonBuild.TabIndex = 17;
            this.buttonBuild.Text = "Построить";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGoldSection);
            this.groupBox1.Controls.Add(this.radioHalfDivision);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 84);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMin);
            this.groupBox2.Controls.Add(this.radioMax);
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 84);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioFunction1);
            this.groupBox3.Controls.Add(this.radioFunction2);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 84);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // radioFunction1
            // 
            this.radioFunction1.AutoSize = true;
            this.radioFunction1.Checked = true;
            this.radioFunction1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioFunction1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioFunction1.Location = new System.Drawing.Point(15, 19);
            this.radioFunction1.Name = "radioFunction1";
            this.radioFunction1.Size = new System.Drawing.Size(49, 23);
            this.radioFunction1.TabIndex = 15;
            this.radioFunction1.TabStop = true;
            this.radioFunction1.Text = "x^2";
            this.radioFunction1.UseVisualStyleBackColor = true;
            this.radioFunction1.CheckedChanged += new System.EventHandler(this.radioFunction1_CheckedChanged);
            // 
            // radioFunction2
            // 
            this.radioFunction2.AutoSize = true;
            this.radioFunction2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioFunction2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioFunction2.Location = new System.Drawing.Point(15, 48);
            this.radioFunction2.Name = "radioFunction2";
            this.radioFunction2.Size = new System.Drawing.Size(148, 23);
            this.radioFunction2.TabIndex = 16;
            this.radioFunction2.Text = "(x + 1)^3 + 5 * x^2";
            this.radioFunction2.UseVisualStyleBackColor = true;
            this.radioFunction2.CheckedChanged += new System.EventHandler(this.radioFunction2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Функции:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(334, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Результат расчета:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(334, 589);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 23);
            this.error.TabIndex = 23;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(334, 532);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 23);
            this.labelResult.TabIndex = 25;
            // 
            // schedule1
            // 
            this.schedule1.BackColor = System.Drawing.Color.LightCyan;
            this.schedule1.GridSize = 20;
            this.schedule1.Location = new System.Drawing.Point(338, 54);
            this.schedule1.Name = "schedule1";
            this.schedule1.Points = new System.Drawing.PointF[] {
        ((System.Drawing.PointF)(resources.GetObject("schedule1.Points"))),
        ((System.Drawing.PointF)(resources.GetObject("schedule1.Points1")))};
            this.schedule1.Size = new System.Drawing.Size(727, 421);
            this.schedule1.TabIndex = 24;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 630);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.schedule1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEPS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGrid);
            this.Controls.Add(this.barGrid);
            this.Name = "ApplicationForm";
            this.Text = "Калькулятор экстремума";
            ((System.ComponentModel.ISupportInitialize)(this.barGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar barGrid;
        private System.Windows.Forms.Label labelGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioGoldSection;
        private System.Windows.Forms.RadioButton radioHalfDivision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioMin;
        private System.Windows.Forms.RadioButton radioMax;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioFunction1;
        private System.Windows.Forms.RadioButton radioFunction2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label error;
        private Schedule schedule1;
        private System.Windows.Forms.Label labelResult;
    }
}

