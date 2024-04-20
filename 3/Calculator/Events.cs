using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (sender is System.Windows.Forms.TextBox textBox) textBox.SelectAll(); 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _velocity = Convert.ToDouble(tBVelocity.Text);
                _angle = Convert.ToDouble(tBLength.Text);
                _angle *= Math.PI/180;
                _step = Convert.ToDouble(tBStep.Text);
                _mass = Convert.ToDouble(tBMass.Text);
                _friction = Convert.ToDouble(tBFriction.Text);
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

            _graph2.Points.Clear();
            _graph.Points.Clear();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            double Vx = _velocity*Math.Cos(_angle), Vy = _velocity*Math.Sin(_angle), x = 0, y = 0, maxx = 0, maxy = 0;
            while (y >= 0)
            {
                _graph.Points.AddXY(x, y);
                if (maxx < x) maxx = x;
                if (maxy < y) maxy = y;

                Vx += -_friction/_mass * Vx*_step;
                Vy += (-9.8 - _friction/_mass * Vy)*_step;
                x += Vx * _step;
                y += Vy * _step;
            }

            double Vt = _mass*9.8/_friction;
            y = 0; x = 0;
            for (double t = 0; y >= 0; t += 0.01)
            {
                _graph2.Points.AddXY(x, y);
                x = Vt / 9.8 * _velocity * Math.Cos(_angle) * (1 - Math.Exp(-9.8 / Vt * t));
                y = Vt / 9.8 * (_velocity * Math.Sin(_angle) + Vt) * (1 - Math.Exp(-9.8 / Vt * t)) - _mass * 9.8 * t / _friction;
            }

            chart.Series.Add(_graph2); 
            chart.Legends.Add("Аналитический");
            chart.Series[0].LegendText = "Аналитический";
            chart.Series.Add(_graph);
            chart.Legends.Add("Численный");
            chart.Series[1].LegendText = "Численный";

            double h = Vt / 9.8 * _velocity * Math.Sin(_angle) - Math.Pow(Vt, 2) / 9.8 * Math.Log(1 + _velocity / Vt * Math.Sin(_angle));

            textBoxL.Text = Math.Round(maxx, 4).ToString();
            textBoxH.Text = Math.Round(maxy, 4).ToString();
            textBoxHF.Text = Math.Round(h, 4).ToString();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            _scale[textBoxXMin] = 0;
            _scale[textBoxXMax] = 10;
            _scale[textBoxYMin] = -0.5;
            _scale[textBoxYMax] = 3;

            textBoxXMin.Text = _scale[textBoxXMin].ToString();
            textBoxXMax.Text = _scale[textBoxXMax].ToString();
            textBoxYMin.Text = _scale[textBoxYMin].ToString();
            textBoxYMax.Text = _scale[textBoxYMax].ToString();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            chart.Series.Clear();
            List<Series> graph = new List<Series>();
            List<Color> colors = new List<Color>() { Color.SlateBlue, Color.DarkBlue, Color.Blue, Color.Cyan, Color.Aquamarine,Color.LimeGreen,Color.LightGreen,Color.Yellow,Color.Orange,Color.DarkOrange,Color.Red,Color.DarkRed, };
            double angle, Vx, Vy, x, y;
            for (int i = 30, j = 0; i <= 50; i+=2, j++)
            {
                graph.Add(new Series { });
                angle = i*Math.PI/180;
                Vx = _velocity * Math.Cos(angle);
                Vy = _velocity * Math.Sin(angle);
                x = 0; y = 0;
                while (y >= 0)
                {
                    graph[j].Points.AddXY(x, y);
                    Vx += -_friction / _mass * Vx * _step;
                    Vy += (-9.8 - _friction / _mass * Vy) * _step;
                    x += Vx * _step;
                    y += Vy * _step;
                }
                graph[j].ChartType = SeriesChartType.Spline;
                graph[j].BorderWidth = 1;
                graph[j].Color = colors[j];

                chart.Series.Add(graph[j]);
            }
            chart.Legends.Clear();

            double maxL = 0, angleL = 0, maxx, angleLx;
            for (int i = 30; i <= 50; i++)
            {
                angle = i * Math.PI / 180;

                Vx = _velocity * Math.Cos(angle);
                Vy = _velocity * Math.Sin(angle);
                x = 0; y = 0; maxx = 0; angleLx = 0;
                while (y >= 0)
                {
                    _graph.Points.AddXY(x, y);
                    if (maxx < x)
                    {
                        maxx = x;
                        angleLx = i;
                    }

                    Vx += -_friction / _mass * Vx * _step;
                    Vy += (-9.8 - _friction / _mass * Vy) * _step;
                    x += Vx * _step;
                    y += Vy * _step;
                }

                if (maxL < maxx) 
                {
                    maxL = maxx;
                    angleL = angleLx;
                }
            }

            textBA.Text = angleL.ToString();
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
    }
}