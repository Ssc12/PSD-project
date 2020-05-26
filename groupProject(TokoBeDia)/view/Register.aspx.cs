using groupProject_TokoBeDia_.controller;
using groupProject_TokoBeDia_.model;
using groupProject_TokoBeDia_.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doRegister(object sender, EventArgs e)
        {
            String email = regEmailId.Text;
            String name = regNameId.Text;
            String password = regPasswordId.Text;
            String confPw = regConfirmPwId.Text;
            String gender;
            try
            {
                gender = genderID.SelectedItem.Value;
            }
            catch
            {
                gender = "";
            }

            User u = UserRepository.db.Users.Where(us => us.Email.Equals(email)).FirstOrDefault();
            string emailIsExist;
                try
                {
                    emailIsExist = u.Email;
                }
                catch
                {
                    emailIsExist = "";
                }

            String status = "active";
            int rolesId = 2;

            if (!email.Contains("@") || !email.Contains(".com"))
            {
                errorMsgID.Text = "email must be unique(___@___.com)";
            }
            else if (email.Equals(emailIsExist))
            {
                errorMsgID.Text = "email has been taken, please use anothe email";
            }
            else if (name.Length == 0)
            {
                errorMsgID.Text = "name must be filled";
            }
            else if (password.Length == 0)
            {
                errorMsgID.Text = "password must be filled";
            }
            else if (password.Contains(" "))
            {
                errorMsgID.Text = "password cannot contain space";
            }
            else if (confPw.Length == 0)
            {
                errorMsgID.Text = "password must be confirm";
            }
            else if (!confPw.Equals(password))
            {
                errorMsgID.Text = "must be confirm with the same password";
            }
            else if (genderID.SelectedIndex < 0)
            {
                errorMsgID.Text = "gender must be selected";
            }
            else
            {
                UserController.registerNewUser(name, email, password, gender, status, rolesId);

                Response.Redirect("Login.aspx");
            }


        }

        //DBCC CHECKIDENT ('Users',RESEED,0);
    }
}