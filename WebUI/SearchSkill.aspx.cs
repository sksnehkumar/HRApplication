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
    public partial class SearchSkill : System.Web.UI.Page
    {
        SkillController objSC = new SkillController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateSkill.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            EntityCollection<SkillInfo> skillCollection = objSC.SearchSkillByName();
            gvSkills.DataSource = skillCollection;
            gvSkills.DataBind();
        }



        protected void gvSkills_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvSkills_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Session["skillId"] = (int)gvSkills.DataKeys[index].Value;
                Response.Redirect("UpdateSkill.aspx");
            }
        }
    }
}