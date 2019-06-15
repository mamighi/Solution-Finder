<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CheckRequest.aspx.cs" Inherits="CheckRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <div style="width:100%;height: 100%; background-color: #FFFFFF;">
        <div style="width:60%; margin-left:20%; height: 100%; color: #FFFFFF; background-color: #FFFFFF;" class="text-center">
            <div>
                <strong>
                <span style="font-size: xx-large; color: #000000; text-align: left;">
                <br />
                Users Requests<br />
            </span>
                </strong><br />
            </div>
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Width="100%" ForeColor="Black">
            </asp:Table>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Back" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

