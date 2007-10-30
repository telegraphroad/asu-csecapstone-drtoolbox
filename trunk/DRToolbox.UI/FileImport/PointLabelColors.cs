using System;
using System.Drawing;

namespace DRToolbox.UI.FileImport
{
	public class PointLabelColors
	{
		#region Class Properties
		public static Color A
		{
			get
			{
				return Color.Blue;
			}
		}
		public static Color B
		{
			get
			{
				return Color.Red;
			}
		}
		public static Color C
		{
			get
			{
				return Color.Pink;
			}
		}
		#endregion

		#region Class Methods
		public static Color GetLabelColor(string label)
		{
			// Local Variables
			Color selected = Color.Transparent;

			// Which label is this?
			switch(label.ToUpper())
			{
				case "A":
					selected = A;
					break;

				case "B":
					selected = B;
					break;

				case "C":
					selected = C;
					break;
			}

			// Return selected color
			return selected;
		}
		#endregion
	}
}
