using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOToolbox_PL.Forms
{
    public partial class frm_Help_PL : Form
    {
        public frm_Help_PL()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_Contc,"Send feedback mail to Development Team");
        }

        private void btn_Contc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:namer_backorders_grp@oracle.com?subject=BO TOOLBOX FEEDBACK");
        }
    }
}
