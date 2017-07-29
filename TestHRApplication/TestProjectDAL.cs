using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using BusinessEntities;

namespace TestHRApplication
{

    [TestClass]
    public class TestProjectDAL
    {
        [TestMethod]
        public void TestCreateProject()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            ProjectInfo objProjectInfo = new ProjectInfo(201, "HRApplication", "HR Management System", "Abridge", DateTime.Now, DateTime.Now, 1, DateTime.Now, 1, DateTime.Now);
            objProjectDAL.CreateProject(objProjectInfo);
        }

        [TestMethod]
        public void TestUpdateCategory()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            ProjectInfo objProjectInfo = new ProjectInfo(201, "HR Application", "HR Management System", "Abridge", DateTime.Now, DateTime.Now, 1, DateTime.Now, 1, DateTime.Now);
            objProjectDAL.UpdateProject(objProjectInfo);
        }

        [TestMethod]
        public void TestSearchProjects()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            objProjectDAL.SearchProjects();
        }

        [TestMethod]
        public void TestViewProject()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            objProjectDAL.ViewProject(201);
        }

        [TestMethod]
        public void TestGetProjectList()
        {
            ProjectDAL objProjectDAL = new ProjectDAL();
            objProjectDAL.GetProjectList();
        }
    }
}
