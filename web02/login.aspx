<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="web02.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserConnectionString2 %>" SelectCommand="SELECT * FROM [UserData]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>

            <asp:Label ID="Label1" runat="server" Text="account"></asp:Label>
            <asp:TextBox ID="account" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="passwd"></asp:Label>
            <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
