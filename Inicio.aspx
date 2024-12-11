<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="MelodyHub.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="resources/css/styles.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>El usuario <%=Session["nombre"] %> ingresó</h1>
            <asp:Button ID ="btnSalir" runat="server" Text="Salir" OnClick="BtnSalir_Click1" />
        </div>
    </form>

</body>
</html>
