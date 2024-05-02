using System.Collections.Generic;

namespace Calculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGr = new System.Windows.Forms.Panel();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuildGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBStep = new System.Windows.Forms.TextBox();
            this.labelCoeff0 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panelGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.panelGr);
            this.groupBox2.Controls.Add(this.btnBuildGraph);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(524, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panelGr
            // 
            this.panelGr.Controls.Add(this.textBoxXMin);
            this.panelGr.Controls.Add(this.textBoxYMax);
            this.panelGr.Controls.Add(this.textBoxXMax);
            this.panelGr.Controls.Add(this.textBoxYMin);
            this.panelGr.Controls.Add(this.chart);
            this.panelGr.Location = new System.Drawing.Point(7, 55);
            this.panelGr.Name = "panelGr";
            this.panelGr.Size = new System.Drawing.Size(510, 331);
            this.panelGr.TabIndex = 12;
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.Location = new System.Drawing.Point(4, 308);
            this.textBoxXMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXMin.MaxLength = 5;
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.Size = new System.Drawing.Size(43, 23);
            this.textBoxXMin.TabIndex = 4;
            this.textBoxXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxXMin.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxXMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(462, 0);
            this.textBoxYMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYMax.MaxLength = 5;
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(43, 23);
            this.textBoxYMax.TabIndex = 7;
            this.textBoxYMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYMax.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxYMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(411, 308);
            this.textBoxXMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXMax.MaxLength = 5;
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(43, 23);
            this.textBoxXMax.TabIndex = 5;
            this.textBoxXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxXMax.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.Location = new System.Drawing.Point(462, 277);
            this.textBoxYMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYMin.MaxLength = 5;
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.Size = new System.Drawing.Size(43, 23);
            this.textBoxYMin.TabIndex = 6;
            this.textBoxYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYMin.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxYMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.Crossing = 0D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisY.Crossing = 0D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(4, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Indigo;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Func";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(450, 300);
            this.chart.TabIndex = 0;
            this.chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.chart.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            // 
            // btnBuildGraph
            // 
            this.btnBuildGraph.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuildGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuildGraph.Location = new System.Drawing.Point(7, 18);
            this.btnBuildGraph.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuildGraph.Name = "btnBuildGraph";
            this.btnBuildGraph.Size = new System.Drawing.Size(237, 30);
            this.btnBuildGraph.TabIndex = 0;
            this.btnBuildGraph.Text = "Построить график";
            this.btnBuildGraph.UseVisualStyleBackColor = false;
            this.btnBuildGraph.Click += new System.EventHandler(this.btnBuildGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBAngle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBStep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(524, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(327, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Угол (с):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(309, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Угол (без):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 51);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(231, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(231, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // tBAngle
            // 
            this.tBAngle.Location = new System.Drawing.Point(70, 20);
            this.tBAngle.Margin = new System.Windows.Forms.Padding(4);
            this.tBAngle.Name = "tBAngle";
            this.tBAngle.Size = new System.Drawing.Size(132, 23);
            this.tBAngle.TabIndex = 1;
            this.tBAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шаг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Угол:";
            // 
            // tBStep
            // 
            this.tBStep.Location = new System.Drawing.Point(70, 51);
            this.tBStep.Margin = new System.Windows.Forms.Padding(4);
            this.tBStep.Name = "tBStep";
            this.tBStep.Size = new System.Drawing.Size(132, 23);
            this.tBStep.TabIndex = 3;
            this.tBStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelCoeff0
            // 
            this.labelCoeff0.AutoSize = true;
            this.labelCoeff0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff0.Location = new System.Drawing.Point(784, 15);
            this.labelCoeff0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoeff0.Name = "labelCoeff0";
            this.labelCoeff0.Size = new System.Drawing.Size(0, 17);
            this.labelCoeff0.TabIndex = 17;
            this.labelCoeff0.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(252, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Найти наилучшие уголы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 502);
            this.Controls.Add(this.labelCoeff0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(540, 39);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение задач по дифф уравнениям";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox2.ResumeLayout(false);
            this.panelGr.ResumeLayout(false);
            this.panelGr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label labelCoeff0;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Button btnBuildGraph;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBAngle;
        private System.Windows.Forms.Panel panelGr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

