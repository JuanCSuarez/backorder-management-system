namespace BOToolbox_PL.Forms
{
    partial class frm_GPlinks_PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GPlinks_PL));
            this.grpbox_Title = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_GSI = new System.Windows.Forms.GroupBox();
            this.pnl_GSI = new System.Windows.Forms.Panel();
            this.btn_Apex = new System.Windows.Forms.Button();
            this.btn_Gdmr = new System.Windows.Forms.Button();
            this.btn_OpBo = new System.Windows.Forms.Button();
            this.btn_Ppse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Alts = new System.Windows.Forms.Button();
            this.btn_Hand = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cloud = new System.Windows.Forms.Button();
            this.btn_Iden = new System.Windows.Forms.Button();
            this.btn_MyDe = new System.Windows.Forms.Button();
            this.btn_MyOr = new System.Windows.Forms.Button();
            this.grpbox_Title.SuspendLayout();
            this.grpbox_GSI.SuspendLayout();
            this.pnl_GSI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_Title
            // 
            this.grpbox_Title.Controls.Add(this.label1);
            this.grpbox_Title.Location = new System.Drawing.Point(14, 8);
            this.grpbox_Title.Name = "grpbox_Title";
            this.grpbox_Title.Size = new System.Drawing.Size(527, 51);
            this.grpbox_Title.TabIndex = 3;
            this.grpbox_Title.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANNING AND ORACLE LINKS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // grpbox_GSI
            // 
            this.grpbox_GSI.Controls.Add(this.pnl_GSI);
            this.grpbox_GSI.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbox_GSI.Location = new System.Drawing.Point(12, 65);
            this.grpbox_GSI.Name = "grpbox_GSI";
            this.grpbox_GSI.Size = new System.Drawing.Size(262, 138);
            this.grpbox_GSI.TabIndex = 4;
            this.grpbox_GSI.TabStop = false;
            this.grpbox_GSI.Text = "Planning";
            // 
            // pnl_GSI
            // 
            this.pnl_GSI.BackColor = System.Drawing.Color.Black;
            this.pnl_GSI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_GSI.Controls.Add(this.btn_Apex);
            this.pnl_GSI.Controls.Add(this.btn_Gdmr);
            this.pnl_GSI.Controls.Add(this.btn_OpBo);
            this.pnl_GSI.Location = new System.Drawing.Point(11, 20);
            this.pnl_GSI.Name = "pnl_GSI";
            this.pnl_GSI.Size = new System.Drawing.Size(240, 105);
            this.pnl_GSI.TabIndex = 0;
            // 
            // btn_Apex
            // 
            this.btn_Apex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Apex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Apex.Location = new System.Drawing.Point(10, 11);
            this.btn_Apex.Name = "btn_Apex";
            this.btn_Apex.Size = new System.Drawing.Size(105, 38);
            this.btn_Apex.TabIndex = 1;
            this.btn_Apex.Text = "APEX BO Tool";
            this.btn_Apex.UseVisualStyleBackColor = false;
            this.btn_Apex.Click += new System.EventHandler(this.btn_Apex_Click);
            // 
            // btn_Gdmr
            // 
            this.btn_Gdmr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Gdmr.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gdmr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Gdmr.Location = new System.Drawing.Point(121, 11);
            this.btn_Gdmr.Name = "btn_Gdmr";
            this.btn_Gdmr.Size = new System.Drawing.Size(105, 38);
            this.btn_Gdmr.TabIndex = 2;
            this.btn_Gdmr.Text = "GDMR";
            this.btn_Gdmr.UseVisualStyleBackColor = false;
            this.btn_Gdmr.Click += new System.EventHandler(this.btn_Gdmr_Click);
            // 
            // btn_OpBo
            // 
            this.btn_OpBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_OpBo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpBo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_OpBo.Location = new System.Drawing.Point(10, 55);
            this.btn_OpBo.Name = "btn_OpBo";
            this.btn_OpBo.Size = new System.Drawing.Size(105, 38);
            this.btn_OpBo.TabIndex = 3;
            this.btn_OpBo.Text = "Open BO Report";
            this.btn_OpBo.UseVisualStyleBackColor = false;
            this.btn_OpBo.Click += new System.EventHandler(this.btn_OpBo_Click);
            // 
            // btn_Ppse
            // 
            this.btn_Ppse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Ppse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ppse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Ppse.Location = new System.Drawing.Point(121, 11);
            this.btn_Ppse.Name = "btn_Ppse";
            this.btn_Ppse.Size = new System.Drawing.Size(105, 38);
            this.btn_Ppse.TabIndex = 6;
            this.btn_Ppse.Text = "PPSE";
            this.btn_Ppse.UseVisualStyleBackColor = false;
            this.btn_Ppse.Click += new System.EventHandler(this.btn_Ppse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(280, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Technical Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Alts);
            this.panel1.Controls.Add(this.btn_Ppse);
            this.panel1.Controls.Add(this.btn_Hand);
            this.panel1.Location = new System.Drawing.Point(11, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 105);
            this.panel1.TabIndex = 0;
            // 
            // btn_Alts
            // 
            this.btn_Alts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Alts.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Alts.Location = new System.Drawing.Point(121, 55);
            this.btn_Alts.Name = "btn_Alts";
            this.btn_Alts.Size = new System.Drawing.Size(105, 38);
            this.btn_Alts.TabIndex = 8;
            this.btn_Alts.Text = "Alternative PNs";
            this.btn_Alts.UseVisualStyleBackColor = false;
            this.btn_Alts.Click += new System.EventHandler(this.btn_Alts_Click);
            // 
            // btn_Hand
            // 
            this.btn_Hand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Hand.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hand.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Hand.Location = new System.Drawing.Point(10, 11);
            this.btn_Hand.Name = "btn_Hand";
            this.btn_Hand.Size = new System.Drawing.Size(105, 38);
            this.btn_Hand.TabIndex = 5;
            this.btn_Hand.Text = "Handbook";
            this.btn_Hand.UseVisualStyleBackColor = false;
            this.btn_Hand.Click += new System.EventHandler(this.btn_Hand_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(14, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Oracle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Cloud);
            this.panel2.Controls.Add(this.btn_Iden);
            this.panel2.Controls.Add(this.btn_MyDe);
            this.panel2.Controls.Add(this.btn_MyOr);
            this.panel2.Location = new System.Drawing.Point(11, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 63);
            this.panel2.TabIndex = 0;
            // 
            // btn_Cloud
            // 
            this.btn_Cloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Cloud.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cloud.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cloud.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cloud.Image")));
            this.btn_Cloud.Location = new System.Drawing.Point(387, 11);
            this.btn_Cloud.Name = "btn_Cloud";
            this.btn_Cloud.Size = new System.Drawing.Size(105, 38);
            this.btn_Cloud.TabIndex = 12;
            this.btn_Cloud.Text = "Oracle Cloud";
            this.btn_Cloud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cloud.UseVisualStyleBackColor = false;
            this.btn_Cloud.Click += new System.EventHandler(this.btn_Cloud_Click);
            // 
            // btn_Iden
            // 
            this.btn_Iden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Iden.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iden.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Iden.Image = ((System.Drawing.Image)(resources.GetObject("btn_Iden.Image")));
            this.btn_Iden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Iden.Location = new System.Drawing.Point(264, 11);
            this.btn_Iden.Name = "btn_Iden";
            this.btn_Iden.Size = new System.Drawing.Size(105, 38);
            this.btn_Iden.TabIndex = 11;
            this.btn_Iden.Text = "Identity Self Serv";
            this.btn_Iden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Iden.UseVisualStyleBackColor = false;
            this.btn_Iden.Click += new System.EventHandler(this.btn_Iden_Click);
            // 
            // btn_MyDe
            // 
            this.btn_MyDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_MyDe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyDe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_MyDe.Image = ((System.Drawing.Image)(resources.GetObject("btn_MyDe.Image")));
            this.btn_MyDe.Location = new System.Drawing.Point(131, 11);
            this.btn_MyDe.Name = "btn_MyDe";
            this.btn_MyDe.Size = new System.Drawing.Size(105, 38);
            this.btn_MyDe.TabIndex = 10;
            this.btn_MyDe.Text = "My Desktop";
            this.btn_MyDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MyDe.UseVisualStyleBackColor = false;
            this.btn_MyDe.Click += new System.EventHandler(this.btn_MyDe_Click);
            // 
            // btn_MyOr
            // 
            this.btn_MyOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_MyOr.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyOr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_MyOr.Image = ((System.Drawing.Image)(resources.GetObject("btn_MyOr.Image")));
            this.btn_MyOr.Location = new System.Drawing.Point(10, 11);
            this.btn_MyOr.Name = "btn_MyOr";
            this.btn_MyOr.Size = new System.Drawing.Size(105, 38);
            this.btn_MyOr.TabIndex = 9;
            this.btn_MyOr.Text = "My Oracle";
            this.btn_MyOr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MyOr.UseVisualStyleBackColor = false;
            this.btn_MyOr.Click += new System.EventHandler(this.btn_MyOr_Click);
            // 
            // frm_GPlinks_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox_GSI);
            this.Controls.Add(this.grpbox_Title);
            this.Name = "frm_GPlinks_PL";
            this.Text = "frm_GPlinks_PL";
            this.grpbox_Title.ResumeLayout(false);
            this.grpbox_GSI.ResumeLayout(false);
            this.pnl_GSI.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbox_GSI;
        private System.Windows.Forms.Panel pnl_GSI;
        private System.Windows.Forms.Button btn_OpBo;
        private System.Windows.Forms.Button btn_Gdmr;
        private System.Windows.Forms.Button btn_Ppse;
        private System.Windows.Forms.Button btn_Apex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Hand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Cloud;
        private System.Windows.Forms.Button btn_Iden;
        private System.Windows.Forms.Button btn_MyDe;
        private System.Windows.Forms.Button btn_MyOr;
        private System.Windows.Forms.Button btn_Alts;
    }
}