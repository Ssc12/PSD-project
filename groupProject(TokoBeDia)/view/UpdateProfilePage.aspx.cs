using groupProject_TokoBeDia_.controller;
using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];

            if (!IsPostBack)
            {
                updateProfileEmailId.Text = user.Email;
                updateProfileNameId.Text = user.Name;
                updateProfileGenderID.Text = user.Gender;
            }
        }

        protected void doUpdateProfile(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.UsersId;
            String email = updateProfileEmailId.Text.ToString();
            String name = updateProfileNameId.Text.ToString();
            String gender = updateProfileGenderID.Text.ToString();

            if (!email.Contains("@") || !email.Contains(".com"))
            {
                errorMsgId.Text = "email must be unique(___@___.com)";
            }
            else if (name.Length == 0)
            {
                errorMsgId.Text = "name must be filled";
            }
            else if (updateProfileGenderID.SelectedIndex < 0)
            {
                errorMsgId.Text = "gender must be selected";
            }
            else
            {
                UserController.updateProfile(userId, email, name, gender);

                Response.Redirect("Profile.aspx");
            }

        }
    }
}