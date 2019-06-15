using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("New_problem.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["ADMIN"] = "";
        Response.Redirect("Default.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateAccount.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Delete.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Edit Problem.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckRequest.aspx");
    }
}