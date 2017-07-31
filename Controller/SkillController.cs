using System;
using BusinessEntities;
using BusinessLogic;
using System.Data;

namespace Controller
{
    public class SkillController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();
        public bool CreateSkill(string skillName, string skillDescription, int categoryId, int createdBy, int lastModifiedBy)
        {
            SkillInfo objSkillInfo = new SkillInfo(skillName, skillDescription, categoryId, createdBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateSkill(objSkillInfo);
        }

        public bool UpdateSkill(string skillName, string skillDescription, int categoryId, int lastModifiedBy)
        {
            SkillInfo objSkillInfo = new SkillInfo(skillName, skillDescription, categoryId, lastModifiedBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.UpdateSkill(objSkillInfo);
        }

        public SkillInfo viewSkill(int skillId)
        {
            DataTable objDT = HRMFacade.ViewSkill(skillId);
            SkillInfo objSkillInfo = new SkillInfo();

            DataRow row = objDT.Rows[0];
            objSkillInfo.SkillId = skillId;
            objSkillInfo.SkillName = row[0].ToString();
            objSkillInfo.SkillDescription = row[1].ToString();
            objSkillInfo.CategoryId = Convert.ToInt32(row[2]);

            return objSkillInfo;
        }

        public EntityCollection<SkillInfo> SearchSkillByName()
        {
            DataTable objDT = HRMFacade.SearchSkills();
            EntityCollection<SkillInfo> skillCollection = new EntityCollection<SkillInfo>();

            foreach(DataRow row in objDT.Rows)
            {
                SkillInfo objSkillInfo = new SkillInfo();
                objSkillInfo.SkillId = Convert.ToInt32(row[0]);
                objSkillInfo.SkillName = row[1].ToString();
                objSkillInfo.SkillDescription = row[2].ToString();
                objSkillInfo.CategoryId = Convert.ToInt32(row[3]);

                skillCollection.Add(objSkillInfo);
            }
            return skillCollection;
        }

        public EntityCollection<string> GetSkillList()
        {
            DataTable objDT = HRMFacade.GetSkillList();
            EntityCollection<string> skillCollection = new EntityCollection<string>();

            foreach (DataRow row in objDT.Rows)
            {
                string skillName = row[0].ToString();

                skillCollection.Add(skillName);
            }
            return skillCollection;
        }
    }
}
