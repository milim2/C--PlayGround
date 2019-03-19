<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginTrafalga.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 635px;
            background-color: #FFFFCC;
        }
        .auto-style2 {
            width: 236px;
        }
        .auto-style3 {
            width: 218px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">User Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbusername" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbusername" ErrorMessage="User Name can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbpw" runat="server" MaxLength="15"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbpw" ErrorMessage="Password can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Retype Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tnRepw" runat="server" MaxLength="15"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tnRepw" ErrorMessage="Password don't match" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbemail" runat="server" MaxLength="50"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbemail" ErrorMessage="Not a proper email" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Full Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbfullname" runat="server" MaxLength="50"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tnRepw" ForeColor="Red" ValidateRequestMode="Enabled">Fullname can&#39;t be empty</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Country</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlCountry" runat="server">
                            <asp:ListItem Selected="True">Select One</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>Must select country</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <input id="Submit1" type="submit" value="submit" /></td>
                    <td>
                        <input id="Reset1" type="reset" value="Start over" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
