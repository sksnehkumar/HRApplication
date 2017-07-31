using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class OptumDetails
    {
        public OptumDetails()
        {

        }

        public OptumDetails(int employeeId, string email, string enterpriseId, int level, int speciality, string status, DateTime dateHired, int createdBy, DateTime ? createdDate, int lastModifiedBy, DateTime lastModifiedDate)
        {
            EmployeeId = employeeId;
            Email = email;
            EnterpriseId = enterpriseId;
            Level = level;
            Speciality = speciality;
            Status = status;
            DateHired = dateHired;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
        }

        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string EnterpriseId { get; set; }
        public int Level { get; set; }
        public int Speciality { get; set; }
        public string Status { get; set; }
        public DateTime DateHired { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ? CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        
    }
}
