<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAddress.aspx.cs" Inherits="WebApplicationCWebForm.ShowAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sophyDB1Address">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="citi" HeaderText="citi" SortExpression="citi" />
                    <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                    <asp:BoundField DataField="zip" HeaderText="zip" SortExpression="zip" />
                    <asp:BoundField DataField="homePhone" HeaderText="homePhone" SortExpression="homePhone" />
                    <asp:BoundField DataField="cellPhone" HeaderText="cellPhone" SortExpression="cellPhone" />
                    <asp:BoundField DataField="lastUpdate" HeaderText="lastUpdate" SortExpression="lastUpdate" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sophyDB1Address" runat="server" ConnectionString="<%$ ConnectionStrings:sophyDB1ConnectionStringAddress %>" SelectCommand="SELECT * FROM [address]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
