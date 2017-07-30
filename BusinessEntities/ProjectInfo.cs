using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProjectInfo
    {
        public ProjectInfo(string projName, string description, string client, DateTime startDate, DateTime endDate, int createdBy, DateTime createdDate, int lastModifiedBy, DateTime lastModifiedDate)
        {
            ProjName = projName;
            Description = description;
            Client = client;
            StartDate = startDate;
            EndDate = endDate;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
        }

        public ProjectInfo()
        {

        }

        public ProjectInfo(int projId, string projName, string description, string client, DateTime startDate, DateTime endDate, int createdBy, DateTime createdDate, int lastModifiedBy, DateTime lastModifiedDate)
        {
            ProjId = projId;
            ProjName = projName;
            Description = description;
            Client = client;
            StartDate = startDate;
            EndDate = endDate;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
        }

        public int ProjId { get; set; }
        public string ProjName { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        
    }
}
