using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Globalization;
using Tyuiu.ShananinaVV.Sprint7.Project.V6.Lib;

namespace Tyuiu.ShananinaVV.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
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

        public int CalculateAge(string birthDate)
        {
            DateTime dob = DateTime.ParseExact(birthDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }


    }
}
