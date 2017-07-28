using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProjectInfo
    {

        public int ProjId { get; set; }
        public string ProjName { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public ProjectInfo()
        {

        }

        public ProjectInfo(int projId, string projName, string description, string client, DateTime startDate, DateTime endDate, string createdBy, string lastModifiedBy)
        {
            ProjId = projId;
            ProjName = projName;
            Description = description;
            Client = client;
            StartDate = startDate;
            EndDate = endDate;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
        }

      
    }
}
