using System;
using System.Data;

using DRToolbox.MatLab;
using DRToolbox.Utilities;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

namespace DRToolbox.Techniques
{
    public class MatLabWrapper
    {
        #region Class Objects
        private MatLabTechniques matlabLink = null;
        #endregion

        #region Constructors
        public MatLabWrapper()
        {
            // Does the matlab link exist?
            if(matlabLink == null)
            {   // No
                // Create new link
                matlabLink = new MatLabTechniques();
            }
        }
        #endregion

        #region Class Methods
        public ResultTable ComputeAutoEncoderEA(MWNumericArray sourceData, int desiredDimensions)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Auto Encoder EA
            results = (matlabLink.compute_mapping(sourceData, "AutoEncoderEA", desiredDimensions) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeAutoEncoderRBM(MWNumericArray sourceData, int desiredDimensions)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Auto Encoder RBM
            results = (matlabLink.compute_mapping(sourceData, "AutoEncoderRBM", desiredDimensions) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeCCA(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run CCA
            results = (matlabLink.compute_mapping(sourceData, "CCA", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeCFA(MWNumericArray sourceData, int desiredDimensions, int numAnalyzers, int maxIterations)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run CFA
            results = (matlabLink.compute_mapping(sourceData, "CFA", desiredDimensions, numAnalyzers, maxIterations) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeDiffusionMaps(MWNumericArray sourceData, int desiredDimensions, double tValue, double sigma)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Diffusion Maps
            results = (matlabLink.compute_mapping(sourceData, "DiffusionMaps", desiredDimensions, tValue, sigma) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeFactorAnalysis(MWNumericArray sourceData, int desiredDimensions)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Factor Analysis
            results = (matlabLink.compute_mapping(sourceData, "FactorAnalysis", desiredDimensions) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeHessianLLE(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Hessian LLE
            results = (matlabLink.compute_mapping(sourceData, "HessianLLE", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeIsomap(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Isomap
            results = (matlabLink.compute_mapping(sourceData, "Isomap", desiredDimensions, kValue) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLandmarkIsomap(MWNumericArray sourceData, int desiredDimensions, int kValue, double precentage)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Landmark Isomap
            results = (matlabLink.compute_mapping(sourceData, "LandmarkIsomap", desiredDimensions, kValue, precentage) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLandmarkMVU(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Landmark MVU
            results = (matlabLink.compute_mapping(sourceData, "LandmarkMVU", desiredDimensions, kValue) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLaplacian(MWNumericArray sourceData, int desiredDimensions, int kValue, double sigma)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Laplacian
            results = (matlabLink.compute_mapping(sourceData, "Laplacian", desiredDimensions, kValue, sigma, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLLC(MWNumericArray sourceData, int desiredDimensions, int kValue, int numAnalyzers, int maxIterations)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run LLC
            results = (matlabLink.compute_mapping(sourceData, "LLC", desiredDimensions, kValue, numAnalyzers, maxIterations, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLLE(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run LLE
            results = (matlabLink.compute_mapping(sourceData, "LLE", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLLTSA(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run LLTSA
            results = (matlabLink.compute_mapping(sourceData, "LLTSA", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLPP(MWNumericArray sourceData, int desiredDimensions, int kValue, double sigma)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run LPP
            results = (matlabLink.compute_mapping(sourceData, "LPP", desiredDimensions, kValue, sigma, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeLTSA(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run LTSA
            results = (matlabLink.compute_mapping(sourceData, "LTSA", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeManifoldChart(MWNumericArray sourceData, int desiredDimensions, int numAnalyzers, int maxIterations)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Manifold Chart
            results = (matlabLink.compute_mapping(sourceData, "ManifoldChart", desiredDimensions, numAnalyzers, maxIterations, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeMDS(MWNumericArray sourceData, int desiredDimensions)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run MDS
            results = (matlabLink.compute_mapping(sourceData, "MDS", desiredDimensions) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeMVU(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run MVU
            results = (matlabLink.compute_mapping(sourceData, "MVU", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeNPE(MWNumericArray sourceData, int desiredDimensions, int kValue)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run NPE
            results = (matlabLink.compute_mapping(sourceData, "NPE", desiredDimensions, kValue, "Matlab") as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputePCA(MWNumericArray sourceData, int desiredDimensions)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run PCA
            results = (matlabLink.compute_mapping(sourceData, "PCA", desiredDimensions) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeProbPCA(MWNumericArray sourceData, int desiredDimensions, int maxIterations)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Prob PCA
            results = (matlabLink.compute_mapping(sourceData, "ProbPCA", desiredDimensions, maxIterations) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeSimplePCA(MWNumericArray sourceData, int desiredDimensions)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run Simple PCA
            results = (matlabLink.compute_mapping(sourceData, "SimplePCA", desiredDimensions) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }
        public ResultTable ComputeSNE(MWNumericArray sourceData, int desiredDimensions, double sigma)
        {
            // Local Variables
            MWNumericArray results = null;

            // Run SNE
            results = (matlabLink.compute_mapping(sourceData, "SNE", desiredDimensions, sigma) as MWNumericArray);

            // Return results
            return (results == null ? null : new ResultTable(results));
        }

        public void Dispose()
        {
            // Make sure matlab link is cleaned up
            if(matlabLink != null)
            {
                matlabLink.Dispose();
                matlabLink = null;
            }

            // Make sure the MCR application is closed
            MWMCR.TerminateApplication();
        }
        #endregion
    }
}
