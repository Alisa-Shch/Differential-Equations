using System;
using System.IO;
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

            chart.Visible = false;
            chart.ChartAreas[0].AxisY.ScaleView.ZoomReset(10);
            chart.ChartAreas[0].AxisX.ScaleView.ZoomReset(10);
            chart.Visible = true;

            chart.Series.Clear();
            chart.Legends.Clear();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            _graph.Points.Clear();
            _graph2.Points.Clear();

            double m0 = 120, mk = 15, mt, L = 10, Vg = 1800, V0 = 20, c = 0.0075, g = 9.81,
                T = (m0 - mk) / L, t, Vxy, x = 0, y = 0, maxX = 0,
                Vx = V0*Math.Cos(_angle), Vy = V0*Math.Sin(_angle);

            for (t = 0; y >= 0; t += _step)
            {
                Vxy = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));
                if (t <= T)
                {
                    _graph.Points.AddXY(x/1000, y/1000);
                    mt = m0 - t * L;
                    Vx += (L * Vg * Vx / (Vxy * mt) - c* Vxy * Vx / mt) * _step;
                    Vy += (-g + L* Vg * Vy / (Vxy * mt) - c* Vxy * Vy / mt) * _step;
                    if (maxX < x) maxX = x;
                }
                else
                {
                    _graph2.Points.AddXY(x/1000, y/1000);
                    Vx += -c * Vxy * Vx / mk * _step;
                    Vy += (-g - c* Vxy * Vy / mk) * _step;
                }
                x += Vx * _step;
                y += Vy * _step;
            }
            chart.Series.Add(_graph);
            chart.Series.Add(_graph2);

            textBox1.Text = Math.Round(maxX/1000, 1).ToString();

            double angle, angleL = 0, angleLX, maxL = 0; 
            for (int i = 30; i <= 50; i++)
            {
                angle = i * Math.PI / 180;
                Vx = V0 * Math.Cos(angle); 
                Vy = V0 * Math.Sin(angle);
                angleLX = 0; maxX = 0;
                for (x = 0, y = 0, t = 0; y >= 0; t += _step)
                {
                    Vxy = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));
                    if (t <= T)
                    {
                        mt = m0 - t * L;
                        Vx += (L * Vg * Vx / (Vxy * mt) - c * Vxy * Vx / mt) * _step;
                        Vy += (-g + L * Vg * Vy / (Vxy * mt) - c * Vxy * Vy / mt) * _step;
                        if (maxX < x) maxX = x;
                    }
                    else
                    {
                        Vx += -c * Vxy * Vx / mk * _step;
                        Vy += (-g - c * Vxy * Vy / mk) * _step;
                    }
                    x += Vx * _step;
                    y += Vy * _step;
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