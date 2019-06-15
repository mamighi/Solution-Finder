using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class New_Questions : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    List<TaskManager.QC> questions;
    int pId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
  
            Label2.Visible = Label3.Visible = Label4.Visible =
                Label5.Visible = Label6.Visible = Label7.Visible =
                Label8.Visible = Label9.Visible = false;
            pId = Int32.Parse(Session["PID"].ToString());
            questions = ts.getQuestions(pId);
            if (questions.Count == 0)
            {
                Session["MSG"] = "You Successfully Filled All Question And Solutions.\nThe Problem Now Is Available For Users.";
                Response.Redirect("End.aspx");
            }
            TextBox3.Text = ts.getQu(questions[0].paid);

            int quNum = questions.Count;
            TextBox6.Text = questions[0].qu;
            if (questions[0].isy == 1)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }

            if (questions[0].isn == 1)
            {
                Panel5.Visible = false;
                Panel6.Visible = true;
            }
            else
            {
                Panel5.Visible = true;
                Panel6.Visible = false;
            }


            if (quNum < 2)
            {
                Panel3.Visible = Panel4.Visible
                    = Panel7.Visible = Panel8.Visible=Panel10.Visible
                    = false;
            }
            else
            {
                TextBox7.Text = questions[1].qu;
                if (questions[1].isy == 1)
                {
                    Panel3.Visible = false;
                    Panel4.Visible = true;
                }
                else
                {
                    Panel3.Visible = true;
                    Panel4.Visible = false;
                }
                if (questions[1].isn == 1)
                {
                    Panel7.Visible = false;
                    Panel8.Visible = true;
                }
                else
                {
                    Panel7.Visible = true;
                    Panel8.Visible = false;
                }
            }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Visible = Label3.Visible = Label4.Visible =
             Label5.Visible = Label6.Visible = Label7.Visible =
             Label8.Visible = Label9.Visible = false; 

        if(Panel1.Visible)
        {
            if(TextBox4.Text.TrimEnd().Length<1)
            {
                Label3.Text = "Please Insert The Question.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label3.Visible = true;
                Label2.Visible = true;
                return;
            }
            int ys = 0;
            int ns = 0;
            if (CheckBox1.Checked)
                ys = 1;
            if (CheckBox2.Checked)
                ns = 1;
            ts.newQuestion(questions[0].id, pId, TextBox4.Text, ys, ns, "Y");
        }
        //////
        if(Panel2.Visible)
        {
            if(TextBox10.Text.TrimEnd().Length<1)
            {
                Label4.Text = "Please Insert Atleast One Solution.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label4.Visible = true;
                Label2.Visible = true;
                return;
            }
            ts.insertSolution(questions[0].id, TextBox10.Text, TextBox11.Text, TextBox12.Text,
                TextBox13.Text, TextBox14.Text, TextBox15.Text, "Y");
        }
        //////
        if(Panel5.Visible)
        {
            if (TextBox5.Text.TrimEnd().Length < 1)
            {
                Label5.Text = "Please Insert The Question.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label5.Visible = true;
                Label2.Visible = true;
                return;
            }
            int ys = 0;
            int ns = 0;
            if (CheckBox3.Checked)
                ys = 1;
            if (CheckBox4.Checked)
                ns = 1;
            ts.newQuestion(questions[0].id, pId, TextBox5.Text, ys, ns, "N");
        }
        ////
        if(Panel6.Visible)
        {
            if (TextBox22.Text.TrimEnd().Length < 1)
            {
                Label6.Text = "Please Insert Atleast One Solution.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label6.Visible = true;
                Label2.Visible = true;
                return;
            }
            ts.insertSolution(questions[0].id, TextBox22.Text, TextBox23.Text, TextBox24.Text,
                TextBox25.Text, TextBox26.Text, TextBox27.Text, "N");
        }
        //////////

        if(Panel3.Visible)
        {
            if (TextBox8.Text.TrimEnd().Length < 1)
            {
                Label7.Text = "Please Insert The Question.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label7.Visible = true;
                Label2.Visible = true;
                return;
            }
            int ys = 0;
            int ns = 0;
            if (CheckBox5.Checked)
                ys = 1;
            if (CheckBox6.Checked)
                ns = 1;
            ts.newQuestion(questions[1].id, pId, TextBox8.Text, ys, ns, "Y");
        }
        /////////////
        if(Panel4.Visible)
        {
            if (TextBox16.Text.TrimEnd().Length < 1)
            {
                Label8.Text = "Please Insert Atleast One Solution.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label8.Visible = true;
                Label2.Visible = true;
                return;
            }
            ts.insertSolution(questions[1].id, TextBox16.Text, TextBox17.Text, TextBox18.Text,
                TextBox19.Text, TextBox20.Text, TextBox21.Text, "Y");
        }
        ///////
        if(Panel7.Visible)
        {
            if (TextBox9.Text.TrimEnd().Length < 1)
            {
                Label9.Text = "Please Insert The Question.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label9.Visible = true;
                Label2.Visible = true;
                return;
            }
            int ys = 0;
            int ns = 0;
            if (CheckBox7.Checked)
                ys = 1;
            if (CheckBox8.Checked)
                ns = 1;
            ts.newQuestion(questions[1].id, pId, TextBox9.Text, ys, ns, "N");
        }
        //////////////////////
        if(Panel8.Visible)
        {
            if (TextBox28.Text.TrimEnd().Length < 1)
            {
                Label10.Text = "Please Insert Atleast One Solution.";
                Label2.Text = "Please Fill All Requierd Information.";
                Label10.Visible = true;
                Label2.Visible = true;
                return;
            }
            ts.insertSolution(questions[1].id, TextBox28.Text, TextBox29.Text, TextBox30.Text,
                TextBox31.Text, TextBox32.Text, TextBox33.Text, "N");
        }
        Response.Redirect("New_Questions.aspx");

    }
}