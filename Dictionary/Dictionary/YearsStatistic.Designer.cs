namespace Dictionary
{
    partial class YearsStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drpYears = new System.Windows.Forms.ComboBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // drpYears
            // 
            this.drpYears.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpYears.FormattingEnabled = true;
            this.drpYears.Location = new System.Drawing.Point(287, 15);
            this.drpYears.Name = "drpYears";
            this.drpYears.Size = new System.Drawing.Size(246, 24);
            this.drpYears.TabIndex = 9;
            this.drpYears.SelectedIndexChanged += new System.EventHandler(this.DrpYears_SelectedIndexChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 49);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Black and White";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.SeriesColorizer = null;
            this.chartControl1.Size = new System.Drawing.Size(853, 567);
            this.chartControl1.TabIndex = 10;
            // 
            // YearsStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drpYears);
            this.Controls.Add(this.chartControl1);
            this.Name = "YearsStatistic";
            this.Size = new System.Drawing.Size(853, 616);
            this.Load += new System.EventHandler(this.YearsStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox drpYears;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
