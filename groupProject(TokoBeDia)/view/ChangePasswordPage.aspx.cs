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
    public partial class ChangePasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doChangePassword(object sender, EventArgs e)
        {
            String oldPassword = oldPasswordId.Text;
            String newPassword = newPasswordId.Text;
            String confirmPassword = confirmNewPasswordId.Text;

            User user = (User)Session["user"];
            String userOldPassword = user.Password;
            int userId = user.UsersId;

            if (oldPassword.Length == 0)
            {
                errorMsgId.Text = "please fill the old password";
            }
            else if (oldPassword!= userOldPassword)
            {
                errorMsgId.Text = "Old Password doesnt match";
            }
            else if (newPassword.Length < 5)
            {
                errorMsgId.Text = "new Password must be at least 5 character";
            }
            else if (newPassword.Equals(userOldPassword))
            {
                errorMsgId.Text = "new Password can't same with the old password";
            }
            else if (!confirmPassword.Equals(newPassword))
            {
                errorMsgId.Text = "Confirm password must be the same with new Password";
            }
            else
            {
                UserController.changePassword(userId, confirmPassword);
                Response.Redirect("Profile.aspx");
            }

        }
    }
}