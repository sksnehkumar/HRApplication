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
    public partial class CreateCategory : System.Web.UI.Page
    {
        CategoryController objSC = new CategoryController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            objSC.CreateCategory(txtName.Text, txtDescription.Text, 101, 101);
        }
    }
}