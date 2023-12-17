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
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }

        private void buttonDonePat_SVV_Click(object sender, EventArgs e)
        {
            // Сначала создаем колонки
            dataGridViewPatients_SVV.ColumnCount = 5;
            dataGridViewPatients_SVV.Columns[0].Name = "Номер";
            dataGridViewPatients_SVV.Columns[1].Name = "Фамилия";
            dataGridViewPatients_SVV.Columns[2].Name = "Имя";
            dataGridViewPatients_SVV.Columns[3].Name = "Отчество";
            dataGridViewPatients_SVV.Columns[4].Name = "Дата рождения";

            // Затем загружаем данные из файла CSV
            using (var reader = new StreamReader("pat.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); // предположим, что разделитель - точка с запятой

                    dataGridViewPatients_SVV.Rows.Add(values);

                    dataGridViewPatients_SVV.Columns["Номер"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewPatients_SVV.Columns["Фамилия"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewPatients_SVV.Columns["Имя"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewPatients_SVV.Columns["Отчество"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewPatients_SVV.Columns["Дата рождения"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    
                }
            }
        }

        private void buttonBackPat_SVV_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем окно 
        }
    }
}
