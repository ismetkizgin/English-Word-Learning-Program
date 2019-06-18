using System;
using Dictionary.BL.Abstract;
using Dictionary.BL.DependencyResolvers.Ninject;
using Dictionary.Entity.Concrete;

namespace Dictionary
{
    public partial class WordList : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IWordService _wordService;
        private Word _word;
        public WordList()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();
        }
        void WordFill()
        {
            _word = new Word
            {
                Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id")),
                English = gridView1.GetFocusedRowCellValue("English").ToString(),
                Turkish = gridView1.GetFocusedRowCellValue("Turkish").ToString(),
                Sentence = gridView1.GetFocusedRowCellValue("Sentence").ToString()
            };
        }
        void GridFill()
        {
            gridControl1.DataSource = _wordService.GetAll();
            gridView1.Columns.ColumnByFieldName("Id").Visible = false;
            gridView1.Columns.ColumnByFieldName("Turkish").Caption = "Türkçe Kelime";
            gridView1.Columns.ColumnByFieldName("English").Caption = "İngilizce Kelime";
            gridView1.Columns.ColumnByFieldName("Sentence").Caption = "İngilizce Kelime Örneği";
        }

        private void KelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen.GetWordOparation(0);
            GridFill();
        }

        private void SeçiliKelimeyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordFill();
            _wordService.Delete(_word);
            GridFill();
        }

        private void SeçiliKelimeyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordFill();
            FormOpen.GetWordOparation(_word.Id);
        }

        private void WordList_Load(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}
