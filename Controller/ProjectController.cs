using BusinessEntities;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ProjectController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();
        public bool CreateProject(string ProjectName, string ProjectDescription, int categoryId, int createdBy, int lastModifiedBy)
        {
            ProjectInfo objProjectInfo = new ProjectInfo(ProjectName, ProjectDescription, categoryId, createdBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateProject(objProjectInfo);
        }

        public bool UpdateProject(string ProjectName, string ProjectDescription, int categoryId, int lastModifiedBy)
        {
            ProjectInfo objProjectInfo = new ProjectInfo(ProjectName, ProjectDescription, categoryId, lastModifiedBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.UpdateProject(objProjectInfo);
        }

        public ProjectInfo viewProject(int ProjectId)
        {
            DataTable objDT = HRMFacade.ViewProject(ProjectId);
            ProjectInfo objProjectInfo = new ProjectInfo();

            DataRow row = objDT.Rows[0];
            objProjectInfo.ProjId = Convert.ToInt32(row[0]);
            objProjectInfo.ProjName = row[1].ToString();
            objProjectInfo.ProjectDescription = row[2].ToString();
            objProjectInfo.CategoryId = Convert.ToInt32(row[3]);

            return objProjectInfo;
        }

        public EntityCollection<ProjectInfo> SearchProjectByName()
        {
            DataTable objDT = HRMFacade.SearchProjects();
            EntityCollection<ProjectInfo> ProjectCollection = new EntityCollection<ProjectInfo>();

            foreach (DataRow row in objDT.Rows)
            {
                ProjectInfo objProjectInfo = new ProjectInfo();
                objProjectInfo.ProjectId = Convert.ToInt32(row[0]);
                objProjectInfo.ProjectName = row[1].ToString();
                objProjectInfo.ProjectDescription = row[2].ToString();
                objProjectInfo.CategoryId = Convert.ToInt32(row[3]);

                ProjectCollection.Add(objProjectInfo);
            }
            return ProjectCollection;
        }

        public EntityCollection<string> GetProjectList()
        {
            DataTable objDT = HRMFacade.SearchProjects();
            EntityCollection<string> ProjectCollection = new EntityCollection<string>();

            foreach (DataRow row in objDT.Rows)
            {
                string ProjectName = row[0].ToString();

                ProjectCollection.Add(ProjectName);
            }
            return ProjectCollection;
        }
    }
}
