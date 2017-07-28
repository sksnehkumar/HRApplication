using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DataAccessLayer;

namespace TestHRApplication
{
    [TestClass]
    public class TestSkillDAL
    {
        [TestMethod]
        public void TestCreateSkill()
        {
            SkillDAL objSkillDAL = new SkillDAL();
            SkillInfo objSkillInfo = new SkillInfo(101,"C#","C# Language",101,1,new DateTime(2017,07,01),1, new DateTime(2017, 07, 01));
            bool flag = objSkillDAL.CreateSkill(objSkillInfo);
            Assert.IsTrue(flag);
        }
    }
}
