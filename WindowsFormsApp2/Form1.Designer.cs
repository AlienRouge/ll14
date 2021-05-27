
namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.RelAver = new System.Windows.Forms.Label();
            this.RelVariance = new System.Windows.Forms.Label();
            this.ResChi = new System.Windows.Forms.Label();
            this.MeanValue = new System.Windows.Forms.NumericUpDown();
            this.DispersValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfExper = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispersValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(189, 27);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(402, 329);
            this.chart1.TabIndex = 0;
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.BorderWidth = 10;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Probability";
            this.chart1.Titles.Add(title2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of experiments:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(39, 94);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 38);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(9, 396);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 15;
            // 
            // RelAver
            // 
            this.RelAver.AutoSize = true;
            this.RelAver.Location = new System.Drawing.Point(32, 305);
            this.RelAver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RelAver.Name = "RelAver";
            this.RelAver.Size = new System.Drawing.Size(0, 13);
            this.RelAver.TabIndex = 16;
            // 
            // RelVariance
            // 
            this.RelVariance.AutoSize = true;
            this.RelVariance.Location = new System.Drawing.Point(32, 329);
            this.RelVariance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RelVariance.Name = "RelVariance";
            this.RelVariance.Size = new System.Drawing.Size(0, 13);
            this.RelVariance.TabIndex = 17;
            // 
            // ResChi
            // 
            this.ResChi.AutoSize = true;
            this.ResChi.Location = new System.Drawing.Point(32, 356);
            this.ResChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResChi.Name = "ResChi";
            this.ResChi.Size = new System.Drawing.Size(0, 13);
            this.ResChi.TabIndex = 18;
            // 
            // MeanValue
            // 
            this.MeanValue.DecimalPlaces = 2;
            this.MeanValue.Location = new System.Drawing.Point(95, 209);
            this.MeanValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MeanValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.MeanValue.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.MeanValue.Name = "MeanValue";
            this.MeanValue.Size = new System.Drawing.Size(55, 20);
            this.MeanValue.TabIndex = 19;
            this.MeanValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // DispersValue
            // 
            this.DispersValue.DecimalPlaces = 2;
            this.DispersValue.Location = new System.Drawing.Point(95, 252);
            this.DispersValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DispersValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.DispersValue.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.DispersValue.Name = "DispersValue";
            this.DispersValue.Size = new System.Drawing.Size(55, 20);
            this.DispersValue.TabIndex = 20;
            this.DispersValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Despersia";
            // 
            // NumberOfExper
            // 
            this.NumberOfExper.FormattingEnabled = true;
            this.NumberOfExper.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.NumberOfExper.Location = new System.Drawing.Point(62, 48);
            this.NumberOfExper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberOfExper.Name = "NumberOfExper";
            this.NumberOfExper.Size = new System.Drawing.Size(52, 21);
            this.NumberOfExper.TabIndex = 23;
            this.NumberOfExper.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 418);
            this.Controls.Add(this.NumberOfExper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DispersValue);
            this.Controls.Add(this.MeanValue);
            this.Controls.Add(this.ResChi);
            this.Controls.Add(this.RelVariance);
            this.Controls.Add(this.RelAver);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispersValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label RelAver;
        private System.Windows.Forms.Label RelVariance;
        private System.Windows.Forms.Label ResChi;
        private System.Windows.Forms.NumericUpDown MeanValue;
        private System.Windows.Forms.NumericUpDown DispersValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberOfExper;
    }
}

