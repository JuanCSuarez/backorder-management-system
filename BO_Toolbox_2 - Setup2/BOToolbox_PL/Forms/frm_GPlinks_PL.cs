using Microsoft.Win32;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace BOToolbox_PL.Forms
{
    public partial class frm_GPlinks_PL : Form
    {
        #region Constructor
        public frm_GPlinks_PL()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip(); toolTip1.SetToolTip(btn_Apex, "Backorders Team Apex Tool");
            ToolTip toolTip2 = new ToolTip(); toolTip2.SetToolTip(btn_Gdmr, "Oracle Process Repository");
            ToolTip toolTip3 = new ToolTip(); toolTip3.SetToolTip(btn_OpBo, "OraDocs: Open Backorders Report from Global Planning");
            //ToolTip toolTip4 = new ToolTip(); toolTip4.SetToolTip(btn_xxxx, "");
            ToolTip toolTip5 = new ToolTip(); toolTip5.SetToolTip(btn_Hand, "Oracle Parts Technical Handbook");
            ToolTip toolTip6 = new ToolTip(); toolTip6.SetToolTip(btn_Ppse, "OraDocs: PPSE Report from Global Planning");
            //ToolTip toolTip7 = new ToolTip(); toolTip7.SetToolTip(btn_xxxx, "");
            ToolTip toolTip8 = new ToolTip(); toolTip8.SetToolTip(btn_Alts, "APEX: Alternative PNs for Backorders");
            ToolTip toolTip9 = new ToolTip(); toolTip9.SetToolTip(btn_MyOr, "My Oracle Web Site");
            ToolTip toolTip10 = new ToolTip(); toolTip10.SetToolTip(btn_MyDe, "Your PC Hardware and Software status");
            ToolTip toolTip11 = new ToolTip(); toolTip11.SetToolTip(btn_Iden, "Change access passwords and request responsibilities");
            ToolTip toolTip12 = new ToolTip(); toolTip12.SetToolTip(btn_Cloud, "Goals, Performance Review and Career Development");
        }
        #endregion

        #region URL management methods
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
        #endregion

        #region Buttons
        /// <summary>
        /// Button 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Apex_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA20", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Gdmr_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA21", ""));
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
        private void btn_OpBo_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA22", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///BUTTON 4 CODE HERE

        /// <summary>
        /// Button 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Hand_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA24", ""));
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
        private void btn_Ppse_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA25", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BUTTON 7 CODE HERE

        /// <summary>
        /// Button 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Alts_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA27", ""));
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
        private void btn_MyOr_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA28", ""));
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
        private void btn_MyDe_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA29", ""));
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
        private void btn_Iden_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA30", ""));
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
        private void btn_Cloud_Click(object sender, EventArgs e)
        {
            try
            {
                launchBrowser("https://" + getLinkfromAppCnf("ORA31", ""));
            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an excecution error while opening the URL: " + e1.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
