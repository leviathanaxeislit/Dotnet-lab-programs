<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BankInterestService.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: lightcyan; width: 300px; padding: 10px;">
            <h2>SIMPLE INTEREST</h2>
            <label>Principal Amount</label><br />
            <asp:TextBox ID="txtPrincipal" runat="server" /><br /><br />
            
            <label>Rate of Interest</label><br />
            <asp:TextBox ID="txtRate" runat="server" /><br /><br />
            
            <label>Number of Years</label><br />
            <asp:TextBox ID="txtTime" runat="server" /><br /><br />
            
            <asp:Button ID="btnCalculate" runat="server" Text="SHOW" OnClick="btnCalculate_Click" /><br /><br />
            
            <label>Simple Interest</label><br />
            <asp:TextBox ID="txtInterest" runat="server" ReadOnly="true" /><br />
        </div>
    </form>
</body>
</html>
