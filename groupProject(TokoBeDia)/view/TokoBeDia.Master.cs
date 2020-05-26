using groupProject_TokoBeDia_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace groupProject_TokoBeDia_.view
{
    public partial class TokoBeDia : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewProductBtnId.Visible = true;
            guestLoginBtnId.Visible = true;
            gotoHomepgBtnId.Visible = false;
            viewProfileBtnId.Visible = false;
            LogoutBtnId.Visible = false;

            User user = (User)Session["user"];
            if (Session["user"] != null)
            {
                guestLoginBtnId.Visible = false;
                if (user.RolesId == 1 || user.RolesId == 2)
                {
                    gotoHomepgBtnId.Visible = true;
                    viewProfileBtnId.Visible = true;
                    LogoutBtnId.Visible = true;
                }
            }
            else
            {
                gotoHomepgBtnId.Visible = false;
                LogoutBtnId.Visible = false;
            }


        }

        protected void gotoViewProductPg(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void gotoProfilePage(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void gotoLoginPg(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void doLogOut(object sender, EventArgs e)
        {
            Session.Remove("user");
            if (Request.Cookies["user_auth"] != null)
            {
                Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["user_auth"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Login.aspx");
        }

        protected void gotoHomePg(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}