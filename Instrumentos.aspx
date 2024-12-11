<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Instrumentos.aspx.cs" Inherits="MelodyHub.instrumentos.Instrumentos" %>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="title" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="gvInstrumento" ContentPlaceHolderID="main" runat="server">
    <h2>Gestión de Instrumentos</h2>
    <table>
        <asp:GridView ID="GvInstrumentos" runat="server" AutoGenerateColumns="False" DataKeyNames="id_instrumento" OnRowEditing="GvInstrumentos_RowEditing" OnRowDeleting="GvInstrumentos_RowDeleting" OnRowUpdating="GvInstrumentos_RowUpdating" OnRowCancelingEdit="GvInstrumentos_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="id_instrumento" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="tipo_instrumento" HeaderText="Tipo" />
                <asp:BoundField DataField="marca" HeaderText="Marca" />
                <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </table>
    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar Nuevo Instrumento" OnClick="BtnAgregar_Click" />
</asp:Content>