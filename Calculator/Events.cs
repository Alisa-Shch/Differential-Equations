using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.SelectionStart == 0 && (e.KeyChar == 45 || e.KeyChar == '0'))
                {
                    e.Handled = true;
                    MessageBox.Show("Только положительные числа!");
                }
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
                    if (textBox.Text.Length != 0 && textBox.Text != "-")
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
                _length = Convert.ToDouble(tBLength.Text);
                _step = Convert.ToDouble(tBStep.Text);

                for (int i = 0; i < _listTextBox.Count; i++) { _listTextBox[i].Enabled = false; }

                groupBox2.Enabled = true;
                btnConfirm.Visible = false;
                btnClear.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _graphPhiOmega.Points.Clear();
            _graphTPhi.Points.Clear();
            _graphTOmega.Points.Clear();
            for (int i =0; i < _listTextBox.Count; i++)
            {
                _listTextBox[i].Text = string.Empty;
                _listTextBox[i].Enabled = true;
            }
            groupBox2.Enabled = false;
            btnBuildGraph.Enabled = true;
            btnConfirm.Visible = true;
            btnClear.Visible = false;
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            btnBuildGraph.Enabled = false;
            BuildGraph();
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
            btnConfirm.Location = new Point(groupBox1.Width/2 - btnConfirm.Width/2, 113);
            btnClear.Location = new Point(groupBox1.Width/2 - btnClear.Width/2, 113);
            btnBuildGraph.Location = new Point(groupBox2.Width/2 - btnBuildGraph.Width/2, 18);

            groupBox1.Height = Height * 25/100;
            groupBox2.Height = Height * 70/100;
        }
    }
}