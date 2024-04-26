using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
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
            if (sender is System.Windows.Forms.TextBox textBox)
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
                _to = Convert.ToDouble(tBOpeningTime.Text);
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
            _graph3.Points.Clear();

            double h = 3000, m = 80, a0 = 0.3, a1 = 60, Cd = 0.95, p = 1.2,
                t, T = 1, t1 = T + _to, Vy = 0, g = 9.8, y = h, a,
                k, k0 = 0.5 * p * Cd * a0, k1 = 0.5 * p * Cd * a1;
                        
            for (t = 0; y >= 0; t += _step)
            {
                _graph.Points.AddXY(t, y/30);
                _graph3.Points.AddXY(t, -Vy);

                if (t <= _to) { k = k0; }
                else if (_to < t && t <= t1) { k = k0 + (k1 - k0) / T * (t - _to); }
                else { k = k1; }

                a = -g + k * Math.Pow(Vy, 2) / m;
                Vy += a * _step;
                y += Vy * _step;

                _graph2.Points.AddXY(t, -a);
            }

            chart.Series.Add(_graph);
            chart.Legends.Add("1");
            chart.Series[0].LegendText = "h";

            chart.Series.Add(_graph2);
            chart.Legends.Add("2");
            chart.Series[1].LegendText = "a";

            chart.Series.Add(_graph3);
            chart.Legends.Add("3");
            chart.Series[2].LegendText = "V";
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