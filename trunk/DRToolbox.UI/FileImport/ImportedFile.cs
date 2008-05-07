using System;

using DRToolbox.Utilities;

namespace DRToolbox.UI.FileImport
{
	public class ImportedFile
	{
		#region Class Objects
		private ImportTable fileData = null;
        private string fileName = "";
		private string filePath = "";
		#endregion

		#region Class Properties
		public ImportTable FileData
		{
			get
			{
				return fileData;
			}
		}
        public string FileName
        {
            get
            {
                return fileName;
            }
        }
		public string FilePath
		{
			get
			{
				return filePath;
			}
		}
		#endregion

        #region Class Methods
        private void SetFileName()
        {
            // Local Variables
            int slashIndex = filePath.LastIndexOf('\\');

            // Get file name without path
            switch(slashIndex)
            {
                case -1:    // Not found    
                    fileName = filePath;
                    break;
                default:    // Grab everything after the slash
                    fileName = filePath.Substring((slashIndex == filePath.Length - 1) ? filePath.Length : slashIndex + 1);
                    break;
            }
        }
        #endregion

        #region Constructors
        public ImportedFile(ImportTable importedData, string importedFileName)
		{
			// Initialize object
            fileData = importedData;
			filePath = importedFileName;
            SetFileName();
		}
		#endregion
	}
}