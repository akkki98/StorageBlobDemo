<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="index.aspx.cs" Inherits="StorageDemo.index" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2"><h2>Microsoft Azure Storage Demo</h2></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Profile Photo:</td>
                    <td><asp:FileUpload ID="photoUpload" runat="server" /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click" /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Label ID="lblInsert" Text="" runat="server" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

