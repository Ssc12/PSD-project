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
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewUserListTableId.DataSource = UserRepository.db.Users.ToList();
            viewUserListTableId.DataBind();
        }

        protected void doChangeRolesOrStatus(object sender, EventArgs e)
        {
            int userId;
            try
            {
                userId = Int32.Parse(userIdforRolesChange.Text);
            }
            catch
            {
                userId = -1;
            }
            String status = statusIdforChange.Text;
            String roles = rolesIdforChange.Text;

            User us = UserRepository.db.Users.Where(users => users.UsersId == userId).FirstOrDefault();
            String name = us.Name;
            String email = us.Email;

            User user = (User)Session["user"];


            if (userId == -1)
            {
                errorMsgId.Text = "please choose the user Id";
            }
            else if (!roles.Equals("administrator") && !roles.Equals("member"))
            {
                errorMsgId.Text = "roles must be (administrator) or (member)";
            }
            else if (!status.Equals("active") && !status.Equals("blocked"))
            {
                errorMsgId.Text = "status must be (active) or (blocked)";
            }
            else if (name == user.Name && email == user.Email)
            {
                errorMsgId.Text = "you can't change your own roles and password";
            }
            else
            {
                UserController.changeRolesOrStatus(userId, roles, status);
                Response.Redirect("ViewUser.aspx");
            }
        }

        protected void viewUserListTableId_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[6].Text = "Roles";
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int rolesId = Int32.Parse(e.Row.Cells[6].Text);
                User u = UserRepository.db.Users.Where(user => user.RolesId == rolesId).FirstOrDefault();
                e.Row.Cells[6].Text = u.Role.Name;
            }
        }
    }
}