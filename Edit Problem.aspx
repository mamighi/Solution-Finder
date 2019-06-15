<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Edit Problem.aspx.cs" Inherits="Edit_Problem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
       <div style="width:100%;height: 100%; background-color: #FFFFFF;">
        <div style="width:60%; margin-left:20%; height: 100%; color: #000000; background-color: #FFFFFF;" class="text-center">
            <div>
                <strong>
                <span style="font-size: xx-large; color: #000000; text-align: left;">
                <br />
            </span>
            <span style="font-size: xx-large; color: #006699; text-align: left;">
                EDIT PROBLEM</span><br />
                <span style="font-size: xx-large; color: #000000; text-align: left;">
            <br />
            </span>
            <span style="font-size: medium; color: #000000; text-align: left;">
                CHOOSE THE PROBLEM TO EDIT</span></strong><br />
            </div>
            <asp:Table ID="Table1" runat="server" GridLines="Both" HorizontalAlign="Center" Width="100%" ForeColor="Black">
            </asp:Table>
            <br />
            <br />
            Entert a part of question you want to edit from<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="273px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Error"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Next" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

