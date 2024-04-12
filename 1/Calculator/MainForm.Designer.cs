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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGr = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnScale = new System.Windows.Forms.Button();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuildGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTB = new System.Windows.Forms.Panel();
            this.tBVelocity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelCoeff0 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.panelGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.panelGr);
            this.groupBox2.Controls.Add(this.btnBuildGraph);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(524, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panelGr
            // 
            this.panelGr.Controls.Add(this.chart1);
            this.panelGr.Controls.Add(this.btnScale);
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
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.HighlightText;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.CursorX.LineColor = System.Drawing.Color.White;
            chartArea1.CursorX.LineWidth = 0;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSpacing = 1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(344, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "R";
            series1.ShadowColor = System.Drawing.Color.White;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(110, 100);
            this.chart1.TabIndex = 11;
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // btnScale
            // 
            this.btnScale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScale.Location = new System.Drawing.Point(108, 306);
            this.btnScale.Margin = new System.Windows.Forms.Padding(4);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(248, 25);
            this.btnScale.TabIndex = 10;
            this.btnScale.Text = "Масштаб по умолчанию";
            this.btnScale.UseVisualStyleBackColor = false;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
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
            this.textBoxXMin.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxXMin.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxXMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
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
            this.textBoxYMax.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxYMax.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxYMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
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
            this.textBoxXMax.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxXMax.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
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
            this.textBoxYMin.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxYMin.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxYMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.Crossing = 0D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(4, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.SlateBlue;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Func";
            this.chart.Series.Add(series2);
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
            this.btnBuildGraph.Text = "Построить графики";
            this.btnBuildGraph.UseVisualStyleBackColor = false;
            this.btnBuildGraph.Click += new System.EventHandler(this.btnBuildGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.panelTB);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(524, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panelTB
            // 
            this.panelTB.Controls.Add(this.tBVelocity);
            this.panelTB.Controls.Add(this.label3);
            this.panelTB.Controls.Add(this.tBLength);
            this.panelTB.Controls.Add(this.label2);
            this.panelTB.Controls.Add(this.tBStep);
            this.panelTB.Controls.Add(this.label1);
            this.panelTB.Location = new System.Drawing.Point(13, 21);
            this.panelTB.Name = "panelTB";
            this.panelTB.Size = new System.Drawing.Size(250, 85);
            this.panelTB.TabIndex = 0;
            // 
            // tBVelocity
            // 
            this.tBVelocity.Location = new System.Drawing.Point(111, 0);
            this.tBVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.tBVelocity.Name = "tBVelocity";
            this.tBVelocity.Size = new System.Drawing.Size(132, 23);
            this.tBVelocity.TabIndex = 0;
            this.tBVelocity.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tBVelocity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шаг:";
            // 
            // tBLength
            // 
            this.tBLength.Location = new System.Drawing.Point(111, 31);
            this.tBLength.Margin = new System.Windows.Forms.Padding(4);
            this.tBLength.Name = "tBLength";
            this.tBLength.Size = new System.Drawing.Size(132, 23);
            this.tBLength.TabIndex = 1;
            this.tBLength.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tBLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Длина нити:";
            // 
            // tBStep
            // 
            this.tBStep.Location = new System.Drawing.Point(111, 62);
            this.tBStep.Margin = new System.Windows.Forms.Padding(4);
            this.tBStep.Name = "tBStep";
            this.tBStep.Size = new System.Drawing.Size(132, 23);
            this.tBStep.TabIndex = 2;
            this.tBStep.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tBStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScale_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Скорость:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(13, 112);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirm.Size = new System.Drawing.Size(134, 30);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(13, 113);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.labelCoeff0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(540, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение задач по дифф уравнениям";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.panelGr.ResumeLayout(false);
            this.panelGr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelTB.ResumeLayout(false);
            this.panelTB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelCoeff0;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Button btnBuildGraph;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBStep;
        private System.Windows.Forms.TextBox tBLength;
        private System.Windows.Forms.TextBox tBVelocity;
        private System.Windows.Forms.Panel panelTB;
        private System.Windows.Forms.Panel panelGr;
    }
}

