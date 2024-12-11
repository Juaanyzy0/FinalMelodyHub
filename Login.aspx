<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MelodyHub.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="resources/css/login.css"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="lblUsuario" runat="server" Text="Nombre de Usuario"></asp:Label></td>
                
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:RequiredFieldValidator
                    runat="server"
                    ID="rfvUsuario"
                    ControlToValidate="txtUsuario"
                    ErrorMessage="El campo es obligatorio"
                    ForeColor="Red"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                 <td><asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label></td>
                 <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:RequiredFieldValidator
                    runat="server"
                    ID="rfvPassword"
                    ControlToValidate="txtPassword"
                    ErrorMessage="El campo es obligatorio"
                    ForeColor="Red"
                    Display="Dynamic">
                </asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click"></asp:Button></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Label ID="lblEstado" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
