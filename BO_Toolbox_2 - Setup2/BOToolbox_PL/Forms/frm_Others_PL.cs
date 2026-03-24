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
    public partial class frm_Others_PL : Form
    {
        public frm_Others_PL()
        {
            InitializeComponent();
            rbtn_OTH01.Checked = true;
            ToolTip toolTip1 = new ToolTip(); toolTip1.SetToolTip(rbtn_OTH01, "Format: 12 or 15 digits, ex. 1Z3456789012");
            ToolTip toolTip2 = new ToolTip(); toolTip2.SetToolTip(rbtn_OTH02, "Tekelec from MOV or US from T3. Format: 12 or 15 digits, ex. 123456789012");
            ToolTip toolTip3 = new ToolTip(); toolTip3.SetToolTip(rbtn_OTH03, "Brazil. Given tracking number below will need to be re-entered");
            ToolTip toolTip4 = new ToolTip(); toolTip4.SetToolTip(rbtn_OTH04, "Given tracking number below will need to be re-entered");
            ToolTip toolTip5 = new ToolTip(); toolTip5.SetToolTip(rbtn_OTH05, "Format: 25 digits");
            ToolTip toolTip6 = new ToolTip(); toolTip6.SetToolTip(rbtn_OTH06, "Mexico and ESOs. Format: 10 digits, ex. AA99999999 or ESO#");
            ToolTip toolTip9 = new ToolTip(); toolTip9.SetToolTip(rbtn_OTH09, "Oracle internal account dashboard ISO tracker");

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_TrkNum.Text = string.Empty;
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
        /// Main round button selection method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetTrk_Click(object sender, EventArgs e)
        {
            if (txtbox_TrkNum.Text.Equals(string.Empty) && rbtn_OTH03.Checked==false && rbtn_OTH04.Checked == false && rbtn_OTH09.Checked == false)
            {
                MessageBox.Show("There is no Tracking Number to find. Please check and try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string sTracking = txtbox_TrkNum.Text.Trim().ToUpper();
                    sTracking = sTracking.Replace("AWB1: ", "");
                    sTracking = sTracking.Replace("AWB2: ", "");
                    sTracking = sTracking.Replace("AWB3: ", "");
                    sTracking = sTracking.Replace("AWB4: ", "");


                    if (rbtn_OTH01.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH01", sTracking));
                    }
                    else if (rbtn_OTH02.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH02", sTracking));
                    }
                    else if (rbtn_OTH03.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH03", sTracking));
                    }
                    else if (rbtn_OTH04.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH04", sTracking));
                    }
                    else if (rbtn_OTH05.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH05", sTracking));
                    }
                    else if (rbtn_OTH06.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH06", sTracking));
                    }
                    else if (rbtn_OTH07.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH07", sTracking));
                    }
                    else if (rbtn_OTH09.Checked)
                    {
                        launchBrowser(getLinkfromAppCnf("OTH09", sTracking));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Exception during the process excecution: /n" + ex.ToString());
                }
            }

        }
    }
}
