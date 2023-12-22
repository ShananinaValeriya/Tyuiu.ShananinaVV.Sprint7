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
        int index;

        DataTable table = new DataTable("table");

        public FormDoctors()
        {
            this.ControlBox = false; //убираем кнопки сворачивания, разворачивания и закрытия окна..
            InitializeComponent();
        }

        private Stack<string> operationStack = new Stack<string>();


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

            buttonSear_SVV.Enabled = true;
            buttonAdd_SVV.Enabled = true;
            buttonDel_SVV.Enabled = true;
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


        private void buttonSear_SVV_Click(object sender, EventArgs e)

        {
            if (!string.IsNullOrEmpty(textBoxSear_SVV.Text))
            {
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
                buttonCbros_SVV.Enabled = true;
            }
            
            else
            { 
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonDel_SVV_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            
            if (dialogResult == DialogResult.Yes)
            {
                index = dataGridViewDoctors_SVV.CurrentCell.RowIndex;
                dataGridViewDoctors_SVV.Rows.RemoveAt(index);
            }
            operationStack.Push("Выполненная операция");
        }

        private void FormDoctors_Load(object sender, EventArgs e)
        {
            //table.Columns.Add("", Type.GetType("System.Int32"));
            //FillComboBoxWithColumns();

            for (int i = 0; i < dataGridViewDoctors_SVV.Columns.Count; i++)
            {
                comboBoxFilter_SVV.Items.Add(dataGridViewDoctors_SVV.Columns[i].HeaderText);
            }
            // var uniqueValues = new HashSet<string>();
            //foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            //{
            //uniqueValues.Add(row.Cells["ФИО"].Value.ToString());
            // }
            //comboBoxFilter_SVV.DataSource = uniqueValues.ToList();

            //comboBoxFilter_SVV.Items.Add("Фильтр 1");
            //comboBoxFilter_SVV.Items.Add("Фильтр 2");
            //comboBoxFilter_SVV.Items.Add("Фильтр 3");
            comboBoxFilter_SVV.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFilter_SVV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFilter_SVV.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        
        private void FillComboBoxWithColumns()
        {
            // Получите ссылку на объект DataGridView
            DataGridView dataGridView = dataGridViewDoctors_SVV; // замените "dataGridView1" на ваше имя DataGridView

            // Очистите ComboBox
            comboBoxFilter_SVV.Items.Clear();

            // Добавьте имена столбцов DataGridView в ComboBox
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxFilter_SVV.Items.Add(column.Name);
            }
        }

        private void FillComboBoxFromColumn(DataGridView dataGridView, int index, ComboBox comboBox)
        {
            comboBox.Items.Clear(); // Очистить список ComboBox
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string cellValue = row.Cells[index].Value.ToString(); // Получить значение ячейки из столбца по индексу
                    if (!comboBox.Items.Contains(cellValue)) // Проверить, не содержится ли значение уже в списке ComboBox
                    {
                        comboBox.Items.Add(cellValue); // Добавить значение в список ComboBox
                    }
                }
            }
        }


        private void comboBoxFilter_SVV_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            // FillComboBoxFromColumn(dataGridViewDoctors_SVV, 0, comboBoxFilter_SVV); // Заполнить ComboBox данными из первого столбца DataGridView
            // Получаем выбранный индекс столбца
            //int columnIndex = comboBoxFilter_SVV.SelectedIndex;

            // Получаем значение для фильтрации
            //string filterValue = comboBoxFilter_SVV.Text;

            // Применяем фильтр к выбранному столбцу
            //(dataGridViewDoctors_SVV.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", dataGridViewDoctors_SVV.Columns[columnIndex].HeaderText, filterValue);
            // string selectedValue = comboBoxFilter_SVV.SelectedItem.ToString();
            //int columnIndex = 0; // индекс столбца, для которого вы устанавливаете фильтр

            //if (columnIndex >= 0 && columnIndex < dataGridViewDoctors_SVV.ColumnCount)
            //{
            //.CurrentCell = null; // Убедитесь, что текущая ячейка не выбрана
            //foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            // {
            //if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() == selectedValue)
            // { 
            //row.Visible = true; // Отображение строк, удовлетворяющих фильтру
            //}
            //
            // {
            //row.Visible = false; // Скрытие строк, не удовлетворяющих фильтру
            // }
            //}
            //}

            // Получите ссылку на объект DataGridView
            // DataGridView dataGridView = dataGridViewDoctors_SVV; // замените "dataGridView1" на ваше имя DataGridView

            // Получите выбранный индекс столбца
            //int columnIndex = comboBoxFilter_SVV.SelectedIndex;

            // Примените фильтр к DataGridView
            // if (columnIndex >= 0)
            //{
            // string columnName = dataGridView.Columns[columnIndex].Name;
            // dataGridView.CurrentCell = null;
            // foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            // if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() != "")
            // row.Visible = true;
            // else
            //row.Visible = false;
            // }
            // }
            // Применение фильтра к DataGridView
            //string selectedValue = comboBoxFilter_SVV.SelectedItem.ToString();
            //(dataGridViewDoctors_SVV.DataSource as DataTable).DefaultView.RowFilter = $"Ф = '{selectedValue}'";

            // Получаем выбранный фильтр из ComboBox
            //string selectedFilter = comboBoxFilter_SVV.SelectedItem.ToString();

            // Применяем фильтр к колонке DataGridView
            //dataGridViewDoctors_SVV.SelectionChanged -= dataGridViewDoctors_SVV_SelectionChanged; // Отписываемся от события, чтобы избежать рекурсии
            //((BindingSource)dataGridViewDoctors_SVV.DataSource).Filter = $"ФИО= '{selectedFilter}'"; // Название_колонки - замените на фактическое название колонки в вашей DataGridView
            //dataGridViewDoctors_SVV.SelectionChanged += dataGridViewDoctors_SVV_SelectionChanged; // Подписываемся на событие изменения выбора
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

            buttonCbros_SVV.Enabled = false;
        }

        private void groupBoxOneDoc_SVV_Enter(object sender, EventArgs e)
        {

        }
        private void ApplyFilter(int index)
        {
            dataGridViewDoctors_SVV.Rows.Cast<DataGridViewRow>()
                                  .ToList()
                                   .ForEach(row => row.Visible = Convert.ToInt32(row.Cells["ФИО"].Value) == index);
            // Получаем BindingSource из DataGridView
            //var bindingSource = (BindingSource)dataGridViewDoctors_SVV.DataSource;

            // Создаем фильтр на основе значения переменной index
            //string filter = "Column1 = '" + index + "'"; // Предполагая, что Column1 - это название столбца, к которому вы хотите применить фильтр

            // Задаем фильтр
            // bindingSource.Filter = filter;
            // Получаем BindingSource из DataGridView
            //var bindingSource = (BindingSource)dataGridViewDoctors_SVV.DataSource;

            //if (index < 0 || index >= dataGridViewDoctors_SVV.Columns.Count)
            //{
            // return;
            //}

            // Применяем фильтр к строкам
            //(dataGridViewDoctors_SVV.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", dataGridViewDoctors_SVV.Columns[index].Name, filterText);

            // Создаем фильтр на основе значения переменной index
            // string filterText = "ФИО = " + index; // Предполагая, что Column1 - это название столбца, к которому вы хотите применить фильтр

            // Задаем фильтр
            //bindingSource.Filter = filterText;
        }

       

        private void buttonFilter_SVV_Click(object sender, EventArgs e)
        {

            int columnIndex = 0; // Ваш индекс столбца
            List<string> items = new List<string>();

            // Перебираем все строки и добавляем значение столбца в список
            foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            {
                if (row.Cells[columnIndex].Value != null && checkBoxFilter_SVV.Checked)
                {
                    items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            // Очищаем combobox и добавляем список значений
            comboBoxFilter_SVV.Items.Clear();
            comboBoxFilter_SVV.Items.AddRange(items.ToArray());


           

            

            //int index = 0; // Индекс столбца для заполнения ComboBox (в данном случае 2)

            // Заполнение ComboBox данными из выбранного столбца
            //comboBoxFilter_SVV.DataSource = dataGridViewDoctors_SVV.Rows.Cast<DataGridViewRow>()
            //.Select(row => row.Cells[index].Value.ToString())
            //.Distinct()
            //.ToList();
            // comboBoxFilter_SVV.SelectedIndex = -1;

            // Добавление фильтра к заголовку таблицы
            // dataGridViewDoctors_SVV.Columns[index].HeaderText += " (фильтр)";


            //string filterValue = comboBoxFilter_SVV.Text;
            //int columnIndex = 0;// здесь укажите нужный индекс

            /// if (dataGridViewDoctors_SVV.Columns[index] is DataGridViewComboBoxColumn)
            // {
            /// DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dataGridViewDoctors_SVV.Columns[index];

            //foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
            //{
            //if (row.Cells[index].Value != null && row.Cells[index].Value.ToString() == filterValue)
            ///
            // row.Visible = true;
            //}
            //else
            //{
            // row.Visible = false;
            //}
            // }
            //  }
            // Получаем выбранный индекс из ComboBox

            // Получаем значение переменной index из пользовательского ввода (например, из TextBox)
            //int index = Convert.ToInt32(textBoxFilter_SVV.Text);

            //ApplyFilter(index);
            // Получаем значение переменной index из пользовательского ввода (например, из TextBox)
            //int index = int.Parse(textBoxFilter_SVV.Text);

            // Применяем фильтр к DataGridView
            //ApplyFilter(index);
            // string filterText = "ФИО = " + index;

            //int index = 0; // Здесь вы указываете индекс нужного столбца
            //string filterText = "vjdf"; // Здесь вы указываете текст фильтра

            //ApplyFilter(index, filterText);

            //int index = // задайте значение переменной index;
            //string filter = $"[ColumnIndex] = {index}"; // замените ColumnIndex на название столбца, по которому необходимо фильтровать
            //(dataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;

            //int index = int.Parse(textBoxFilter_SVV.Text);
            //dataGridViewDoctors_SVV.DataSource = table.DefaultView;
            //dataGridViewDoctors_SVV.DefaultView.RowFilter = "Column_Name = " + index;

        }

        private void groupBoxSear_SVV_Enter(object sender, EventArgs e)
        {

        }
        private Stack<string> history = new Stack<string>();
        private void buttonOtmena_SVV_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                string previousOperation = history.Pop(); // извлекаем предыдущую операцию из стека
                                                          // выполнение отмены предыдущей операции

                // Например, если вы хотите отменить введенный текст в TextBox:
                textBoxSear_SVV.Text = previousOperation;
            }
            //if (operationStack.Count > 0)
            //{
                // Возврат на предыдущую операцию
                // previousOperation = operationStack.Pop();
                // Отмена выполненной операции
                // ...
            //}
            else
            { 
                MessageBox.Show("Нет доступных операций для отмены.");
            }
        }

        private void textBoxSear_SVV_TextChanged(object sender, EventArgs e)
        {
            
            string searchText = textBoxSear_SVV.Text.ToString().ToLower(); // Получите текст из TextBox

            if (!string.IsNullOrEmpty(searchText))
            {
                int columnIndex = 0 ; // Установите индекс столбца по умолчанию

                if (radioButtonOne_SVV.Checked)
                {
                    columnIndex = 0; // Установите индекс столбца для поиска в первом столбце
                }
                else if (radioButtonTwo_SVV.Checked)
                {
                    columnIndex = 1; // Установите индекс столбца для поиска во втором столбце
                }
                else if (radioButtonThree_SVV.Checked)
                {
                    columnIndex = 2; // Установите индекс столбца для поиска в третьем столбце
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

        private void dataGridViewDoctors_SVV_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void buttonFil_SVV_Click(object sender, EventArgs e)
        {
            // Получаем выбранное значение из ComboBox
            string selectedValue = comboBoxFilter_SVV.SelectedItem.ToString();

            // Фильтруем таблицу по выбранному значению
            for (int i = 0; i < dataGridViewDoctors_SVV.Rows.Count; i++)
            {
                if (dataGridViewDoctors_SVV.Rows[i].Cells[index].Value.ToString() == selectedValue)
                {
                    dataGridViewDoctors_SVV.Rows[i].Visible = true;
                }
                else
                {
                    dataGridViewDoctors_SVV.Rows[i].Visible = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        //private void ApplyFilter(int index, string filterValue)
        //{
        // foreach (DataGridViewRow row in dataGridViewDoctors_SVV.Rows)
        //
        //string cellValue = row.Cells[index].Value.ToString();
        // if (cellValue == filterValue)
        //{
        //row.Visible = true;
        // }
        // else
        //{
        // row.Visible = false;
        //
        //}
        //}
    }
}