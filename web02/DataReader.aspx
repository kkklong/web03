<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReader.aspx.cs" Inherits="web02.DataReader" %>

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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
