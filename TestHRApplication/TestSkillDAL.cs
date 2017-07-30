using System;
using BusinessEntities;
using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestHRApplication
{

    [TestClass]
    public class TestSkillDAL
    {
        [TestMethod]
        public void TestCreateSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            SkillInfo objSkillInfo = new SkillInfo("VB", "Visual Basic", 302, 101, DateTime.Now, 101, DateTime.Now);

            objSkillDAL.CreateSkill(objSkillInfo);
        }
        [TestMethod]
        public void TestUpdateSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            SkillInfo objSkillInfo = new SkillInfo(408, ".Net", ".Net Framework", 302, 101, DateTime.Now, 101, DateTime.Now);

            objSkillDAL.UpdateSkill(objSkillInfo);
        }
        [TestMethod]
        public void TestSearchSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            objSkillDAL.SearchSkills();
        }
        [TestMethod]
        public void TestViewSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            objSkillDAL.ViewSkill(102);
        }
        [TestMethod]
        public void TestGetkillList()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            objSkillDAL.SearchSkills();
        }
    }
}
