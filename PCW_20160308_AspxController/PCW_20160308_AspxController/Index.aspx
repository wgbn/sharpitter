<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PCW_20160308_AspxController.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AreaPrincipal" runat="server">
    <h1>Index</h1>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="AreaLateral" runat="server">
    <asp:LinkButton CssClass="botaoLateral" ID="lnkPagina1" OnClick="PaginaUmClick" runat="server">Página Um</asp:LinkButton>
    <asp:LinkButton CssClass="botaoLateral" ID="lnkPagina2" OnClick="PaginaDoisClick" runat="server">Página Dois</asp:LinkButton>
    <asp:LinkButton CssClass="botaoLateral" ID="lnkLogin" OnClick="PaginaLoginClick" runat="server">ENTRAR</asp:LinkButton>
</asp:Content>
