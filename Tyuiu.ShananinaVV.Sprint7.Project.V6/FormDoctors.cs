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
        //List<string[]> data = new List<string[]>();
        DataTable table = new DataTable("table");

       // private DataTable originalData;


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
            buttonCbros_SVV.Enabled = true;
        }
        
        private void buttonSear_SVV_Click(object sender, EventArgs e)
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
            index = dataGridViewDoctors_SVV.CurrentCell.RowIndex;
            dataGridViewDoctors_SVV.Rows.RemoveAt(index);
        }

        private void FormDoctors_Load(object sender, EventArgs e)
        {
            table.Columns.Add("", Type.GetType("System.Int32"));

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
        }

        private void groupBoxOneDoc_SVV_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelOneDoc_SVV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}