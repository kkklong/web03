<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSet.aspx.cs" Inherits="web02.DataSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserConnectionString2 %>" SelectCommand="SELECT * FROM [UserData]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br/>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Passwd" HeaderText="Passwd" SortExpression="Passwd" />
                    <asp:BoundField DataField="initDate" HeaderText="initDate" SortExpression="initDate" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
