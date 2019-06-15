using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckRequest : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();

    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> requests = ts.getRequests();
        Table1.Rows.Clear();
        for(int i=0;i<requests.Count;i++)
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            cell.Text = requests[i];
            row.Cells.Add(cell);
            if(i%2==0)
            {
                row.BackColor = System.Drawing.Color.YellowGreen;

            }
            Table1.Rows.Add(row);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }
}