<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RestQ.aspx.cs" Inherits="RestQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
           <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">
            <strong>
            <span style="font-size: xx-large; color: #006699"><span style="font-size: medium; color: #006699">
            <br />
            Please Answer The Questions To Find The Solution.</span><br />
            </span>
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderStyle="Solid" Height="59px">
                <strong>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label" style="color: #000000"></asp:Label>
                </strong>
            </asp:Panel>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="YES" Checked="True" GroupName="B" style="color: #000000" />
            <br />
            </strong>
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="NO" GroupName="B" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Next" Width="208px" BackColor="Black" ForeColor="White" />
            <br />
            <br />
            </div>
           </div>
</asp:Content>

