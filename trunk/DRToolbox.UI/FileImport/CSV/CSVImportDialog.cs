using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DRToolbox.UI.FileImport.CSV
{
	public partial class CSVImportDialog : Form
	{
		#region Class Objects
		private ImportedFile importFile = null;
		#endregion

		#region Class Properties
		public ImportedFile ImportFile
		{
			get
			{
				return importFile;
			}
		}
		#endregion

		#region Constructors
		public CSVImportDialog()
		{
			InitializeComponent();
		}
		#endregion

		#region Event Handlers
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			// Show file open dialog
			ofdFileToImport.ShowDialog();

			// Update the file to import textbox
			txtFileToImport.Text = ofdFileToImport.FileName;
		}
		private void btnImportFile_Click(object sender, EventArgs e)
		{
			// Local Variables
			FileStream selectedFile = null;

			// Was a file selected?
			if(txtFileToImport.Text != "")
			{	// Yes
				// Does file exist?
				if(File.Exists(txtFileToImport.Text))
				{	// Yes
                    try
                    {
                        // Get selected file
                        selectedFile = new FileStream(txtFileToImport.Text, FileMode.Open);

                        // Import file
                        importFile = CSVImporter.ImportFile(selectedFile);
                    }
                    catch(Exception ex)
                    {
                        // Display error msg
                        ErrorMessageForm.Show(ex.Message, "File Import Error");
                    }
				}
				else
				{	// No
					// Display error msg
					ErrorMessageForm.Show("The selected file does not exist.", "File Import Error");
				}
			}
			else
			{	// No
				// Display error msg
				ErrorMessageForm.Show("Please select a file to import.", "File Import Error");
			}
		}
		#endregion

	}
}