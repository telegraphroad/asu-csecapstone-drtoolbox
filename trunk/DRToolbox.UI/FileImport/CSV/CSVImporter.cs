using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace DRToolbox.UI.FileImport.CSV
{
	public class CSVImporter
	{
		#region Class Objects
		private ImportedFile processedFile = null;
		private FileStream originalFile = null;
		#endregion

		#region Class Properties
		public ImportedFile ProcessedFile
		{
			get
			{
				return processedFile;
			}
		}
		#endregion

		#region Class Methods
		private void ImportFile(bool hasLabels, int numRows, int numColumns)
		{
			// Local Variables
			double[][] matrix = null;
			Color[] labels = null;
			StreamReader fileContents = null;
			string currentLine = "";
			string[] lineParts = null;
			int currentRow = -1;
			
			// Is there a file to import?
			if(originalFile != null)
			{	// Yes
				// Get file contents
				fileContents = new StreamReader(originalFile);

				// Initialize label/matrix arrays
				labels = (hasLabels ? new Color[numRows] : null);
				matrix = new double[numRows][];

				// Read each line in the file
				currentLine = fileContents.ReadLine();
				currentRow = 0;
				while(currentLine != null && (currentLine = currentLine.Trim(' ', ',')) != "")
				{
					// Get the line parts
					lineParts = currentLine.Split(',');

					// Are there parts?
					if(lineParts != null)
					{	// Yes
						// Create row in matrix
						matrix[currentRow] = (hasLabels ? new double[numColumns - 1] : new double[numColumns]);

						// Add each part to the correct cell in matrix/label arrays
						for(int i = 0; i < lineParts.Length; i++)
						{
							// Are there labels?
							if(hasLabels)
							{	// Yes
								// Is this the first part?
								if(i == 0)
								{	// Yes
									// Save part as label
									labels[currentRow] = PointLabelColors.GetLabelColor(lineParts[i]);
								}
								else
								{	// No
									// Save part as matrix value
									matrix[currentRow][i - 1] = double.Parse(lineParts[i]);
								}
							}
							else
							{	// No
								// Save part as matrix value
								matrix[currentRow][i] = double.Parse(lineParts[i]);
							}
						}
					}

					// Move to next line
					currentLine = fileContents.ReadLine();
					currentRow++;
				}

				// Save imported file
				processedFile = new ImportedFile(matrix, labels, originalFile.Name);

				// Close stream
				fileContents.Close();
			}			
		}
		#endregion

		#region Constructors
		public CSVImporter(FileStream fileToBeImported, bool labelsPresent, int rowCount, int columnCount)
		{
			// Save original file
			originalFile = fileToBeImported;

			// Import file into matrix
			ImportFile(labelsPresent, rowCount, columnCount);
		}
		#endregion
	}
}
