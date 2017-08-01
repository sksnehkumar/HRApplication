using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
using BusinessEntities;
namespace WebUI
{
    public partial class ViewCategory : System.Web.UI.Page
    {
        CategoryController objSC = new CategoryController();
        //CategoryController objCC = new CategoryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString.ToString().Substring(8));
            CategoryInfo objSkill = objSC.ViewCategory(id);
            //lblId.Text = objSkill.SkillId.ToString();
            lblId.Text = objSkill.CategoryId.ToString();
            lblName.Text = objSkill.CategoryName;
            lblDescription.Text = objSkill.CategoryDescription;
            //lblCategory.Text = categoryList[objSkill.CategoryId];
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchCategory.aspx");
        }
    }
}