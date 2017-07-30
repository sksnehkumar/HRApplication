using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DataAccessLayer;
using System.Data;

namespace TestHRApplication
{
    [TestClass]
    public class TestEmployeeDAL
    {
        [TestMethod]
        public void TestCreateEmployee()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            EmployeeInfo objEmployeeInfo = new EmployeeInfo("Sanjit", "Kumar", "Varnwal", new DateTime(1995, 8, 1), 22, "Male", 
                801, "Indian", "Hindu", "8292780061", "8292780061", "Jhumri", "Tilaiya", "Koderma", "Jharrkhand", "827650", "India", 502,
                402, "Graduate", "None", 101, DateTime.Now, 101, DateTime.Now);
            objEmployeeDAL.CreateEmployee(objEmployeeInfo);
        }
        [TestMethod]
        public void TestUpdateEmployee()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            EmployeeInfo objEmployeeInfo = new EmployeeInfo(903, "Sneh", "Kumar", "Kumar", new DateTime(1995, 4, 4), 22, "Male",
                801, "Indian", "Hindu", "8292780061", "8292780061", "Bokaro", "Steel City", "Bokaro", "Jharkhand", "827004", "India", 502,
                402, "Graduate", "None", 101, DateTime.Now, 101, DateTime.Now);
            objEmployeeDAL.UpdateEmployee(objEmployeeInfo);
        }
        [TestMethod]
        public void TestSearchEmployees()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            DataTable objDT = objEmployeeDAL.SearchEmployees();

            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }
        [TestMethod]
        public void TestViewEmployee()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            DataTable objDT = objEmployeeDAL.ViewEmployee(902);

            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }
    }
}
