using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOToolbox_BLL.Email;
using BOToolbox_DAL.Email;

namespace BOToolbox_PL.Forms
{
    public partial class frm_Email_PL : Form
    {
        #region Variables declaration
        cls_Email_DAL Obj_Email_DAL = new cls_Email_DAL();
        cls_Email_BLL Obj_Email_BLL = new cls_Email_BLL();
        List<string> menu = new List<string>();
        #endregion

        #region Constructor(s)
        public frm_Email_PL()
        {
            InitializeComponent();
            //Load list of mail templates
            load_MailList();
            cbox_mailList.SelectedIndex = 0;
            tbox_Subj.ReadOnly = false;
            
        }
        #endregion

        /// <summary>
        /// Method to load the list of mail templates into de dropmenu
        /// </summary>
        private void load_MailList()
        {
            //Set the 1st item in the combo box
            cbox_mailList.Items.Add("Select item");
            //Call BLL method to load the combobox list
            Obj_Email_BLL.load_MailList(ref Obj_Email_DAL);
            if (Obj_Email_DAL.sError.Equals(""))
            {
                //Load the sorted Array into the combobox
                for (int j = 0; j < Obj_Email_DAL.lstMen.Count; j++)
                {
                    cbox_mailList.Items.Add(Obj_Email_DAL.lstMen[j]);
                }
            }
            else
            {
                //List loading error handling here
            }
        }

        /// <summary>
        /// Get mail subject
        /// </summary>
        private void get_Subject()
        {
            //Get template name from combobox
            Obj_Email_DAL.sVal = cbox_mailList.SelectedItem.ToString();
            //Call BLL method to get the mail subject
            Obj_Email_BLL.get_mailSubect(ref Obj_Email_DAL);
            if (Obj_Email_DAL.sError.Equals(""))
            {
                tbox_Subj.Text = Obj_Email_DAL.sSub;
            }
        }

        /// <summary>
        /// Get mail body
        /// </summary>
        private void get_Body()
        {
            //Get template name from combobox
            Obj_Email_DAL.sVal = cbox_mailList.SelectedItem.ToString();
            //Call BLL method to get the mail body
            Obj_Email_BLL.get_mailBody(ref Obj_Email_DAL);
            if (Obj_Email_DAL.sError.Equals("") && Obj_Email_DAL.sarrBod != null)
            {
                for (int i = 0; i < Obj_Email_DAL.sarrBod.Length; i++)
                {
                    if (Obj_Email_DAL.sarrBod[i].ToString().Equals(""))
                    {
                        rtbox_Body.Text = rtbox_Body.Text + "\n\n";
                    }
                    else
                    {
                        rtbox_Body.Text = rtbox_Body.Text + Obj_Email_DAL.sarrBod[i].ToString();
                    }                    
                }
            }
        }




        private void cbox_mailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get mail subject
            get_Subject();
            rtbox_Body.Clear();
            //Get mail body
            get_Body();            
        }


        #region Bottom section functions

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txtbox_Row.Text == "")
            {
                MessageBox.Show("Please set the Row Number in your personal tracking file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Obj_Email_DAL.iRow = Int32.Parse(txtbox_Row.Text);
                Obj_Email_DAL.iCol = 3;
                Obj_Email_BLL.import_ExcelCell(ref Obj_Email_DAL);
                MessageBox.Show(Obj_Email_DAL.sVal);

            }
        }

        #endregion

        private void btn_sndM_Click(object sender, EventArgs e)
        {
            if (!tbox_Subj.Text.Equals(""))
            {
                var mailtoUri = "mailto:?subject=" + tbox_Subj.Text + "&body=" + rtbox_Body.Text;

                string mailadr = "";
                string subject = tbox_Subj.Text;
                string bodytext = convertURI(rtbox_Body.Text);
                string MM;

                MM = "Mailto:" + mailadr + "?subject=" + subject + "&body=" +  bodytext;
                Process proc = new Process();
                proc.StartInfo.FileName = MM;
                proc.Start();

            }
        }

        private string convertURI(string sText)
        {
            sText = sText.Replace("\n", "%0A");
            return sText;
        }
    }
}
