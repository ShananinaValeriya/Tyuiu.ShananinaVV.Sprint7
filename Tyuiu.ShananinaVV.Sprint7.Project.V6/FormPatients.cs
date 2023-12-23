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
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    public partial class FormPatients : Form
    {
        int index;

        DataTable table = new DataTable("table");
        //private DataTable dataTable;
        public FormPatients()
        {
            this.ControlBox = false; //убираем кнопки сворачивания, разворачивания и закрытия окна..
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
                }
            }

            buttonSear_SVV.Enabled = true;
            buttonAdd_SVV.Enabled = true;
            buttonDel_SVV.Enabled = true;
            buttonChange_SVV.Enabled = true;
            buttonNew_SVV.Enabled = true;
            buttonSave_SVV.Enabled = true;

            textBoxNumber_SVV.Enabled = true;
            textBoxDR_SVV.Enabled = true;
            textBoxName_SVV.Enabled = true;
            textBoxFam_SVV.Enabled = true;
            textBoxOth_SVV.Enabled = true;
            textBoxSear_SVV.Enabled = true;

            buttonDonePat_SVV.Enabled = false;
            buttonBackPat_SVV.Enabled = false;
            buttonClose_SVV.Enabled = true;
            buttonFam_SVV.Enabled = true;
            buttonName_SVV.Enabled = true;
            buttonOth_SVV.Enabled = true;
            buttonNumber_SVV.Enabled = true;
            buttonDR_SVV.Enabled = true;

        }

        private void SortByAlphabet(int columnIndex)
        {
            // Получаем столбец DataGridView, который нужно отсортировать
            DataGridViewColumn column = dataGridViewPatients_SVV.Columns[columnIndex];

            // Проверка, была ли уже выполнена сортировка по этому столбцу
            if (dataGridViewPatients_SVV.SortOrder == SortOrder.Ascending)
            {
                // Если была выполнена сортировка по возрастанию, выполнить сортировку по убыванию
                dataGridViewPatients_SVV.Sort(column, ListSortDirection.Descending);
            }
            else
            {
                // Если не было выполнено сортировки или была выполнена сортировка по убыванию, выполнить сортировку по возрастанию
                dataGridViewPatients_SVV.Sort(column, ListSortDirection.Ascending);
            }
        }


        private void buttonBackPat_SVV_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем окно 
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            table.Columns.Add("", Type.GetType("System.Int32"));
        }

        private void buttonClose_SVV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы сохранили изменения?", "Вопрос", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вернитесь для сохранения");
            }
        }

        private void buttonSear_SVV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSear_SVV.Text))
            {
                string searchText = textBoxSear_SVV.Text.ToLower();
                foreach (DataGridViewRow row in dataGridViewPatients_SVV.Rows)
                {
                    if (row.IsNewRow) continue;
                    bool found = false;
                    for (int i = 0; i < dataGridViewPatients_SVV.Columns.Count; i++)
                    {
                        if (row.Cells[i].Value.ToString().ToLower().Contains(searchText))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                buttonCbros_SVV.Enabled = true;
            }
            else
            {
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_SVV_Click(object sender, EventArgs e)
        {
            string number = textBoxNumber_SVV.Text;
            string surname = textBoxFam_SVV.Text;
            string name = textBoxName_SVV.Text;
            string fathname = textBoxOth_SVV.Text;
            string dr = textBoxDR_SVV.Text;

            dataGridViewPatients_SVV.Rows.Add(number, surname, name, fathname, dr);
            textBoxNumber_SVV.Text = "";
            textBoxFam_SVV.Text = "";
            textBoxName_SVV.Text = "";
            textBoxOth_SVV.Text = "";
            textBoxDR_SVV.Text = "";


            // Переход к добавленной строке
            dataGridViewPatients_SVV.CurrentCell = dataGridViewPatients_SVV.Rows[dataGridViewPatients_SVV.Rows.Count - 1].Cells[0];
        }

        private void buttonChange_SVV_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewPatients_SVV.Rows[index];
            newdata.Cells[0].Value = textBoxNumber_SVV.Text;
            newdata.Cells[1].Value = textBoxFam_SVV.Text;
            newdata.Cells[2].Value = textBoxName_SVV.Text;
            newdata.Cells[3].Value = textBoxOth_SVV.Text;
            newdata.Cells[4].Value = textBoxDR_SVV.Text;
        }

        private void buttonNew_SVV_Click(object sender, EventArgs e)
        {
            textBoxNumber_SVV.Text = String.Empty;
            textBoxFam_SVV.Text = String.Empty;
            textBoxName_SVV.Text = String.Empty;
            textBoxOth_SVV.Text = String.Empty;
            textBoxDR_SVV.Text = String.Empty;
        }

        private void dataGridViewPatients_SVV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewPatients_SVV.Rows[index];
            textBoxNumber_SVV.Text = row.Cells[0].Value.ToString();
            textBoxFam_SVV.Text = row.Cells[1].Value.ToString();
            textBoxName_SVV.Text = row.Cells[2].Value.ToString();
            textBoxOth_SVV.Text = row.Cells[3].Value.ToString();
            textBoxDR_SVV.Text = row.Cells[4].Value.ToString();
        }

        private void buttonSave_SVV_Click(object sender, EventArgs e)
        {
            try
            {
                //Сохраняем изменения обратно в CSV файл
                using (var writer = new StreamWriter("pat.csv"))
                {
                    foreach (DataGridViewRow row in dataGridViewPatients_SVV.Rows)
                    {
                        writer.WriteLine(string.Join(";", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), cell => cell.Value.ToString())));
                    }
                }
                MessageBox.Show("Данные успешно сохранены!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void buttonCbros_SVV_Click(object sender, EventArgs e)
        {
            textBoxSear_SVV.Clear();

            string searchText = textBoxSear_SVV.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewPatients_SVV.Rows)
            {
                if (row.IsNewRow) continue;
                bool found = false;
                for (int i = 0; i < dataGridViewPatients_SVV.Columns.Count; i++)
                {
                    if (row.Cells[i].Value.ToString().ToLower().Contains(searchText))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    row.Visible = true;
                else
                    row.Visible = false;
            }
            textBoxSear_SVV.Clear();
            buttonCbros_SVV.Enabled = false;
        }
        private Stack<string> operationStack = new Stack<string>();


        private void buttonDel_SVV_Click(object sender, EventArgs e)
        {
            int count = dataGridViewPatients_SVV.SelectedRows.Count;
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                while (count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewPatients_SVV.SelectedRows)
                    {
                        dataGridViewPatients_SVV.Rows.Remove(row);
                        count--;
                    }
                }
            }
            //operationStack.Push("Выполненная операция");
        }

        private void buttonFam_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 1; // Указываем нужный индекс столбца
            SortByAlphabet(columnIndex);
        }

        private void buttonName_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 2; // Указываем нужный индекс столбца
            SortByAlphabet(columnIndex);
        }

        private void buttonOth_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 3; // Указываем нужный индекс столбца
            SortByAlphabet(columnIndex);
        }

        private void buttonNumber_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 0;
            SortByAlphabet(columnIndex);

            // индекс колонки, по которой нужно сортировать
        }

        private void buttonDR_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 4; // Указываем нужный индекс столбца
            SortByAlphabet(columnIndex);
        }
    

        private void dataGridViewPatients_SVV_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }

            if (e.Column.Index == 4) 
            {
                DateTime dt1 = Convert.ToDateTime(e.CellValue1);
                DateTime dt2 = Convert.ToDateTime(e.CellValue2);
                e.SortResult = System.DateTime.Compare(dt1, dt2);
                e.Handled = true;
            } 
        }

        private void buttonStatic_SVV_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewPatients_SVV.Rows)
            {
                if (!row.IsNewRow) // Пропустить пустую строку в конце
                {
                    if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString())) // Проверить, что ячейка не пустая
                    {
                        count++;
                        //MessageBox.Show("Количество сотрудников: " + count);
                    }
                }
            }
            MessageBox.Show("Количество пациентов: " + count, "Статистика");
        }

        //private int CalculateAge(DateTime birthDate)
        //{
            //int age = DateTime.Today.Year - birthDate.Year;
           // if (birthDate.Date > DateTime.Today.AddYears(-age))
            //{
                //age--;
            //}
            //return age;
        //

        // Метод для вычисления возраста на основе даты рождения
        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate > currentDate.AddYears(-age)) age--;
            return age;
        }
        private void buttonChart_SVV_Click(object sender, EventArgs e)
        {

            // Создайте новую форму для отображения графика и статистики
            FormChart chartForm = new FormChart();

            // Передайте данные из dataGridView в новую форму
            List<DateTime> birthDates = new List<DateTime>();
            foreach (DataGridViewRow row in dataGridViewPatients_SVV.Rows)
            {
                if (row.Cells[4].Value != null && DateTime.TryParseExact(row.Cells[4].Value.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                    birthDates.Add(date);
                }
            }

            // Вычислите возраст каждого пациента и выведите данные в статистику
            int patientsUnder30 = birthDates.Count(date => CalculateAge(date) < 30);
            int patientsOver30 = birthDates.Count(date => CalculateAge(date) >= 30);

            chartForm.UpdateChart(patientsUnder30, patientsOver30); // Передайте данные для отображения на графике
            chartForm.UpdateStatistics(patientsUnder30, patientsOver30); // Передайте данные для отображения статистики
            chartForm.Show();


            


            //FormChart formchart = new FormChart();
           // formchart.ShowDialog();

            //var chartForm = new FormChart();
            //var chart = chartForm.chart;

            // Получаем данные из DataGridView
            

            // Отображаем новое окно с графиком
            //chartForm.Show();

            

            // Добавляем данные в график
            
            // Добавляем график на форму и отображаем её
            //ageStatsForm.Controls.Add(ageChart);
            //ageStatsForm.ShowDialog();


            //int patientsUnder30 = 0;
            //int patientsOver30 = 0;

            //foreach (DataGridViewRow row in dataGridViewPatients_SVV.Rows)
            //{
                //string birthDate = row.Cells["BirthDateColumn"].Value.ToString();
                //int age = CalculateAge(birthDate);

                //if (age < 30)
                //{
                    //patientsUnder30++;
                //}
                //else
                //{
                    //patientsOver30++;
                //}
           // }

            // Выводим результаты на график
            //chart1.Series["AgeGroup"].Points.AddXY("Under 30", patientsUnder30);
            //chart1.Series["AgeGroup"].Points.AddXY("Over 30", patientsOver30);
        }
    }
}
