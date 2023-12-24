using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.ShananinaVV.Sprint7.Project.V6.Lib
{
    public class DataService
    {
        public string[,] SortMin(string[,] matrix, int NumberColumn)
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => x.CompareTo(y));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }



        public string[,] GetMatrix(string path) // возврашает данные из excel
        {
            string[] str = File.ReadAllLines(path);

            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }

        public string[,] SortMax(string[,] matrix, int NumberColumn)
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => y.CompareTo(x));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }

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
}
