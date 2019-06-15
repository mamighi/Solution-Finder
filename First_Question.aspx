<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="First_Question.aspx.cs" Inherits="First_Question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
       <div style="width:100%">
        <div style="width:60%; margin-left:20%" class="text-center">


            <br />
            <strong>
            <asp:Label ID="Label1" runat="server" style="color: #336699; font-size: xx-large" Text="First Question"></asp:Label>
            </strong>
            <br />
            <br />
            <strong>Problem</strong><br />
            <asp:TextBox ID="TextBox2" runat="server" Height="79px" TextMode="MultiLine" Width="60%" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <strong>Question<br />
            </strong>
            <asp:TextBox ID="TextBox3" runat="server" Width="80%"></asp:TextBox>
            <br />
            <br />
            <br />
            <strong style="color: #000000">Next Question For &#39;YES&#39; Option</strong><br />
            <asp:TextBox ID="TextBox4" runat="server" Width="80%"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Next 'YES' Has Solution" OnCheckedChanged="CheckBox1_CheckedChanged" />
&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Next 'NO' Has Solution" />
            <br />
            <br />
            <strong>Next Question For &#39;NO&#39; Option<br />
            <asp:TextBox ID="TextBox5" runat="server" Width="80%"></asp:TextBox>
            </strong>
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Next 'YES' Has Solution" />
            &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Next 'NO' Has Solution" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Next" Width="43%" BackColor="Black" ForeColor="White" Height="30px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Cancel" Width="43%" BackColor="Black" ForeColor="White" Height="30px" />
            <br />
            <br />
            <br />


        </div>



    </div>
</asp:Content>

