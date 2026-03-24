namespace BOToolbox_PL.Forms
{
    partial class frm_Help_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Help_PL));
            this.btn_Contc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Icon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Contc
            // 
            this.btn_Contc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contc.Location = new System.Drawing.Point(339, 261);
            this.btn_Contc.Name = "btn_Contc";
            this.btn_Contc.Size = new System.Drawing.Size(200, 35);
            this.btn_Contc.TabIndex = 14;
            this.btn_Contc.Text = "Contact us";
            this.btn_Contc.UseVisualStyleBackColor = true;
            this.btn_Contc.Click += new System.EventHandler(this.btn_Contc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(339, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Need help or have questions?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Icon
            // 
            this.lbl_Icon.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Icon.Image")));
            this.lbl_Icon.Location = new System.Drawing.Point(361, 47);
            this.lbl_Icon.Name = "lbl_Icon";
            this.lbl_Icon.Size = new System.Drawing.Size(154, 154);
            this.lbl_Icon.TabIndex = 15;
            // 
            // frm_Help_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.lbl_Icon);
            this.Controls.Add(this.btn_Contc);
            this.Controls.Add(this.label2);
            this.Name = "frm_Help_PL";
            this.Text = "HELP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Contc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Icon;
    }
}