namespace BOToolbox_PL.Forms
{
    partial class frm_DHLTrack_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DHLTrack_PL));
            this.txtbox_TrkNum = new System.Windows.Forms.TextBox();
            this.grpbox_TrkNum = new System.Windows.Forms.GroupBox();
            this.btn_GetTrk = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.grpbox_DHLTrk = new System.Windows.Forms.GroupBox();
            this.rbtn_DHL06 = new System.Windows.Forms.RadioButton();
            this.rbtn_DHL09 = new System.Windows.Forms.RadioButton();
            this.rbtn_DHL03 = new System.Windows.Forms.RadioButton();
            this.rbtn_DHL02 = new System.Windows.Forms.RadioButton();
            this.rbtn_DHL01 = new System.Windows.Forms.RadioButton();
            this.grpbox_TrkNum.SuspendLayout();
            this.grpbox_DHLTrk.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_TrkNum
            // 
            this.txtbox_TrkNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_TrkNum.Location = new System.Drawing.Point(14, 29);
            this.txtbox_TrkNum.MaxLength = 50;
            this.txtbox_TrkNum.Name = "txtbox_TrkNum";
            this.txtbox_TrkNum.Size = new System.Drawing.Size(250, 22);
            this.txtbox_TrkNum.TabIndex = 10;
            // 
            // grpbox_TrkNum
            // 
            this.grpbox_TrkNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_TrkNum.Controls.Add(this.btn_GetTrk);
            this.grpbox_TrkNum.Controls.Add(this.btn_Clear);
            this.grpbox_TrkNum.Controls.Add(this.txtbox_TrkNum);
            this.grpbox_TrkNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbox_TrkNum.Location = new System.Drawing.Point(12, 228);
            this.grpbox_TrkNum.Name = "grpbox_TrkNum";
            this.grpbox_TrkNum.Size = new System.Drawing.Size(530, 80);
            this.grpbox_TrkNum.TabIndex = 1;
            this.grpbox_TrkNum.TabStop = false;
            this.grpbox_TrkNum.Text = "Tracking number";
            // 
            // btn_GetTrk
            // 
            this.btn_GetTrk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetTrk.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetTrk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GetTrk.Location = new System.Drawing.Point(278, 28);
            this.btn_GetTrk.Name = "btn_GetTrk";
            this.btn_GetTrk.Size = new System.Drawing.Size(120, 23);
            this.btn_GetTrk.TabIndex = 11;
            this.btn_GetTrk.Text = "Get Tracking";
            this.btn_GetTrk.UseVisualStyleBackColor = true;
            this.btn_GetTrk.Click += new System.EventHandler(this.btn_GetTrk_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.Location = new System.Drawing.Point(404, 29);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // grpbox_DHLTrk
            // 
            this.grpbox_DHLTrk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_DHLTrk.Controls.Add(this.rbtn_DHL06);
            this.grpbox_DHLTrk.Controls.Add(this.rbtn_DHL09);
            this.grpbox_DHLTrk.Controls.Add(this.rbtn_DHL03);
            this.grpbox_DHLTrk.Controls.Add(this.rbtn_DHL02);
            this.grpbox_DHLTrk.Controls.Add(this.rbtn_DHL01);
            this.grpbox_DHLTrk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbox_DHLTrk.Location = new System.Drawing.Point(13, 13);
            this.grpbox_DHLTrk.Name = "grpbox_DHLTrk";
            this.grpbox_DHLTrk.Size = new System.Drawing.Size(529, 209);
            this.grpbox_DHLTrk.TabIndex = 2;
            this.grpbox_DHLTrk.TabStop = false;
            this.grpbox_DHLTrk.Text = "DHL Track";
            // 
            // rbtn_DHL06
            // 
            this.rbtn_DHL06.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_DHL06.Image")));
            this.rbtn_DHL06.Location = new System.Drawing.Point(177, 136);
            this.rbtn_DHL06.Name = "rbtn_DHL06";
            this.rbtn_DHL06.Size = new System.Drawing.Size(163, 51);
            this.rbtn_DHL06.TabIndex = 6;
            this.rbtn_DHL06.TabStop = true;
            this.rbtn_DHL06.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtn_DHL06.UseVisualStyleBackColor = true;
            // 
            // rbtn_DHL09
            // 
            this.rbtn_DHL09.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_DHL09.Image")));
            this.rbtn_DHL09.Location = new System.Drawing.Point(346, 136);
            this.rbtn_DHL09.Name = "rbtn_DHL09";
            this.rbtn_DHL09.Size = new System.Drawing.Size(163, 51);
            this.rbtn_DHL09.TabIndex = 9;
            this.rbtn_DHL09.TabStop = true;
            this.rbtn_DHL09.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtn_DHL09.UseVisualStyleBackColor = true;
            // 
            // rbtn_DHL03
            // 
            this.rbtn_DHL03.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_DHL03.Image")));
            this.rbtn_DHL03.Location = new System.Drawing.Point(13, 136);
            this.rbtn_DHL03.Name = "rbtn_DHL03";
            this.rbtn_DHL03.Size = new System.Drawing.Size(163, 51);
            this.rbtn_DHL03.TabIndex = 2;
            this.rbtn_DHL03.TabStop = true;
            this.rbtn_DHL03.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtn_DHL03.UseVisualStyleBackColor = true;
            // 
            // rbtn_DHL02
            // 
            this.rbtn_DHL02.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_DHL02.Image")));
            this.rbtn_DHL02.Location = new System.Drawing.Point(13, 79);
            this.rbtn_DHL02.Name = "rbtn_DHL02";
            this.rbtn_DHL02.Size = new System.Drawing.Size(163, 51);
            this.rbtn_DHL02.TabIndex = 1;
            this.rbtn_DHL02.TabStop = true;
            this.rbtn_DHL02.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtn_DHL02.UseVisualStyleBackColor = true;
            // 
            // rbtn_DHL01
            // 
            this.rbtn_DHL01.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_DHL01.Image")));
            this.rbtn_DHL01.Location = new System.Drawing.Point(15, 24);
            this.rbtn_DHL01.Name = "rbtn_DHL01";
            this.rbtn_DHL01.Size = new System.Drawing.Size(163, 51);
            this.rbtn_DHL01.TabIndex = 0;
            this.rbtn_DHL01.TabStop = true;
            this.rbtn_DHL01.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtn_DHL01.UseVisualStyleBackColor = true;
            // 
            // frm_DHLTrack_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.grpbox_DHLTrk);
            this.Controls.Add(this.grpbox_TrkNum);
            this.Name = "frm_DHLTrack_PL";
            this.Text = "DHL Tracking";
            this.grpbox_TrkNum.ResumeLayout(false);
            this.grpbox_TrkNum.PerformLayout();
            this.grpbox_DHLTrk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_TrkNum;
        private System.Windows.Forms.GroupBox grpbox_TrkNum;
        private System.Windows.Forms.Button btn_GetTrk;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox grpbox_DHLTrk;
        private System.Windows.Forms.RadioButton rbtn_DHL01;
        private System.Windows.Forms.RadioButton rbtn_DHL03;
        private System.Windows.Forms.RadioButton rbtn_DHL02;
        private System.Windows.Forms.RadioButton rbtn_DHL09;
        private System.Windows.Forms.RadioButton rbtn_DHL06;
    }
}