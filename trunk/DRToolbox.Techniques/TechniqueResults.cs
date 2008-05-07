using System;

using DRToolbox.Utilities;

namespace DRToolbox.Techniques
{
    public class TechniqueResults
    {
        #region Class Objects
        private string importFileName = "";
        private ResultTable results = null;
        private string name = "";
        #endregion

        #region Class Properties
        public string ImportFileName
        {
            get
            {
                return importFileName;
            }
        }
        public ResultTable Results
        {
            get
            {
                return results;
            }
        }
        public string TechniqueName
        {
            get
            {
                return name;
            }
        }
        #endregion

        #region Constructors
        public TechniqueResults(string importedFileName, string techniqueName, ResultTable resultData)
        {
            // Initialize object
            importFileName = importedFileName;
            name = techniqueName;
            results = resultData;
        }
        #endregion
    }
}
