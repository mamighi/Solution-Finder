<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="New_problem.aspx.cs" Inherits="New_problem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">


            <br />
            <br />
            <strong>
            <asp:Label ID="Label1" runat="server" style="color: #336699; font-size: xx-large" Text="New Problem"></asp:Label>
            </strong>
            <br />
            <br />
            <strong>Category<br />
            </strong>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="208px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="New Category" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="208px"></asp:TextBox>
            <br />
            <br />
            <strong>Problem</strong><br />
            <asp:TextBox ID="TextBox2" runat="server" Height="121px" TextMode="MultiLine" Width="300px" ClientIDMode="Static" EnableTheming="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Next" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Cancel" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" />
            <br />
            <br />
            <br />


        </div>



    </div>

</asp:Content>

