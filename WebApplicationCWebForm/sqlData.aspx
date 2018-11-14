<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sqlData.aspx.cs" Inherits="WebApplicationCWebForm.sqlData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 363px;
            height: 387px;
            position: absolute;
            left: 28px;
            top: 54px;
        }
        .auto-style2 {
            width: 339px;
            height: 438px;
            position: absolute;
            left: 609px;
            top: 63px;
        }
        .auto-style3 {
            width: 340px;
            height: 216px;
            position: absolute;
            left: 971px;
            top: 82px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSourceCourse" runat="server" ConnectionString="<%$ ConnectionStrings:sophyTest1_1ConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [Course]"></asp:SqlDataSource>
        <asp:GridView ID="GridView4" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="auto-style3" DataKeyNames="StudentID" DataSourceID="SqlDataSourceStudent">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" InsertVisible="False" ReadOnly="True" SortExpression="StudentID" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="EnrollmentDate" HeaderText="EnrollmentDate" SortExpression="EnrollmentDate" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="auto-style1" DataKeyNames="EnrollmentID" DataSourceID="SqlDataSourceEnrollment" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="EnrollmentID" HeaderText="EnrollmentID" InsertVisible="False" ReadOnly="True" SortExpression="EnrollmentID" />
                <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                <asp:BoundField DataField="CourseID" HeaderText="CourseID" SortExpression="CourseID" />
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceEnrollment" runat="server" ConnectionString="<%$ ConnectionStrings:sophyTest1_1ConnectionString2 %>" SelectCommand="SELECT * FROM [Enrollment]" OnSelecting="SqlDataSourceEnrollment_Selecting"></asp:SqlDataSource>
        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="auto-style2" DataKeyNames="CourseID" DataSourceID="SqlDataSourceCourse" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CourseID" HeaderText="CourseID" InsertVisible="False" ReadOnly="True" SortExpression="CourseID" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceStudent" runat="server" ConnectionString="<%$ ConnectionStrings:sophyTest1_1ConnectionString2 %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    </form>
</body>
</html>
