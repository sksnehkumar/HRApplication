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
    public partial class UpdateCategory : System.Web.UI.Page
    {
        CategoryController objSC = new CategoryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
                int id = Convert.ToInt32(Session["categoryId"]);
                CategoryInfo objCategory = objSC.ViewCategory(id);
                lblId.Text = objCategory.CategoryId.ToString();
                txtName.Text = objCategory.CategoryName;
                txtDescription.Text = objCategory.CategoryDescription;
                //ddlCategory.ClearSelection();
                //ddlCategory.Items.FindByValue(objSkill.CategoryId.ToString()).Selected = true;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            objSC.UpdateCategory(Convert.ToInt32(lblId.Text), txtName.Text, txtDescription.Text,101);
        }
    }
}