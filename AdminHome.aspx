<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
       <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">


            <br />
            <strong>
            <asp:Label ID="Label1" runat="server" style="color: #336699; font-size: xx-large" Text="Admin Home"></asp:Label>
            </strong>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Add New Problem" Width="50%" BackColor="Black" ForeColor="White" Height="35px" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Font-Bold="True" Text="Delete Problem" Width="50%" BackColor="Black" ForeColor="White" Height="35px" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Font-Bold="True" Text="Edit Problem" Width="50%" BackColor="Black" ForeColor="White" Height="35px" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Font-Bold="True" Text="Check Requests" Width="50%" BackColor="Black" ForeColor="White" Height="35px" OnClick="Button6_Click"  />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Font-Bold="True" Text="Add New Admin Account" Width="50%" BackColor="Black" ForeColor="White" Height="35px" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Log Out" Width="50%" BackColor="Black" ForeColor="White" OnClick="Button2_Click" Height="35px" />
            <br />
            <br />
            <br />
            <br />


        </div>



    </div>
</asp:Content>

