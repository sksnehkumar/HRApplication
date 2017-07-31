using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessLogic;
using System.Data;
namespace Controller
{
    class CategoryController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();
        public bool CreateCategory(string CategoryName, string CategoryDescription, int createdBy, int lastModifiedBy)
        {
            CategoryInfo objCategoryInfo = new CategoryInfo(CategoryName, CategoryDescription, createdBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateCategory(objCategoryInfo);
        }

        public bool UpdateCategory(string CategoryName, string CategoryDescription, int lastModifiedBy)
        {
            CategoryInfo objCategoryInfo = new CategoryInfo(CategoryName, CategoryDescription, lastModifiedBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.UpdateCategory(objCategoryInfo);
        }

    }
}
