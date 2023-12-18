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
    public partial class FormMain : Form
    {
       // private List<Patient> patients;

        public FormMain()
        {
            InitializeComponent();
            //patients = new List<Patient>();
            //LoadDataFromCSV("patients.csv");
            //PopulateDataGridView();
            //LoadCSVData();
            
            //openFileDialog_SVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            //saveFileDialog_SVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonPatients_SVV_Click(object sender, EventArgs e)
        {
            FormPatients formAbout = new FormPatients();
            formAbout.ShowDialog();
        }

        private void buttonDoctors_SVV_Click(object sender, EventArgs e)
        {
            FormDoctors formAbout = new FormDoctors();
            formAbout.ShowDialog();
        }

        private void buttonAll_SVV_Click(object sender, EventArgs e)
        {
            FormAll formAbout = new FormAll();
            formAbout.ShowDialog();
        }




        //private void LoadDataFromCSV(string filePath)
        //{
        //try
        //{
        //using (var reader = new StreamReader(filePath))
        //{
        //while (!reader.EndOfStream)
        //{
        //var line = reader.ReadLine();
        //var values = line.Split(',');

        //var patient = new Patient
        //{
        //Number = values[0],
        //LastName = values[1],
        //FirstName = values[2],
        //MiddleName = values[3],
        //BirthDate = DateTime.Parse(values[4]),
        //DoctorFullName = values[5],
        //DoctorPosition = values[6],
        //DoctorSpecialization = values[7],
        //Diagnosis = values[8],
        //AmbulatoryTreatment = bool.Parse(values[9]),
        //DisabilityDuration = int.Parse(values[10]),
        //DispensaryRecord = bool.Parse(values[11]),
        //Note = values[12]
        //};

        //patients.Add(patient);
        //}
        //}
        //}
        //catch (Exception ex)
        //{
        //MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        //}

        //private void PopulateDataGridView()
        //{
        //dataGridViewPatients_SVV.Rows.Clear();

        //foreach (var patient in patients)
        //{
        //dataGridViewPatients_SVV.Rows.Add(
        //patient.Number,
        //patient.LastName,
        //patient.FirstName,
        //patient.MiddleName,
        //patient.BirthDate.ToShortDateString()
        //patient.DoctorFullName,
        //patient.DoctorPosition,
        //patient.DoctorSpecialization,
        //patient.Diagnosis,
        //patient.AmbulatoryTreatment ? "Yes" : "No",
        //patient.DisabilityDuration.ToString(),
        //patient.DispensaryRecord ? "Yes" : "No",
        //patient.Note
        // );
        //}
        //}

        // Можно добавить обработчики событий для кнопок, фильтров и т. д.

        // Определение класса для представления пациента
        //private class Patient
        //{
        //public string Number { get; set; }
        //public string LastName { get; set; }
        //public string FirstName { get; set; }
        //public string MiddleName { get; set; }
        //public DateTime BirthDate { get; set; }
        //public string DoctorFullName { get; set; }
        //public string DoctorPosition { get; set; }
        //public string DoctorSpecialization { get; set; }
        //public string Diagnosis { get; set; }
        //public bool AmbulatoryTreatment { get; set; }
        //public int DisabilityDuration { get; set; }
        //public bool DispensaryRecord { get; set; }
        //public string Note { get; set; }
        //}




    }
}

