<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebApplicationCWebFormDemo.aspx.cs" Inherits="WebApplicationCWebForm.WebApplicationCWebFormDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Entity Framework Ex1" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Response.OutPut.Write" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Send email to nationwidesy" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Call WCF WS" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Call Wcf Welcome" />
                </td>
                <td>
                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Get Your Age" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Show All TestRecord" />
                 </td>
                <td>
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Insert Record to TestRecord" />
                 </td>
                <td>
                    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Delete TestRecord" />
                 </td>
            </tr>
             <tr>
                <td>
                     
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Array Demo" />
                     
                 </td>
                <td>
                     
                    <asp:Button ID="Button13" runat="server" Text="Button" />
                     
                 </td>
                <td>
                      
                    <asp:Button ID="Button14" runat="server" Text="Button" />
                      
                 </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="hideGridView_bnt" runat="server" BackColor="#99CCFF" OnClick="hideGridView_bnt_Click" Text="Hide Grid View" Visible="False" />
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Visible="False">
                    </asp:GridView>
                 </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text=" label1" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Visible="False"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="label2" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged" Visible="False"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" EnableTheming="True" Text="label3" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged" Visible="False"></asp:TextBox>
                 </td>
                <td>
                    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Hide Calendar" Visible="False" />
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                    <asp:DropDownList ID="SelectYears" runat="server" OnSelectedIndexChanged="SelectYears_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                    <asp:Label ID="Label4" runat="server" Text=" "></asp:Label>
                    <asp:DropDownList ID="SelectMonth" runat="server" OnSelectedIndexChanged="SelectMonth_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                    <asp:DropDownList ID="SelectDay" runat="server" OnSelectedIndexChanged="SelectDay_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                    <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Run" Visible="False" />
                 </td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="ShowResult" runat="server" Height="330px" TextMode="MultiLine" Width="185px" OnTextChanged="ShowResult_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="Refresh" />
                </td>
                <td>
                    <asp:TextBox ID="ShowResult0" runat="server" Height="330px" TextMode="MultiLine" Width="175px" OnTextChanged="ShowResult0_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="Refresh" />
                </td>
                <td>
                    <asp:TextBox ID="ShowResult1" runat="server" Height="330px" TextMode="MultiLine" Width="334px" OnTextChanged="ShowResult1_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="Refresh" />
                </td>
            </tr>
            <tr>
                 <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
               

            </tr>
        </table>
    </form>
</body>
</html>
