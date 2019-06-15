using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if(TextBox1.Text.TrimEnd().Length<1)
        {
            Label1.Text = "Please Insert A Valid User Name.";
            Label1.Visible = true;
            return;
        }
        if(TextBox2.Text.Length<1)
        {
            Label1.Text = "Please Insert A Valid Password.";
            Label1.Visible = true;
            return;
        }
        if(!TextBox2.Text.Equals(TextBox3.Text))
        {
            Label1.Text = "Passwords Are Not Match.";
            Label1.Visible = true;
            return;
        }
        TaskManager ts = new TaskManager();
        if(!ts.CreateAccount(TextBox1.Text,TextBox2.Text))
        {
            Label1.Text = "The UserName Already Exist.";
            Label1.Visible = true;
            return;
        }
        else
        {
            Label1.Text = "The New Account Created Successfully.";
            TextBox1.Text = TextBox2.Text = TextBox3.Text = string.Empty;
            Label1.Visible = true;
            return;
        }
    }
}