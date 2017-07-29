using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DataAccessLayer;

namespace TestHRApplication
{
    [TestClass]
    public class TestEmployeeDAL
    {
        [TestMethod]
        public void TestCreateEmployee()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            EmployeeInfo objEmployeeInfo = new EmployeeInfo(301, "Sanjit", "Kumar", "Varnwal", new DateTime(1995, 8, 1), 22, "Male", 
                401, "Indian", "Hindu", "8292780061", "8292780061", "Jhumri", "Tilaiya", "Koderma", "Jharrkhand", "827650", "India", 201,
                101, "Graduate", "None", 1, DateTime.Now, 1, DateTime.Now);
            objEmployeeDAL.CreateEmployee(objEmployeeInfo);
        }
        [TestMethod]
        public void TestUpdateEmployee()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            EmployeeInfo objEmployeeInfo = new EmployeeInfo(301, "Sanjit", "Kumar", "Varnwal", new DateTime(1995, 8, 1), 22, "Male",
                401, "Indian", "Hindu", "8292780061", "8292780061", "Jhumri", "Tilaiya", "Koderma", "Jharkhand", "827650", "India", 201,
                101, "Graduate", "None", 1, DateTime.Now, 1, DateTime.Now);
            objEmployeeDAL.CreateEmployee(objEmployeeInfo);
        }
        [TestMethod]
        public void TestSearchEmployees()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            objEmployeeDAL.SearchEmployees();
        }
        [TestMethod]
        public void TestViewEmployee()
        {
            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
            objEmployeeDAL.SearchEmployees();
        }
    }
}
