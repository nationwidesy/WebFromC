<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataTest.aspx.cs" Inherits="WebApplicationCWebForm.DataTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 74px;
            position: absolute;
            left: 14px;
            top: 136px;
        }
        .auto-style2 {
            width: 349px;
        }
        .auto-style3 {
            width: 299px;
        }
        .auto-style4 {
            width: 382px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EnrollmentID">
                        <Columns>
                            <asp:BoundField DataField="EnrollmentID" HeaderText="EnrollmentID" InsertVisible="False" ReadOnly="True" SortExpression="EnrollmentID" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="CourseID" HeaderText="CourseID" SortExpression="CourseID" />
                            <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                        </Columns>
                    </asp:GridView>
                    <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                    </asp:EntityDataSource>
                </td>
                <td class="auto-style3">
                    <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged1">
                    </asp:GridView>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="ShowResult" runat="server" Height="467px" TextMode="MultiLine" Width="397px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">Data 1</td>
                <td class="auto-style3">Data2</td>
                <td class="auto-style4">Date3</td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sophyTest1_1ConnectionString2 %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [Enrollment]"></asp:SqlDataSource>
    </form>
</body>
</html>
