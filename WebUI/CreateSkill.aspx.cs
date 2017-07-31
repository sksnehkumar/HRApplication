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
    public partial class CreateSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryController objCC = new CategoryController();
            EntityCollection<string> categoryList = objCC.GetCatagoryList();
            foreach(string item in categoryList)
            {
                ddlCategory.Items.Add(item);
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}