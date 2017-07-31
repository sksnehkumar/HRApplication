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
        public EmployeeBC()
        {
            objEmpDAL = new EmployeeDAL();
        }
        public EmployeeBC(EmployeeDAL objEmpDAL)
        {
            this.objEmpDAL = objEmpDAL;
        }
        public EmployeeDAL objEmpDAL { get; set; }

        public bool CreateEmployee(EmployeeInfo ObjEmployeeInfo)
        {
            return objEmpDAL.CreateEmployee(ObjEmployeeInfo);
        }
        public DataTable SearchEmployees()
        {
            return objEmpDAL.SearchEmployees();
        }
        public DataTable ViewEmployee(int EmployeeId)
        {
            return objEmpDAL.ViewEmployee(EmployeeId);
           
        }
        public bool UpdateEmploye(EmployeeInfo ObjEmployeeInfo)
        {   
            return objEmpDAL.UpdateEmployee(ObjEmployeeInfo);
        }
    }
}
