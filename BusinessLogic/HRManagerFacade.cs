using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLogic
{
    class HRManagerFacade
    {
        EmployeeBC eBC;
        CategoryBC cBC;
        ProjectBC pBC;
        SkillBC sBC;


        public HRManagerFacade()
        {
            
        }
        public bool ValidateUser()
        {
            // TO DO : Define this function
            return true;

        }
        public bool CreateEmployee( EmployeeInfo objEmployeeInfo )
        {
            return eBC.CreateEmployee(objEmployeeInfo);
        }
        public bool UpdateEmployee(EmployeeInfo objEmployeeInfo)
        {
            return eBC.UpdateEmploye(objEmployeeInfo);
        }
        public DataTable SearchEmployees()
        {
            return eBC.SearchEmployees();
        }
        public DataTable ViewEmployee(int EmployeeId)
        {
            return eBC.ViewEmployee(EmployeeId);

        }

        //-------
        public bool CreateProject(ProjectInfo objProjInfo)
        {
            return pBC.CreateProject(objProjInfo);
        }
        public bool UpdateProject(ProjectInfo objProjInfo)
        {
            return pBC.UpdateProject(objProjInfo);
        }
        public DataTable SearchProjegories()
        {
            return pBC.SearchProjects();
        }
        public DataTable ViewProject(int ProjId)
        {
            return pBC.ViewProject(ProjId);
        }
        public DataTable GetProjectList()
        {
            return pBC.GetProjectList();
        }

        //-------
        public bool CreateCategory(CategoryInfo objCatInfo)
        {
            return cBC.CreateCategory(objCatInfo);
        }
        public bool UpdateCategory(CategoryInfo objCatInfo)
        {
            return cBC.UpdateCategory(objCatInfo);
        }
        public DataTable SearchCategories()
        {
            return cBC.SearchCategories();
        }
        public DataTable ViewCategory(int catId)
        {
            return cBC.ViewCategory(catId);
        }
        public DataTable GetCatagoryList()
        {
            return cBC.GetCatagoryList();
        }
        //-------
        public bool CreateSkill(SkillInfo objSkillInfo)
        {
            return sBC.CreateSkill(objSkillInfo);
        }
        public bool UpdateSkill(SkillInfo objSkillInfo)
        {
            return sBC.UpdateSkill(objSkillInfo);
        }
        public DataTable SearchSkills()
        {
            return sBC.SearchSkills();
        }
        public DataTable ViewSkill(int SkillId)
        {
            return sBC.ViewSkill(SkillId);
        }
        public DataTable GetSkillList()
        {
            return sBC.GetSkillList();
        }
    }

}
