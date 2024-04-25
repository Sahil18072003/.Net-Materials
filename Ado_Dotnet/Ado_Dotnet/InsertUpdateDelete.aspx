<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUpdateDelete.aspx.cs" Inherits="Ado_Dotnet.InsertUpdateDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 443px; width: 1349px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 85px; position: absolute; left: 251px"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 134px; top: 204px; position: absolute" Text="Salary"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 252px; top: 143px; position: absolute" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label" runat="server" style="height: 24px; width: 75px; z-index: 1; left: 137px; top: 84px; position: absolute" Text="Eid"></asp:Label>
            &nbsp;</p>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 252px; top: 262px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 252px; top: 202px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 253px; top: 315px; position: absolute" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 135px; top: 264px; position: absolute" Text="Mid"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 136px; top: 142px; position: absolute" Text="Ename"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 136px; top: 321px; position: absolute" Text="DId"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 243px; top: 381px; position: absolute; right: 1071px;" Text="Insert" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 834px; top: 559px; position: absolute" Text="Show data" />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 340px; top: 496px; position: absolute; height: 152px; width: 232px">
        </asp:GridView>
    </form>
</body>
</html>
