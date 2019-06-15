<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShowSol.aspx.cs" Inherits="ShowSol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">
            <strong>
            <span style="font-size: xx-large; color: #006699">
            <br />
            <br />
            Solution<br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BackColor="Yellow" BorderStyle="Solid">
                <strong>
                <asp:Label ID="Label1" runat="server" Text="Label" style="font-size: medium; color: #000000"></asp:Label>
                </strong>
            </asp:Panel>
            </span>
            <br />
            <br />
            Is This Solved Your Problem?<br />
            </strong><br />
            <asp:Button ID="Button1" runat="server" Text="Yes" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button1_Click1" Width="158px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="No" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button2_Click" Width="158px" />
            <br />
            <br />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

