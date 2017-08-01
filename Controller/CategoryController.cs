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
    public  class CategoryController
    {
        HRManagerFacade HRMFacade = new HRManagerFacade();
        public bool CreateCategory(string CategoryName, string CategoryDescription, int createdBy, int lastModifiedBy)
        {
            CategoryInfo objCategoryInfo = new CategoryInfo(CategoryName, CategoryDescription, createdBy, DateTime.Now, lastModifiedBy, DateTime.Now);

            return HRMFacade.CreateCategory(objCategoryInfo);
        }

        public bool UpdateCategory(string CategoryName, string CategoryDescription, int lastModifiedBy)
        {
            CategoryInfo objCategoryInfo = new CategoryInfo(CategoryName, CategoryDescription, 0, null, lastModifiedBy, DateTime.Now);

            return HRMFacade.UpdateCategory(objCategoryInfo);
        }

        public CategoryInfo ViewCategory(int catId)
        {
            DataTable objDT = HRMFacade.ViewCategory(catId);
            CategoryInfo objCategoryInfo = new CategoryInfo();

            DataRow row = objDT.Rows[0];
            objCategoryInfo.CategoryId = catId;
            objCategoryInfo.CategoryName = row[0].ToString();
            objCategoryInfo.CategoryDescription= row[1].ToString();

            return objCategoryInfo;

        }
        public EntityCollection<CategoryInfo> SearchCategoryByName()
        {
            DataTable objDT = HRMFacade.SearchCategories();
            EntityCollection<CategoryInfo> categoryCollection = new EntityCollection<CategoryInfo>();

            foreach (DataRow row in objDT.Rows)
            {
                CategoryInfo objCategoryInfo = new CategoryInfo();
                objCategoryInfo.CategoryId = Convert.ToInt32(row[0]);
                objCategoryInfo.CategoryName = row[1].ToString();
                objCategoryInfo.CategoryDescription = row[2].ToString();

                categoryCollection.Add(objCategoryInfo);
            }
            return categoryCollection;
        }
        public Dictionary<int,string> GetCatagoryList()
        {
            DataTable objDT = HRMFacade.GetCatagoryList();
            Dictionary<int, string> categoryCollection = new Dictionary<int, string>();

            foreach (DataRow row in objDT.Rows)
            {
                int categoryId = Convert.ToInt32(row[0]);
                string CategoryName = row[1].ToString();

                categoryCollection.Add(categoryId,CategoryName);
            }
            return categoryCollection;
        }
    }
}
