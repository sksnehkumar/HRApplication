using BusinessEntities;
using DataAccessLayer;
using System.Data;


namespace BusinessLogic
{
    public class SkillBC
    {
        public SkillBC()
        {
            objSkillDAL = new SkillDAL();
        }
        public SkillBC(SkillDAL objSkillDAL)
        {
            this.objSkillDAL = objSkillDAL;
        }

        public SkillDAL objSkillDAL { get; set; }

        public bool CreateSkill(SkillInfo objSkillInfo)
        {
            return objSkillDAL.CreateSkill(objSkillInfo);
        }
        public bool UpdateSkill(SkillInfo objSkillInfo)
        {
            return objSkillDAL.UpdateSkill(objSkillInfo);
        }
        public DataTable SearchSkills()
        {
            return objSkillDAL.SearchSkills();
        }
        public DataTable ViewSkill(int SkillId)
        {
            return objSkillDAL.ViewSkill(SkillId);
        }
        public DataTable GetSkillList()
        {
            return objSkillDAL.GetSkillList();
        }
    }
}
