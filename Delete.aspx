<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
           <div style="width:100%;height: 100%; background-color: #FFFFFF;">
        <div style="width:60%; margin-left:20%; height: 100%; color: #FFFFFF; background-color: #FFFFFF;" class="text-center">
            <div>
                <strong>
                <span style="font-size: xx-large; color: #000000; text-align: left;">
                <br />
            </span>
                </strong><span style="font-size: xx-large; color: #006699; text-align: left;">
                <strong style="color: #000000">
                DELETE PROBLEM</strong></span><strong><span style="font-size: xx-large; color: #000000; text-align: left;"><br />
            <br />
            </span>
            <span style="font-size: medium; color: #000000; text-align: left;">
                CHOOSE THE PROBLEM TO DELETE</span></strong><br />
            </div>
            <asp:Table ID="Table1" runat="server" GridLines="Both" HorizontalAlign="Center" Width="100%" ForeColor="Black">
            </asp:Table>
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Error"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Delete" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

