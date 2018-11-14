<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPersonByName.aspx.cs" Inherits="WebApplicationCWebForm.ShowPersonByName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="sophyDB1PersonByName">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" SortExpression="DateOfBirth" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sophyDB1PersonByName" runat="server" ConnectionString="<%$ ConnectionStrings:sophyDB1ConnectionStringAddress %>" SelectCommand="personByName" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:Parameter Name="Name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
