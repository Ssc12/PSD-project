using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            profileEmailId.Text = user.Email;
            profileNameId.Text = user.Name;
            profileGenderId.Text = user.Gender;
        }

        protected void gotoUpdateProfilePg(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfilePage.aspx");
        }

        protected void gotoChangePasswordPg(object sender, EventArgs e)
        {
            Response.Redirect("ChangePasswordPage.aspx");
        }
    }
}