using System;
using System.Drawing;
using System.IO;
using System.Text;

using DRToolbox.Utilities;

namespace DRToolbox.UI.FileImport.Images
{
    public class ImageImporter
    {
        #region Class Constants
        private const int ImageMaxHeight = 32;
        private const int ImageMaxWidth = 32;
        #endregion

        #region Class Methods
        private static double ConvertRGBToGrayScale(Color pixelValue)
        {
            // Local Variables
            double grayscaleValue = 0.0;

            // Calculate gray scale value
            grayscaleValue = (0.3 * pixelValue.R) + (0.59 * pixelValue.G) + (0.11 * pixelValue.B);

            // Return gray scale value
            return grayscaleValue;
        }
        private static string GetFileListAsString(string[] fileNames)
        {
            // Local Variables
            StringBuilder fileList = new StringBuilder(1024);

            // Add each file to the list
            foreach(string currentFile in fileNames)
                fileList.AppendLine(currentFile);

            // Return file list
            return fileList.ToString();
        }
        private static Bitmap ResizeImage(Image source, int newHeight, int newWidth)
        {
            // Local Variables
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using(Graphics graph = Graphics.FromImage(resizedImage))
            {
                // Resize image
                graph.DrawImage(source, 0, 0, newWidth, newHeight);
            }

            // Return resized image
            return resizedImage;
        }

        public static ImportedFile ImportImages(string[] imagesToImport)
        {
            // Local Variables
            ImportTable importData = null;
            Bitmap currentImage = null;
            double[] rowValues = null;

            // Are there images to import?
            if(imagesToImport != null)
            {   // Yes
                // Import images
                foreach(string currentFile in imagesToImport)
                {
                    // Does this file exist?
                    if(File.Exists(currentFile))
                    {   // Yes
                        // Setup import data (if needed)
                        if(importData == null)
                            importData = new ImportTable(ImageMaxHeight * ImageMaxWidth);

                        // Get current image
                        using(currentImage = ResizeImage(Image.FromFile(currentFile), ImageMaxHeight, ImageMaxWidth))
                        {

                            // Create row values array (if needed)
                            if(rowValues == null)
                                rowValues = new double[importData.TableData.Columns.Count - 1];

                            // Read image into array
                            for(int i = 0; i < currentImage.Height; i++)
                            {
                                // Get row values
                                for(int j = 0; j < currentImage.Width; j++)
                                {
                                    // Set current row value
                                    rowValues[j + (i * currentImage.Width)] = ConvertRGBToGrayScale(currentImage.GetPixel(j, i));
                                }
                            }
                        }

                        // Add row to import table
                        importData.AddNewRow(rowValues);
                    }
                    else
                    {   // No
                        // Display error msg
                        ErrorMessageForm.Show("The image '" + currentFile + "' does not exist.", "File Import Error");
                    }
                }
            }
            else
            {   // No
                // Throw exception
                throw new ArgumentNullException("imagesToImport", "No images were selected for importation.");
            }

            // Return the imported file
            return (new ImportedFile(importData, GetFileListAsString(imagesToImport)));
        }
        #endregion

        #region Constructors
        private ImageImporter()
        {
            // Not needed
        }
        #endregion
    }
}