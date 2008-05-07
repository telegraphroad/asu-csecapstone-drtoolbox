using System;
using System.Windows.Forms;

using DRToolbox.Techniques;
using DRToolbox.UI.FileImport;
using DRToolbox.UI.TechniqueParameters;
using DRToolbox.UI.UserControls;
using DRToolbox.Utilities;

namespace DRToolbox.UI.Menus
{
    public class TechniqueMenu : ContextMenu
    {
        #region Class Objects
        private int numControlsAdded = 0;
        private Panel pnlTechniques = null;
        private MainForm mdiParent = null;
        private ImportedFile importFile = null;
        private MatLabWrapper matlabLink = null;
        #endregion

        #region Class Methods
        private void BuildTechniqueMenu()
        {
            // Add each technique to the menu
            this.MenuItems.Add(TechniqueNames.AutoEncoderEA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.AutoEncoderRBM, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.CCA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.CFA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.DiffusionMaps, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.FactorAnalysis, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.HessianLLE, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.Isomap, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LandmarkIsomap, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LandmarkMVU, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.Laplacian, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LLC, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LLE, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LLTSA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LPP, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.LTSA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.ManifoldChart, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.MDS, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.MVU, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.NPE, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.PCA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.ProbPCA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.SimplePCA, menuTechnique_Click);
            this.MenuItems.Add(TechniqueNames.SNE, menuTechnique_Click);
        }
        private TechniqueResults RunTechnique(string techniqueName)
        {
            // Local Variables
            ResultTable resultData = null;
            TechniqueResults results = null;
            
            // Which technique is this?
            if(techniqueName == TechniqueNames.AutoEncoderEA)
            {   //Auto Encoder EA
                // Run Auto Encoder EA technique
                resultData = RunAutoEncoderEA();
            }
            if(techniqueName == TechniqueNames.AutoEncoderRBM)
            {   //Auto Encoder RBM
                // Run Auto Encoder RBM technique
                resultData = RunAutoEncoderRBM();
            }
            if(techniqueName == TechniqueNames.CCA)
            {
                // Run CCA technique
                resultData = RunCCA();
            }
            if(techniqueName == TechniqueNames.DiffusionMaps)
            {
                // Run DiffusionMaps technique
                resultData = RunDiffusionMaps();
            }
            if(techniqueName == TechniqueNames.CFA)
            {
                // Run CFA technique
                resultData = RunCFA();
            }
            if(techniqueName == TechniqueNames.FactorAnalysis)
            {   //Factor Analysis
                // Run Factor Analysis technique
                resultData = RunFactorAnalysis();
            }
            if(techniqueName == TechniqueNames.HessianLLE)
            {
                // Run HessianLLE technique
                resultData = RunHessianLLE();
            }
            if(techniqueName == TechniqueNames.Isomap)
            {   //Isomap
                // Run Isomap technique
                resultData = RunIsomap();
            }
            if(techniqueName == TechniqueNames.LandmarkIsomap)
            {
                // Run LandmarkIsomap technique
                resultData = RunLandmarkIsomap();
            }
            if(techniqueName == TechniqueNames.LandmarkMVU)
            {
                // Run LandmarkMVU technique
                resultData = RunLandmarkMVU();
            }
            if(techniqueName == TechniqueNames.Laplacian)
            {
                // Run Laplacian technique
                resultData = RunLaplacian();
            }
            if(techniqueName == TechniqueNames.LLC)
            {
                // Run LLC technique
                resultData = RunLLC();
            }
            if(techniqueName == TechniqueNames.LLE)
            {   //LLE
                // Run LLE technique
                resultData = RunLLE();
            }
            if(techniqueName == TechniqueNames.LLTSA)
            {
                // Run LLTSA technique
                resultData = RunLLTSA();
            }
            if(techniqueName == TechniqueNames.LTSA)
            {
                // Run LTSA technique
                resultData = RunLTSA();
            }
            if(techniqueName == TechniqueNames.LPP)
            {
                // Run LPP technique
                resultData = RunLPP();
            }
            if(techniqueName == TechniqueNames.ManifoldChart)
            {
                // Run ManifoldChart technique
                resultData = RunManifoldChart();
            }
            if(techniqueName == TechniqueNames.MDS)
            {   //MDS
                // Run MDS technique
                resultData = RunMDS();
            }
            if(techniqueName == TechniqueNames.MVU)
            {
                // Run MVU technique
                resultData = RunMVU();
            }
            if(techniqueName == TechniqueNames.PCA)
            {   //PCA
                // Run PCA technique
                resultData = RunPCA();
            }
            if(techniqueName == TechniqueNames.ProbPCA)
            {
                // Run ProbPCA technique
                resultData = RunProbPCA();
            }
            if(techniqueName == TechniqueNames.SimplePCA)
            {   //Simple PCA
                // Run Simple PCA technique
                resultData = RunSimplePCA();
            }
            if(techniqueName == TechniqueNames.SNE)
            {
                // Run SNE technique
                resultData = RunSNE();
            }

            // Is there result data?
            if(resultData != null && !resultData.IsEmpty)
            {   // Yes
                // Get technique results
                results = new TechniqueResults(importFile.FileName, techniqueName, resultData);
            }

            // Return results
            return results;
        }

        #region Technique Activatation Methods
        private ResultTable RunAutoEncoderEA()
        {
            // Local Variables
            ResultTable results = null;

            try
            {
                // Ensure that there's a matlab link
                if(matlabLink == null)
                    matlabLink = new MatLabWrapper();

                // Display starting progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Running " + TechniqueNames.AutoEncoderEA + "...";

                // Run Auto Encoder EA technique
                results = matlabLink.ComputeAutoEncoderEA(importFile.FileData.NumericArrayData, 3);

                // Display end progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Finished " + TechniqueNames.AutoEncoderEA + ".";
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "Auto Encoder EA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunAutoEncoderRBM()
        {
            // Local Variables
            ResultTable results = null;

            try
            {
                // Ensure that there's a matlab link
                if(matlabLink == null)
                    matlabLink = new MatLabWrapper();

                // Display starting progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Running " + TechniqueNames.AutoEncoderRBM + "...";

                // Run Auto Encoder RBM technique
                results = matlabLink.ComputeAutoEncoderRBM(importFile.FileData.NumericArrayData, 3);

                // Display end progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Finished " + TechniqueNames.AutoEncoderRBM + ".";
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "Auto Encoder RBM Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunCCA()
        {
            // Local Variables
            CCAForm paramForm = new CCAForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.CCA + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeCCA(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.CCA + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "CCA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunCFA()
        {
            // Local Variables
            CFAForm paramForm = new CFAForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.CFA + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeCFA(importFile.FileData.NumericArrayData, 3, paramForm.NumAnalyzers, paramForm.MaxInterations);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.CFA + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "CFA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunDiffusionMaps()
        {
            // Local Variables
            DiffusionMapsForm paramForm = new DiffusionMapsForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.DiffusionMaps + "...";

                    // Run DiffusionMaps technique
                    results = matlabLink.ComputeDiffusionMaps(importFile.FileData.NumericArrayData, 3, paramForm.TValue, paramForm.Sigma);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.DiffusionMaps + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "DiffusionMaps Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunFactorAnalysis()
        {
            // Local Variables
            ResultTable results = null;

            try
            {
                // Ensure that there's a matlab link
                if(matlabLink == null)
                    matlabLink = new MatLabWrapper();

                // Display starting progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Running " + TechniqueNames.FactorAnalysis + "...";

                // Run Factor Analysis technique
                results = matlabLink.ComputeFactorAnalysis(importFile.FileData.NumericArrayData, 3);

                // Display end progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Finished " + TechniqueNames.FactorAnalysis + ".";
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "Factor Analysis Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunHessianLLE()
        {
            // Local Variables
            HessianLLEForm paramForm = new HessianLLEForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.HessianLLE + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeHessianLLE(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.HessianLLE + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "HessianLLE Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunIsomap()
        {
            // Local Variables
            IsomapForm paramForm = new IsomapForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.Isomap + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeIsomap(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.Isomap + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "Isomap Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLandmarkIsomap()
        {
            // Local Variables
            LandmarkIsomapForm paramForm = new LandmarkIsomapForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LandmarkIsomap + "...";

                    // Run LandmarkIsomap technique
                    results = matlabLink.ComputeLandmarkIsomap(importFile.FileData.NumericArrayData, 3, paramForm.KValue, paramForm.Precentage);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LandmarkIsomap + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LandmarkIsomap Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLandmarkMVU()
        {
            // Local Variables
            LandmarkMVUForm paramForm = new LandmarkMVUForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LandmarkMVU + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeLandmarkMVU(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LandmarkMVU + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LandmarkMVU Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLaplacian()
        {
            // Local Variables
            LaplacianForm paramForm = new LaplacianForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.Laplacian + "...";

                    // Run Laplacian technique
                    results = matlabLink.ComputeLaplacian(importFile.FileData.NumericArrayData, 3, paramForm.KValue, paramForm.Sigma);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.Laplacian + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "Laplacian Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLLC()
        {
            // Local Variables
            LLCForm paramForm = new LLCForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LLC + "...";

                    // Run LLC technique
                    results = matlabLink.ComputeLLC(importFile.FileData.NumericArrayData, 3, paramForm.KValue, paramForm.NumAnalyzers, paramForm.MaxInterations);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LLC + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LLC Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLLE()
        {
            // Local Variables
            LLEForm paramForm = new LLEForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LLE + "...";

                    // Run LLE technique
                    results = matlabLink.ComputeLLE(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LLE + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LLE Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLLTSA()
        {
            // Local Variables
            LLTSAForm paramForm = new LLTSAForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LLTSA + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeLLTSA(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LLTSA + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LLTSA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLTSA()
        {
            // Local Variables
            LTSAForm paramForm = new LTSAForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LTSA + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeLTSA(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LTSA + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LTSA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunLPP()
        {
            // Local Variables
            LPPForm paramForm = new LPPForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.LPP + "...";

                    // Run LPP technique
                    results = matlabLink.ComputeLPP(importFile.FileData.NumericArrayData, 3, paramForm.KValue, paramForm.Sigma);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.LPP + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "LPP Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunManifoldChart()
        {
            // Local Variables
            ManifoldChartForm paramForm = new ManifoldChartForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.ManifoldChart + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeManifoldChart(importFile.FileData.NumericArrayData, 3, paramForm.NumAnalyzers, paramForm.MaxInterations);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.ManifoldChart + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "ManifoldChart Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunMDS()
        {
            // Local Variables
            ResultTable results = null;

            try
            {
                // Ensure that there's a matlab link
                if(matlabLink == null)
                    matlabLink = new MatLabWrapper();

                // Display starting progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Running " + TechniqueNames.MDS + "...";

                // Run MDS technique
                results = matlabLink.ComputeMDS(importFile.FileData.NumericArrayData, 3);

                // Display end progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Finished " + TechniqueNames.MDS + ".";
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "MDS Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunMVU()
        {
            // Local Variables
            MVUForm paramForm = new MVUForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.MVU + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeMVU(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.MVU + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "MVU Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunNPE()
        {
            // Local Variables
            NPEForm paramForm = new NPEForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.NPE + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeNPE(importFile.FileData.NumericArrayData, 3, paramForm.KValue);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.NPE + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "NPE Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunPCA()
        {
            // Local Variables
            ResultTable results = null;
            

            try
            {
                // Ensure that there's a matlab link
                if(matlabLink == null)
                    matlabLink = new MatLabWrapper();

                // Display starting progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Running " + TechniqueNames.PCA + "...";

                // Run PCA technique
                results = matlabLink.ComputePCA(importFile.FileData.NumericArrayData, 3);

                // Display end progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Finished " + TechniqueNames.PCA + ".";
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "PCA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunProbPCA()
        {
            // Local Variables
            ProbPCAForm paramForm = new ProbPCAForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.ProbPCA + "...";

                    // Run Isomap technique
                    results = matlabLink.ComputeProbPCA(importFile.FileData.NumericArrayData, 3, paramForm.MaxInterations);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.ProbPCA + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "ProbPCA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunSimplePCA()
        {
            // Local Variables
            ResultTable results = null;

            try
            {
                // Ensure that there's a matlab link
                if(matlabLink == null)
                    matlabLink = new MatLabWrapper();

                // Display starting progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Running " + TechniqueNames.SimplePCA + "...";

                // Run Simple PCA technique
                results = matlabLink.ComputePCA(importFile.FileData.NumericArrayData, 3);

                // Display end progress status
                if(mdiParent != null)
                    mdiParent.StatusMsg = "Finished " + TechniqueNames.SimplePCA + ".";
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "Simple PCA Error");
            }

            // Return results
            return results;
        }
        private ResultTable RunSNE()
        {
            // Local Variables
            SNEForm paramForm = new SNEForm();
            ResultTable results = null;

            try
            {
                // Was the parameter dialog successful?
                if(paramForm.ShowDialog() == DialogResult.OK)
                {   // Yes
                    // Ensure that there's a matlab link
                    if(matlabLink == null)
                        matlabLink = new MatLabWrapper();

                    // Display starting progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Running " + TechniqueNames.SNE + "...";

                    // Run SNE technique
                    results = matlabLink.ComputeSNE(importFile.FileData.NumericArrayData, 3, paramForm.Sigma);

                    // Display end progress status
                    if(mdiParent != null)
                        mdiParent.StatusMsg = "Finished " + TechniqueNames.SNE + ".";
                }
            }
            catch(Exception ex)
            {
                // Display error msg
                ErrorMessageForm.Show(ex.Message, "SNE Error");
            }

            // Return results
            return results;
        }
        #endregion
        #endregion

        #region Constructors
        public TechniqueMenu(Panel parentAttachPoint, ImportedFile fileData)
        {
            // Save parent panel
            pnlTechniques = parentAttachPoint;

            // Grab reference to mdi parent form
            mdiParent = (MainForm.ActiveForm as MainForm);

            // Save import data
            importFile = fileData;

            // Build technique menu
            BuildTechniqueMenu();
        }
        #endregion

        #region Event Handlers
        private void menuTechnique_Click(object sender, EventArgs e)
        {
            // Local Variables
            MenuItem selectedItem = (sender as MenuItem);
            RanTechniqueControl techniqueControl = null;
            TechniqueResults results = null;

            // Was a menu item selected?
            if(selectedItem != null)
            {
                // Run technique
                results = RunTechnique(selectedItem.Text);

                // Are there results?
                if(results != null)
                {
                    // Add technique control to form
                    techniqueControl = new RanTechniqueControl(results);
                    pnlTechniques.Controls.Add(techniqueControl);
                    techniqueControl.Top = numControlsAdded * (techniqueControl.Height + 5);

                    // Update number of controls added to the form
                    numControlsAdded++;
                }
            }
        }
        #endregion
    }
}