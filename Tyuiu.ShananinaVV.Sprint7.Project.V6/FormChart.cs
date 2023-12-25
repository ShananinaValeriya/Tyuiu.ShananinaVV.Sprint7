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
//using System.Globalization;

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
            Series series1 = new Series("Пациенты младше 30 лет");
            series1.ChartType = SeriesChartType.Column;

            // Создание серии для статистики "Пациенты старше 30 лет"
            Series series2 = new Series("Пациенты 30 лет и старше");
            series2.ChartType = SeriesChartType.Column;

            // Добавление серий на график
            chartDoctors_SVV.Series.Add(series1);
            chartDoctors_SVV.Series.Add(series2);

            // Добавление данных на график
            chartDoctors_SVV.Series["Пациенты младше 30 лет"].Points.AddXY("", patientsUnder30);
            chartDoctors_SVV.Series["Пациенты 30 лет и старше"].Points.AddXY("", patientsOver30);

            // Настройка внешнего вида графика
            chartDoctors_SVV.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartDoctors_SVV.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chartDoctors_SVV.ChartAreas[0].AxisY.Title = "Количество пациентов";
            chartDoctors_SVV.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void UpdateStatistics(int patientsUnder30, int patientsOver30)
        {
            labelYounger.Text = "Количество пациентов \nмладше 30 лет: " + patientsUnder30.ToString();
            labelOlder.Text = "Количество пациентов \n30 лет и старше: " + patientsOver30.ToString();
        }

        private void labelYounger_Click(object sender, EventArgs e)
        {

        }

        private void chartDoctors_SVV_Click(object sender, EventArgs e)
        {

        }
    }
}
