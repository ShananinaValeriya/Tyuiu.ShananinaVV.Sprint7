using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace Tyuiu.ShananinaVV.Sprint7.Project.V6.Lib
{
    public class DataService
    {

        // Метод для вычисления возраста на основе даты рождения
        public int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        public int GetNonEmptyRowCount(DataGridView dataGridView)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // Пропустить пустую строку в конце
                {
                    if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString())) // Проверить, что ячейка не пустая
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int CountYesValues(DataGridView dataGridView, int columnIndex)
        {
            int yesCount = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
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

            return yesCount;
        }

       
        public int CountNoValues(DataGridView dataGridView, int columnIndex)
        {
            int noCount = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    string cellValue = row.Cells[columnIndex].Value.ToString();

                    if (cellValue.Equals("Нет", StringComparison.OrdinalIgnoreCase))
                    {
                        noCount++;
                    }
                }
            }
            return noCount;
        }
    }

}

