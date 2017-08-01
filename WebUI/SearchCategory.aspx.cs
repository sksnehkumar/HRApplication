using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntities;
using Controller;
namespace WebUI
{
    public partial class SearchCategory : System.Web.UI.Page
    {
        CategoryController objSC = new CategoryController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            EntityCollection<CategoryInfo> categoryCollection = objSC.SearchCategoryByName();
            gvCategory.DataSource = categoryCollection;
            gvCategory.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCategory.aspx");
        }

        protected void gvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvCategory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Session["categoryId"] = (int)gvCategory.DataKeys[index].Value;
                Response.Redirect("UpdateCategory.aspx");
            }
        }
    }
}