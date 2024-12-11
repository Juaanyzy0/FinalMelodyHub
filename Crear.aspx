<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="MelodyHub.instrumentos.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
</asp:Content>
    <asp:Content ID="gvInstrumento" ContentPlaceHolderID="main" runat="server">
        <h2>Gestión de Instrumentos</h2>
    <asp:GridView ID="gvInstrumentos" runat="server" AutoGenerateColumns="False" DataKeyNames="id_instrumento" OnRowEditing="gvInstrumentos_RowEditing" OnRowDeleting="gvInstrumentos_RowDeleting" OnRowUpdating="gvInstrumentos_RowUpdating" OnRowCancelingEdit="gvInstrumentos_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="id_instrumento" HeaderText="ID" ReadOnly="True" />
            <asp:BoundField DataField="tipo_instrumento" HeaderText="Tipo" />
            <asp:BoundField DataField="marca" HeaderText="Marca" />
            <asp:BoundField DataField="modelo" HeaderText="Modelo" />
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>

    <!-- Formulario para agregar nuevos instrumentos -->
    <h3>Agregar Nuevo Instrumento</h3>
    <table>
        <tr>
            <td>Tipo:</td>
            <td><asp:TextBox ID="txtTipoInstrumento" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Marca:</td>
            <td><asp:TextBox ID="txtMarca" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Modelo:</td>
            <td><asp:TextBox ID="txtModelo" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Nuevo Instrumento" OnClick="btnAgregar_Click" />
</asp:Content>
