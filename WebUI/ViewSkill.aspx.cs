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
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString.ToString().Substring(8));
            SkillInfo objSkill = objSC.viewSkill(402);
            lblId.Text = objSkill.SkillId.ToString();
            lblName.Text = objSkill.SkillName;
            lblDescription.Text = objSkill.SkillDescription;
            lblCategory.Text = objSkill.CategoryId.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchSkill.aspx");
        }
    }
}