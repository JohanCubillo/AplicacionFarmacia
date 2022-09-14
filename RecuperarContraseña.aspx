<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits="Sistema_de_Requisiciones.RecuperarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link  rel="stylesheet" href="styles.css"  type="text/css"/>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body >
    <asp:Panel ID="PanelFondo" runat="server"  CssClass="wrapper"  >
            <asp:Panel ID="Panel1" runat="server" CssClass="wrapper-content" >
                <h1>SISTEMA WEB DE SOLICITUDES</h1>
                <form id="form1" runat="server">
                    <h2><i class="uil uil-padlock"></i>¿OlVIDASTE CONTRASEÑA?</h2>
                    <asp:TextBox ID="TextBox2" runat="server"  CssClass="input" placeholder="Usuario" ></asp:TextBox  >
                    
                   
                                 <asp:Button ID="Button1" runat="server" Text="Cambiar" CssClass="button" />
                    
                </form>
            </asp:Panel>
        </asp:Panel>
</body>
</html>
