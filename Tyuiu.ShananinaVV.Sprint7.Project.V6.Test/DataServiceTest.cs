using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using System.Windows.Forms;

using Tyuiu.ShananinaVV.Sprint7.Project.V6.Lib;

namespace Tyuiu.ShananinaVV.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateAge()
        {
            DataService ds = new DataService();

            DateTime birthDate = new DateTime(1990, 12, 26);  //(год, месяц, день)
            int wait = 33;
            int res = ds.CalculateAge(birthDate);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetNonEmptyRowCount()
        {
            DataService ds = new DataService();

            DataGridView dgw = new DataGridView();

            dgw.Columns.Add("Column", "ColumnHeaderText");

            // Добавляем строки с разными значениями
            dgw.Rows.Add("Лечение");
            dgw.Rows.Add("");
            dgw.Rows.Add("Лечить");

            int count = ds.GetNonEmptyRowCount(dgw);
            int wait = 2;

            Assert.AreEqual(wait, count);
        }

        
        [TestMethod]
        public void TestCountYes()
        {
            DataService ds = new DataService();
            // Здесь создаем объект DataGridView и заполняем его данными для тестирования
            DataGridView dgw = new DataGridView();
            dgw.Columns.Add("Column", "ColumnHeaderText");  //1.  можем использовать для обращения к нему в коде. 
                                                            //2. текст, который будет отображаться в заголовке столбца в dataGridView.

            // Добавляем строки с разными значениями
            dgw.Rows.Add("Да");
            dgw.Rows.Add("Нет");
            dgw.Rows.Add("ДА");
            dgw.Rows.Add("нет");
            dgw.Rows.Add("да");

            // Вызываем метод и проверяем ожидаемый результат
            int columnIndex = 0;
            int result = ds.CountYesValues(dgw, columnIndex);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestCountNo()
        {
            DataService ds = new DataService();
            
            DataGridView dgw = new DataGridView();
            dgw.Columns.Add("Column", "ColumnHeaderText");
            dgw.Rows.Add("Да");
            dgw.Rows.Add("Да");
            dgw.Rows.Add("Нет");
            dgw.Rows.Add("Нет");
            dgw.Rows.Add("нет");
            dgw.Rows.Add("НЕТ");

            int columnIndex = 0;
            int result = ds.CountNoValues(dgw, columnIndex);
            int wait = 4;
            
            Assert.AreEqual(wait, result);
        }



        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint7\Tyuiu.ShananinaVV.Sprint7.Project.V6\bin\Debug\doc.csv"; ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFileTwo()
        {
            string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint7\Tyuiu.ShananinaVV.Sprint7.Project.V6\bin\Debug\pat.csv"; ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFileThree()
        {
            string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint7\Tyuiu.ShananinaVV.Sprint7.Project.V6\bin\Debug\all.csv"; ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
