using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using Dictionary.BL.DependencyResolvers.Ninject;
using Dictionary.BL.Abstract;
using Dictionary.Entity.Concrete;
using DevExpress.XtraCharts;

namespace Dictionary
{
    public partial class YearsStatistic : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ILearningWordSevice _learningWordSevice;
        public YearsStatistic()
        {
            InitializeComponent();
            _learningWordSevice = InstanceFactory.GetInstance<ILearningWordSevice>();
        }
        void LoadStatistics(int years)
        {
            List<LearningWord> listLearningWord = _learningWordSevice.GetAll().Where(x => x.Stage != 0).Where(x => x.LearningDate.Year == years).ToList();
            int[] aylikKelimeSayisi = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (var kelime in listLearningWord)
                aylikKelimeSayisi[kelime.LearningDate.Month - 1]++;

            Series series1 = new Series();
            series1.Name = years.ToString();
            series1.Points.Add(new SeriesPoint("Ocak", aylikKelimeSayisi[0]));
            series1.Points.Add(new SeriesPoint("Şubat", aylikKelimeSayisi[1]));
            series1.Points.Add(new SeriesPoint("Mart", aylikKelimeSayisi[2]));
            series1.Points.Add(new SeriesPoint("Nisan", aylikKelimeSayisi[3]));
            series1.Points.Add(new SeriesPoint("Mayıs", aylikKelimeSayisi[4]));
            series1.Points.Add(new SeriesPoint("Haziran", aylikKelimeSayisi[5]));
            series1.Points.Add(new SeriesPoint("Temmuz", aylikKelimeSayisi[6]));
            series1.Points.Add(new SeriesPoint("Ağustos", aylikKelimeSayisi[7]));
            series1.Points.Add(new SeriesPoint("Eylül", aylikKelimeSayisi[8]));
            series1.Points.Add(new SeriesPoint("Ekim", aylikKelimeSayisi[9]));
            series1.Points.Add(new SeriesPoint("Kasım", aylikKelimeSayisi[10]));
            series1.Points.Add(new SeriesPoint("Aralık", aylikKelimeSayisi[11]));
            chartControl1.Series.Clear();
            chartControl1.Series.Add(series1);
        }
        public void LoadDrop()
        {
            drpYears.Items.Clear();
            LearningWord learningWord =
                _learningWordSevice.GetAll().OrderByDescending(x => x.LearningDate).FirstOrDefault();
            if (learningWord != null)
            {
                int sonYil = learningWord.LearningDate.Year;

                learningWord =
                    _learningWordSevice.GetAll().OrderBy(x => x.LearningDate).FirstOrDefault();
                if (learningWord != null)
                {
                    int ilkYil = learningWord.LearningDate.Year;

                    for (int i = ilkYil; i <= sonYil; i++)
                    {
                        drpYears.Items.Add(i);
                    }

                    drpYears.SelectedIndex = 0;
                }
            }
        }

        private void DrpYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStatistics(Convert.ToInt32(drpYears.Text));
        }

        private void YearsStatistic_Load(object sender, EventArgs e)
        {
            LoadDrop();
            if (drpYears.Text != String.Empty)
                LoadStatistics(Convert.ToInt32(drpYears.Text));
            else
            {
                XtraMessageBox.Show("İstatistik verisi bulunmamaktadır !!!", "Uyarı !");
            }
        }
    }
}
