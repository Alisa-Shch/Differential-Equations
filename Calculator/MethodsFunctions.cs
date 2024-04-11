using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private bool Verify()
        {
            try
            {
                for (int i = 0; i < _listTextBox.Count; i++)
                {
                    if (_listTextBox[i].Text.Length == 0) return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }

        private bool VerifyMessage()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }

        private void BuildGraph()
        {
            chart.Series.Clear();
            chart1.Series.Clear();

            _graphTOmega.Points.Clear();
            _graphTPhi.Points.Clear();
            _graphPhiOmega.Points.Clear();

            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            double phi = 0, omega = _velocity / Math.Sqrt(9.8 * _length);
            for (double t = 0; t <= 360; t += 1)
            {
                _graphPhiOmega.Points.AddXY(phi, omega);

                _graphTOmega.Points.AddXY(t, omega);
                _graphTPhi.Points.AddXY(t, phi);
                omega -= _step * Math.Sin(phi);
                phi += _step * omega;
            }
            chart.Series.Add(_graphTOmega);
            chart.Series.Add(_graphTPhi);
            chart1.Series.Add(_graphPhiOmega);
            chart.Legends.Clear();
        }
    }
}