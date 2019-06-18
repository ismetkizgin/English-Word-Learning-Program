using System;
using System.Drawing;
using DevExpress.XtraEditors;
using Dictionary.BL.Abstract;
using Dictionary.BL.DependencyResolvers.Ninject;
using Dictionary.Entity.Concrete;

namespace Dictionary
{
    public partial class WordLearning : DevExpress.XtraEditors.XtraForm
    {
        private readonly IWordService _wordService;
        private readonly ILearningWordSevice _learningWordSevice;
        private Word _word = new Word();
        private LearningWord _learningWord = new LearningWord();
        public WordLearning()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();
            _learningWordSevice = InstanceFactory.GetInstance<ILearningWordSevice>();
            Bitmap bmp = Properties.Resources.WordLearning;
            Icon = Icon.FromHandle(bmp.GetHicon());
        }

        void WordNewid()
        {
            _learningWord = _learningWordSevice.LearningWordAddNewid();
            if (_learningWord != null)
            {
                _word = _wordService.WordGet(_learningWord.WordId);

                lblTurkishWord.Text = _word.Turkish;
                lblEnglishWord.Text = _word.English;
                lblSententeEnglish.Text = _word.Sentence;
            }
            else
            {
                XtraMessageBox.Show("Öğrenilebilecek yeni kelime bulunmamaktadır...","Uyarı");
                Close();
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WordLearning_Load(object sender, EventArgs e)
        {
            WordNewid();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            _learningWord.LearningDate = DateTime.Now;
            _learningWord.TestDate = _learningWord.LearningDate.AddDays(7);
            _learningWord.Stage++;
            _learningWordSevice.Update(_learningWord);

            WordNewid();
        }

        private void SimpleButton3_Click(object sender, EventArgs e)
        {
            WordNewid();
        }
    }
}