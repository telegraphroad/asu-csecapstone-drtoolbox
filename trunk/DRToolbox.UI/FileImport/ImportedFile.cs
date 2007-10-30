using System;
using System.Drawing;

namespace DRToolbox.UI.FileImport
{
	public class ImportedFile
	{
		#region Class Objects
		private double[][] matrix = null;
		private Color[] labels = null;
		private string fileName = "";
		#endregion

		#region Class Properties
		public double[][] Matrix
		{
			get
			{
				return matrix;
			}
			set
			{
				matrix = value;
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
			matrix = matrixArray;
			labels = labelArray;
			fileName = fileToImport;
		}
		#endregion
	}
}
