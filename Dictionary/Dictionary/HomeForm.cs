using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class HomeForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public HomeForm()
        {
            InitializeComponent();
            Bitmap bmp = Properties.Resources.WordLearning;
            Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (!formContainer.Controls.Contains(FormOpen.InstanceYearsStatistic))
                formContainer.Controls.Add(FormOpen.InstanceYearsStatistic);
            FormOpen.InstanceYearsStatistic.BringToFront();
        }

        private void BtnWordEdit_Click(object sender, EventArgs e)
        {
            FormOpen.GetWordOparation(0);
        }

        private void BtnWordList_Click(object sender, EventArgs e)
        {
            if (!formContainer.Controls.Contains(FormOpen.InstanceWordList))
                formContainer.Controls.Add(FormOpen.InstanceWordList);
            FormOpen.InstanceWordList.BringToFront();
        }

        private void AccordionControlElement1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnWordLearning_Click(object sender, EventArgs e)
        {
            FormOpen.GetWordLearning();
        }

        private void BtnWordTesting_Click(object sender, EventArgs e)
        {
            FormOpen.GetWordTesting();
        }

        private void BtnYearStatistics_Click(object sender, EventArgs e)
        {
            if (!formContainer.Controls.Contains(FormOpen.InstanceYearsStatistic))
                formContainer.Controls.Add(FormOpen.InstanceYearsStatistic);
            FormOpen.InstanceYearsStatistic.BringToFront();
        }
    }
}