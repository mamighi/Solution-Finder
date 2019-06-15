using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using SolutionFinder;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ADMIN"]!=null)
            {
                if(Session["ADMIN"].ToString().TrimEnd().Equals("ADMIN"))
                    Response.Redirect("../AdminHome.aspx");
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            TaskManager ts = new TaskManager();
            if (ts.Login(UserName.Text,Password.Text))
            {
                // Validate the user password

                Session["ADMIN"] = "ADMIN";
                Response.Redirect("../AdminHome.aspx");
            }
            else
            {
                FailureText.Text = "Invalid username or password.";
                ErrorMessage.Visible = true;
            }
        }
}