using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    public partial class FormDoctors : Form
    {
        public FormDoctors()
        {
            InitializeComponent();
        }

        private void buttonDoctors_SVV_Click(object sender, EventArgs e)
        {
            // Сначала создаем колонки
            dataGridViewDoctors_SVV.ColumnCount = 3;
            dataGridViewDoctors_SVV.Columns[0].Name = "ФИО";
            dataGridViewDoctors_SVV.Columns[1].Name = "Должность";
            dataGridViewDoctors_SVV.Columns[2].Name = "Специализация";
            //dataGridViewDoctors_SVV.Columns[3].Name = "Отчество";
            //dataGridViewDoctors_SVV.Columns[4].Name = "Дата рождения";

            // Затем загружаем данные из файла CSV
            using (var reader = new StreamReader("doc.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); // предположим, что разделитель - точка с запятой

                    dataGridViewDoctors_SVV.Rows.Add(values);
                    
                    dataGridViewDoctors_SVV.Columns["ФИО"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewDoctors_SVV.Columns["Должность"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewDoctors_SVV.Columns["Специализация"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void buttonBackDoc_SVV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
