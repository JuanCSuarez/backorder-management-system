using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Win32;

namespace BOToolbox_PL.Forms
{
    public partial class frm_DHLTrack_PL : Form
    {

        #region CONSTRCUTOR
        public frm_DHLTrack_PL()
        {
            InitializeComponent();
            rbtn_DHL01.Checked = true;
            ToolTip toolTip1 = new ToolTip(); toolTip1.SetToolTip(rbtn_DHL01, "Format: 10 digits, ex. 3213213213");
            ToolTip toolTip2 = new ToolTip(); toolTip2.SetToolTip(rbtn_DHL02, "");
            ToolTip toolTip3 = new ToolTip(); toolTip3.SetToolTip(rbtn_DHL03, "Format: 7 digits, ex. 8AAY489");
            ToolTip toolTip6 = new ToolTip(); toolTip6.SetToolTip(rbtn_DHL06, "DHL´s Same Day tracking for NFO orders");
            ToolTip toolTip9 = new ToolTip(); toolTip9.SetToolTip(rbtn_DHL09, "Make sure you have an active account");
        }
        #endregion

        /// <summary>
        /// Clear button method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_TrkNum.Text = string.Empty;
        }

        /// <summary>
        /// Takes the given Awb & selected button and opens the corresponding URL
        /// </summary>
        /// <param name="sValue"></param>
        /// <param name="sAWB"></param>
        /// <returns></returns>
        private string getLinkfromAppCnf(string sValue, string sAWB)
        {
            return ConfigurationManager.AppSettings[sValue].Replace("[a]","&").Replace("[e]","=").Replace("[xAWBx]", sAWB);
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

        /// <summary>
        /// Main round button selection method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetTrk_Click(object sender, EventArgs e)
        {
            if (rbtn_DHL09.Checked == true || rbtn_DHL06.Checked == true || !txtbox_TrkNum.Text.Equals(string.Empty))
            {
                try
                {
                    string sTracking = txtbox_TrkNum.Text.Trim().ToUpper();
                    sTracking = sTracking.Replace("AWB1: ", "");
                    sTracking = sTracking.Replace("AWB2: ", "");
                    sTracking = sTracking.Replace("AWB3: ", "");
                    sTracking = sTracking.Replace("AWB4: ", "");

                    if (rbtn_DHL01.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("DHL01", sTracking));
                    }
                    else if (rbtn_DHL02.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("DHL02", sTracking));
                    }
                    else if (rbtn_DHL03.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("DHL03", sTracking));
                    }
                    else if (rbtn_DHL06.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("DHL06", sTracking));
                    }
                    else if (rbtn_DHL09.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("DHL09", sTracking));
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("There was an Exception during the process excecution: /n" + er.ToString());
                }
            }
            else
            {
                MessageBox.Show("There is no Tracking Number to find. Please check and try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
