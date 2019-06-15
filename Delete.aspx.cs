using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        loadProblems();
    }
    public void loadProblems()
    {
        List<TaskManager.pr> probs = ts.getProblems();
        Table1.Rows.Clear();
        TableRow frow = new TableRow();
        TableCell cont = new TableCell();
        cont.Text = "-";
        TableCell cId = new TableCell();
        cId.Text = "ID";
        TableCell cprob = new TableCell();
        cprob.Text = "PROBLEMS";
        TableCell ccat = new TableCell();
        ccat.Text = "CATEGORY";
        frow.Cells.Add(cont);
        frow.Cells.Add(cId);
        frow.Cells.Add(cprob);
        frow.Cells.Add(ccat);
        frow.BackColor = System.Drawing.Color.YellowGreen;
        Table1.Rows.Add(frow);
        foreach (TaskManager.pr temp in probs)
        {
            TableRow frow2 = new TableRow();
            TableCell cont2 = new TableCell();
            RadioButton rb = new RadioButton();
            rb.GroupName = "S";
            cont2.Controls.Add(rb);
            TableCell cId2 = new TableCell();
            cId2.Text = temp.id.ToString();
            TableCell cprob2 = new TableCell();
            cprob2.Text = temp.pr_;
            TableCell ccat2 = new TableCell();
            ccat2.Text = temp.ca;
            frow2.Cells.Add(cont2);
            frow2.Cells.Add(cId2);
            frow2.Cells.Add(cprob2);
            frow2.Cells.Add(ccat2);
            Table1.Rows.Add(frow2);

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        bool found = false;
        for (int i = 1; i < Table1.Rows.Count; i++)
        {
            TableRow frow2 = Table1.Rows[i];
            TableCell cont2 = frow2.Cells[0];
            RadioButton rb = (RadioButton)cont2.Controls[0];

            TableCell cId2 = frow2.Cells[1];
            int id = Int32.Parse(cId2.Text);
            if (rb.Checked)
            {
                found = true;
                ts.deleteProblem(id);
                Label1.Text = "Problem has been deleted successfully.";
                Label1.Visible = true;
            }
        }
        if (!found)
        {
            Label1.Text = "Please choose a problem to delete.";
            Label1.Visible = true;
            return;
        }
        Response.Redirect("Delete.aspx");
    }
}