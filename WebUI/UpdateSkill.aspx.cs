using Controller;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class UpdateSkill1 : System.Web.UI.Page
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

                int id = Convert.ToInt32(Session["skillId"]);
                SkillInfo objSkill = objSC.viewSkill(id);
                lblId.Text = objSkill.SkillId.ToString();
                txtName.Text = objSkill.SkillName;
                txtDesc.Text = objSkill.SkillDescription;
                ddlCategory.ClearSelection();
                ddlCategory.Items.FindByValue(objSkill.CategoryId.ToString()).Selected = true;
            }


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            objSC.UpdateSkill(Convert.ToInt32(lblId.Text), txtName.Text, txtDesc.Text, Convert.ToInt32(ddlCategory.SelectedItem.Value), 101);
        }
    }
}