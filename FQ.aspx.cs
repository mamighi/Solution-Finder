using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FQ : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    TaskManager.QC qu;
    protected void Page_Load(object sender, EventArgs e)
    {
        int pid=Int32.Parse(Session["PID"].ToString());
        qu = ts.getQus(pid, 0, "M");
        Label1.Text = qu.qu;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["PAID"] = qu.id;
        if(RadioButton1.Checked)
        {
            Session["ANS"] = "Y";
            if(qu.isy==0)
            {
                Response.Redirect("RestQ.aspx");
            }
            else
            {
                Response.Redirect("ShowSol.aspx");
            }
        }
        else
        {
            Session["ANS"] = "N";
            if (qu.isn == 0)
            {
                Response.Redirect("RestQ.aspx");
            }
            else
            {
                Response.Redirect("ShowSol.aspx");
            }
        }
    }
}