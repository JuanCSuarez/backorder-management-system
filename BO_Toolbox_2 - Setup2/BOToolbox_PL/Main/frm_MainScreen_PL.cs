using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

//https://www.youtube.com/watch?v=JP5rgXO_5Sk 
//13:36

namespace BOToolbox_PL.Main
{
    public partial class frm_MainScreen_PL : Form
    {
        #region Variables declaration
        private Form activeForm = null; //Variable for the currenlty active form
        #endregion

        #region Constructor
        public frm_MainScreen_PL()
        {
            InitializeComponent();
            customizeDesign();
            #region Tooltips
            ToolTip toolTip01 = new ToolTip(); toolTip01.SetToolTip(btn_ODS, "GSI Apps and ODS data bases");
            ToolTip toolTip02 = new ToolTip(); toolTip02.SetToolTip(btn_PlOr, "Global Planning, Backorders and My Oracle Links");
            ToolTip toolTip03 = new ToolTip(); toolTip03.SetToolTip(btn_GDMR, "GDMR direct process reference");
            ToolTip toolTip04 = new ToolTip(); toolTip04.SetToolTip(btn_Sourc, "GSI format to standard text format sourcing note converter");
            ToolTip toolTip05 = new ToolTip(); toolTip05.SetToolTip(btn_Email, "Backorders e-mail templates");
            ToolTip toolTip06 = new ToolTip(); toolTip06.SetToolTip(btn_Apex, "APEX sourcing notes");
            ToolTip toolTip07 = new ToolTip(); toolTip07.SetToolTip(btn_Vario, "GSI backorder note templates");
            ToolTip toolTip08 = new ToolTip(); toolTip08.SetToolTip(btn_DHL, "DHL tracking");
            ToolTip toolTip09 = new ToolTip(); toolTip09.SetToolTip(btn_Others, "Other delivery services tracking");
            ToolTip toolTip10 = new ToolTip(); toolTip10.SetToolTip(btn_Feedb, "Send your feedback via e-mail");
            ToolTip toolTip11 = new ToolTip(); toolTip11.SetToolTip(btn_Relea, "This version release notes");
            ToolTip toolTip12 = new ToolTip(); toolTip12.SetToolTip(btn_About, "The minds behind the Project");
            ToolTip toolTip13 = new ToolTip(); toolTip13.SetToolTip(btn_Home, "Back to Main Screen");
            ToolTip toolTip14 = new ToolTip(); toolTip14.SetToolTip(btn_Zoom, "Launch Zoom");
            ToolTip toolTip15 = new ToolTip(); toolTip15.SetToolTip(btn_Slck, "Launch Slack");
            ToolTip toolTip16 = new ToolTip(); toolTip16.SetToolTip(btn_Exit, "Exit and close the Application");
            #endregion
        }
        #endregion

        #region Mainscreen setup and Show&Hide Submenu methods

        /// <summary>
        /// Method to set default screen design
        /// </summary>
        private void customizeDesign()
        {
            pnl_Link.Visible = false;
            pnl_Note.Visible = false;
            pnl_Trac.Visible = false;
            pnl_Help.Visible = false;
        }

        /// <summary>
        /// Method to hide visible submenus
        /// </summary>
        private void hideSubmenu()
        {
            if (pnl_Link.Visible == true){pnl_Link.Visible = false;}
            if (pnl_Note.Visible == true){pnl_Note.Visible = false;}
            if (pnl_Trac.Visible == true){pnl_Trac.Visible = false;}
            if (pnl_Help.Visible == true){pnl_Help.Visible = false;}
        }

        /// <summary>
        /// Method to show the given Submenu
        /// </summary>
        /// <param name="subMenu"></param>
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_Link_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Link);
        }

        private void btn_Notes_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Note);
        }

        private void btn_Track_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Trac);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Help);
        }

        #endregion

        #region Left menu Button functions
    
        /// <summary>
        /// Method to change to new menu and close the previous one 
        /// </summary>
        /// <param name="childForm"></param>
        private void open_ChildrenPanel(Form childForm)
        {
            //Close previous Form -if active- and open the new one
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false; //Avoid Form to act as main control
            //Set visual values
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //Add Form controls to Child Panel, associate it with it and bring it front
            pnl_MainChild.Controls.Add(childForm);
            pnl_MainChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// HOME SCREEN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Main.frm_HomeScreen_PL());
            customizeDesign();
            /*
            Code goes here
            */
            //hideSubmenu();
        }
       
        #region LINKS SECTION

        /// <summary>
        /// ODS Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ODS_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_GsiOds_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// Planning and Oracle links Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PlOr_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_GPlinks_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// GDMR Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntr_GDMR_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Main.frm_WIP_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }
        
        #endregion

        #region QUICK NOTES SECTION

        /// <summary>
        /// Sourcing notes Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sourc_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_Sourcing_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// E-mail templates Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Email_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Main.frm_WIP_PL());
            //open_ChildrenPanel(new Forms.frm_Email_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// APEX data Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Apex_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Main.frm_WIP_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// Various Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Vario_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Main.frm_WIP_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        #endregion

        #region TRACKING SECTION

        /// <summary>
        /// DHL tracking Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DHL_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_DHLTrack_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// Other tracking Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnt_Others_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_Others_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        #endregion

        #region HELP SECTION

        /// <summary>
        /// Feedback Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Feedb_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_Help_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// Release notes Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Relea_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_RelNotes_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        /// <summary>
        /// About Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_About_Click(object sender, EventArgs e)
        {
            open_ChildrenPanel(new Forms.frm_About_PL());
            /*
            Code goes here
            */
            //hideSubmenu();
        }

        #endregion

        #endregion

        #region Bottom menu Button functions

        /// <summary>
        /// ZOOM launch button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            string zoomDirectory = "";
            try
            {
                zoomDirectory = Environment.ExpandEnvironmentVariables(@"C:\Program Files\Zoom\bin");
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = $@"{zoomDirectory}\Zoom.exe",
                    Arguments = $"--url={""}",
                    WorkingDirectory = zoomDirectory
                };
                Process.Start(startInfo);

            }
            catch (Exception)
            {
                MessageBox.Show("Error while tryin to open ZOOM: THE SYSTEM CANNOT FIND THE APPLICATION LAUNCHER\n" + zoomDirectory, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// SLACK launch button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Slck_Click(object sender, EventArgs e)
        {
            string slackDirectory = "";
            try
            {
                slackDirectory = Environment.ExpandEnvironmentVariables(@"%userprofile%\AppData\Local\slack");
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = $@"{slackDirectory}\slack.exe",
                    Arguments = $"--url={""}",
                    WorkingDirectory = slackDirectory
                };
                Process.Start(startInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Error while tryin to open SLACK: THE SYSTEM CANNOT FIND THE APPLICATION LAUNCHER\n" + slackDirectory, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// EXIT APPLICATION button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit the Application?", "CONFIRM"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion


    }
}
