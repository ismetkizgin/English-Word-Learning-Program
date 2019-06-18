using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using Dictionary.BL.Abstract;
using Dictionary.BL.DependencyResolvers.Ninject;
using Dictionary.Entity.Concrete;

namespace Dictionary
{
    public partial class WordTesting : XtraForm
    {
        private readonly ILearningWordSevice _learningWordService;
        private readonly IWordService _wordService;
        private LearningWord _learningWord;
        private Word _word;

        public WordTesting()
        {
            InitializeComponent();
            _learningWordService = InstanceFactory.GetInstance<ILearningWordSevice>();
            _wordService = InstanceFactory.GetInstance<IWordService>();
            Bitmap bmp = Properties.Resources.WordTesting;
            Icon = Icon.FromHandle(bmp.GetHicon());
        }

        void NewTestingWord()
        {
            _learningWord = _learningWordService.LearningWordGetNewid();
            if (_learningWord == null)
            {
                XtraMessageBox.Show("Öğrendiğiniz kelime yok veya test sırası gelmemiştir.","Uyarı!");
                Close();
            }
            else
            {
                _word =_wordService.WordGet(_learningWord.WordId);
                lblKelime.Text = _word.English;

                Random rnd = new Random();
                int rndSayi = rnd.Next(0, 3);

                var btn = (SimpleButton)groupBox1.Controls[rndSayi];
                btn.Text = _word.Turkish;

                List<Word> wordList = _wordService.GetAll().Where(x => x.Id != _learningWord.WordId).OrderBy(u => Guid.NewGuid()).Take(3).ToList();

                int i = 0;
                foreach (var word in wordList)
                {
                    if (i == rndSayi)
                        i++;

                    btn = (SimpleButton)groupBox1.Controls[i];
                    btn.Text = word.Turkish;
                    i++;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnswar_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            if (btn.Text == _word.Turkish)
            {
                switch (_learningWord.Stage)
                {
                    case 1:
                        _learningWord.TestDate = _learningWord.LearningDate.AddMonths(1);
                        _learningWord.Stage++;
                        break;
                    case 2:
                        _learningWord.TestDate = _learningWord.LearningDate.AddMonths(6);
                        _learningWord.Stage++;
                        break;
                    case 3:
                        _learningWord.TestDate = _learningWord.LearningDate.AddYears(1);
                        break;
                }

                _learningWordService.Update(_learningWord);
                XtraMessageBox.Show("Doğru cevap verdiniz tebrik ederiz...","Cevap");
            }
            else
            {
                _learningWordService.Delete(_learningWord);
                XtraMessageBox.Show("Yanlış cevap verdiniz üzgünüz...", "Cevap");
            }
            NewTestingWord();
        }

        private void WordTesting_Load(object sender, EventArgs e)
        {
            NewTestingWord();
        }
    }
}