using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    
    public partial class FormStatistics : Form
    {

        private DataGridView dataGridViewDoctors_SVV;
        public FormStatistics(DataGridView dataGridViewDoctors_SVV)
        {
            
            InitializeComponent();
            this.dataGridViewDoctors_SVV = dataGridViewDoctors_SVV;
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            int count = dataGridViewDoctors_SVV.Rows.Count;
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (DataGridViewRow columns in dataGridViewDoctors_SVV.Rows)
            {
                // Предполагается, что значение находится в ячейке с индексом 0
                double value = double.Parse(columns.Cells[0].Value.ToString());
                sum += value;

                if (value < min)
                {
                    min = value;
                }

                if (value > max)
                {
                    max = value;
                }
            }

            double average = sum / count;

            labelCount_SVV.Text = "Количество: " + count;
            labelSum_SVV.Text = "Сумма: " + sum;
            labelAver_SVV.Text = "Среднее: " + average;
            labelMin_SVV.Text = "Минимальное значение: " + min;
            labelMax_SVV.Text = "Максимальное значение: " + max;
        }

        private void labelCount_SVV_Click(object sender, EventArgs e)
        {

        }
    }
}
