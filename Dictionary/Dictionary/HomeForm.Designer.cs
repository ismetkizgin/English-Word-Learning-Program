namespace Dictionary
{
    partial class HomeForm
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
            this.formContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnWordLearning = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnWordOperations = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnWordList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnWordEdit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnWordTesting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStatistics = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnYearStatistics = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.formContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.formContainer.Appearance.Options.UseBackColor = true;
            this.formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainer.Location = new System.Drawing.Point(307, 30);
            this.formContainer.Name = "formContainer";
            this.formContainer.Size = new System.Drawing.Size(862, 684);
            this.formContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnWordLearning,
            this.accordionControlSeparator1,
            this.btnWordOperations,
            this.btnStatistics,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(307, 684);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnWordLearning
            // 
            this.btnWordLearning.ImageOptions.Image = global::Dictionary.Properties.Resources.WordLearning;
            this.btnWordLearning.Name = "btnWordLearning";
            this.btnWordLearning.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnWordLearning.Text = "KELİME ÖĞREN";
            this.btnWordLearning.Click += new System.EventHandler(this.BtnWordLearning_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btnWordOperations
            // 
            this.btnWordOperations.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnWordList,
            this.btnWordEdit,
            this.btnWordTesting});
            this.btnWordOperations.Expanded = true;
            this.btnWordOperations.ImageOptions.Image = global::Dictionary.Properties.Resources.dashboardtitle_32x32;
            this.btnWordOperations.Name = "btnWordOperations";
            this.btnWordOperations.Text = "KELİME İŞLEMLERİ";
            // 
            // btnWordList
            // 
            this.btnWordList.ImageOptions.Image = global::Dictionary.Properties.Resources.WordList;
            this.btnWordList.Name = "btnWordList";
            this.btnWordList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnWordList.Text = "KELİME LİSTESİ";
            this.btnWordList.Click += new System.EventHandler(this.BtnWordList_Click);
            // 
            // btnWordEdit
            // 
            this.btnWordEdit.ImageOptions.Image = global::Dictionary.Properties.Resources.WordAdd;
            this.btnWordEdit.Name = "btnWordEdit";
            this.btnWordEdit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnWordEdit.Text = "KELİME EKLE";
            this.btnWordEdit.Click += new System.EventHandler(this.BtnWordEdit_Click);
            // 
            // btnWordTesting
            // 
            this.btnWordTesting.ImageOptions.Image = global::Dictionary.Properties.Resources.WordTesting;
            this.btnWordTesting.Name = "btnWordTesting";
            this.btnWordTesting.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnWordTesting.Text = "KELİME TEST";
            this.btnWordTesting.Click += new System.EventHandler(this.BtnWordTesting_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnYearStatistics});
            this.btnStatistics.Expanded = true;
            this.btnStatistics.ImageOptions.Image = global::Dictionary.Properties.Resources.fullstackedline_32x32;
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Text = "İSTATİSTİK İŞLEMLERİ";
            // 
            // btnYearStatistics
            // 
            this.btnYearStatistics.ImageOptions.Image = global::Dictionary.Properties.Resources.YearsStatistic;
            this.btnYearStatistics.Name = "btnYearStatistics";
            this.btnYearStatistics.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnYearStatistics.Text = "YILLIK İSTATİSTİK";
            this.btnYearStatistics.Click += new System.EventHandler(this.BtnYearStatistics_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = global::Dictionary.Properties.Resources.cancel_32x32;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "ÇIKIŞ";
            this.accordionControlElement1.Click += new System.EventHandler(this.AccordionControlElement1_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1169, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 714);
            this.ControlContainer = this.formContainer;
            this.Controls.Add(this.formContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "HomeForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer formContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnWordOperations;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnWordList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnWordEdit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStatistics;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnYearStatistics;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnWordLearning;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnWordTesting;
    }
}