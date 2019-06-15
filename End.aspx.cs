using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class End : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["MSG"].ToString();
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if(Session["ADMIN"]==null || Session["ADMIN"].ToString().Length<1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}