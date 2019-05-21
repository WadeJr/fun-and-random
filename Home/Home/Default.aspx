<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Home.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
            <h1>HOME</h1>
        </div>
   
    <br />
    <br />
    <div class ="Links" > 
         <p>
            <asp:LinkButton ID="movies" runat="server" OnClick="movies_Click">~ Movies</asp:LinkButton>
        </p>
    </div>




</asp:Content>
