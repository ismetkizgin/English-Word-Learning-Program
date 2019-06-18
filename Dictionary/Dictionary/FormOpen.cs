using System.Windows.Forms;

namespace Dictionary
{
    class FormOpen
    {
        private static WordList _instanceWordList;
        public static WordList InstanceWordList
        {
            get
            {
                if (_instanceWordList == null)
                {
                    _instanceWordList = new WordList();
                    _instanceWordList.Dock = DockStyle.Fill;
                }
                return _instanceWordList;
            }
        }

        private static YearsStatistic _instanceYearsStatistic;
        public static YearsStatistic InstanceYearsStatistic
        {
            get
            {
                if(_instanceYearsStatistic == null)
                {
                    _instanceYearsStatistic = new YearsStatistic();
                    _instanceYearsStatistic.Dock = DockStyle.Fill;
                }
                return _instanceYearsStatistic;
            }
        }
        public static void GetWordLearning()
        {
            WordLearning frm = new WordLearning();
            frm.ShowDialog();
            frm.Dispose();
        }
        public static void GetWordTesting()
        {
            WordTesting frm = new WordTesting();
            frm.ShowDialog();
            frm.Dispose();
        }
        public static void GetWordOparation(int i)
        {
            WordOperation frm = new WordOperation(i);
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}