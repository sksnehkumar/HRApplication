using System;
using BusinessEntities;
using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestHRApplication
{

    [TestClass]
    public class TestSkillDAL
    {
        [TestMethod]
        public void TestCreateSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            SkillInfo objSkillInfo = new SkillInfo("EJB", "Enterprise Java Beans", 304, 101, DateTime.Now, 101, DateTime.Now);

            objSkillDAL.CreateSkill(objSkillInfo);
        }
        [TestMethod]
        public void TestUpdateSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            SkillInfo objSkillInfo = new SkillInfo(403, "C#", "C# Language", 302, 101, DateTime.Now, 101, DateTime.Now);

            objSkillDAL.UpdateSkill(objSkillInfo);
        }
        [TestMethod]
        public void TestSearchSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            DataTable objDT = objSkillDAL.SearchSkills();
            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[1].ToString());
            }
        }
        [TestMethod]
        public void TestViewSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            DataTable objDT = objSkillDAL.ViewSkill(402);
            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[1].ToString());
            }
        }
        [TestMethod]
        public void TestGetkillList()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            DataTable objDT = objSkillDAL.SearchSkills();
            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }
    }
}
