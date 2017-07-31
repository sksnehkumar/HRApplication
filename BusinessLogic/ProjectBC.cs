using BusinessEntities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProjectBC
    {
        public ProjectBC()
        {

        }
        public ProjectBC(ProjectDAL objProjDAL)
        {
            this.objProjDAL = objProjDAL;
        }

        public ProjectDAL objProjDAL { get; set; }

        public bool CreateProject(ProjectInfo objProjInfo)
        {
            return objProjDAL.CreateProject(objProjInfo);
        }
        public bool UpdateProject(ProjectInfo objProjInfo)
        {
            return objProjDAL.UpdateProject(objProjInfo);
        }
        public DataTable SearchProjects()
        {
            return objProjDAL.SearchProjects();
        }
        public DataTable ViewProject(int ProjId)
        {
            return objProjDAL.ViewProject(ProjId);
        }
        public DataTable GetProjectList()
        {
            return objProjDAL.GetProjectList();
        }
    }
}
