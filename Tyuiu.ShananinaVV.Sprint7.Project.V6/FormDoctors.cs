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
using Tyuiu.ShananinaVV.Sprint7.Project.V6.Lib;



namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{

    public partial class FormDoctors : Form
    {
        int index;

        DataTable table = new DataTable("table");

        public FormDoctors()
        {
            this.ControlBox = false; //убираем кнопки сворачивания, разворачивания и закрытия окна..
            InitializeComponent();
            
        }

        private void buttonDoctors_SVV_Click(object sender, EventArgs e)
        {

            //создаем колонки
            dataGridViewDoctors_SVV.ColumnCount = 3;
            dataGridViewDoctors_SVV.Columns[0].Name = "ФИО";
            dataGridViewDoctors_SVV.Columns[1].Name = "Должность";
            dataGridViewDoctors_SVV.Columns[2].Name = "Специализация";

            //загружаем данные из файла CSV
            using (var reader = new StreamReader("doc.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); // разделитель - точка с запятой

                    dataGridViewDoctors_SVV.Rows.Add(values);
                }
            }

           
            buttonAdd_SVV.Enabled = true;
            
            buttonChange_SVV.Enabled = true;
            buttonNew_SVV.Enabled = true;
            buttonSave_SVV.Enabled = true;
            textBoxName_SVV.Enabled = true;
            textBoxPosit_SVV.Enabled = true;
            textBoxSpec_SVV.Enabled = true;
            textBoxSear_SVV.Enabled = true;
            buttonDoctors_SVV.Enabled = false;
            buttonBackDoc_SVV.Enabled = false;
            buttonClose_SVV.Enabled = true;
            buttonSort_SVV.Enabled = true;
            buttonSortPosit_SVV.Enabled = true;
            buttonSortSpec_SVV.Enabled = true;
            buttonCbros_SVV.Enabled = true;
            radioButtonOne_SVV.Enabled = true;
            radioButtonTwo_SVV.Enabled = true;
            radioButtonThree_SVV.Enabled = true;
            buttonStatic_SVV.Enabled = true;
        }

        private void SortByAlphabet(int columnIndex)
        {

            // Получаем столбец DataGridView, который нужно отсортировать
            DataGridViewColumn column = dataGridViewDoctors_SVV.Columns[columnIndex];

            // Проверка, была ли уже выполнена сортировка по этому столбцу
            if (dataGridViewDoctors_SVV.SortOrder == SortOrder.Ascending)
            {
                // Если была выполнена сортировка по возрастанию, выполнить сортировку по убыванию
                dataGridViewDoctors_SVV.Sort(column, ListSortDirection.Descending);
            }
            else
            {
                // Если не было выполнено сортировки или была выполнена сортировка по убыванию, выполнить сортировку по возрастанию
                dataGridViewDoctors_SVV.Sort(column, ListSortDirection.Ascending);
            }
        }
    

        private void buttonSort_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 0; // Указываем нужный индекс столбца
            SortByAlphabet(columnIndex);

           
            
        }

        private void buttonSortPosit_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 1;
            SortByAlphabet(columnIndex);
        }

        private void buttonSortSpec_SVV_Click(object sender, EventArgs e)
        {
            int columnIndex = 2;
            SortByAlphabet(columnIndex);
        }

        private void buttonBackDoc_SVV_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void buttonAdd_SVV_Click(object sender, EventArgs e)
        {
            string name = textBoxName_SVV.Text;
            string position = textBoxPosit_SVV.Text;
            string specialization = textBoxSpec_SVV.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(specialization))
            {
                // Вывод ошибки
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Остановить выполнение метода
            }

            dataGridViewDoctors_SVV.Rows.Add(name, position, specialization);
            textBoxName_SVV.Text = "";
            textBoxPosit_SVV.Text = "";
            textBoxSpec_SVV.Text = "";
            // Переход к добавленной строке
            dataGridViewDoctors_SVV.CurrentCell = dataGridViewDoctors_SVV.Rows[dataGridViewDoctors_SVV.Rows.Count - 1].Cells[0];
        }


        private void buttonChange_SVV_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewDoctors_SVV.Rows[index];
            newdata.Cells[0].Value = textBoxName_SVV.Text;
            newdata.Cells[1].Value = textBoxPosit_SVV.Text;
            newdata.Cells[2].Value = textBoxSpec_SVV.Text;
        }


        private void FormDoctors_Load(object sender, EventArgs e)
        {
            table.Columns.Add("", Type.GetType("System.Int32"));
            

            for (int i = 0; i < dataGridViewDoctors_SVV.Columns.Count; i++)
            {
                comboBoxFilter_SVV.Items.Add(dataGridViewDoctors_SVV.Columns[i].HeaderText);
            }
            
            comboBoxFilter_SVV.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFilter_SVV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFilter_SVV.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        
   
        private void comboBoxFilter_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxFilter_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewDoctors_SVV.Columns)
            {
                int columnIndex = 0;
                foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }


            
        }

        private void buttonNew_SVV_Click(object sender, EventArgs e)
        {
            textBoxName_SVV.Text = String.Empty;
            textBoxPosit_SVV.Text = String.Empty;
            textBoxSpec_SVV.Text = String.Empty;
        }

        private void dataGridViewDoctors_SVV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridViewDoctors_SVV.Rows[index];
            textBoxName_SVV.Text = row.Cells[0].Value.ToString();
            textBoxPosit_SVV.Text = row.Cells[1].Value.ToString();
            textBoxSpec_SVV.Text = row.Cells[2].Value.ToString();
        }

        private void buttonSave_SVV_Click(object sender, EventArgs e)
        {
            try
            {
                //Сохраняем изменения обратно в CSV файл
                using (var writer = new StreamWriter("doc.csv"))
                {
                    foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
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

        private void buttonCbros_SVV_Click(object sender, EventArgs e)
        {
            textBoxSear_SVV.Clear();

            string searchText = textBoxSear_SVV.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                if (row.IsNewRow) continue;
                bool found = false;
                for (int i = 0; i < dataGridViewDoctors_SVV.Columns.Count; i++)
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

           

            comboBoxFilter_SVV.Items.Clear();
            comboBoxPosit_SVV.Items.Clear();
            comboBoxSpec_SVV.Items.Clear();

            comboBoxFilter_SVV.Text = "";
            comboBoxPosit_SVV.Text = "";
            comboBoxSpec_SVV.Text = "";

            // Очистить значения в 
            radioButtonOne_SVV.Checked = false;
            radioButtonTwo_SVV.Checked = false;
            radioButtonThree_SVV.Checked = false;

            
            comboBoxFilter_SVV.SelectedIndex = -1;
            comboBoxPosit_SVV.SelectedIndex = -1;
            comboBoxSpec_SVV.SelectedIndex = -1;


            comboBoxFilter_SVV.Enabled = false;
            comboBoxPosit_SVV.Enabled = false;
            comboBoxSpec_SVV.Enabled = false;
        }
        

        private void textBoxSear_SVV_TextChanged(object sender, EventArgs e)
        {
            
            string searchText = textBoxSear_SVV.Text.ToString().ToLower(); //  текст из TextBox

            if (!string.IsNullOrEmpty(searchText))
            {
               
                int columnIndex = 0 ; // индекс столбца по умолчанию
                
                if (radioButtonOne_SVV.Checked)
                {
                    columnIndex = 0; //индекс столбца для поиска в первом столбце
                }
                else if (radioButtonTwo_SVV.Checked)
                {
                    columnIndex = 1; //  индекс столбца для поиска во втором столбце
                }
                else if (radioButtonThree_SVV.Checked)
                {
                    columnIndex = 2; //  индекс столбца для поиска в третьем столбце
                }

                foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
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
                foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        

        private void radioButtonOne_SVV_CheckedChanged(object sender, EventArgs e)
        {
            int columnIndex = 0; //  индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxFilter_SVV.Items.Clear();
            comboBoxFilter_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxFilter_SVV.Enabled = true;

            comboBoxPosit_SVV.Enabled = false;
            comboBoxSpec_SVV.Enabled = false;

            
            comboBoxPosit_SVV.Text = "";
            comboBoxSpec_SVV.Text = "";

        }

        private void radioButtonTwo_SVV_CheckedChanged(object sender, EventArgs e)
        {
            
            int columnIndex = 1; //  индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxPosit_SVV.Items.Clear();
            comboBoxPosit_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxPosit_SVV.Enabled = true;

            comboBoxFilter_SVV.Enabled = false;
            comboBoxSpec_SVV.Enabled = false;

            comboBoxFilter_SVV.Text = "";
            comboBoxSpec_SVV.Text = "";
        }

        private void radioButtonThree_SVV_CheckedChanged(object sender, EventArgs e)
        {

            int columnIndex = 2; // индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxSpec_SVV.Items.Clear();
            comboBoxSpec_SVV.Items.AddRange(items.Distinct().ToArray());

            comboBoxSpec_SVV.Enabled = true;

            comboBoxFilter_SVV.Enabled = false;
            comboBoxPosit_SVV.Enabled = false;

            comboBoxFilter_SVV.Text = "";
            comboBoxPosit_SVV.Text = "";
            
        }
 
        private void comboBoxPosit_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxPosit_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewDoctors_SVV.Columns)
            {
                int columnIndex = 1;
                foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void comboBoxSpec_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxSpec_SVV.SelectedItem.ToString();

            // Очистить предыдущие действия
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                row.Visible = true;
            }

            // Перебираем все столбцы в dataGridView и скрываем строки, у которых значение в выбранном столбце не соответствует выбранному значению в comboBox
            foreach (DataGridViewColumn column in dataGridViewDoctors_SVV.Columns)
            {
                int columnIndex = 2;
                foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() != selectedValue)
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        
        DataService ds = new DataService();
        private void buttonStatic_SVV_Click(object sender, EventArgs e)
        {

            int count = ds.GetNonEmptyRowCount(dataGridViewDoctors_SVV);
           
            MessageBox.Show("Количество сотрудников: " + count, "Статистика");   
        }

       
        private void buttonClose_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Закрыть";
            
        }

        private void buttonBackDoc_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Назад";
            this.Cursor = Cursors.Hand;
        }

        private void buttonDoctors_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Открыть";
            this.Cursor = Cursors.Hand;
        }

        private void buttonStatic_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Статистика";
        }

        
        private void buttonAdd_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Добавить";
        }

        private void buttonChange_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Изменить";
        }

        private void buttonSave_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Сохранить";
        }

        private void buttonNew_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Сбросить";
        }

        private void buttonSort_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "ФИО";
        }

        private void buttonSortPosit_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Должность";
        }

        private void buttonSortSpec_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Специализация";
        }

        private void buttonCbros_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Сброс";
        }

        private void buttonSear_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Искать";
        }

        private void radioButtonOne_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "ФИО";
        }

        private void radioButtonTwo_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Должность";
        }

        private void radioButtonThree_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Специализация";
        }

        private void textBoxSear_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoctors_SVV.ToolTipTitle = "Ввод данных для поиска";
        }
    }   
}