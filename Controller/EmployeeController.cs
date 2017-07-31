using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessLogic;
using BusinessEntities;

namespace Controller
{
    class EmployeeController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();

        public bool CreateEmployee(string firstName, string middleName, string lastName, DateTime birthDate, 
            int age, string gender, int civilStatus, string citizenship, string religion, string mobileNo, 
            string homePhoneNo, string street1, string street2, string city, string state, string zipCode, 
            string country, int projectProfile, int skillProfile, string educBackground, string recognitions,
            int createdBy, int lastModifiedBy)
        {
            EmployeeInfo objEmpInfo = new EmployeeInfo(firstName, middleName, lastName, birthDate, age, gender, civilStatus,
                citizenship, religion, mobileNo, homePhoneNo, street1, street2, city, state, zipCode, country, 
                projectProfile, skillProfile, educBackground, recognitions, createdBy, DateTime.Now,
                lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateEmployee(objEmpInfo);
        }

        public bool UpdateEmployee(int employeeId, string firstName, string middleName, string lastName, DateTime birthDate,
            int age, string gender, int civilStatus, string citizenship, string religion, string mobileNo,
            string homePhoneNo, string street1, string street2, string city, string state, string zipCode,
            string country, int projectProfile, int skillProfile, string educBackground, string recognitions,
            int lastModifiedBy)
        {
            EmployeeInfo objEmpInfo = new EmployeeInfo(employeeId, firstName, middleName, lastName, birthDate, age, 
                gender, civilStatus, citizenship, religion, mobileNo, homePhoneNo, street1, street2, city, state, 
                zipCode, country, projectProfile, skillProfile, educBackground, recognitions, 0, null, lastModifiedBy,
                DateTime.Now);

            return HRMFacade.UpdateEmployee(objEmpInfo);
        }

        public EmployeeInfo viewEmployee(int employeeId)
        {
            DataTable objDT = HRMFacade.ViewEmployee(employeeId);
            EmployeeInfo objEmpInfo = new EmployeeInfo();

            DataRow row = objDT.Rows[0];
            objEmpInfo.EmployeeId = employeeId;
            objEmpInfo.FirstName = row[0].ToString();
            objEmpInfo.MiddleName = row[1].ToString();
            objEmpInfo.LastName = row[2].ToString();
            objEmpInfo.BirthDate = Convert.ToDateTime(row[3]);
            objEmpInfo.Age = Convert.ToInt32(row[4]);
            objEmpInfo.Gender = row[5].ToString();
            objEmpInfo.CivilStatus = Convert.ToInt32(row[6]);
            objEmpInfo.Religion = row[7].ToString();
            objEmpInfo.Citizenship = row[8].ToString();
            objEmpInfo.MobileNo = row[9].ToString();
            objEmpInfo.HomePhoneNo = row[10].ToString();
            objEmpInfo.Street1 = row[11].ToString();
            objEmpInfo.Street2 = row[12].ToString();
            objEmpInfo.City = row[13].ToString();
            objEmpInfo.State = row[14].ToString();
            objEmpInfo.ZipCode = row[15].ToString();
            objEmpInfo.Country = row[16].ToString();
            objEmpInfo.ProjectProfile = Convert.ToInt32(row[17]);
            objEmpInfo.SkillProfile = Convert.ToInt32(row[18]);
            objEmpInfo.EducBackground = row[19].ToString();
            objEmpInfo.Recognitions = row[20].ToString();

            return objEmpInfo;
        }

        public EntityCollection<EmployeeInfo> SearchEmployees()
        {
            DataTable objDT = HRMFacade.SearchEmployees();
            EntityCollection<EmployeeInfo> EmployeeCollection = new EntityCollection<EmployeeInfo>();

            foreach (DataRow row in objDT.Rows)
            {
                EmployeeInfo objEmpInfo = new EmployeeInfo();
                objEmpInfo.EmployeeId = Convert.ToInt32(row[0]);
                objEmpInfo.FirstName = row[1].ToString();
                objEmpInfo.MiddleName = row[2].ToString();
                objEmpInfo.LastName = row[3].ToString();
                objEmpInfo.BirthDate = Convert.ToDateTime(row[4]);
                objEmpInfo.Age = Convert.ToInt32(row[5]);
                objEmpInfo.Gender = row[6].ToString();
                objEmpInfo.CivilStatus = Convert.ToInt32(row[7]);
                objEmpInfo.Religion = row[8].ToString();
                objEmpInfo.Citizenship = row[9].ToString();
                objEmpInfo.MobileNo = row[10].ToString();
                objEmpInfo.HomePhoneNo = row[11].ToString();
                objEmpInfo.Street1 = row[12].ToString();
                objEmpInfo.Street2 = row[13].ToString();
                objEmpInfo.City = row[14].ToString();
                objEmpInfo.State = row[15].ToString();
                objEmpInfo.ZipCode = row[16].ToString();
                objEmpInfo.Country = row[17].ToString();
                objEmpInfo.ProjectProfile = Convert.ToInt32(row[18]);
                objEmpInfo.SkillProfile = Convert.ToInt32(row[19]);
                objEmpInfo.EducBackground = row[20].ToString();
                objEmpInfo.Recognitions = row[21].ToString();


                EmployeeCollection.Add(objEmpInfo);
            }
            return EmployeeCollection;
        }
    }
}
