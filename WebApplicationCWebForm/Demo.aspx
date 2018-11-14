<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplicationCWebForm.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 { 
            top: 145px;
            left: 520px;
            position: absolute;
            margin-left: 40px;
            height: 134px;
            width: 516px;
        }
        .auto-style2 {
            z-index: 1;
            left: 308px;
            top: 16px;
            position: absolute;
        }
        .auto-style3 {
            width: 428px;
            height: 20px;
            position: absolute;
            left: 25px;
            top: 52px;
        }
        .auto-style5 {
            height: 52px;
            position: absolute;
            left: 459px;
            top: 141px;
        }
        .auto-style6 {
            top: 149px;
            left: 30px;
            position: absolute;
            height: 419px;
            width: 423px;
        }
        .auto-style7 {
            top: 100px;
            left: 25px;
            position: absolute;
            height: 20px;
            width: 215px;
            right: 1267px;
        }
        .auto-style8 {
            top: 100px;
            left: 247px;
            position: absolute;
            width: 219px;
            height: 20px;
        }
        .auto-style9 {
            top: 80px;
            left: 30px;
            position: absolute;
            height: 20px;
            width: 209px;
            right: 1011px;
        }
        .auto-style10 {
            width: 241px;
            height: 20px;
            position: absolute;
            top: 80px;
            left: 254px;
            margin-left: 0px;
        }
        .auto-style11 {
            width: 247px;
            height: 20px;
            position: absolute;
            left: 482px;
            top: 80px;
        }
        .auto-style14 {
            width: 255px;
            position: absolute;
            left: 473px;
            top: 100px;
            height: 20px;
            right: 779px;
        }
        .auto-style15 {
            width: 149px;
            height: 33px;
            position: absolute;
            top: 91px;
            left: 744px;
        }
        .auto-style16 {
            width: 294px;
            height: 403px;
            position: absolute;
            left: 1085px;
            top: 144px;
        }
        .auto-style17 {
            width: 506px;
            height: 136px;
            position: absolute;
            left: 555px;
            top: 492px;
            margin-top: 11px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pool Demo" Width="100%" TabIndex="6" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Queue Pool" OnClick="Button2_Click" Width="100%" TabIndex="7" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Stack Pool" OnClick="Button3_Click" Width="100%" TabIndex="8" />
                </td>
               <td>
                    <asp:Button ID="Button24" runat="server" Text="File Handling" OnClick="Button24_Click" Width="100%" TabIndex="21" />
                </td>
            <tr>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Singleton" OnClick="Button4_Click" Width="100%" TabIndex="9" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="Generic/Swap" OnClick="Button5_Click" Width="100%" TabIndex="10" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="Generic/Delegate" OnClick="Button6_Click" Width="100%" TabIndex="11" />
                </td>
               <td>
                    <asp:Button ID="Button25" runat="server" Text="Read File" OnClick="Button25_Click" Width="100%" TabIndex="22"   />
                </td>
           </tr>
            <tr>
                <td>
                    <asp:Button ID="Button7" runat="server" Text="Virtual Method" OnClick="Button7_Click" Width="100%" TabIndex="12" />
                </td>
                <td  >
                    <asp:Button ID="Button8" runat="server" Text="ArrayList" Width="100%" OnClick="Button8_Click" TabIndex="13" />
                </td>
                <td  >
                    <asp:Button ID="Button9" runat="server" Text="IEnumerator" Width="100%" OnClick="Button9_Click" TabIndex="14" />
                </td>
                <td>
                    <asp:Button ID="Button26" runat="server" Text="Reflection"   Width="100%" TabIndex="23" OnClick="Button26_Click"   />
                </td>
           </tr>
             <tr>
                <td>
                    <asp:Button ID="Button12" runat="server" Text="Value type vs reference Type"   Width="100%" TabIndex="15" OnClick="Button12_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button13" runat="server" Text="Serialization" Width="100%"   TabIndex="16" OnClick="Button13_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button14" runat="server" Text="DeSerialization" Width="100%"   TabIndex="17" OnClick="Button14_Click" />
                </td>
                <td>
                    <asp:Button ID="Button27" runat="server" Text="DataBase connection"   Width="100%" TabIndex="24" OnClick="Button27_Click"   />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button15" runat="server" Text="File I/O"   Width="100%" TabIndex="15" OnClick="Button15_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button16" runat="server" Text="Using block" Width="100%"   TabIndex="16" OnClick="Button16_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button17" runat="server" Text="Jagged Array" Width="100%"   TabIndex="17" OnClick="Button17_Click" />
                </td>
                <td>
                    <asp:Button ID="Button28" runat="server" Text=" "   Width="100%" TabIndex="25"   />
                </td>
            </tr>             
             <tr>
                <td>
                    <asp:Button ID="Button18" runat="server" Text="MultiThreading"   Width="100%" TabIndex="15" OnClick="Button18_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button19" runat="server" Text="Run Thread" Width="100%"   TabIndex="16" OnClick="Button19_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button20" runat="server" Text="Deadlocks" Width="100%"   TabIndex="17" OnClick="Button20_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button29" runat="server" Text="Serialization" Width="100%" OnClick="Button29_Click"     />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button21" runat="server" Text="Hashtable"   Width="100%" TabIndex="18" OnClick="Button21_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button22" runat="server" Text="Anonymous Type" Width="100%"   TabIndex="19" OnClick="Button22_Click" />
                </td>
                <td  >
                    <asp:Button ID="Button23" runat="server" Text="LINQ" Width="100%"   TabIndex="20" OnClick="Button23_Click" />
                </td>
                 <td  >
                    <asp:Button ID="Button30" runat="server" Text="More...." Width="100%"   TabIndex="20" OnClick="Button30_Click"   />
                </td>
           </tr>
         </table>
        <asp:Label ID="Label1" runat="server" style="text-align: center; " Text="Welcome to Sophy's Web Application" CssClass="auto-style2"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" EnableTheming="False" OnTextChanged="TextBox2_TextChanged" Visible="False" CssClass="auto-style7" TabIndex="1">0</asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox2" CssClass="auto-style3" Display="Dynamic" ErrorMessage=" " Font-Names="Andale Sans for VST" ForeColor="#CC0000" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style10" Text="Label" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" CssClass="auto-style6"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False" CssClass="auto-style9"></asp:Label>       
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" CssClass="auto-style8" Visible="False" TabIndex="2">0</asp:TextBox>          
        <asp:Button ID="Button10" runat="server" CssClass="auto-style5" OnClick="Button10_Click" Text="Reset" TabIndex="5" BackColor="#FFFF99" />
        <asp:Label ID="Label4" runat="server" CssClass="auto-style11" Text="Label" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style14" OnTextChanged="TextBox4_TextChanged" Visible="False" TabIndex="3">0</asp:TextBox>
        <asp:Button ID="Button11" runat="server" CssClass="auto-style15" OnClick="Button11_Click" TabIndex="4" Text="Run" Visible="False" />
         <p>
             &nbsp;</p>
         <asp:Label ID="Label5" runat="server" CssClass="auto-style16" Text=" "></asp:Label>
         <asp:GridView ID="GridView1" runat="server" CssClass="auto-style17" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
         </asp:GridView>
    </form>
</body>
</html>
