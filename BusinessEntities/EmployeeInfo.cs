using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class EmployeeInfo
    {
        public EmployeeInfo()
        {

        }

        public EmployeeInfo(int employeeId, string firstName, string middleName, string lastName, string fullName, DateTime dateOfBirth, string age, string gender, string civilStatus, string citizenship, string religion, string mobileNo, string homePhoneNo, string street1, string street2, string city, string state, string zipCode, string country, int projectProfile, int skillProfile, string educBackground, string recognitions, int createdBy, int lastModifiedBy)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Age = age;
            Gender = gender;
            CivilStatus = civilStatus;
            Citizenship = citizenship;
            Religion = religion;
            MobileNo = mobileNo;
            HomePhoneNo = homePhoneNo;
            Street1 = street1;
            Street2 = street2;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            ProjectProfile = projectProfile;
            SkillProfile = skillProfile;
            EducBackground = educBackground;
            Recognitions = recognitions;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string Citizenship { get; set; }
        public string Religion { get; set; }
        public string MobileNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int ProjectProfile { get; set; }
        public int SkillProfile { get; set; }
        public string EducBackground { get; set; }
        public string Recognitions { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
