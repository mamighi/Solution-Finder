using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowSol : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    List<string> solutions;
    protected void Page_Load(object sender, EventArgs e)
    {
        int pid = Int32.Parse(Session["PAID"].ToString());
        string yn = Session["ANS"].ToString().TrimEnd();
        solutions = ts.getSol(pid, yn);
        if (!IsPostBack)
        {
            Label1.Text = solutions[0];
            Session["NEXT"] = "1";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int loadSolution = Int32.Parse(Session["NEXT"].ToString());
        if (solutions.Count < loadSolution + 1 || solutions[loadSolution].TrimEnd().Length<1)
        {
            Session["MSG"] = "Sorry, We Could Not Find A Soultion For Your Problem. \nPlease Contact Your Administartor";
            Response.Redirect("End.aspx");
            return;
        }
        else
        {
            Label1.Text = solutions[loadSolution];
            Session["NEXT"] = loadSolution + 1;
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Session["MSG"] = "We Are Happy That We Could Help You.\nThank You For Choosing Us.";
        Response.Redirect("End.aspx");
        return;
    }
}