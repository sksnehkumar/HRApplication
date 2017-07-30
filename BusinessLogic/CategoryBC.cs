using System;
using DataAccessLayer;
using BusinessEntities;
using System.Data;

namespace BusinessLogic
{
    public class CategoryBC
    {
        public CategoryBC()
        {

        }
        public CategoryBC(CategoryDAL objCatDAL)
        {
            this.objCatDAL = objCatDAL;
        }

        public CategoryDAL objCatDAL { get; set; }

        public bool CreateCategory(CategoryInfo objCatInfo)
        {
            return objCatDAL.CreateCategory(objCatInfo);
        }
        public bool UpdateCategory(CategoryInfo objCatInfo)
        {
            return objCatDAL.UpdateCategory(objCatInfo);
        }
        public DataTable SearchCategories()
        {
            return objCatDAL.SearchCategories();
        }
        public DataTable ViewCategory(int catId)
        {
            return objCatDAL.ViewCategory(catId);
        }
        public DataTable GetCatagoryList()
        {
            return objCatDAL.GetCategoryList();
        }
    }
}
