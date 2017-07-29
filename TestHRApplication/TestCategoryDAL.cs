using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DataAccessLayer;

namespace TestHRApplication
{
    [TestClass]
    public class TestCategoryDAL
    {
        [TestMethod]
        public void TestCreateCategory()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            CategoryInfo objCategoryInfo = new CategoryInfo(2, "Microsoft", "Windows Related Technology", 1,DateTime.Now, 1, DateTime.Now);
            objCategoryDAL.CreateCategory(objCategoryInfo);
        }

        [TestMethod]
        public void TestUpdateCategory()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            CategoryInfo objCategoryInfo = new CategoryInfo(2, "Microsoft Stack", "Windows Related Technology", 1, DateTime.Now, 1, DateTime.Now);
            objCategoryDAL.UpdateCategory(objCategoryInfo);
        }

        [TestMethod]
        public void TestSearchCategories()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            objCategoryDAL.SearchCategories();
        }

        [TestMethod]
        public void TestViewCategory()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            objCategoryDAL.ViewCategory(2);
        }

        [TestMethod]
        public void TestGetCategoryList()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            objCategoryDAL.GetCategoryList();
        }
    }
}
