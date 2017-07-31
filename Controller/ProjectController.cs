using BusinessEntities;
using BusinessLogic;
using System;
using System.Data;


namespace Controller
{
    class ProjectController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();
        public bool CreateProject(string projectName, string projectDescription, string client, DateTime startDate, DateTime endDate, int createdBy, int lastModifiedBy)
        {
            ProjectInfo objProjectInfo = new ProjectInfo(projectName, projectDescription, client, startDate, endDate, createdBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateProject(objProjectInfo);
        }

        public bool UpdateProject(int projectId, string projectName, string projectDescription, string client, DateTime startDate, DateTime endDate, int lastModifiedBy)
        {
            ProjectInfo objProjectInfo = new ProjectInfo(projectId, projectName, projectDescription, client, startDate, endDate, 0, null, lastModifiedBy, DateTime.Now);

            return HRMFacade.UpdateProject(objProjectInfo);
        }

        public ProjectInfo viewProject(int projectId)
        {
            DataTable objDT = HRMFacade.ViewProject(projectId);
            ProjectInfo objProjectInfo = new ProjectInfo();

            DataRow row = objDT.Rows[0];
            objProjectInfo.ProjId = projectId;
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
            EntityCollection<ProjectInfo> projectCollection = new EntityCollection<ProjectInfo>();

            foreach (DataRow row in objDT.Rows)
            {
                ProjectInfo objProjectInfo = new ProjectInfo();
                objProjectInfo.ProjId = Convert.ToInt32(row[0]);
                objProjectInfo.ProjName = row[1].ToString();
                objProjectInfo.Description = row[2].ToString();
                objProjectInfo.Client = row[3].ToString();
                objProjectInfo.StartDate = Convert.ToDateTime(row[4]);
                objProjectInfo.EndDate = Convert.ToDateTime(row[5]);

                projectCollection.Add(objProjectInfo);
            }
            return projectCollection;
        }

        public EntityCollection<string> GetProjectList()
        {
            DataTable objDT = HRMFacade.GetProjectList();
            EntityCollection<string> projectCollection = new EntityCollection<string>();

            foreach (DataRow row in objDT.Rows)
            {
                string projectName = row[0].ToString();

                projectCollection.Add(projectName);
            }
            return projectCollection;
        }
    }
}
