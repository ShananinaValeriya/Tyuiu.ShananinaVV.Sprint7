using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    public partial class FormChartAll : Form
    {
        public FormChartAll()
        {
            InitializeComponent();
        }
        public void UpdateChart(int yesCount, int noCount)
        {
            chartAllAmbDisp_SVV.Series.Clear();

            // Создание серии для статистики 
            Series seriesone = new Series("Пациенты, нуждающиеся \nв амбулаторном лечении");
            seriesone.ChartType = SeriesChartType.Column;

            // Создание серии для статистики 
            Series seriestwo = new Series("Пациенты, НЕ нуждающиеся \nв амбулаторном лечении");
            seriestwo.ChartType = SeriesChartType.Column;

            // Добавление серий на график
            chartAllAmbDisp_SVV.Series.Add(seriesone);
            chartAllAmbDisp_SVV.Series.Add(seriestwo);

            // Добавление данных на график
            chartAllAmbDisp_SVV.Series["Пациенты, нуждающиеся \nв амбулаторном лечении"].Points.AddXY("", yesCount);
            chartAllAmbDisp_SVV.Series["Пациенты, НЕ нуждающиеся \nв амбулаторном лечении"].Points.AddXY("", noCount);

            // Настройка внешнего вида графика
            chartAllAmbDisp_SVV.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartAllAmbDisp_SVV.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chartAllAmbDisp_SVV.ChartAreas[0].AxisY.Title = "Количество пациентов";
            chartAllAmbDisp_SVV.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void UpdateStatistics(int yesCount, int noCount)
        {
            labelYes_SVV.Text = "Количество пациентов, \nнуждающихся в амбулаторном \nлечении: " + yesCount.ToString();
            labelNo_SVV.Text = "Количество пациентов, НЕ \nнуждающихся в амбулаторном \nлечении: " + noCount.ToString();
        }

        public void UpdateChartTwo(int yesCount, int noCount)
        {
            chartAllAmbDisp_SVV.Series.Clear();

            // Создание серии для статистики 
            Series seriesone = new Series("Пациенты, состоящие \nна диспансерном учете");
            seriesone.ChartType = SeriesChartType.Column;

            // Создание серии для статистики 
            Series seriestwo = new Series("Пациенты, НЕ состоящие \nна диспансерном учете");
            seriestwo.ChartType = SeriesChartType.Column;

            // Добавление серий на график
            chartAllAmbDisp_SVV.Series.Add(seriesone);
            chartAllAmbDisp_SVV.Series.Add(seriestwo);

            // Добавление данных на график
            chartAllAmbDisp_SVV.Series["Пациенты, состоящие \nна диспансерном учете"].Points.AddXY("", yesCount);
            chartAllAmbDisp_SVV.Series["Пациенты, НЕ состоящие \nна диспансерном учете"].Points.AddXY("", noCount);

            // Настройка внешнего вида графика
            chartAllAmbDisp_SVV.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartAllAmbDisp_SVV.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chartAllAmbDisp_SVV.ChartAreas[0].AxisY.Title = "Количество пациентов";
            chartAllAmbDisp_SVV.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void UpdateStatisticsTwo(int yesCount, int noCount)
        {
            labelYes_SVV.Text = "Количество пациентов, \nсостоящих на диспансерном \nучете: " + yesCount.ToString();
            labelNo_SVV.Text = "Количество пациентов, НЕ \nсостоящих на диспансерном \nучете: " + noCount.ToString();
        }

    }
}
