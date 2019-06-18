namespace Dictionary
{
    partial class WordOperation
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
            this.txtEnglishWord = new DevExpress.XtraEditors.TextEdit();
            this.txtTurkishWord = new DevExpress.XtraEditors.TextEdit();
            this.txtSentence = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurkishWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSentence.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce Kelime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe Kelime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Örnek İngilizce Cümle";
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Location = new System.Drawing.Point(171, 37);
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.Size = new System.Drawing.Size(206, 22);
            this.txtEnglishWord.TabIndex = 3;
            // 
            // txtTurkishWord
            // 
            this.txtTurkishWord.Location = new System.Drawing.Point(171, 65);
            this.txtTurkishWord.Name = "txtTurkishWord";
            this.txtTurkishWord.Size = new System.Drawing.Size(206, 22);
            this.txtTurkishWord.TabIndex = 4;
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(171, 93);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(206, 22);
            this.txtSentence.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::Dictionary.Properties.Resources.actions_deletecircled;
            this.simpleButton1.Location = new System.Drawing.Point(284, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 40);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Çıkış";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = global::Dictionary.Properties.Resources.actions_addcircled;
            this.simpleButton2.Location = new System.Drawing.Point(185, 124);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 40);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Kaydet";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // WordOperation
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 179);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.txtTurkishWord);
            this.Controls.Add(this.txtEnglishWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WordOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WordOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurkishWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSentence.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtEnglishWord;
        private DevExpress.XtraEditors.TextEdit txtTurkishWord;
        private DevExpress.XtraEditors.TextEdit txtSentence;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}