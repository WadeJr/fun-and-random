<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Movies.aspx.cs" Inherits="Home.Groceries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movies</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <webopt:BundleReference runat="server" Path="~/Css" />
    <link runat="server" type="text/css" rel="stylesheet" href="~/Css/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <h1>Movies</h1>
                <br />
                <div class="Links">
                    <p>
                        <asp:LinkButton ID="home" runat="server" OnClick="home_Click">Home</asp:LinkButton>
                    </p>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
