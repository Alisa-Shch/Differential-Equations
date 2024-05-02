using System;
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

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                try
                {
                    if (textBox.Text.Length != 0 && textBox.Text != "-" && textBox.Text != "," && textBox.Text != "-,")
                    {
                        _scale[textBox] = Convert.ToDouble(textBox.Text);

                        if (_scale[textBoxXMin] < _scale[textBoxXMax] && _scale[textBoxYMin] < _scale[textBoxYMax])
                        {
                            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
                            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
                            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
                            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _angle = Convert.ToDouble(tBAngle.Text);
                _angle *= Math.PI / 180;
                _step = Convert.ToDouble(tBStep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            btnConfirm_Click(sender, e);
            btnScale_Click(sender, e);

            chart.Series.Clear();
            chart.Legends.Clear();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            _graph.Points.Clear();
            _graph2.Points.Clear();

            double m = 104, D = 0.2, v0 = 1800, p, p0 = 1.2, Cd = 0.2, g = 9.81,
                A = Math.PI*Math.Pow(D, 2)/4, k = 0.5*p0*Cd*A, 
                x, y, vx = v0 * Math.Cos(_angle), vy = v0 * Math.Sin(_angle), vxy;                        
            for (x = 0, y = 0; y >= 0;)
            {
                _graph.Points.AddXY(x/1000, y/500);
                vxy = -k * Math.Sqrt(Math.Pow(vx, 2) + Math.Pow(vy, 2)) / m;
                vx += vxy*vx * _step;
                vy += (-g + vxy*vy) * _step;
                x += vx * _step;
                y += vy * _step;
            }
            label2.Text = Math.Round(x/1000, 2).ToString();

            vx = v0 * Math.Cos(_angle);
            vy = v0 * Math.Sin(_angle);
            for (x = 0, y = 0; y >= 0;)
            {
                p = p0 * Math.Exp(-y/80000);
                k = 0.5 * p * Cd * A;
                _graph2.Points.AddXY(x/1000, y/500);
                vxy = -k * Math.Sqrt(Math.Pow(vx, 2) + Math.Pow(vy, 2)) / m;
                vx += vxy * vx * _step;
                vy += (-g + vxy * vy) * _step;
                x += vx * _step;
                y += vy * _step;
            }
            label4.Text = Math.Round(x/1000, 2).ToString();          

            chart.Series.Add(_graph2);
            chart.Legends.Add("1");
            chart.Series[0].LegendText = "с изменением p";

            chart.Series.Add(_graph);
            chart.Legends.Add("2");
            chart.Series[1].LegendText = "без изменения p";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 104, D = 0.2, v0 = 1800, p, p0 = 1.2, Cd = 0.2, g = 9.81,
                A = Math.PI*Math.Pow(D, 2)/4, k = 0.5*p0*Cd*A,
                x, y, vx, vy, vxy, angle, angleL = 0, angleLX, maxL = 0, maxX;
            for (int i = 30; i <= 50; i++)
            {
                angle = i * Math.PI / 180;

                vx = v0 * Math.Cos(angle);
                vy = v0 * Math.Sin(angle);
                maxX = 0; angleLX = 0;
                for (x = 0, y = 0; y >= 0;)
                {
                    if (i % 5 == 0) _graph.Points.AddXY(x / 1000, y / 500);
                    vxy = -k * Math.Sqrt(Math.Pow(vx, 2) + Math.Pow(vy, 2)) / m;
                    vx += vxy * vx * _step;
                    vy += (-g + vxy * vy) * _step;
                    x += vx * _step;
                    y += vy * _step;
                    if (maxX < x)
                    {
                        maxX = x;
                        angleLX = i;
                    }
                }
                if (maxL < maxX)
                {
                    maxL = maxX;
                    angleL = angleLX;
                }
            }
            textBox1.Text = angleL.ToString();
            label2.Text = Math.Round(maxL/1000, 2).ToString();

            maxL = 0; angleL = 0;
            for (int i = 30; i <= 50; i++)
            {
                angle = i * Math.PI / 180;

                vx = v0 * Math.Cos(angle);
                vy = v0 * Math.Sin(angle);
                maxX = 0; angleLX = 0;
                for (x = 0, y = 0; y >= 0;)
                {
                    p = p0 * Math.Exp(-y / 80000);
                    k = 0.5 * p * Cd * A;
                    if (i % 5 == 0) _graph2.Points.AddXY(x / 1000, y / 500);
                    vxy = -k * Math.Sqrt(Math.Pow(vx, 2) + Math.Pow(vy, 2)) / m;
                    vx += vxy * vx * _step;
                    vy += (-g + vxy * vy) * _step;
                    x += vx * _step;
                    y += vy * _step;
                    if (maxX < x)
                    {
                        maxX = x;
                        angleLX = i;
                    }
                }
                if (maxL < maxX)
                {
                    maxL = maxX;
                    angleL = angleLX;
                }
            }
            textBox2.Text = angleL.ToString();
            label4.Text = Math.Round(maxL/1000, 2).ToString();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
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

        private void Chart_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;

            double currentMinX = chart.ChartAreas[0].AxisX.Minimum;
            double currentMaxX = chart.ChartAreas[0].AxisX.Maximum;
            double currentMinY = chart.ChartAreas[0].AxisY.Minimum;
            double currentMaxY = chart.ChartAreas[0].AxisY.Maximum;

            double newMinX = currentMinX - delta * 0.01;
            double newMaxX = currentMaxX + delta * 0.01;
            double newMinY = currentMinY - delta * 0.01;
            double newMaxY = currentMaxY + delta * 0.01;

            if (newMinX < newMaxX)
            {
                chart.ChartAreas[0].AxisX.Minimum = newMinX;
                chart.ChartAreas[0].AxisX.Maximum = newMaxX;
            }
            if (newMinY < newMaxY)
            {
                chart.ChartAreas[0].AxisY.Minimum = newMinY;
                chart.ChartAreas[0].AxisY.Maximum = newMaxY;
            }
        }
    }
}