using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.Graphs
{
    public partial class XYScatterPlot : Form
    {
        #region Global Var/Objects
        /// <summary>
        /// Global Variables.
        /// </summary>
        private string title = "";
        private string xAxis = "";
        private string yAxis = "";

        /// <summary>
        /// Global Objects
        /// </summary>
        private ZedGraph.ZedGraphControl zGraph;
        private ZedGraph.PointPairList dataList;
        private ZedGraph.LineItem dataPath;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public XYScatterPlot()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        public XYScatterPlot(string plotTitle, string plotXAxis, string plotYAxis, ZedGraph.PointPairList plotData)
        {
            this.GraphTitle = plotTitle;
            this.XAxisTitle = plotXAxis;
            this.YAxisTitle = plotYAxis;
            this.GraphDataList = plotData;

            InitializeComponent();

            DrawXYScatterPlot();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Graph title.
        /// </summary>
        public string GraphTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// X-Axis title
        /// </summary>
        public string XAxisTitle
        {
            get
            {
                return xAxis;
            }
            set
            {
                xAxis = value;
            }
        }

        /// <summary>
        /// Y-Axis title
        /// </summary>
        public string YAxisTitle
        {
            get
            {
                return yAxis;
            }
            set
            {
                yAxis = value;
            }
        }

        /// <summary>
        /// Data list
        /// </summary>
        public ZedGraph.PointPairList GraphDataList
        {
            get
            {
                return dataList;
            }
            set
            {
                dataList = value;
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Draw an XY scatter plot.
        /// </summary>
        public void DrawXYScatterPlot()
        {
            //Init graph
            zGraph.GraphPane.Title.Text = this.GraphTitle;
            zGraph.GraphPane.XAxis.Title.Text = this.XAxisTitle;
            zGraph.GraphPane.YAxis.Title.Text = this.YAxisTitle;

            //Draw data as scatter plot
            dataPath = zGraph.GraphPane.AddCurve("Technique Data", this.dataList, Color.Red, ZedGraph.SymbolType.Default);
            dataPath.Line.IsVisible = false;

            //Refresh axis to show new graph
            zGraph.AxisChange();
        }
        #endregion
    }
}