using System;
using System.Windows.Forms;

using DRToolbox.UI.Graphs;
using DRToolbox.Utilites;
using MathNet.Numerics.LinearAlgebra;

namespace DRToolbox.UI.Menus
{
    public class GraphMenu : ContextMenu
    {
        #region Class Objects
        private Matrix techniqueResults = null;
        private string techniqueName = "";
        #endregion

        #region Class Methods
        private void BuildGraphMenu()
        {
            // Add 'View Results" option
            this.MenuItems.Add("Dataset", menuDataset_Click);
            
            // Add seperator
            this.MenuItems.Add("-");

            // Add graph options
            this.MenuItems.Add(GraphNames.XYScatterPlot, menuGraph_Click);
        }
        private void DisplayXYScatterPlot()
        {
            //Display the data in a XY scatter plot
            XYScatterPlot xyPlot = new XYScatterPlot();
            ZedGraph.PointPairList list = ListConversions.MatrixToPointPairList(techniqueResults, 2);
            xyPlot.GraphTitle = techniqueName;
            xyPlot.XAxisTitle = "X-Axis";
            xyPlot.YAxisTitle = "Y-Axis";
            xyPlot.GraphDataList = list;
            xyPlot.MdiParent = MainForm.ActiveForm;
            xyPlot.DrawXYScatterPlot();
            xyPlot.Show();
        }
        #endregion

        #region Constructors
        public GraphMenu(string technique, Matrix results)
        {
            // Save technique name and results
            techniqueName = technique;
            techniqueResults = results;

            // Build graph menu
            BuildGraphMenu();
        }
        #endregion
        
        #region Event Handlers
        private void menuDataset_Click(object sender, EventArgs e)
        {
            //Display Data imported in a DataGridView
            DatasetForm data = new DatasetForm();
            data.FormTitle = "Dataset Imported and Processed";
            data.Dataset = ListConversions.MatrixToDataTable(techniqueResults);
            data.FillDataGridView();
            data.MdiParent = MainForm.ActiveForm;
            data.Show();
        }
        private void menuGraph_Click(object sender, EventArgs e)
        {
            // Local Variables
            MenuItem selectedItem = (sender as MenuItem);

            // Was an item selected?
            if(selectedItem != null)
            {   // Yes
                // Which graph is this?
                if(selectedItem.Text == GraphNames.XYScatterPlot)
                {
                    // Display XY Scatter Plot
                    DisplayXYScatterPlot();
                }
            }
        }
        #endregion
    }
}
