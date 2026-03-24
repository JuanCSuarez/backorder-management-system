namespace BOToolbox_PL.Main
{
    partial class frm_HomeScreen_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HomeScreen_PL));
            this.picbox_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_Main
            // 
            this.picbox_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox_Main.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Main.Image")));
            this.picbox_Main.Location = new System.Drawing.Point(53, 3);
            this.picbox_Main.Name = "picbox_Main";
            this.picbox_Main.Size = new System.Drawing.Size(449, 314);
            this.picbox_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_Main.TabIndex = 1;
            this.picbox_Main.TabStop = false;
            // 
            // frm_HomeScreen_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.picbox_Main);
            this.Name = "frm_HomeScreen_PL";
            this.Text = "frm_HomeScreen_PL";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Main;
    }
}