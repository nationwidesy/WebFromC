<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPerson.aspx.cs" Inherits="WebApplicationCWebForm.ShowPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="sophyDB1Person">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" SortExpression="DateOfBirth" />
                </Columns>
            </asp:GridView>
            <asp:TextBox ID="ShoeResult" runat="server" Height="361px" TextMode="MultiLine" Width="436px"></asp:TextBox>
            <asp:TextBox ID="ShowSecondResult" runat="server" Height="361px" TextMode="MultiLine" Width="436px"></asp:TextBox>
            <asp:SqlDataSource ID="sophyDB1Person" runat="server" ConnectionString="<%$ ConnectionStrings:sophyDB1ConnectionString %>" SelectCommand="SELECT * FROM [Person]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
