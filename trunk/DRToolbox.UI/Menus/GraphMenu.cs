using System;
using System.Windows.Forms;

using DRToolbox.Techniques;
using DRToolbox.UI.Graphs;
using DRToolbox.Utilities;

namespace DRToolbox.UI.Menus
{
    public class GraphMenu : ContextMenu
    {
        #region Class Objects
        private TechniqueResults theResults = null;
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
            this.MenuItems.Add(GraphNames.XYZScatterPlot, menuGraph_Click);
        }
        private void DisplayGraph(string graphName)
        {
            // Which graph is this?
            if(graphName == GraphNames.XYScatterPlot)
            {
                // Display XY Scatter Plot
                DisplayXYScatterPlot();
            }
            if (graphName == GraphNames.XYZScatterPlot)
            {
                // Display XYZ Scatter Plot
                DisplayXYZScatterPlot();
            }
        }

        #region Graph Activation Methods
        private void DisplayXYScatterPlot()
        {
            //Display the data in a XY scatter plot
            XYScatterPlot xyPlot = new XYScatterPlot(theResults);
            xyPlot.MdiParent = MainForm.ActiveForm;
            xyPlot.Show();
        }

        private void DisplayXYZScatterPlot()
        {
            //Display the data in a XYZ scatter plot
            XYZPlotter xyzPlot = new XYZPlotter();
            //...
        }
        #endregion
        #endregion

        #region Constructors
        public GraphMenu(TechniqueResults results)
        {
            // Initialize object
            theResults = results;

            // Build graph menu
            BuildGraphMenu();
        }
        #endregion
        
        #region Event Handlers
        private void menuDataset_Click(object sender, EventArgs e)
        {
            //Display Data imported in a DataGridView
            DatasetForm dataForm = new DatasetForm(theResults.ImportFileName + " (" + theResults.TechniqueName + ")", theResults.Results.TableData);
            dataForm.MdiParent = MainForm.ActiveForm;
            dataForm.Show();
        }
        private void menuGraph_Click(object sender, EventArgs e)
        {
            // Local Variables
            MenuItem selectedItem = (sender as MenuItem);

            // Was an item selected?
            if(selectedItem != null)
            {   // Yes
                // Display graph
                DisplayGraph(selectedItem.Text);
            }
        }
        #endregion
    }
}
