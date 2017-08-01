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
    public partial class UpdateSkill : System.Web.UI.Page
    {
        SkillController objSC = new SkillController();
        CategoryController objCC = new CategoryController();

        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> categoryList = objCC.GetCatagoryList();

            int id = Convert.ToInt32(Request.QueryString.ToString().Substring(8));
            SkillInfo objSkill = objSC.viewSkill(id);
            lblId.Text = objSkill.SkillId.ToString();
            lblName.Text = objSkill.SkillName;
            lblDescription.Text = objSkill.SkillDescription;
            lblCategory.Text = categoryList[objSkill.CategoryId];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchSkill.aspx");
        }
    }
}