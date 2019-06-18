namespace Dictionary
{
    partial class WordList
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kelimeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliKelimeyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliKelimeyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(669, 459);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeEkleToolStripMenuItem,
            this.seçiliKelimeyiGüncelleToolStripMenuItem,
            this.seçiliKelimeyiSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 76);
            // 
            // kelimeEkleToolStripMenuItem
            // 
            this.kelimeEkleToolStripMenuItem.Name = "kelimeEkleToolStripMenuItem";
            this.kelimeEkleToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.kelimeEkleToolStripMenuItem.Text = "Kelime Ekle";
            this.kelimeEkleToolStripMenuItem.Click += new System.EventHandler(this.KelimeEkleToolStripMenuItem_Click);
            // 
            // seçiliKelimeyiGüncelleToolStripMenuItem
            // 
            this.seçiliKelimeyiGüncelleToolStripMenuItem.Name = "seçiliKelimeyiGüncelleToolStripMenuItem";
            this.seçiliKelimeyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.seçiliKelimeyiGüncelleToolStripMenuItem.Text = "Seçili Kelimeyi Güncelle";
            this.seçiliKelimeyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.SeçiliKelimeyiGüncelleToolStripMenuItem_Click);
            // 
            // seçiliKelimeyiSilToolStripMenuItem
            // 
            this.seçiliKelimeyiSilToolStripMenuItem.Name = "seçiliKelimeyiSilToolStripMenuItem";
            this.seçiliKelimeyiSilToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.seçiliKelimeyiSilToolStripMenuItem.Text = "Seçili Kelimeyi Sil";
            this.seçiliKelimeyiSilToolStripMenuItem.Click += new System.EventHandler(this.SeçiliKelimeyiSilToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView1.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // WordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "WordList";
            this.Size = new System.Drawing.Size(669, 459);
            this.Load += new System.EventHandler(this.WordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kelimeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliKelimeyiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliKelimeyiSilToolStripMenuItem;
    }
}
