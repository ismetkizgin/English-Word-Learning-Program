namespace Dictionary
{
    partial class WordLearning
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSententeEnglish = new System.Windows.Forms.Label();
            this.lblTurkishWord = new System.Windows.Forms.Label();
            this.lblEnglishWord = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce Kelime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe Kelime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Örnek İngilizce Cümle";
            // 
            // lblSententeEnglish
            // 
            this.lblSententeEnglish.AutoSize = true;
            this.lblSententeEnglish.Location = new System.Drawing.Point(179, 104);
            this.lblSententeEnglish.Name = "lblSententeEnglish";
            this.lblSententeEnglish.Size = new System.Drawing.Size(137, 17);
            this.lblSententeEnglish.TabIndex = 5;
            this.lblSententeEnglish.Text = "Örnek İngilizce Cümle";
            // 
            // lblTurkishWord
            // 
            this.lblTurkishWord.AutoSize = true;
            this.lblTurkishWord.Location = new System.Drawing.Point(179, 70);
            this.lblTurkishWord.Name = "lblTurkishWord";
            this.lblTurkishWord.Size = new System.Drawing.Size(92, 17);
            this.lblTurkishWord.TabIndex = 4;
            this.lblTurkishWord.Text = "Türkçe Kelime";
            // 
            // lblEnglishWord
            // 
            this.lblEnglishWord.AutoSize = true;
            this.lblEnglishWord.Location = new System.Drawing.Point(179, 30);
            this.lblEnglishWord.Name = "lblEnglishWord";
            this.lblEnglishWord.Size = new System.Drawing.Size(96, 17);
            this.lblEnglishWord.TabIndex = 3;
            this.lblEnglishWord.Text = "İngilizce Kelime";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::Dictionary.Properties.Resources.actions_deletecircled;
            this.simpleButton1.Location = new System.Drawing.Point(325, 147);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 43);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Çıkış";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = global::Dictionary.Properties.Resources.bo_validation;
            this.simpleButton2.Location = new System.Drawing.Point(15, 147);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(147, 43);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Kelime Öğrenildi";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = global::Dictionary.Properties.Resources.reset_32x32;
            this.simpleButton3.Location = new System.Drawing.Point(182, 147);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(120, 43);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Daha Sonra";
            this.simpleButton3.Click += new System.EventHandler(this.SimpleButton3_Click);
            // 
            // WordLearning
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 232);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblSententeEnglish);
            this.Controls.Add(this.lblTurkishWord);
            this.Controls.Add(this.lblEnglishWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "WordLearning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Öğrenme";
            this.Load += new System.EventHandler(this.WordLearning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSententeEnglish;
        private System.Windows.Forms.Label lblTurkishWord;
        private System.Windows.Forms.Label lblEnglishWord;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}