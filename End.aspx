<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="End.aspx.cs" Inherits="End" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">
            <span style="font-size: xx-large; color: #006699">
            <strong>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BackColor="Yellow">
                <asp:Label ID="Label1" runat="server" Text="Label" style="color: #000000; font-size: medium"></asp:Label>
            </strong>
            </asp:Panel>
            <br />
            </span>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button1_Click1" Width="158px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

