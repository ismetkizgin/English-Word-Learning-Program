using System;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using Dictionary.BL.Abstract;
using Dictionary.BL.DependencyResolvers.Ninject;
using Dictionary.Entity.Concrete;

namespace Dictionary
{
    public partial class WordOperation : XtraForm
    {
        /*
         * Add - 0
         * Update - 1
         */
        private readonly int _operation;
        private readonly IWordService _wordService;
        private readonly ILearningWordSevice _learningWordSevice;
        private readonly Word _word;
        public WordOperation(int operation)
        {
            InitializeComponent();
            _operation = operation;
            _wordService = InstanceFactory.GetInstance<IWordService>();
            _learningWordSevice = InstanceFactory.GetInstance<ILearningWordSevice>();
            if (_operation != 0)
                _word = _wordService.WordGet(_operation);
            else
                _word = new Word();
            Bitmap bmp = Properties.Resources.WordAdd;
            Icon = Icon.FromHandle(bmp.GetHicon());
        }

        void WordFill()
        {
            _word.English = txtEnglishWord.Text;
            _word.Turkish = txtTurkishWord.Text;
            _word.Sentence = txtSentence.Text;
        }
        private void WordOperation_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case 0:
                    Text = @"Kelime Ekle";
                    break;
                default:
                    txtSentence.Text = _word.Sentence;
                    txtEnglishWord.Text = _word.English;
                    txtTurkishWord.Text = _word.Turkish;
                    Text = @"Kelime Güncelle";
                    break;
            }
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_operation)
                {
                    case 0:
                        WordFill();
                        _wordService.Add(_word);
                        Word wordTemp = _wordService.GetAll().OrderByDescending(x => x.Id).FirstOrDefault();
                        if (wordTemp != null)
                            _learningWordSevice.Add(new LearningWord
                            {
                                WordId = wordTemp.Id,
                                LearningDate = DateTime.Now,
                                TestDate = DateTime.Now.AddDays(7),
                                Stage = 0
                            });
                        break;
                    default:
                        WordFill();
                        _wordService.Update(_word);
                        break;
                }

                XtraMessageBox.Show(@"İşleminiz başarılı bir şekilde gerçekleştirildi...");
                txtEnglishWord.Text = txtSentence.Text = txtTurkishWord.Text = String.Empty;
                Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,"Uyarı !");
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}