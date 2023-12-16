using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.ShananinaVV.Sprint7.Project.V6.Lib
{
    public class Patient
    {
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }


    public class PatientRepository
    {
        private const string PatientsFilePath = "patients.csv";

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (StreamReader reader = new StreamReader(PatientsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    if (values.Length == 5)
                    {
                        Patient patient = new Patient();
                        patient.Number = int.Parse(values[0]);
                        patient.LastName = values[1];
                        patient.FirstName = values[2];
                        patient.MiddleName = values[3];
                        patient.DateOfBirth = DateTime.Parse(values[4]);

                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }
    }

}
