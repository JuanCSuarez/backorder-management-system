using System;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Win32;

namespace BOToolbox_PL.Forms
{
    public partial class frm_GsiOds_PL : Form
    {
        #region Constructor
        public frm_GsiOds_PL()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip(); toolTip1.SetToolTip(btn_DiCe, "Launch GSI Dispatch Center Application");
            ToolTip toolTip2 = new ToolTip(); toolTip2.SetToolTip(btn_OrMn, "Launch GSI Orden Management Application");
            ToolTip toolTip3 = new ToolTip(); toolTip3.SetToolTip(btn_GsRe, "Check Reservations status via GSI");
            ToolTip toolTip4 = new ToolTip(); toolTip4.SetToolTip(btn_MaTr, "Review material transactions/movements per RSL via GSI");
            ToolTip toolTip5 = new ToolTip(); toolTip5.SetToolTip(btn_PlDe, "Check worldwide stock status via GSI");
            ToolTip toolTip6 = new ToolTip(); toolTip6.SetToolTip(btn_PtHi, "Check global stock status per PN via GSI");
            ToolTip toolTip7 = new ToolTip(); toolTip7.SetToolTip(btn_WbAd, "Generate orders and movements across global RSLs");
            ToolTip toolTip8 = new ToolTip(); toolTip8.SetToolTip(btn_WbRs, "Negative reservations management");
            ToolTip toolTip9 = new ToolTip(); toolTip9.SetToolTip(btn_OpBo, "Get the most recent Open Backorders Report from ODS");
            ToolTip toolTip10 = new ToolTip(); toolTip10.SetToolTip(btn_SpIs, "Get the Spares Internal Orders Report from ODS");
            ToolTip toolTip11 = new ToolTip(); toolTip11.SetToolTip(btn_DVS, "Check for Parts status, chains, reserves and stock levels");
            ToolTip toolTip12 = new ToolTip(); toolTip12.SetToolTip(btn_OdHo, "Open the ODS Home Site");
            //ToolTip toolTip13 = new ToolTip(); toolTip13.SetToolTip(xxx, "");
            //ToolTip toolTip14 = new ToolTip(); toolTip14.SetToolTip(xxx, "");
            ToolTip toolTip15 = new ToolTip(); toolTip15.SetToolTip(btn_EnHo, "Open the Endeca´s Home Site for Planning");
            ToolTip toolTip16 = new ToolTip(); toolTip16.SetToolTip(btn_SiPa, "Check Planning part status via Endeca");
        }
        #endregion

        #region URL opening methods
        /// <summary>
        /// Takes the given Awb & selected button and opens the corresponding URL
        /// </summary>
        /// <param name="sValue"></param>
        /// <param name="sAWB"></param>
        /// <returns></returns>
        private string getLinkfromAppCnf(string sValue, string sAWB)
        {
            return ConfigurationManager.AppSettings[sValue].Replace("[a]", "&").Replace("[e]", "=").Replace("[xAWBx]", sAWB);
        }

        /// <summary>
        /// Opens a given URL based on the user´s select default browser
        /// </summary>
        /// <param name="url"></param>
        private void launchBrowser(string url)
        {
            string browserName = "iexplore.exe";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("chrome"))
                            browserName = "chrome.exe";
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                            browserName = "firefox.exe";
                        else if (progIdValue.ToString().ToLower().Contains("safari"))
                            browserName = "safari.exe";
                        else if (progIdValue.ToString().ToLower().Contains("opera"))
                            browserName = "opera.exe";
                    }
                }
            }
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(browserName, url));
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Button 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DiCe_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA01", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(),"ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrMn_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA02", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GsRe_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA03", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MaTr_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA04", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PlDe_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA05", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PtHi_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA06", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_WbAd_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser(getLinkfromAppCnf("ORA07", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// BUtton 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_WbRs_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser(getLinkfromAppCnf("ORA08", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpBo_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser(getLinkfromAppCnf("ORA09", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SpIs_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser(getLinkfromAppCnf("ORA10", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DVS_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser(getLinkfromAppCnf("ORA11", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        /// <summary>
        /// Button 12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OdHo_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser(getLinkfromAppCnf("ORA12", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BUTTON 13 CODE HERE
        //BUTTON 14 CODE HERE

        /// <summary>
        /// Button 15
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EnHo_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA15", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SiPa_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA16", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
