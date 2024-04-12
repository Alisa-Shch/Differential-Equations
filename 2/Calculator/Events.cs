using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (e.KeyChar == 45 && textBox.SelectionStart == 0) {; }
                else
                {
                    if (e.KeyChar == '.') e.KeyChar = ',';
                    if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    {
                        e.Handled = true;
                        MessageBox.Show("Только цифpы!");
                    }
                    if (e.KeyChar == 13)
                    {
                        if (textBox.Text.Length > 0 && textBox.Text != "-") SendKeys.Send("{TAB}");
                        else MessageBox.Show("Bведите число");
                    }
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (Verify()) btnConfirm.Visible = true;
        }

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                try
                {
                    if (textBox.Text.Length != 0 && textBox.Text != "-" && textBox.Text != "," && textBox.Text != "-,")
                    {
                        _scale[textBox] = Convert.ToDouble(textBox.Text);

                        chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
                        chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
                        chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
                        chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void textBoxScale_Click(object sender, EventArgs e)
        {
            if (sender is TextBox textBox) textBox.SelectAll(); 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _velocity = Convert.ToDouble(tBVelocity.Text);
                _angle = Convert.ToDouble(tBLength.Text);
                _angle *= Math.PI/180;
                _step = Convert.ToDouble(tBStep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            btnScale_Click(sender, e);
            chart.Series.Clear();
            chart.Legends.Clear();

            _graph2.Points.Clear();
            _graph.Points.Clear();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            double Vx = _velocity*Math.Cos(_angle), Vy = _velocity*Math.Sin(_angle), x = 0, y = 0, maxy = 0;
            while (y >= 0)
            {
                _graph.Points.AddXY(x, y);
                if (maxy < y) maxy = y;
                Vy -= 9.8 * _step;
                x += Vx * _step;
                y += Vy * _step;
            }
            double L = Math.Pow(_velocity, 2) / 9.8 * Math.Sin(2 * _angle);
            y = 0;
            for (x = 0; x <= L; x+=0.1)
            {
                _graph2.Points.AddXY(x, y);
                y = x*Math.Tan(_angle) - Math.Pow(x, 2)*9.8 / (2*Math.Pow(_velocity, 2)*Math.Pow(Math.Cos(_angle), 2));
            }

            chart.Series.Add(_graph2); 
            chart.Legends.Add("Аналитический");
            chart.Series[0].LegendText = "Аналитический";
            chart.Series.Add(_graph);
            chart.Legends.Add("Численный");
            chart.Series[1].LegendText = "Численный";

            textBoxL.Text = Math.Round(L, 4).ToString();
            textBoxH.Text = Math.Round(maxy, 4).ToString();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            _scale[textBoxXMin] = 0;
            _scale[textBoxXMax] = 10.5;
            _scale[textBoxYMin] = -0.5;
            _scale[textBoxYMax] = 5.5;

            textBoxXMin.Text = _scale[textBoxXMin].ToString();
            textBoxXMax.Text = _scale[textBoxXMax].ToString();
            textBoxYMin.Text = _scale[textBoxYMin].ToString();
            textBoxYMax.Text = _scale[textBoxYMax].ToString();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            chart.Series.Clear();
            List<Series> graph = new List<Series>(60);
            double angle, Vx, Vy, x, y;
            for (int i = 30, j = 0; i < 90; i+=5, j++)
            {
                graph.Add(new Series { });
                angle = i*Math.PI/180;
                Vx = _velocity*Math.Cos(angle);
                Vy = _velocity*Math.Sin(angle);
                x = 0; y = 0;
                while (y >= 0)
                {
                    graph[j].Points.AddXY(x, y);
                    Vy -= 9.8 * _step;
                    x += Vx * _step;
                    y += Vy * _step;
                }
                graph[j].ChartType = SeriesChartType.Spline;
                graph[j].BorderWidth = 1;

                chart.Series.Add(graph[j]);
            }
            chart.Legends.Clear();

            double L, maxL = 0, angleL = 0;
            for (int i = 30; i < 90; i++)
            {
                angle = i * Math.PI / 180;
                L = Math.Pow(_velocity, 2)/9.8 * Math.Sin(2*angle);
                if (maxL < L) 
                {
                    maxL = L;
                    angleL = i;
                }
            }
            textBoxA.Text = angleL.ToString();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            _scale[textBoxXMin] = _XMin;
            _scale[textBoxXMax] = _XMax;
            _scale[textBoxYMin] = _YMin;
            _scale[textBoxYMax] = _YMax;

            textBoxXMin.Text = _scale[textBoxXMin].ToString();
            textBoxXMax.Text = _scale[textBoxXMax].ToString();
            textBoxYMin.Text = _scale[textBoxYMin].ToString();
            textBoxYMax.Text = _scale[textBoxYMax].ToString();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            chart.Visible = false;
            chart.ChartAreas[0].AxisY.ScaleView.ZoomReset(10);
            chart.ChartAreas[0].AxisX.ScaleView.ZoomReset(10);
            chart.Visible = true;
        }

        private void chart_MouseEnter(object sender, EventArgs e)
        {
            ChartArea ca = chart.ChartAreas[0];
            ca.AxisX.ScaleView.Zoomable = true;
            ca.AxisY.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorY.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true;
            ca.CursorY.IsUserSelectionEnabled = true;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            btnConfirm.Location = new Point(groupBox1.Width/4 - btnConfirm.Width/2, 113);
            btnBuildGraph.Location = new Point(groupBox2.Width/4 - btnBuildGraph.Width/2, 18);
            buttonG.Location = new Point(groupBox2.Width/2 + groupBox2.Width/4 - buttonG.Width / 2, 18);
            panelTB.Location = new Point(groupBox1.Width/4 - panelTB.Width/2, 21);
            panelGr.Location = new Point(groupBox2.Width/2 - panelGr.Width/2, 55);
            panel1.Location = new Point(groupBox3.Width/2 - panel1.Width/2, 39);

            groupBox1.Height = Height * 25/100;
            groupBox2.Height = Height * 70/100;
        }
    }
}