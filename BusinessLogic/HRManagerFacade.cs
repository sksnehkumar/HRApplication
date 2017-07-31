using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLogic
{
    class HRManagerFacade
    {
        EmployeeBC eBC;
        CategoryBC cBC;
        ProjectBC pBC;
        SkillBC sBC;


        public HRManagerFacade()
        {
            
        }
        public bool ValidateUser()
        {
            // TO DO : Define this function
            return true;

        }
        public bool CreateEmployee( EmployeeInfo objEmployeeInfo )
        {
            return eBC.CreateEmployee(objEmployeeInfo);
        }
        

    }
}
