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

using System.Windows.Forms.DataVisualization.Charting;


namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    public partial class FormAll : Form
    {
        int index;
        public FormAll()
        {
            InitializeComponent();
            this.ControlBox = false;
            //DuplicateData(0, dataGridViewPatients_SVV, targtDataGridView);
            //comboBoxFIODoc_SVV.SelectedIndex = -1;
            //comboBoxDispUch_SVV.Items.AddRange(new object[] { "Да", "Нет" });

            comboBoxDispUch_SVV.Items.Add("Да");
            comboBoxDispUch_SVV.Items.Add("Нет");

            comboBoxAmbLech_SVV.Items.Add("Да");
            comboBoxAmbLech_SVV.Items.Add("Нет");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void buttonOpenBase_SVV_Click(object sender, EventArgs e)
        {
            dataGridViewAll_SVV.ColumnCount = 11; // 4 колонок изначально + 6 новые колонки для добавления данных из второго файла
            dataGridViewAll_SVV.Columns[0].Name = "Номер";
            dataGridViewAll_SVV.Columns[1].Name = "Фамилия";
            dataGridViewAll_SVV.Columns[2].Name = "Имя";
            dataGridViewAll_SVV.Columns[3].Name = "Отчество";
            dataGridViewAll_SVV.Columns[4].Name = "Дата рождения";
            dataGridViewAll_SVV.Columns[5].Name = "ФИО лечащего врача";
            dataGridViewAll_SVV.Columns[6].Name = "Диагноз";
            dataGridViewAll_SVV.Columns[7].Name = "Амбулаторное лечение";
            dataGridViewAll_SVV.Columns[8].Name = "Срок потери \nтрудоспособности";
            dataGridViewAll_SVV.Columns[9].Name = "Диспансерный учёт";
            dataGridViewAll_SVV.Columns[10].Name = "Примечание";
        
            // Затем загружаем данные из первого файла CSV
            using (var reader = new StreamReader("pat.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Добавляем данные из первого файла в соответствующие колонки с помощью индекса
                    dataGridViewAll_SVV.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                }
            }

            // Далее загружаем данные из второго файла CSV
            int index = 0; // Указываем, с какой колонки начинать добавление данных из второго файла
            using (var reader = new StreamReader("all.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Добавляем данные из второго файла в определенные колонки с помощью индекса
                    dataGridViewAll_SVV.Rows[index].Cells[5].Value = values[0];
                    dataGridViewAll_SVV.Rows[index].Cells[6].Value = values[1];
                    dataGridViewAll_SVV.Rows[index].Cells[7].Value = values[2];
                    dataGridViewAll_SVV.Rows[index].Cells[8].Value = values[3];
                    dataGridViewAll_SVV.Rows[index].Cells[9].Value = values[4];
                    dataGridViewAll_SVV.Rows[index].Cells[10].Value = values[5];

                    index++; // Увеличиваем индекс, чтобы следующие данные из второго файла добавлялись в следующую строку
                }
            }
            //this.WindowState = FormWindowState.Maximized;

            
            buttonAdd_SVV.Enabled = true;
            buttonDelete_SVV.Enabled = true;
            buttonChange_SVV.Enabled = true;
            buttonCbros_SVV.Enabled = true;
            buttonSave_SVV.Enabled = true;

            textBoxNumber_SVV.Enabled = true;
            textBoxFam_SVV.Enabled = true;
            textBoxName_SVV.Enabled = true;
            textBoxOth_SVV.Enabled = true;
            textBoxDr_SVV.Enabled = true;
            comboBoxFIODoc_SVV.Enabled = true;
            textBoxDiagnoz_SVV.Enabled = true;
            comboBoxDispUch_SVV.Enabled = true;
            textBoxCrok_SVV.Enabled = true;
            comboBoxAmbLech_SVV.Enabled = true;
            textBoxPrimech_SVV.Enabled = true;
            textBoxFilterSearch_SVV.Enabled = true;


            buttonOpenBase_SVV.Enabled = false;
            buttonBack_SVV.Enabled = false;
            buttonClose_SVV.Enabled = true;

            buttonSortNumber_SVV.Enabled = true;
            buttonSortFam_SVV.Enabled = true;
            buttonSortDR_SVV.Enabled = true;
            buttonSortFIODoc_SVV.Enabled = true;
            buttonSortDiagnoz_SVV.Enabled = true;

            //buttonCbrSear_SVV.Enabled = true;

            radioButtonFilFam_SVV.Enabled = true;
            radioButtonFilNumber_SVV.Enabled = true;
            radioButtonFilFIODoc_SVV.Enabled = true;
            radioButtonFilDiagnoz_SVV.Enabled = true;

            comboBoxFIODoc_SVV.SelectedIndex = -1;


            buttonStatic_SVV.Enabled = true;
        }


        
        private void groupBoxSear_SVV_Enter(object sender, EventArgs e)
        {

        }

        
        private void buttonSave_SVV_Click(object sender, EventArgs e)
        {

            try
            {
                using (var writerPat = new StreamWriter("pat.csv"))
                using (var writerAll = new StreamWriter("all.csv"))
                {
                    foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                    {
                        writerPat.WriteLine(string.Join(";", row.Cells.Cast<DataGridViewCell>().Take(5).Select(cell => cell.Value)));
                        writerAll.WriteLine(string.Join(";", row.Cells.Cast<DataGridViewCell>().Skip(5).Select(cell => cell.Value)));
                    }
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message);
            }


        }

        private void labelCrok_SVV_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxInst_SVV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_SVV_Click(object sender, EventArgs e)
        {
            string number = textBoxNumber_SVV.Text;
            string surname = textBoxFam_SVV.Text;
            string name = textBoxName_SVV.Text;
            string fathname = textBoxOth_SVV.Text;
            string dr = textBoxDr_SVV.Text;
            string docname = comboBoxFIODoc_SVV.Text;
            string diagnoz = textBoxDiagnoz_SVV.Text;
            string amblech = comboBoxAmbLech_SVV.Text;
            string crokpoter = textBoxCrok_SVV.Text;
            string dispuch = comboBoxDispUch_SVV.Text;
            string primech = textBoxPrimech_SVV.Text;

            // Проверка на заполнение всех полей
            if (string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(fathname) || string.IsNullOrWhiteSpace(dr) || string.IsNullOrWhiteSpace(docname) || string.IsNullOrWhiteSpace(diagnoz) || string.IsNullOrWhiteSpace(amblech) || string.IsNullOrWhiteSpace(crokpoter) || string.IsNullOrWhiteSpace(dispuch) || string.IsNullOrWhiteSpace(primech))
            {
                // Вывод ошибки
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Остановить выполнение метода
            }

            dataGridViewAll_SVV.Rows.Add(number, surname, name, fathname, dr, docname, diagnoz, amblech, crokpoter, dispuch, primech );
            textBoxNumber_SVV.Text = "";
            textBoxFam_SVV.Text= "";
            textBoxName_SVV.Text ="";
            textBoxOth_SVV.Text = "";
            textBoxDr_SVV.Text = "";
            comboBoxFIODoc_SVV.Text = "";
            textBoxDiagnoz_SVV.Text = "";
            comboBoxAmbLech_SVV.Text = "";
            textBoxCrok_SVV.Text = "";
            comboBoxDispUch_SVV.Text = "";
            textBoxPrimech_SVV.Text = "";

            // Переход к добавленной строке
            dataGridViewAll_SVV.CurrentCell = dataGridViewAll_SVV.Rows[dataGridViewAll_SVV.Rows.Count - 1].Cells[0];
        }

        private void buttonCbros_SVV_Click(object sender, EventArgs e)
        {
            textBoxNumber_SVV.Text = String.Empty;
            textBoxFam_SVV.Text = String.Empty;
            textBoxName_SVV.Text = String.Empty;
            textBoxOth_SVV.Text = String.Empty;
            textBoxDr_SVV.Text = String.Empty;
            comboBoxFIODoc_SVV.Text = String.Empty;
            textBoxDiagnoz_SVV.Text = String.Empty;
            comboBoxAmbLech_SVV.Text = String.Empty;
            textBoxCrok_SVV.Text = String.Empty;
            comboBoxDispUch_SVV.Text = String.Empty;
            textBoxPrimech_SVV.Text = String.Empty;
            
        }

        private void dataGridViewAll_SVV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewAll_SVV.Rows[index];
            textBoxNumber_SVV.Text = row.Cells[0].Value.ToString();
            textBoxFam_SVV.Text = row.Cells[1].Value.ToString();
            textBoxName_SVV.Text = row.Cells[2].Value.ToString();
            textBoxOth_SVV.Text = row.Cells[3].Value.ToString();
            textBoxDr_SVV.Text = row.Cells[4].Value.ToString();
            comboBoxFIODoc_SVV.Text = row.Cells[5].Value.ToString();
            textBoxDiagnoz_SVV.Text = row.Cells[6].Value.ToString();
            comboBoxAmbLech_SVV.Text = row.Cells[7].Value.ToString();
            textBoxCrok_SVV.Text = row.Cells[8].Value.ToString();
            comboBoxDispUch_SVV.Text = row.Cells[9].Value.ToString();
            textBoxPrimech_SVV.Text = row.Cells[10].Value.ToString();
        }

        private void buttonBack_SVV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonClose_SVV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы сохранили изменения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вернитесь для сохранения");
            }
        }

        private void buttonChange_SVV_Click(object sender, EventArgs e)
        {

            DataGridViewRow newdata = dataGridViewAll_SVV.Rows[index];
            newdata.Cells[0].Value = textBoxNumber_SVV.Text;
            newdata.Cells[1].Value = textBoxFam_SVV.Text;
            newdata.Cells[2].Value = textBoxName_SVV.Text;
            newdata.Cells[3].Value = textBoxOth_SVV.Text;
            newdata.Cells[4].Value = textBoxDr_SVV.Text;
            newdata.Cells[5].Value = comboBoxFIODoc_SVV.Text;
            newdata.Cells[6].Value = textBoxDiagnoz_SVV.Text;
            newdata.Cells[7].Value = comboBoxAmbLech_SVV.Text;
            newdata.Cells[8].Value = textBoxCrok_SVV.Text;
            newdata.Cells[9].Value = comboBoxDispUch_SVV.Text;
            newdata.Cells[10].Value = textBoxPrimech_SVV.Text;
           
        }

        private void buttonDelete_SVV_Click(object sender, EventArgs e)
        {
            int count = dataGridViewAll_SVV.SelectedRows.Count;
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                while (count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewAll_SVV.SelectedRows)
                    {
                        dataGridViewAll_SVV.Rows.Remove(row);
                        count--;
                    }
                }
            }
            
        }

        private void dataGridViewAll_SVV_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
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

        private void buttonSortNumber_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 0;
            SortByAlphabet(columnIndex);
        }

        private void SortByAlphabet(int columnIndex)
        {
            // Получаем столбец DataGridView, который нужно отсортировать
            DataGridViewColumn column = dataGridViewAll_SVV.Columns[columnIndex];

            // Проверка, была ли уже выполнена сортировка по этому столбцу
            if (dataGridViewAll_SVV.SortOrder == SortOrder.Ascending)
            {
                // Если была выполнена сортировка по возрастанию, выполнить сортировку по убыванию
                dataGridViewAll_SVV.Sort(column, ListSortDirection.Descending);
            }
            else
            {
                // Если не было выполнено сортировки или была выполнена сортировка по убыванию, выполнить сортировку по возрастанию
                dataGridViewAll_SVV.Sort(column, ListSortDirection.Ascending);
            }
        }

        private void buttonSortFam_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 1;
            SortByAlphabet(columnIndex);
        }

        private void buttonSortFIODoc_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 5;
            SortByAlphabet(columnIndex);
        }

        private void buttonSortDiagnoz_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 6;
            SortByAlphabet(columnIndex);
        }

        private void buttonStatic_SVV_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
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
            MessageBox.Show("Количество записей: " + count, "Статистика");


            

            
        }

        private void textBoxDr_SVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSortDR_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 4;
            SortByAlphabet(columnIndex);
        }

        private void textBoxDiagnoz_SVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFilNumber_SVV_CheckedChanged(object sender, EventArgs e)
        {
            int columnIndex = 0; // Ваш индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxFilNumber_SVV.Items.Clear();
            comboBoxFilNumber_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxFilNumber_SVV.Enabled = true;

            
            comboBoxFilFam_SVV.Enabled = false;
            comboBoxFilFIODoc_SVV.Enabled = false;
            comboBoxFilDiagnoz_SVV.Enabled = false;

           
            comboBoxFilFam_SVV.Text = "";
            comboBoxFilFIODoc_SVV.Text = "";
            comboBoxFilDiagnoz_SVV.Text = "";

            buttonCbrSear_SVV.Enabled = true;
        }

        private void textBoxFilterSearch_SVV_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxFilterSearch_SVV.Text.ToString().ToLower(); // Получите текст из TextBox

            if (!string.IsNullOrEmpty(searchText))
            {
                int columnIndex = 1; // Установите индекс столбца по умолчанию

                if (radioButtonFilNumber_SVV.Checked)
                {
                    columnIndex = 0; // Установите индекс столбца для поиска в первом столбце
                }
                else if (radioButtonFilFam_SVV.Checked)
                {
                    columnIndex = 1; // Установите индекс столбца для поиска во втором столбце
                }
                else if (radioButtonFilFIODoc_SVV.Checked)
                {
                    columnIndex = 5; 
                }
                else if (radioButtonFilDiagnoz_SVV.Checked)
                {
                    columnIndex = 6; 
                }
                

                foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null)
                    {
                        if (row.Cells[columnIndex].Value.ToString().ToLower().Contains(searchText))
                        {
                            row.Visible = true; // Если найден текст, то отображаем строку
                        }
                        else
                        {
                            row.Visible = false; // Если текст не найден, то скрываем строку
                        }
                    }
                }


            }
            else
            {
                // Очистить фильтр, если текстовое поле пустое
                foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void comboBoxFilNumber_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxFilNumber_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewAll_SVV.Columns)
            {
                int columnIndex = 0;
                foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void comboBoxFilDiagnoz_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxFilDiagnoz_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewAll_SVV.Columns)
            {
                int columnIndex = 6;
                foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void radioButtonFilFam_SVV_CheckedChanged(object sender, EventArgs e)
        {
            int columnIndex = 1; // Ваш индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxFilFam_SVV.Items.Clear();
            comboBoxFilFam_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxFilFam_SVV.Enabled = true;

            comboBoxFilNumber_SVV.Enabled = false;
            
            comboBoxFilFIODoc_SVV.Enabled = false;
            comboBoxFilDiagnoz_SVV.Enabled = false;

            comboBoxFilNumber_SVV.Text = "";
            
            comboBoxFilFIODoc_SVV.Text = "";
            comboBoxFilDiagnoz_SVV.Text = "";

            buttonCbrSear_SVV.Enabled = true;
        }

        private void radioButtonFilFIODoc_SVV_CheckedChanged(object sender, EventArgs e)
        {
            int columnIndex = 5; // Ваш индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox
            comboBoxFilFIODoc_SVV.Items.Clear();

            // Добавляем только уникальные значения
            comboBoxFilFIODoc_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxFilFIODoc_SVV.Enabled = true;

            comboBoxFilNumber_SVV.Enabled = false;
            comboBoxFilFam_SVV.Enabled = false;
            
            comboBoxFilDiagnoz_SVV.Enabled = false;

            comboBoxFilNumber_SVV.Text = "";
            comboBoxFilFam_SVV.Text = "";
            
            comboBoxFilDiagnoz_SVV.Text = "";

            buttonCbrSear_SVV.Enabled = true;
        }

        private void radioButtonFilDiagnoz_SVV_CheckedChanged(object sender, EventArgs e)
        {
            
            int columnIndex = 6; // Ваш индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxFilDiagnoz_SVV.Items.Clear();
            comboBoxFilDiagnoz_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxFilDiagnoz_SVV.Enabled = true;

            comboBoxFilNumber_SVV.Enabled = false;
            comboBoxFilFam_SVV.Enabled = false;
            comboBoxFilFIODoc_SVV.Enabled = false;
            

            comboBoxFilNumber_SVV.Text = "";
            comboBoxFilFam_SVV.Text = "";
            comboBoxFilFIODoc_SVV.Text = "";
            

            buttonCbrSear_SVV.Enabled = true;
        }

        

        private void comboBoxFilFam_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxFilFam_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewAll_SVV.Columns)
            {
                int columnIndex = 1;
                foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }
            
        }
        
        private void comboBoxFilFIODoc_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = comboBoxFilFIODoc_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewAll_SVV.Columns)
            {
                int columnIndex = 5;
                foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        

       

        private void buttonCbrSear_SVV_Click(object sender, EventArgs e)
        {
            textBoxFilterSearch_SVV.Clear();
            //buttonCbrSear_SVV.Enabled = false;

            string searchText = textBoxFilterSearch_SVV.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.IsNewRow) continue;
                bool found = false;
                for (int i = 0; i < dataGridViewAll_SVV.Columns.Count; i++)
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
            textBoxFilterSearch_SVV.Clear();

           //buttonCbrSear_SVV.Enabled = false;

            comboBoxFilNumber_SVV.Items.Clear();
            comboBoxFilFam_SVV.Items.Clear();
            comboBoxFilFIODoc_SVV.Items.Clear();
            comboBoxFilDiagnoz_SVV.Items.Clear();
            


            comboBoxFilNumber_SVV.Text = "";
            comboBoxFilFam_SVV.Text = "";
            comboBoxFilFIODoc_SVV.Text = "";
            comboBoxFilDiagnoz_SVV.Text = "";
            
          
            
            radioButtonFilNumber_SVV.Checked = false;
            radioButtonFilFam_SVV.Checked = false;
            radioButtonFilFIODoc_SVV.Checked = false;
            radioButtonFilDiagnoz_SVV.Checked = false;



           
            comboBoxFilNumber_SVV.SelectedIndex = -1;
            comboBoxFilFam_SVV.SelectedIndex = -1;
            comboBoxFilFIODoc_SVV.SelectedIndex = -1;
            comboBoxFilDiagnoz_SVV.SelectedIndex = -1;
      

            
            comboBoxFilNumber_SVV.Enabled = false;
            comboBoxFilFam_SVV.Enabled = false;
            comboBoxFilFIODoc_SVV.Enabled = false;
            comboBoxFilDiagnoz_SVV.Enabled = false;
            
        }

        private void buttonChart_SVV_Click(object sender, EventArgs e)
        {
            // Создание новой формы для отображения графика
            Form graphForm = new Form();

            // Создание графика
            Chart chart = new Chart();

            // Добавление графика на новую форму
            graphForm.Controls.Add(chart);

            // Установка размеров и расположения графика на новой форме
            chart.Size = new Size(400, 300);
            chart.Location = new Point(10, 10);

            // Создание серии данных для графика
            Series series = new Series();
            series.ChartType = SeriesChartType.Bar; // Тип графика - столбчатая диаграмма

            

            
            // Получение данных из datagridview и подсчет количества "Да" и "Нет"
            int countYes = 0;
            int countNo = 0;

            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    if (row.Cells[7].Value.ToString() == "Да")
                    {
                        countYes++;
                    }
                    else if (row.Cells[7].Value.ToString() == "Нет")
                    {
                        countNo++;
                    }
                }
            }

            // Добавление данных в серию графика
            series.Points.AddXY("Да", countYes);
            series.Points.AddXY("Нет", countNo);

            // Добавление серии на график
            chart.Series.Add(series);

            // Отображение формы с графиком
            graphForm.ShowDialog();
        }

        private void buttonClose_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Закрыть";
        }

        private void buttonBack_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Назад";
            this.Cursor = Cursors.Hand;
        }

        private void buttonOpenBase_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Открыть";
            this.Cursor = Cursors.Hand;
        }

        private void buttonStatic_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Статистика";
        }

        private void buttonChart_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "График";
        }

        private void buttonChange_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Изменить";
        }

        private void buttonAdd_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Добавить";
        }

        private void buttonSave_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Сохранить";
        }

        private void buttonCbros_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Сбросить";
        }

        private void buttonDelete_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Удалить";
        }

        private void buttonSortNumber_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Номер";
        }

        private void buttonSortFam_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Фамилия";
        }

        private void buttonSortDR_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Дата рождения";
        }

        private void buttonSortFIODoc_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "ФИО лечащего врача";
        }

        private void buttonSortDiagnoz_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Диагноз";
        }

        private void radioButtonFilNumber_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Номер";
        }

        private void radioButtonFilFam_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Фамилия";
        }

        private void radioButtonFilFIODoc_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "ФИО лечащего врача";
        }

        private void radioButtonFilDiagnoz_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Диагноз";
        }

        private void buttonCbrSear_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Сброс";
        }

        private void buttonSearch_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Искать";
        }

        private void textBoxDispUch_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Стоит ли на диспансерном учете?";
        }

        private void textBoxAmbLech_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipAll_SVV.ToolTipTitle = "Нужно ли амбулаторное лечение?";
        }

        private void labelDispUch_SVV_Click(object sender, EventArgs e)
        {

        }

        

        private void textBoxFIODoc_SVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> doctorsList = new List<string>();

            // Читаем файл CSV
            using (StreamReader reader = new StreamReader("doc.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');

                    // Добавляем врачей в список
                    doctorsList.Add(values[0]); // 0 - индекс столбца с именами врачей
                }
            }

            // Заполняем ComboBox найденными врачами
            comboBoxFIODoc_SVV.DataSource = doctorsList;
        }

        private void FormAll_Load(object sender, EventArgs e)
        {
            // Читаем файл csv
            List<string[]> data = new List<string[]>();
            using (StreamReader reader = new StreamReader("doc.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    data.Add(row);
                }
            }

            // Получаем список всех врачей из столбца с заданным индексом
            List<string> doctors = new List<string>();
            foreach (string[] row in data)
            {
                if (row.Length > 0)
                {
                    string doctor = row[0]; // Индекс столбца с врачами
                    doctors.Add(doctor);
                }
            }

            // Заполняем ComboBox данными
            comboBoxFIODoc_SVV.DataSource = doctors;
        }

        private void comboBoxFIODoc_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comboBoxFIODoc_SVV.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBoxFIODoc_SVV.SelectedItem = null;
            //comboBoxFIODoc_SVV.SelectedIndex = -1;
            //comboBoxFIODoc_SVV.SelectedIndex = 0; // выбрать первый элемент
        }

        private void groupBoxSortir_SVV_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxDispUch_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Добавляем возможные значения ("Да" и "Нет") в комбо-бокс
            //comboBoxDispUch_SVV.Items.AddRange(new object[] { "Да", "Нет" });
            

            //comboBoxDispUch_SVV.SelectedIndex = -1;
        }

        private void groupBoxMenu_SVV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStaticTwo_SVV_Click(object sender, EventArgs e)
        {

            

            int yesCount = 0;
            //int noCount = 0;
            // Предположим, что столбец с индексом 7 содержит значения "Да" и "Нет"
            int columnIndex = 7;

            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    string cellValue = row.Cells[columnIndex].Value.ToString();

                    if (cellValue.Equals("Да", StringComparison.OrdinalIgnoreCase))
                    {
                        yesCount++;
                    }
                    
                }
            }
            MessageBox.Show("Количество пациентов, нуждающихся\nв амбулаторном лечении: " + yesCount, "Статистика");
        }

        private void buttonStaticThree_SVV_Click(object sender, EventArgs e)
        {
            int yesCount = 0;
            //int noCount = 0;
            // Предположим, что столбец с индексом 7 содержит значения "Да" и "Нет"
            int columnIndex = 9;

            foreach (DataGridViewRow row in dataGridViewAll_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    string cellValue = row.Cells[columnIndex].Value.ToString();

                    if (cellValue.Equals("Да", StringComparison.OrdinalIgnoreCase))
                    {
                        yesCount++;
                    }

                }
            }
            MessageBox.Show("Количество пациентов, состоящих\nна диспансерном учете: " + yesCount, "Статистика");

        }
    }
}
