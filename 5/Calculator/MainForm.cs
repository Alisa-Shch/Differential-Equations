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
        private Dictionary<TextBox, double> _scale = new Dictionary<TextBox, double>();

        Series _graph = new Series();
        Series _graph2 = new Series();

        double _step;
        double _angle;

        private double _XMin = 0;
        private double _XMax = 60;
        private double _YMin = -5;
        private double _YMax = 50;

        private void AddComponents()
        {
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
            _graph.ChartType = SeriesChartType.Spline;
            _graph.Color = Color.MediumAquamarine;
            _graph.BorderWidth = 2;

            _graph2.ChartType = SeriesChartType.Spline;
            _graph2.Color = Color.SlateBlue;
            _graph2.BorderWidth = 2;

            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Black;
            chart.ChartAreas[0].AxisX.Crossing = 0;
            chart.ChartAreas[0].AxisY.Crossing = 0;

            chart.MouseWheel += Chart_MouseWheel;
        }
    }
}