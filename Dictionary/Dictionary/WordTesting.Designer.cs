namespace Dictionary
{
    partial class WordTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordTesting));
            this.lblKelime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnD = new DevExpress.XtraEditors.SimpleButton();
            this.btnC = new DevExpress.XtraEditors.SimpleButton();
            this.btnB = new DevExpress.XtraEditors.SimpleButton();
            this.btnA = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(86, 107);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(163, 23);
            this.lblKelime.TabIndex = 1;
            this.lblKelime.Text = "İngilizce Kelime";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Controls.Add(this.btnB);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Location = new System.Drawing.Point(26, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(164, 77);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(110, 47);
            this.btnD.TabIndex = 3;
            this.btnD.Click += new System.EventHandler(this.BtnAnswar_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(6, 77);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(117, 47);
            this.btnC.TabIndex = 2;
            this.btnC.Click += new System.EventHandler(this.BtnAnswar_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(164, 11);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(110, 44);
            this.btnB.TabIndex = 1;
            this.btnB.Click += new System.EventHandler(this.BtnAnswar_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(6, 11);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(117, 44);
            this.btnA.TabIndex = 0;
            this.btnA.Click += new System.EventHandler(this.BtnAnswar_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.SvgImage = global::Dictionary.Properties.Resources.actions_deletecircled;
            this.btnClose.Location = new System.Drawing.Point(342, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Çıkış";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 90);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelimenin Türkçesini Seçin";
            // 
            // WordTesting
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKelime);
            this.Name = "WordTesting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Test";
            this.Load += new System.EventHandler(this.WordTesting_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnD;
        private DevExpress.XtraEditors.SimpleButton btnC;
        private DevExpress.XtraEditors.SimpleButton btnB;
        private DevExpress.XtraEditors.SimpleButton btnA;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}