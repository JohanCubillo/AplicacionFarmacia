<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador_Datos.aspx.cs" Inherits="Sistema_de_Requisiciones.Administrador_Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link  rel="stylesheet" href="styles.css"  type="text/css"/>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css"/>
    <title>Administracion Datos del Usuario</title>
    <style type="text/css">
        .auto-style1 {
            width: 796px;
        }
        .auto-style2 {
            width: 762px;
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
                <h2>DATOS DEL USUARIO</h2>

                <div class="container-table">
                    
                    <table>
                             <tr>
                                <td class="auto-style1">Identificación</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="txtId" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                 </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Nombres</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtNombres" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Apellidos</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtApellidos" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Telefono</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtTelefono" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1">Email</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtEmail" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Tipo de usuario</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtTipoU" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1">Estado</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtEstado" runat="server" Width="180px" ReadOnly="True"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td class="auto-style1" colspan="2" rowspan="1">

                                    <asp:Button ID="btnImprimir" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Imprimir" />
                                    <asp:Button ID="btnCerrar" runat="server" BackColor="Red" ForeColor="White" Width="80px" Height="30PX" Text="Cerrar" OnClick="btnCerrar_Click" />

                                </td>
                            </tr>
                    </table>
                </div>

            </div>
        </main>
    </form>
</body>
</html>
