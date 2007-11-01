using System;
using System.Drawing;

using MathNet.Numerics.LinearAlgebra;

namespace DRToolbox.UI.FileImport
{
	public class ImportedFile
	{
		#region Class Objects
		private Matrix importedData = null;
		private Color[] labels = null;
		private string fileName = "";
		#endregion

		#region Class Properties
		public Matrix ImportedData
		{
			get
			{
				return importedData;
			}
			set
			{
				importedData = value;
			}
		}
		public Color[] Labels
		{
			get
			{
				return labels;
			}
			set
			{
				labels = value;
			}
		}
		public string FileName
		{
			get
			{
				return fileName;
			}
			set
			{
				fileName = value;
			}
		}
		#endregion

		#region Constructors
		public ImportedFile(double[][] matrixArray, Color[] labelArray, string fileToImport)
		{
			// Initialize object
            if (matrixArray != null && matrixArray.Length > 0 && matrixArray[0] != null)
            {
                importedData = new Matrix(matrixArray.Length, matrixArray[0].Length);
                for (int i = 0; i < matrixArray.Length; i++)
                    for (int j = 0; j < matrixArray[0].Length; j++)
                        importedData[i, j] = matrixArray[i][j];
            }
			labels = labelArray;
			fileName = fileToImport;
		}
		#endregion
	}
}
