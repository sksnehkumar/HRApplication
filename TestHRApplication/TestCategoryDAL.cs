using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessEntities;
using DataAccessLayer;
using System.Data;

namespace TestHRApplication
{
    [TestClass]
    public class TestCategoryDAL
    {
        [TestMethod]
        public void TestCreateCategory()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            CategoryInfo objCategoryInfo = new CategoryInfo("Goolgle", "Android Related Technology", 101,DateTime.Now, 101, DateTime.Now);
            objCategoryDAL.CreateCategory(objCategoryInfo);
        }

        [TestMethod]
        public void TestUpdateCategory()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            CategoryInfo objCategoryInfo = new CategoryInfo(302, "Microsoft", "Windows Related Technology", 101, DateTime.Now, 101, DateTime.Now);
            objCategoryDAL.UpdateCategory(objCategoryInfo);
        }

        [TestMethod]
        public void TestSearchCategories()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            DataTable objDT = objCategoryDAL.SearchCategories();

            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[1].ToString());
            }
        }

        [TestMethod]
        public void TestViewCategory()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            DataTable objDT = objCategoryDAL.ViewCategory(302);

            foreach (DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString() + " " + row[1].ToString());
            }
        }

        [TestMethod]
        public void TestGetCategoryList()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            DataTable objDT = objCategoryDAL.GetCategoryList();
            
            foreach(DataRow row in objDT.Rows)
            {
                Console.WriteLine(row[0].ToString());
            }
        }
    }
}
