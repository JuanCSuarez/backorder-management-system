namespace BOToolbox_PL.Forms
{
    partial class frm_Email_PL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Email_PL));
            this.grpbox_Row = new System.Windows.Forms.GroupBox();
            this.txtbox_Row = new System.Windows.Forms.TextBox();
            this.grpbox_Mail = new System.Windows.Forms.GroupBox();
            this.radbut_Reco = new System.Windows.Forms.RadioButton();
            this.radbut_Sour = new System.Windows.Forms.RadioButton();
            this.btn_Send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_mailList = new System.Windows.Forms.ComboBox();
            this.btn_sndM = new System.Windows.Forms.Button();
            this.tbox_Subj = new System.Windows.Forms.TextBox();
            this.lbl_Subj = new System.Windows.Forms.Label();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.rtbox_Body = new System.Windows.Forms.RichTextBox();
            this.grpbox_Row.SuspendLayout();
            this.grpbox_Mail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_Row
            // 
            this.grpbox_Row.Controls.Add(this.txtbox_Row);
            this.grpbox_Row.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbox_Row.Location = new System.Drawing.Point(6, 19);
            this.grpbox_Row.Name = "grpbox_Row";
            this.grpbox_Row.Size = new System.Drawing.Size(127, 56);
            this.grpbox_Row.TabIndex = 0;
            this.grpbox_Row.TabStop = false;
            this.grpbox_Row.Text = "Set Row";
            // 
            // txtbox_Row
            // 
            this.txtbox_Row.Location = new System.Drawing.Point(7, 20);
            this.txtbox_Row.MaxLength = 6;
            this.txtbox_Row.Name = "txtbox_Row";
            this.txtbox_Row.Size = new System.Drawing.Size(109, 20);
            this.txtbox_Row.TabIndex = 5;
            // 
            // grpbox_Mail
            // 
            this.grpbox_Mail.Controls.Add(this.radbut_Reco);
            this.grpbox_Mail.Controls.Add(this.grpbox_Row);
            this.grpbox_Mail.Controls.Add(this.radbut_Sour);
            this.grpbox_Mail.Controls.Add(this.btn_Send);
            this.grpbox_Mail.Enabled = false;
            this.grpbox_Mail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbox_Mail.Location = new System.Drawing.Point(12, 224);
            this.grpbox_Mail.Name = "grpbox_Mail";
            this.grpbox_Mail.Size = new System.Drawing.Size(530, 84);
            this.grpbox_Mail.TabIndex = 1;
            this.grpbox_Mail.TabStop = false;
            this.grpbox_Mail.Text = "E-mail templates";
            // 
            // radbut_Reco
            // 
            this.radbut_Reco.AutoSize = true;
            this.radbut_Reco.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbut_Reco.Location = new System.Drawing.Point(149, 51);
            this.radbut_Reco.Name = "radbut_Reco";
            this.radbut_Reco.Size = new System.Drawing.Size(109, 18);
            this.radbut_Reco.TabIndex = 7;
            this.radbut_Reco.TabStop = true;
            this.radbut_Reco.Text = " GP recovery";
            this.radbut_Reco.UseVisualStyleBackColor = true;
            // 
            // radbut_Sour
            // 
            this.radbut_Sour.AutoSize = true;
            this.radbut_Sour.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbut_Sour.Location = new System.Drawing.Point(149, 27);
            this.radbut_Sour.Name = "radbut_Sour";
            this.radbut_Sour.Size = new System.Drawing.Size(88, 18);
            this.radbut_Sour.TabIndex = 6;
            this.radbut_Sour.TabStop = true;
            this.radbut_Sour.Text = " Sourcing";
            this.radbut_Sour.UseVisualStyleBackColor = true;
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Send.Location = new System.Drawing.Point(257, 49);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(267, 23);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "CREATE";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbox_Body);
            this.groupBox1.Controls.Add(this.lbl_Temp);
            this.groupBox1.Controls.Add(this.lbl_logo);
            this.groupBox1.Controls.Add(this.lbl_Body);
            this.groupBox1.Controls.Add(this.lbl_Subj);
            this.groupBox1.Controls.Add(this.tbox_Subj);
            this.groupBox1.Controls.Add(this.btn_sndM);
            this.groupBox1.Controls.Add(this.cbox_mailList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-mail templates";
            // 
            // cbox_mailList
            // 
            this.cbox_mailList.FormattingEnabled = true;
            this.cbox_mailList.Location = new System.Drawing.Point(93, 27);
            this.cbox_mailList.Name = "cbox_mailList";
            this.cbox_mailList.Size = new System.Drawing.Size(240, 21);
            this.cbox_mailList.TabIndex = 0;
            this.cbox_mailList.SelectedIndexChanged += new System.EventHandler(this.cbox_mailList_SelectedIndexChanged);
            // 
            // btn_sndM
            // 
            this.btn_sndM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sndM.Location = new System.Drawing.Point(349, 25);
            this.btn_sndM.Name = "btn_sndM";
            this.btn_sndM.Size = new System.Drawing.Size(160, 23);
            this.btn_sndM.TabIndex = 4;
            this.btn_sndM.Text = "SEND MAIL";
            this.btn_sndM.UseVisualStyleBackColor = true;
            this.btn_sndM.Click += new System.EventHandler(this.btn_sndM_Click);
            // 
            // tbox_Subj
            // 
            this.tbox_Subj.Location = new System.Drawing.Point(93, 60);
            this.tbox_Subj.Name = "tbox_Subj";
            this.tbox_Subj.Size = new System.Drawing.Size(416, 20);
            this.tbox_Subj.TabIndex = 2;
            // 
            // lbl_Subj
            // 
            this.lbl_Subj.AutoSize = true;
            this.lbl_Subj.Location = new System.Drawing.Point(25, 63);
            this.lbl_Subj.Name = "lbl_Subj";
            this.lbl_Subj.Size = new System.Drawing.Size(55, 13);
            this.lbl_Subj.TabIndex = 8;
            this.lbl_Subj.Text = "SUBJECT";
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Location = new System.Drawing.Point(43, 92);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(37, 13);
            this.lbl_Body.TabIndex = 9;
            this.lbl_Body.Text = "BODY";
            // 
            // lbl_logo
            // 
            this.lbl_logo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_logo.Image")));
            this.lbl_logo.Location = new System.Drawing.Point(20, 110);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(60, 60);
            this.lbl_logo.TabIndex = 11;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(16, 30);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(64, 13);
            this.lbl_Temp.TabIndex = 12;
            this.lbl_Temp.Text = "TEMPLATE";
            // 
            // rtbox_Body
            // 
            this.rtbox_Body.Location = new System.Drawing.Point(93, 92);
            this.rtbox_Body.Name = "rtbox_Body";
            this.rtbox_Body.Size = new System.Drawing.Size(416, 96);
            this.rtbox_Body.TabIndex = 3;
            this.rtbox_Body.Text = "";
            // 
            // frm_Email_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox_Mail);
            this.Name = "frm_Email_PL";
            this.Text = "frm_Email_PL";
            this.grpbox_Row.ResumeLayout(false);
            this.grpbox_Row.PerformLayout();
            this.grpbox_Mail.ResumeLayout(false);
            this.grpbox_Mail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_Row;
        private System.Windows.Forms.TextBox txtbox_Row;
        private System.Windows.Forms.GroupBox grpbox_Mail;
        private System.Windows.Forms.RadioButton radbut_Reco;
        private System.Windows.Forms.RadioButton radbut_Sour;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_mailList;
        private System.Windows.Forms.Label lbl_Subj;
        private System.Windows.Forms.TextBox tbox_Subj;
        private System.Windows.Forms.Button btn_sndM;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.RichTextBox rtbox_Body;
    }
}