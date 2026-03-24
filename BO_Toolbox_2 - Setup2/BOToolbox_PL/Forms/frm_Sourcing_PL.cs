using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOToolbox_DAL.QuickNotes;
using BOToolbox_BLL.QuickNotes;
using Tulpep.NotificationWindow;

namespace BOToolbox_PL.Forms
{
    public partial class frm_Sourcing_PL : Form
    {
        #region Variables and Objects
        cls_Sourcing_DAL Obj_Sourcing_DAL = new cls_Sourcing_DAL();
        cls_Sourcing_BLL Obj_Sourcing_BLL = new cls_Sourcing_BLL();
        PopupNotifier pumsg = new PopupNotifier();
                
        #endregion

        #region Constructor
        public frm_Sourcing_PL()
        {
            InitializeComponent();
            pumsg.Image = Properties.Resources.ico_info;
            pumsg.TitleText = "BOTOOLBOX CLIPBOARD";
        }

        
        #endregion

        #region Buttons and control actions

        /// <summary>
        /// Get Note button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetNot_Click(object sender, EventArgs e)
        {
            if (txtbox_Sourc.Text.Equals(""))
            {
                MessageBox.Show("There is no source note. Please check and try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstbox_SrcNot.Items.Clear();
                Obj_Sourcing_DAL.sSourc = txtbox_Sourc.Text.ToString();
                string sNoteType = Obj_Sourcing_DAL.sSourc.Substring(0,5);
                switch (sNoteType)
                {
                    case "[$ABO":
                        Obj_Sourcing_BLL.get_ABOsourcing(ref Obj_Sourcing_DAL);
                        break;
                    case "[$MBO":
                        Obj_Sourcing_BLL.get_MBOsourcing(ref Obj_Sourcing_DAL);
                        break;
                    default:
                        Obj_Sourcing_DAL.sError = "The given note´s format does not correspond to a GSI sourcing note. Please check and try again";
                        break;
                }
                if (Obj_Sourcing_DAL.sError.Equals("NO ERROR"))
                {
                    string[] finalnotes = Obj_Sourcing_DAL.sNotes.Split('|');
                    for (int i = 0; i < finalnotes.Length; i++)
                    {
                        lstbox_SrcNot.Items.Add(finalnotes[i].ToString());
                    }
                }
                else
                {
                    MessageBox.Show(Obj_Sourcing_DAL.sError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Checbox ETA warning action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkbox_ETAwr_CheckedChanged(object sender, EventArgs e)
        {
            //Adds a note of the DHL´s ETA warning
            if (lstbox_SrcNot.Items.Count > 0)
            {
                //Clears the blank
                lstbox_SrcNot.Items.Clear();

                //Identifies the ETA position
                int pos = -1;
                pos = Obj_Sourcing_DAL.sNotes.IndexOf("ETA:");


                //Adds or removes the warning note
                if (chkbox_ETAwr.Checked)
                {
                    if (pos > 0) { Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes.Insert((pos + 24), " (*)"); }
                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "||(*) Parts may be available at System level during the next 24Hrs after being delivered at Whs by the Carrier.";
                }
                else
                {
                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes.Replace(" (*)", "");
                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes.Replace("||(*) Parts may be available at System level during the next 24Hrs after being delivered at Whs by the Carrier.", "");
                }
                string[] finalnotes = Obj_Sourcing_DAL.sNotes.Split('|');
                for (int i = 0; i < finalnotes.Length; i++)
                {
                    lstbox_SrcNot.Items.Add(finalnotes[i].ToString());
                }
            }
        }

        /// <summary>
        /// Copy note button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CopNot_Click(object sender, EventArgs e)
        {
            if (lstbox_SrcNot.Items.Count > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, lstbox_SrcNot.Items.OfType<string>()));
                //MessageBox.Show("Text copied into Clipboard", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pumsg.ContentText = "New format note has been copied!";
                pumsg.Popup();
            }
            else
            {
                pumsg.ContentText = "There is no message to copy!";
                pumsg.Popup();
            }
        }

        /// <summary>
        /// Clear button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnt_Clear_Click(object sender, EventArgs e)
        {
            txtbox_Sourc.Text = string.Empty;
            lstbox_SrcNot.Items.Clear();
            chkbox_ETAwr.Checked = false;
        }

        /// <summary>
        /// Mouse double click on final note action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbox_SrcNot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstbox_SrcNot.Items.Count > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, lstbox_SrcNot.Items.OfType<string>()));
                //MessageBox.Show("Text copied into Clipboard", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pumsg.ContentText = "New format note has been copied!";
                pumsg.Popup();
            }
        }

        #endregion

    }
}
