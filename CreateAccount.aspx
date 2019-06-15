<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="CreateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">
            <strong>
            <span style="font-size: xx-large; color: #000000">
            <br />
            </span>
            <span style="font-size: xx-large; color: #336699">
            Create New Account</span><span style="font-size: xx-large; color: #000000"><br />
            <br />
            </span>
            <span style="font-size: medium; color: #000000">
            User Name<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="194px"></asp:TextBox>
            <br />
            <br />
            Re-Password<br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="194px"></asp:TextBox>
            <br />
            </span>
            <br />
            <br />
            </strong>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button1_Click1" Width="158px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button2_Click" Width="158px" />
            <br />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

