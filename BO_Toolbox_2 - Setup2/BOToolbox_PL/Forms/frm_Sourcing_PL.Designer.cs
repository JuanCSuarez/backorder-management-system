namespace BOToolbox_PL.Forms
{
    partial class frm_Sourcing_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sourcing_PL));
            this.lstbox_SrcNot = new System.Windows.Forms.ListBox();
            this.bnt_ClrNot = new System.Windows.Forms.Button();
            this.btn_GetNot = new System.Windows.Forms.Button();
            this.txtbox_Sourc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbox_ETAwr = new System.Windows.Forms.CheckBox();
            this.lbl_Ico1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CopNot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbox_SrcNot
            // 
            this.lstbox_SrcNot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbox_SrcNot.FormattingEnabled = true;
            this.lstbox_SrcNot.Location = new System.Drawing.Point(267, 48);
            this.lstbox_SrcNot.Name = "lstbox_SrcNot";
            this.lstbox_SrcNot.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbox_SrcNot.Size = new System.Drawing.Size(275, 225);
            this.lstbox_SrcNot.TabIndex = 5;
            this.lstbox_SrcNot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbox_SrcNot_MouseDoubleClick);
            // 
            // bnt_ClrNot
            // 
            this.bnt_ClrNot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_ClrNot.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_ClrNot.Location = new System.Drawing.Point(410, 285);
            this.bnt_ClrNot.Name = "bnt_ClrNot";
            this.bnt_ClrNot.Size = new System.Drawing.Size(132, 23);
            this.bnt_ClrNot.TabIndex = 4;
            this.bnt_ClrNot.Text = "<< Clear all >>";
            this.bnt_ClrNot.UseVisualStyleBackColor = true;
            this.bnt_ClrNot.Click += new System.EventHandler(this.bnt_Clear_Click);
            // 
            // btn_GetNot
            // 
            this.btn_GetNot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_GetNot.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetNot.Location = new System.Drawing.Point(12, 285);
            this.btn_GetNot.Name = "btn_GetNot";
            this.btn_GetNot.Size = new System.Drawing.Size(132, 23);
            this.btn_GetNot.TabIndex = 1;
            this.btn_GetNot.Tag = "";
            this.btn_GetNot.Text = "Get note >>";
            this.btn_GetNot.UseVisualStyleBackColor = true;
            this.btn_GetNot.Click += new System.EventHandler(this.btn_GetNot_Click);
            // 
            // txtbox_Sourc
            // 
            this.txtbox_Sourc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_Sourc.Location = new System.Drawing.Point(12, 48);
            this.txtbox_Sourc.Multiline = true;
            this.txtbox_Sourc.Name = "txtbox_Sourc";
            this.txtbox_Sourc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_Sourc.Size = new System.Drawing.Size(234, 225);
            this.txtbox_Sourc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "GSI sourcing note";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(264, 13);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formatted sourcing note";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkbox_ETAwr
            // 
            this.chkbox_ETAwr.AutoSize = true;
            this.chkbox_ETAwr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkbox_ETAwr.Location = new System.Drawing.Point(159, 288);
            this.chkbox_ETAwr.Name = "chkbox_ETAwr";
            this.chkbox_ETAwr.Size = new System.Drawing.Size(87, 17);
            this.chkbox_ETAwr.TabIndex = 2;
            this.chkbox_ETAwr.Text = "ETA warning";
            this.chkbox_ETAwr.UseVisualStyleBackColor = true;
            this.chkbox_ETAwr.CheckedChanged += new System.EventHandler(this.chkbox_ETAwr_CheckedChanged);
            // 
            // lbl_Ico1
            // 
            this.lbl_Ico1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Ico1.Image")));
            this.lbl_Ico1.Location = new System.Drawing.Point(204, 6);
            this.lbl_Ico1.Name = "lbl_Ico1";
            this.lbl_Ico1.Size = new System.Drawing.Size(36, 36);
            this.lbl_Ico1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(502, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 36);
            this.label3.TabIndex = 9;
            // 
            // btn_CopNot
            // 
            this.btn_CopNot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_CopNot.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopNot.Location = new System.Drawing.Point(267, 285);
            this.btn_CopNot.Name = "btn_CopNot";
            this.btn_CopNot.Size = new System.Drawing.Size(132, 23);
            this.btn_CopNot.TabIndex = 3;
            this.btn_CopNot.Tag = "";
            this.btn_CopNot.Text = "Copy >>";
            this.btn_CopNot.UseVisualStyleBackColor = true;
            this.btn_CopNot.Click += new System.EventHandler(this.btn_CopNot_Click);
            // 
            // frm_Sourcing_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.btn_CopNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Ico1);
            this.Controls.Add(this.chkbox_ETAwr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbox_SrcNot);
            this.Controls.Add(this.txtbox_Sourc);
            this.Controls.Add(this.bnt_ClrNot);
            this.Controls.Add(this.btn_GetNot);
            this.Name = "frm_Sourcing_PL";
            this.Text = "Sourcing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_SrcNot;
        private System.Windows.Forms.Button bnt_ClrNot;
        private System.Windows.Forms.Button btn_GetNot;
        private System.Windows.Forms.TextBox txtbox_Sourc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbox_ETAwr;
        private System.Windows.Forms.Label lbl_Ico1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CopNot;
    }
}