<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="PCW_20160308_AspxController.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AreaPrincipal" runat="server">
    <h1>Pagina 2<asp:FormView ID="FormView1" runat="server" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="#333333">
        <EditItemTemplate>
            Id:
            <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
            <br />
            Nome:
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            Celular:
            <asp:TextBox ID="CelularTextBox" runat="server" Text='<%# Bind("Celular") %>' />
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <InsertItemTemplate>
            Id:<br />
            <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
            <br />
            Nome:<br />
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NomeTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Celular:<br />
            <asp:TextBox ID="CelularTextBox" runat="server" Text='<%# Bind("Celular") %>' />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CelularTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Email:<br />
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" CommandName="Insert" Text="Salvar Contato" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancelar" />
        </InsertItemTemplate>
        <ItemTemplate>
            Id:
            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
            <br />
            Nome:
            <asp:Label ID="NomeLabel" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            Celular:
            <asp:Label ID="CelularLabel" runat="server" Text='<%# Bind("Celular") %>' />
            <br />
            Email:
            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Celular" HeaderText="Celular" SortExpression="Celular" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testedbConnectionString %>" DeleteCommand="DELETE FROM [Contatos] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Contatos] ([Id], [Nome], [Celular], [Email]) VALUES (@Id, @Nome, @Celular, @Email)" ProviderName="<%$ ConnectionStrings:testedbConnectionString.ProviderName %>" SelectCommand="SELECT [Id], [Nome], [Celular], [Email] FROM [Contatos]" UpdateCommand="UPDATE [Contatos] SET [Nome] = @Nome, [Celular] = @Celular, [Email] = @Email WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id" Type="Int32" />
            <asp:Parameter Name="Nome" Type="String" />
            <asp:Parameter Name="Celular" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Nome" Type="String" />
            <asp:Parameter Name="Celular" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="AreaLateral" runat="server">
    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lacus ipsum, rhoncus malesuada varius in, vestibulum in eros. Pellentesque pellentesque pellentesque tempus. Ut iaculis feugiat urna, non consectetur ipsum laoreet sit amet. Sed enim erat, consequat in justo a, sodales fringilla erat. Aliquam pretium suscipit lacus, quis luctus nibh dignissim quis. Mauris feugiat iaculis mi vitae dignissim. Ut accumsan diam eget lectus commodo commodo. Sed quis erat vitae magna tincidunt elementum. Nam accumsan, sem interdum ornare tempor, nulla ante bibendum tellus, sit amet porta mauris dolor et purus. Praesent ornare nibh at tortor dignissim, et mollis ligula commodo. Nunc vel lectus et eros tempus sodales in eu mi. Etiam laoreet odio ut urna lobortis aliquam. Fusce auctor sodales maximus. Aenean bibendum tellus eu libero commodo, ut tempus nunc iaculis. Nulla luctus malesuada gravida. Aliquam facilisis ornare lorem ac imperdiet. 
</asp:Content>
