<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="PCW_20160308_AspxController.Pagina1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AreaPrincipal" runat="server">
    <h1>Pagina 1</h1>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataLista" DataTextField="Nome" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataLista" runat="server" ConnectionString="<%$ ConnectionStrings:testedbConnectionString %>" SelectCommand="SELECT [Id], [Nome] FROM [Contatos]"></asp:SqlDataSource>
    </p>

    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="AreaLateral" runat="server">
    Sed quis pulvinar magna. Vivamus luctus nec ex eu efficitur. Maecenas semper purus at sapien vehicula sollicitudin ut id odio. Pellentesque quis tortor elit. Mauris consectetur nisl a tellus lobortis, quis pellentesque nulla vehicula. Donec scelerisque tempus tincidunt. Donec pharetra molestie massa, eget pellentesque lectus egestas scelerisque. Etiam neque urna, vulputate accumsan diam et, suscipit commodo odio.
</asp:Content>
