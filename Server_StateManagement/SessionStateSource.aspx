<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessionStateSource.aspx.cs" Inherits="SessionStateSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Name" runat="server" />
            <asp:TextBox runat="server" ID="txtName" />
            <br />
            <asp:Label Text="Course" runat="server" />
            <asp:TextBox runat="server" ID="txtCourse"/>
            <br />
            <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
