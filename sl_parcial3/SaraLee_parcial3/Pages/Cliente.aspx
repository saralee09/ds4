<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="sl_parcial3.Pages.Cliente" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Clientes</title>
    <style>
        .form-group {
            margin-bottom: 10px;
        }
        label {
            display: block;
            font-weight: bold;
        }
        input[type="text"] {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Listado de Clientes</h2>

        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" DataKeyNames="ClienteId"
                      CssClass="table" Width="600px">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
            </Columns>
        </asp:GridView>

        <hr />

        <h3>Agregar nuevo cliente</h3>

        <div class="form-group">
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" />
        </div>

        <div class="form-group">
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" />
        </div>

        <div class="form-group">
            <label for="txtTelefono">Teléfono:</label>
            <asp:TextBox ID="txtTelefono" runat="server" />
        </div>

        <asp:Button ID="btnAgregar" runat="server" Text="Agregar Cliente" OnClick="btnAgregar_Click" />
    </form>
</body>
</html>