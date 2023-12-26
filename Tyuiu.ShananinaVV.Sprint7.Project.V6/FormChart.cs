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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }
        public DataTable patientsData;

        public void UpdateChart(int patientsUnder30, int patientsOver30)
        {
            chartDoctors_SVV.Series.Clear();

            // Создание серии для статистики "Пациенты младше 30 лет"
            Series seriesone = new Series("Пациенты младше 30 лет");
            seriesone.ChartType = SeriesChartType.Column; //столбчатая диаграмма

            // Создание серии для статистики "Пациенты старше 30 лет"
            Series seriestwo = new Series("Пациенты 30 лет и старше");
            seriestwo.ChartType = SeriesChartType.Column;

            // Добавление серий на график
            chartDoctors_SVV.Series.Add(seriesone);
            chartDoctors_SVV.Series.Add(seriestwo);

            // Добавление данных на график
            chartDoctors_SVV.Series["Пациенты младше 30 лет"].Points.AddXY("", patientsUnder30);
            chartDoctors_SVV.Series["Пациенты 30 лет и старше"].Points.AddXY("", patientsOver30);

            // Настройка внешнего вида графика
            chartDoctors_SVV.ChartAreas[0].AxisX.MajorGrid.Enabled = false; //отключаем основную сетку по Х
            chartDoctors_SVV.ChartAreas[0].AxisX.LabelStyle.Enabled = false; //отключаем подписи по Х
            chartDoctors_SVV.ChartAreas[0].AxisY.Title = "Количество пациентов"; //задаем заголовок
            chartDoctors_SVV.ChartAreas[0].AxisY.MajorGrid.Enabled = false; //отлючаем основную сетку по У
        }

        public void UpdateStatistics(int patientsUnder30, int patientsOver30)
        {
            labelYounger_SVV.Text = "Количество пациентов \nмладше 30 лет: " + patientsUnder30.ToString();
            labelOlder_SVV.Text = "Количество пациентов \n30 лет и старше: " + patientsOver30.ToString();
        }

        
    }
}
