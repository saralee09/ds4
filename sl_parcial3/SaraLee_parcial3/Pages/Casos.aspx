<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Casos.aspx.cs" Inherits="sl_parcial3.Pages.Casos" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gestión de Casos</title>
</head>
<body>
<form id="form1" runat="server">
    <asp:GridView ID="gvCasos" runat="server" AutoGenerateColumns="False" DataKeyNames="CasoId">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Código" />
            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
            <asp:BoundField DataField="FechaInicio" HeaderText="Inicio" />
        </Columns>
    </asp:GridView>

    <asp:TextBox ID="txtTitulo" runat="server" Placeholder="Título"></asp:TextBox>
    <asp:Button ID="btnAgregarCaso" runat="server" Text="Agregar Caso" OnClick="btnAgregarCaso_Click" />
</form>
</body>
</html>