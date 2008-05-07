using System;
using System.IO;
using System.Text;

using DRToolbox.Utilities;

namespace DRToolbox.UI.FileImport.CSV
{
	public class CSVImporter
	{
		#region Class Methods
        public static ImportedFile ImportFile(FileStream fileToImport)
        {
            // Local Variables
            ImportTable importedData = null;
            StreamReader fileContents = null;
            string currentLine = "";
            string[] lineParts = null;
            char[] lineSep = {','};
            int numPartsPerLine = -1;

            // Is there a file to import?
            if(fileToImport != null)
            {   // Yes
                // Get file contents
                using(fileContents = new StreamReader(fileToImport))
                {
                    // Read first line of file
                    currentLine = fileContents.ReadLine();

                    // Get the line's parts
                    lineParts = currentLine.Trim(' ', ',').Split(lineSep);

                    // Are there parts?
                    if(lineParts != null)
                    {   // Yes
                        // Get how many parts
                        numPartsPerLine = lineParts.Length;

                        // Create the import table
                        importedData = new ImportTable(numPartsPerLine);

                        // Add first line to the import table
                        importedData.AddNewRow(ListConversions.ConvertToDoubleArray(lineParts));

                        // Read rest of the file
                        currentLine = fileContents.ReadLine();
                        while(currentLine != null)
                        {
                            // Get the line's parts
                            lineParts = currentLine.Trim(' ', ',').Split(lineSep, numPartsPerLine);

                            // Are there parts?
                            if(lineParts != null)
                            {   // Yes
                                // Add line to the import table
                                importedData.AddNewRow(ListConversions.ConvertToDoubleArray(lineParts));
                            }

                            // Move to next line
                            currentLine = fileContents.ReadLine();
                        }
                    }

                    // Close file stream
                    fileContents.Close();
                }
            }

            // Return the imported file
            return (new ImportedFile(importedData, fileToImport.Name));
        }
		#endregion

		#region Constructors
        private CSVImporter()
        {
            // No need to create this object
        }
		#endregion
	}
}
