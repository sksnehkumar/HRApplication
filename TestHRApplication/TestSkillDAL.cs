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
            SkillInfo objSkillInfo = new SkillInfo(102, "VB", "Visual BAsic", 101, 1, DateTime.Now, 1, DateTime.Now);

            objSkillDAL.CreateSkill(objSkillInfo);
        }

        [TestMethod]
        public void TestUpdateSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            SkillInfo objSkillInfo = new SkillInfo(101, ".Net", ".Net Framework", 101, 1, DateTime.Now, 1, DateTime.Now);

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
    }
}
