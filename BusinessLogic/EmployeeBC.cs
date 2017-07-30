using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLogic
{
    public class EmployeeBC
    {
        EmployeeDAL empDAL = new EmployeeDAL();

        public bool CreateEmployee(EmployeeInfo ObjEmployeeInfo)
        {
            return empDAL.CreateEmployee(ObjEmployeeInfo);
            //return flag;

        }
        public DataTable SearchEmployees()
        {
            DataTable ObjDT = new DataTable();
            ObjDT = empDAL.SearchEmployees();
            return ObjDT;
        }
        public DataTable ViewEmployee(int EmployeeId)
        {
            DataTable ObjDT = new DataTable();
            ObjDT = empDAL.ViewEmployee(EmployeeId);
            return ObjDT;
        }
        public bool UpdateEmploye(EmployeeInfo ObjEmployeeInfo)
        {
            
            return empDAL.UpdateEmployee(ObjEmployeeInfo);
        }
    }
}
