<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HotelTrafalga.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Hotel Room Reservation"></asp:Label>
            <br />
        </p>
        <div>
            <br />
            <br />
            <asp:CheckBox ID="cbPick" runat="server" AutoPostBack="True" Text="Airplane Pick up $20" />
            <br />
            <br />
            <asp:CheckBox ID="cbBuff" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Buffet $15" />
            <br />
            <br />
            <asp:CheckBox ID="cbWifi" runat="server" AutoPostBack="True" Text="Wifi &amp;10" />
            <br />
        </div>
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:RadioButton ID="rbKing" runat="server" AutoPostBack="True" GroupName="Bed Type" Text="King $150" />
            <br />
            <br />
            <asp:RadioButton ID="rbQueen" runat="server" AutoPostBack="True" GroupName="Bed Type" Text="Queen $120" />
            <br />
            <br />
            <br />
            <asp:RadioButton ID="rbStandard" runat="server" AutoPostBack="True" GroupName="Room Type" Text="Standard $125" />
            <br />
            <br />
            <asp:RadioButton ID="rbDelux" runat="server" AutoPostBack="True" GroupName="Room Type" Text="Delux $250" />
            <br />
            <br />
            <asp:RadioButton ID="rbHoneyMoon" runat="server" AutoPostBack="True" GroupName="Room Type" Text="HoneyMoon $500" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="102px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="166px">
                <asp:ListItem>Tourism</asp:ListItem>
                <asp:ListItem Selected="True">Business</asp:ListItem>
                <asp:ListItem>Education</asp:ListItem>
                <asp:ListItem>Research</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Bill"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show Bill" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Checkout.aspx">PaymentInfoButoon</asp:LinkButton>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" ImageHeight="100px" ImageUrl="~/images/1529504445934.jpg" ImageWidth="150px" NavigateUrl="~/Checkout.aspx">HyperLink</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
