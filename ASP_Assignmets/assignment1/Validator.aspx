<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ASP_Assignment1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 64%;
            height: 210px;
        }
        .auto-style2 {
            width: 179px;
        }
        .auto-style3 {
            width: 275px;
        }
        .auto-style4 {
            width: 330px;
        }
        .auto-style5 {
            margin-top: 20px;
        }
        .auto-style6 {
            width: 275px;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Family Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="family_name" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="name" ControlToValidate="family_name" ErrorMessage="differs from name" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Address</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="address" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="address" ErrorMessage="address at least 2 letters" ForeColor="Red" MaximumValue="50" MinimumValue="2"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="city" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="city" ErrorMessage="al least 2 charecter" ForeColor="Red" MaximumValue="20" MinimumValue="2"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Zip Code</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="zip_code" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="zip_code" ErrorMessage="should be 6 digit" ForeColor="Red" MaximumValue="6" MinimumValue="6"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone No</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="phone_no" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="phone_no" ErrorMessage="enter valid format" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="phone_no" ErrorMessage="enter phone no of 10 digit" ForeColor="Red" MaximumValue="10" MinimumValue="10"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="enter valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="27px" OnClick="Button1_Click" Text="Check" Width="74px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
