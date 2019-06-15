using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class First_Question : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    int pId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        pId = Int32.Parse(Session["PID"].ToString());
        string problem = ts.getProblem(pId);
        TextBox2.Text=problem;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string mQ = TextBox3.Text;
        string yQ = TextBox4.Text;
        string nQ = TextBox5.Text;

        if(mQ.TrimEnd().Length<1 || yQ.TrimEnd().Length<1 || nQ.TrimEnd().Length<1)
        {
            Label2.Text = "Please Fill All Questions.";
            Label2.Visible = true;
            return;
        }
        if(!ts.newQuestion(0,pId,mQ,0,0,"M"))
        {
            Label2.Text = "Somthing Went Wrong, Please Try Again.";
            Label2.Visible = true;
            return;
        }
        int mID = ts.getFQID(mQ);

        int ys = 0;
        int ns = 0;
        if (CheckBox1.Checked)
            ys = 1;
        if (CheckBox2.Checked)
            ns = 1;
        if (!ts.newQuestion(mID, pId, yQ, ys, ns, "Y"))
        {
            Label2.Text = "Somthing Went Wrong, Please Try Again.";
            Label2.Visible = true;
            return;
        }

        ys = ns = 0;
        if (CheckBox3.Checked)
            ys = 1;
        if (CheckBox4.Checked)
            ns = 1;
        if (!ts.newQuestion(mID, pId, nQ, ys, ns, "N"))
        {
            Label2.Text = "Somthing Went Wrong, Please Try Again.";
            Label2.Visible = true;
            return;
        }
        Response.Redirect("New_Questions.aspx");

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}