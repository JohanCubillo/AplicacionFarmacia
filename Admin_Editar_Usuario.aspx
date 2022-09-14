<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Editar_Usuario.aspx.cs" Inherits="Sistema_de_Requisiciones.Admin_Editar_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link  rel="stylesheet" href="styles.css"  type="text/css"/>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css"/>
    <title>Administracion Editar Usuario</title>
    <style type="text/css">
        .auto-style1 {
            width: 471px;
            text-align:left;
        }
        .Estilo{
            font-size: 15px;
            color:red;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <main>
            <header>
                <h1>Sistema Web de Solicitudes</h1>
                <button class="btn-header"><i class="uil uil-user-circle"></i></button>
               
            </header>
            <nav>
                <div class="info-user">
                    <button class="btn-info"><i class="uil uil-user-circle"></i></button>
                    <div class="info">
                        <h3>Nombre del Usuario</h3>
                        <h4>Administrador</h4>
                    </div>

                </div>
                <ul>
                    <li><a href="Administrador.aspx">Usuarios</a></li>
                    <li><a href="Administrador_Rangos.aspx">Rangos</a></li>
                    <li><a href="Login.aspx">Cerrar Sesion</a></li>
                </ul>
            </nav>
            <div class="container">
                <h2>ACTUALIZAR USUARIO</h2>
                <h2 class="Estilo"> TODOS LOS CAMPOS SON OBLIGATORIOS</h2>

                <div class="container-table">
                    
                    <table>
                        
                            <tr>
                                <td class="auto-style1">Identificación</td>
                                <td class="auto-style1"></td>
                            </tr>
                            <tr>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtId" runat="server" Width="180px"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtId" ErrorMessage="Ingrese un ID Valido" ValidationExpression="\d{1}-\d{4}-\d{4}">*</asp:RegularExpressionValidator>
                                </td>
                                <td class="auto-style1"></td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Nombres</td>
                                <td class="auto-style1">Apellidos</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtNombres" runat="server" Width="180px"></asp:TextBox>
                                </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtApellidos" runat="server" Width="180px"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1">Telefono</td>
                                <td class="auto-style1">Email</td>
                            </tr>
                             <tr>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtTelefono" runat="server" Width="180px"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Ingrese un Telefono Valido" ValidationExpression="\d{4}-\d{4}">*</asp:RegularExpressionValidator>
                                </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un correo Valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1">Tipo de Usuario</td>
                                <td class="auto-style1">Estado</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">
                                    <asp:ListBox ID="ListBox1" runat="server" Width="180px">
                                        <asp:ListItem>Comprador</asp:ListItem>
                                        <asp:ListItem>Aprobador Jefe</asp:ListItem>
                                        <asp:ListItem>Aprobador Financiero 1</asp:ListItem>
                                        <asp:ListItem>Aprobador Financiero 2</asp:ListItem>
                                        <asp:ListItem>Aprobador Financiero 3</asp:ListItem>
                                    </asp:ListBox>
                                </td>
                                <td class="auto-style1">
                                    <asp:ListBox ID="ListBox2" runat="server" Width="180px">
                                        <asp:ListItem>Inactivo</asp:ListItem>
                                        <asp:ListItem>Activo</asp:ListItem>
                                    </asp:ListBox>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1" colspan="2" style="text-align:center" rowspan="1">
                                    <asp:Button ID="btnActualizar" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Actualizar" />
                                    <asp:Button ID="btnCerrar" runat="server" BackColor="Red" ForeColor="White" Width="80px" Height="30PX" Text="Cerrar" OnClick="btnCerrar_Click" />
                                 </td>
                               
                            </tr>

                        
                    </table>
                </div>

            </div>
        </main>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
