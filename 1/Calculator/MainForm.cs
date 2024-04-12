using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddComponents();
            SettingGraph();
        }

        private List<TextBox> _listTextBox = new List<TextBox>();
        private Dictionary<TextBox, double> _scale = new Dictionary<TextBox, double>();

        Series _graphPhiOmega = new Series();
        Series _graphTPhi = new Series();
        Series _graphTOmega = new Series();

        double _velocity;        
        double _length;
        double _step;        

        private double _XMin = 0;
        private double _XMax = 20;
        private double _YMin = -10;
        private double _YMax = 10;

        private void AddComponents()
        {
            _listTextBox.Add(tBVelocity);
            _listTextBox.Add(tBLength);
            _listTextBox.Add(tBStep);

            _scale.Add(textBoxXMin, _XMin);
            _scale.Add(textBoxXMax, _XMax);
            _scale.Add(textBoxYMin, _YMin);
            _scale.Add(textBoxYMax, _YMax);

            textBoxXMin.Text = _XMin.ToString();
            textBoxXMax.Text = _XMax.ToString();
            textBoxYMin.Text = _YMin.ToString();
            textBoxYMax.Text = _YMax.ToString();
        }

        private void SettingGraph()
        {
            _graphPhiOmega.ChartType = SeriesChartType.Spline;
            _graphPhiOmega.Color = Color.SlateBlue;
            _graphPhiOmega.BorderWidth = 2;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;

            _graphTOmega.ChartType = SeriesChartType.Spline;
            _graphTOmega.Color = Color.SlateBlue;
            _graphTOmega.BorderWidth = 2;
            _graphTPhi.ChartType = SeriesChartType.Spline;
            _graphTPhi.Color = Color.MediumAquamarine;
            _graphTPhi.BorderWidth = 2;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Black;
            chart.ChartAreas[0].AxisX.Crossing = 0;
            chart.ChartAreas[0].AxisY.Crossing = 0;
        }

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
    }
}