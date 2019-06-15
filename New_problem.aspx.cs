using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class New_problem : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        if (!IsPostBack)
            loadCats();
    }
    protected void loadCats()
    {
        List<string> cats = ts.getCats();
        if(cats.Count==0)
        {
            CheckBox1.Checked=true;
            return;
        }
        DropDownList1.Items.Clear();
        foreach (string tc in cats)
        {
            DropDownList1.Items.Add(tc);
        }

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if(CheckBox1.Checked)
        {
            TextBox1.Enabled = true;
            DropDownList1.Enabled = false;
        }
        else
        {
            TextBox1.Enabled = false;
            DropDownList1.Enabled = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cat=string.Empty;
        if (CheckBox1.Checked)
            cat = TextBox1.Text;
        else
            cat = DropDownList1.SelectedItem.ToString();
        if(cat.TrimEnd().Length<1)
        {
            Label2.Text = "Please Enter/Select The Category.";
            Label2.Visible = true;
            return;
        }
        string problem = TextBox2.Text;
        if (problem.TrimEnd().Length < 1)
        {
            Label2.Text = "Please Enter The Problem.";
            Label2.Visible = true;
            return;
        }
        if(CheckBox1.Checked && DropDownList1.Items.ToString().Contains(TextBox1.Text))
        {
            Label2.Text = "Category Exist, Please Choose From The List.";
            Label2.Visible = true;
            return;
        }
        if(CheckBox1.Checked)
        {
            if(!ts.newCat(cat))
            {
                Label2.Text = "Failed To Insert To Database.";
                Label2.Visible = true;
                return;
            }
        }
        if(!ts.newProblem(cat,problem))
        {
            if (!ts.newCat(cat))
            {
                Label2.Text = "Failed To Insert To Database.";
                Label2.Visible = true;
                return;
            }
        }
        int problemId = ts.getProblemId(problem);
        if(problemId==0)
        {
            Label2.Text = "Sorry Something Went Wrong, Please Try Again.";
            Label2.Visible = true;
            return;
        }
        Session["PID"] = problemId;
        Response.Redirect("First_Question");
    }
}