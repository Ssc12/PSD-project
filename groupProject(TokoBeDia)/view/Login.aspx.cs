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
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user_auth"] != null)
            {
                if (!IsPostBack)
                {
                    loginEmailId.Text = Request.Cookies["user_auth"]["email"].ToString();
                    loginPasswordId.Attributes["value"] = Request.Cookies["user_auth"]["password"];
                    rememberMeId.Checked = true;
                }
            }
            else
            {
                if (!IsPostBack)
                {
                    loginEmailId.Text = "";
                    loginPasswordId.Text = "";
                    rememberMeId.Checked = false;
                }
            }


        }

        protected void doLogin(object sender, EventArgs e)
        {
            String email = loginEmailId.Text;
            String password = loginPasswordId.Text;

            if (email.Length == 0)
            {
                errorMsgId.Text = "email must be input";
            }
            else if (password.Length == 0)
            {
                errorMsgId.Text = "password must be input";
            }
            else
            {
                User user = UserController.login(email, password);

                if (user != null)
                {

                    if (user.Status.Equals("blocked"))
                    {
                        errorMsgId.Text = "You are currently banned by administrator";
                    }
                    else
                    {
                        if (rememberMeId.Checked == true)
                        {
                            Response.Cookies["user_auth"]["email"] = email;
                            Response.Cookies["user_auth"]["password"] = password;
                            Response.Cookies["email"].Expires = DateTime.Now.AddDays(1);
                            Response.Cookies["password"].Expires = DateTime.Now.AddDays(1);
                        }
                        else if (rememberMeId.Checked == false)
                        {
                            Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);
                            Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                            Response.Cookies["user_auth"].Expires = DateTime.Now.AddDays(-1);
                        }

                        Session["user"] = user;
                        Response.Redirect("Home.aspx");
                    }

                }
                else
                {
                    errorMsgId.Text = "account doesn't exist";
                }
            }
        }
    }
}