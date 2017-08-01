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
        CategoryController objCC = new CategoryController();
        SkillController objSC = new SkillController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Dictionary<int, string> categoryList = objCC.GetCatagoryList();
                ddlCategory.DataSource = categoryList;
                ddlCategory.DataValueField = "Key";
                ddlCategory.DataTextField = "Value";
                ddlCategory.DataBind();
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            objSC.CreateSkill(txtName.Text, txtDesc.Text, Convert.ToInt32(ddlCategory.SelectedItem.Value), 101, 101);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}