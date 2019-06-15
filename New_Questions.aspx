<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="New_Questions.aspx.cs" Inherits="New_Questions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
           <div style="width:100%">
        <div style="width:60%; margin-left:20%; background-color: #FFFFFF; " class="text-center">


            <br />
            <br />
            <strong>
            <asp:Label ID="Label1" runat="server" style="color: #336699; font-size: xx-large" Text="Questions/Solutions"></asp:Label>
            </strong>
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel9" runat="server" BackColor="#336699" Height="62px">
                <strong><span style="color: #FFFFFF">Parent Question</span><br /> </strong>
                <asp:TextBox ID="TextBox3" runat="server" Width="80%" ReadOnly="True" Height="20px"></asp:TextBox>
            </asp:Panel>
      
            <br />
       
         
            <span style="font-size: large">&nbsp;Question For Answer Yes To Parent Question</span><br />
          
           
            <asp:TextBox ID="TextBox6" runat="server" Width="80%" ReadOnly="True"></asp:TextBox>

  
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="124px" BackColor="White">
                <strong>
                <br />
                </strong><span style="font-size: medium">Next Question For &#39;YES&#39; Option</span><br />
                <asp:TextBox ID="TextBox4" runat="server" Width="80%"></asp:TextBox>
                <br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Next 'YES' Has Solution" />
                &nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Next 'NO' Has Solution" />
                <br />
                <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
                <br />
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Height="345px" BackColor="White" style="margin-top: 0px">
                Solution For Answer Yes<br />
                <br />
                Solution 1<br />
                <asp:TextBox ID="TextBox10" runat="server" Width="90%" style="font-weight: bold"></asp:TextBox>
                <br />
                Solution 2<br />
                <asp:TextBox ID="TextBox11" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 3<br />
                <asp:TextBox ID="TextBox12" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 4<br />
                <asp:TextBox ID="TextBox13" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 5<br />
                <asp:TextBox ID="TextBox14" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 6<strong><br /> </strong>
                <asp:TextBox ID="TextBox15" runat="server" Width="90%"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel5" runat="server" BackColor="White" Height="91px" style="margin-top: 0px">
                <span style="font-size: large">Next Question For &#39;NO&#39; Option<br /> </span><strong>
                <asp:TextBox ID="TextBox5" runat="server" Width="80%"></asp:TextBox>
                </strong>
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Next 'YES' Has Solution" />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Next 'NO' Has Solution" />
                <br />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel6" runat="server" Height="323px" BackColor="White" style="margin-top: 0px">
                Solutions For Answer No<br />
                <br />
                Solution 1<br />
                <asp:TextBox ID="TextBox22" runat="server" Width="90%" style="font-weight: bold"></asp:TextBox>
                <br />
                Solution 2<br />
                <asp:TextBox ID="TextBox23" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 3<br />
                <asp:TextBox ID="TextBox24" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 4<br />
                <asp:TextBox ID="TextBox25" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 5<br />
                <asp:TextBox ID="TextBox26" runat="server" style="font-weight: bold" Width="90%"></asp:TextBox>
                <br />
                Solution 6<strong><br /> </strong>
                <asp:TextBox ID="TextBox27" runat="server" Width="90%"></asp:TextBox>
                <br />
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel10" runat="server" BackColor="#336699" Height="66px">
                <strong><span style="color: #FFFFFF">Question For Answer No To Parent Question</span><br /> </strong>
                <asp:TextBox ID="TextBox7" runat="server" Width="80%" ReadOnly="True"></asp:TextBox>
            </asp:Panel>
           
            <asp:Panel ID="Panel3" runat="server" Height="134px" BackColor="#336699" style="margin-top: 0px">
                <strong>
                <br />
                <span style="color: #FFFFFF">Next Question For &#39;YES&#39; Option</span></strong><br />
                <asp:TextBox ID="TextBox8" runat="server" Width="80%"></asp:TextBox>
                <br />
                <asp:CheckBox ID="CheckBox5" runat="server" Text="Next 'YES' Has Solution" style="color: #FFFFFF" />
                &nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox6" runat="server" Text="Next 'NO' Has Solution" style="color: #FFFFFF" />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel4" runat="server" Height="327px" BackColor="#336699">
                <strong><span style="color: #FFFFFF">Solution For Answer Yes</span><br />
                <br />
                <span style="color: #FFFFFF">Solution 1</span><br /> </strong>
                <asp:TextBox ID="TextBox16" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 2</span><br /> </strong>
                <asp:TextBox ID="TextBox17" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 3</span><br /> </strong>
                <asp:TextBox ID="TextBox18" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 4</span><br /> </strong>
                <asp:TextBox ID="TextBox19" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 5</span><br /> </strong>
                <asp:TextBox ID="TextBox20" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 6</span><br /> </strong>
                <asp:TextBox ID="TextBox21" runat="server" Width="90%"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel7" runat="server" BackColor="#336699" Height="89px">
                <strong>Next Question For &#39;NO&#39; Option<br />
                <asp:TextBox ID="TextBox9" runat="server" Width="80%"></asp:TextBox>
                </strong>
                <br />
                <asp:CheckBox ID="CheckBox7" runat="server" Text="Next 'YES' Has Solution" style="color: #FFFFFF" />
                <asp:CheckBox ID="CheckBox8" runat="server" Text="Next 'NO' Has Solution" style="color: #FFFFFF" />
                <br />
                <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel8" runat="server" Height="336px" BackColor="#336699">
                <strong><span style="color: #FFFFFF">Solutions For Answer No</span><br />
                <br />
                <span style="color: #FFFFFF">Solution 1</span><br /> </strong>
                <asp:TextBox ID="TextBox28" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 2</span><br /> </strong>
                <asp:TextBox ID="TextBox29" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 3</span><br /> </strong>
                <asp:TextBox ID="TextBox30" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 4</span><br /> </strong>
                <asp:TextBox ID="TextBox31" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 5</span><br /> </strong>
                <asp:TextBox ID="TextBox32" runat="server" Width="90%"></asp:TextBox>
                <br />
                <strong><span style="color: #FFFFFF">Solution 6</span><br /> </strong>
                <asp:TextBox ID="TextBox33" runat="server" Width="90%"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            </asp:Panel>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Next" Width="43%" UseSubmitBehavior="False" BackColor="Black" ForeColor="White" Height="30px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Cancel" Width="43%" BackColor="Black" ForeColor="White" Height="30px" />
            <br />
            <br />


        </div>



    </div>
</asp:Content>

