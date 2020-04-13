<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clock.aspx.cs" Inherits="ZegarKomponentPrototyp.Clock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server">
            <asp:Image ID="Image1" runat="server" />
            <asp:Image ID="Image2" runat="server" />
            <asp:Image ID="Image3" runat="server" />
            <asp:Image ID="Image4" runat="server" />
            <asp:Image ID="Image5" runat="server" />
            <asp:Image ID="Image6" runat="server" />
            <asp:Image ID="Image7" runat="server" />
            <asp:Image ID="Image8" runat="server" />
            <asp:Timer ID="Timer1" runat="server" Interval="900" OnTick="Page_Load">
            </asp:Timer>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
    </form>
</body>
</html>
