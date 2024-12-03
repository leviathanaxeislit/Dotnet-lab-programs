<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1 { font-size: xx-large; font-weight: bold; color: #FF66CC; text-align: center; }
        .style2 { width: 500px; text-align: center; }
        .style5 { font-size: x-large; text-align: center; }
        .style6 { font-size: x-large; text-align: right; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="style1"><br />Web Application with Validation<br /></div>
        <div style="text-align:center">
            <table class="style2">
                <tr>
                    <td class="style6">
                        <asp:Label ID="lblUserID" runat="server" Text="Enter User ID"></asp:Label>
                    </td>
                    <td class="style5">
                        <asp:TextBox ID="txtUID" runat="server"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUID" ErrorMessage="Value Required" style="font-size: x-small"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtUID" ErrorMessage="Enter the valid UserName" style="font-size: x-small" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="CustomValidator1_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style6"><asp:Label ID="lblPassword" runat="server" Text="Enter Password"></asp:Label></td>
                    <td class="style5"><asp:TextBox ID="txtPWD" runat="server" TextMode="Password"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPWD" ErrorMessage="Value Required" style="font-size: x-small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style6"><asp:Label ID="lblRpassword" runat="server" Text="Re-Type Password"></asp:Label></td>
                    <td class="style5"><asp:TextBox ID="txtRpwd" runat="server" TextMode="Password"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRpwd" ErrorMessage="Value Required" style="font-size: x-small"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPWD" ControlToValidate="txtRpwd" ErrorMessage="Check Password" style="font-size: x-small"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style6"><asp:Label ID="lblUname" runat="server" Text="User Name"></asp:Label></td>
                    <td class="style5"><asp:TextBox ID="txtUname" runat="server"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUname" ErrorMessage="Value Required" style="font-size: x-small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style6"><asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label></td>
                    <td class="style5"><asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAge" ErrorMessage="Value Required" style="font-size: x-small"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="RangeValidator" MaximumValue="30" MinimumValue="21" style="font-size: x-small"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style6"><asp:Label ID="lblemailID" runat="server" Text="emailID"></asp:Label></td>
                    <td class="style5">
                        <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPWD" ErrorMessage="Value Required" style="font-size: x-small"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Correct e-mail format" style="font-size: x-small" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center"><asp:Button ID="btnSubmit" runat="server" Text="Submit" /></td>
                    <td style="text-align: center"><asp:Button ID="btnClose" runat="server" Text="Close" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
