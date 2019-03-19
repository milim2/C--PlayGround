<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCatalog.aspx.cs" Inherits="Week10NavigationTech.ViewCatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ViewCart.aspx">ViewCart(HyperLink)</asp:HyperLink>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">ViewCartResponseRedirect</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddl" runat="server" Height="20px" Width="105px">
                <asp:ListItem>Pants</asp:ListItem>
                <asp:ListItem>Shirt</asp:ListItem>
                <asp:ListItem>Socks</asp:ListItem>
                <asp:ListItem>Hat</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />

        </div>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">ViewCart(ServerTransfer)</asp:LinkButton>
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">ViewCart(ServerExecute)</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">VoewCart(ServerTransfer--&gt;SessionVariables)</asp:LinkButton>
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">ViewCart(ServerTransfer--&gt;ApplicationVariables)</asp:LinkButton>
        <br />
        <br />
    </form>
</body>
</html>
