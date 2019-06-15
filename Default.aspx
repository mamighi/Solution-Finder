<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
       <div style="width:100%;height: 100%; background-color: #FFFFFF;">
        <div style="width:60%; margin-left:20%; height: 100%; color: #FFFFFF; background-color: #FFFFFF; font-weight: 700;" class="text-center">
            <div>
                <strong>
                <span style="font-size: xx-large; color: #006699; text-align: left;">
                <br />
                WELCOME TO IntelliShoot<br />
            <br />
            </span>
            <span style="font-size: small; color: #000000; text-align: left;">Find your problem from the below list and press next to get your solution</span></strong><br />
            </div>
            <asp:Table ID="Table1" runat="server" GridLines="Both" HorizontalAlign="Center" Width="100%" ForeColor="Black" ViewStateMode="Enabled">
            </asp:Table>
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Next" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" />
            <br />
            <br style="color: #000000" />
            <span style="color: #000000">Type your problem if it is not in the list. We will try to add the case as soon as possible:<br />
            </span>
            <asp:TextBox ID="TextBox1" runat="server" Height="73px" TextMode="MultiLine" Width="406px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True"  Text="Submit" Width="208px" BackColor="Black" BorderStyle="Solid" ForeColor="White" Height="30px" OnClick="Button2_Click" />
            <br />
            <br />
            </div>
           </div>
 
</asp:Content>
