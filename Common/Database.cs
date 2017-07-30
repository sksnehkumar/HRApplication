using System;
using System.Data.SqlClient;
using System.Data;

namespace Common
{
    public static class Database
    {
        public static string ConnectionString
        {
            get
            {
                return "server=.;database=HRApplication;integrated security=true";
            }
        }

        //Stored Procedures for Employee Management
        public const string CreateEmployee = "CreateEmployee";
        public const string SearchEmployees = "SearchEmployees";
        public const string UpdateEmployee = "UpdateEmployee";
        public const string ViewEmployee = "ViewEmployee";

        //Stored Procedures for Project Management
        public const string CreateProject = "CreateProject";
        public const string SearchProjects = "SearchProjects";
        public const string UpdateProject = "UpdateProject";
        public const string ViewProject = "ViewProject";
        public const string GetProjectList = "GetProjectList";

        //Stored Procedures for Category Management
        public const string CreateCategory = "CreateCategory";
        public const string SearchCategories = "SearchCategories";
        public const string UpdateCategory = "UpdateCategory";
        public const string ViewCategory = "ViewCategory";
        public const string GetCategoryList = "GetCategoryList";

        //Stored Procedures for Skill Management
        public const string CreateSkill = "CreateSkill";
        public const string SearchSkills = "SearchSkills";
        public const string UpdateSkill = "UpdateSkill";
        public const string ViewSkill = "ViewSkill";
        public const string GetSkillList = "GetSkillList";

        //Stored Procedure for User Validation
        public const string ValidateUser = "ValidateUser";

    }
}
