using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DRToolbox.Techniques;
using ZedGraph;

namespace DRToolbox.UI.Graphs
{
    public partial class XYScatterPlot : Form
    {
        #region Class Objects
        protected ZedGraphControl zGraph;

        private TechniqueResults graphData = null;
        private string xAxisTitle = "";
        private string yAxisTitle = "";
        #endregion

        #region Class Methods
        private void PlotGraph()
        {
            // Local Variables
            GraphPane theGraphPane = zGraph.GraphPane;
            LineItem theCurve = null;

            // Set graph titles
            theGraphPane.Title.Text = graphData.TechniqueName;
            theGraphPane.XAxis.Title.Text = xAxisTitle;
            theGraphPane.YAxis.Title.Text = yAxisTitle;

            // Plot graph data
            theCurve = theGraphPane.AddCurve("Technique Data", graphData.Results.GraphData2D, Color.FromArgb(128, 112, 89), SymbolType.Default);

            // Configure curve
            theCurve.Line.IsVisible = false;
            try
            {
                //Fill the points with an image
                Image imgBullet = DRToolbox.UI.Properties.Resources.BrownishBullet;
                theCurve.Symbol.Border.IsVisible = false;
                theCurve.Symbol.Fill = new Fill(imgBullet, System.Drawing.Drawing2D.WrapMode.Clamp);
            }
            catch
            {
                //Fill with a solid color
                theCurve.Symbol.Fill = new Fill(Color.FromArgb(128, 112, 89));
                theCurve.Symbol.Border.Color = Color.Black;
            }

            // Refresh graph
            zGraph.AxisChange();
        }
        private void SetupForm()
        {
            // Set form title
            this.Text = "XY Scatter Plot - " + graphData.ImportFileName + " - " + graphData.TechniqueName;

            // Plot graph
            PlotGraph();

        }
        #endregion

        #region Constructors
        public XYScatterPlot(TechniqueResults results) : this(results, "X Axis", "Y Axis")
        {
        }
        public XYScatterPlot(TechniqueResults results, string xAxisName, string yAxisName)
        {
            // Perform designer work
            InitializeComponent();

            // Initialize object
            graphData = results;
            xAxisTitle = xAxisName;
            yAxisTitle = yAxisName;

            // Setup form
            SetupForm();
        }
        #endregion

    }
}