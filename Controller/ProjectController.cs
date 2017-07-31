using BusinessEntities;
using BusinessLogic;
using System;
using System.Data;


namespace Controller
{
    class ProjectController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();
        public bool CreateProject(string ProjectName, string ProjectDescription, string client, DateTime startDate, DateTime endDate, int createdBy, int lastModifiedBy)
        {
            ProjectInfo objProjectInfo = new ProjectInfo(ProjectName, ProjectDescription, client, startDate, endDate, createdBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateProject(objProjectInfo);
        }

        public bool UpdateProject(string ProjectName, string ProjectDescription, string client, DateTime startDate, DateTime endDate, int lastModifiedBy)
        {
            ProjectInfo objProjectInfo = new ProjectInfo(ProjectName, ProjectDescription, client, startDate, endDate, 0, null, lastModifiedBy, DateTime.Now);

            return HRMFacade.UpdateProject(objProjectInfo);
        }

        public ProjectInfo viewProject(int ProjectId)
        {
            DataTable objDT = HRMFacade.ViewProject(ProjectId);
            ProjectInfo objProjectInfo = new ProjectInfo();

            DataRow row = objDT.Rows[0];
            objProjectInfo.ProjId = ProjectId;
            objProjectInfo.ProjName = row[0].ToString();
            objProjectInfo.Description = row[1].ToString();
            objProjectInfo.Client = row[2].ToString();
            objProjectInfo.StartDate = Convert.ToDateTime(row[3]);
            objProjectInfo.EndDate = Convert.ToDateTime(row[4]);

            return objProjectInfo;
        }

        public EntityCollection<ProjectInfo> SearchProjectByName()
        {
            DataTable objDT = HRMFacade.SearchProjects();
            EntityCollection<ProjectInfo> ProjectCollection = new EntityCollection<ProjectInfo>();

            foreach (DataRow row in objDT.Rows)
            {
                ProjectInfo objProjectInfo = new ProjectInfo();
                objProjectInfo.ProjId = Convert.ToInt32(row[0]);
                objProjectInfo.ProjName = row[1].ToString();
                objProjectInfo.Description = row[2].ToString();
                objProjectInfo.Client = row[3].ToString();
                objProjectInfo.StartDate = Convert.ToDateTime(row[4]);
                objProjectInfo.EndDate = Convert.ToDateTime(row[5]);

                ProjectCollection.Add(objProjectInfo);
            }
            return ProjectCollection;
        }

        public EntityCollection<string> GetProjectList()
        {
            DataTable objDT = HRMFacade.GetProjectList();
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
