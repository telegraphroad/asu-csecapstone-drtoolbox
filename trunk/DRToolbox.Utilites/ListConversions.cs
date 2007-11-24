using System;

using MathNet.Numerics.LinearAlgebra;
using ZedGraph;

namespace DRToolbox.Utilites
{
    public class ListConversions
    {
        #region Class Methods
        /// <summary>
        /// Convert a 2D Matrix to a PointPairList
        /// </summary>
        public static PointPairList MatrixToPointPairList(Matrix techniqueResults, int desiredDimensions)
        {
            // Local Variables
            PointPairList pointList = new PointPairList();
            PointPair currentPoint = null;

            // Add each row in the matrix to the point pair list
            for(int i = 0; i < techniqueResults.RowCount; i++)
            {
                // What's the desired dimensions?
                switch(desiredDimensions)
                {
                    case 2:
                        // Convert to 2D point
                        currentPoint = new PointPair(techniqueResults[i, 0], techniqueResults[i, 1]);
                        break;

                    case 3:
                        // Convert to 3D point
                        currentPoint = new PointPair(techniqueResults[i, 0], techniqueResults[i, 1], techniqueResults[i, 2]);
                        break;
                }

                // Add current point to list
                pointList.Add(currentPoint);
            }

            //return the pointpairlist
            return pointList;
        }
        #endregion
    }
}
