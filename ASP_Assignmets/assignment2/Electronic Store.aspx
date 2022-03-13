<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Electronic Store.aspx.cs" Inherits="ASP_Assignment2.Electronic_Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Select items from store"></asp:Label>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="59px" ValidationGroup="vg" AutoPostBack="true"  Width="91px">
              
            </asp:DropDownList>
            <br />
            <asp:Image ID="Image1" runat="server" Height="300px" Width="302px" style="margin-right:448px" />
        </div>
        <p>
    Cost of selected Item: <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="vg" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
</p>
<asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="submit" Width="121px" />
    </form>
</body>
</html>
