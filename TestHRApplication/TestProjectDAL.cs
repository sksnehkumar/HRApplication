using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using BusinessEntities;
using System.Data;

namespace TestHRApplication
{

    [TestClass]
    public class TestProjectDAL
    {
        [TestMethod]
        public void TestCreateProject()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            ProjectInfo objProjectInfo = new ProjectInfo("HRApplication", "HR Management System", "Abridge", DateTime.Now, DateTime.Now, 101, DateTime.Now, 101, DateTime.Now);
            objProjectDAL.CreateProject(objProjectInfo);
        }

        [TestMethod]
        public void TestUpdateProject()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            ProjectInfo objProjectInfo = new ProjectInfo(503, "HR Application", "HR Management System", "Abridge", DateTime.Now, DateTime.Now, 101, DateTime.Now, 101, DateTime.Now);
            objProjectDAL.UpdateProject(objProjectInfo);
        }

        [TestMethod]
        public void TestSearchProjects()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            DataTable objDT = objProjectDAL.SearchProjects();

            foreach (DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }

        [TestMethod]
        public void TestViewProject()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            DataTable objDT = objProjectDAL.ViewProject(502);

            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }

        [TestMethod]
        public void TestGetProjectList()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            DataTable objDT = objProjectDAL.GetProjectList();

            foreach (DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }
    }
}
