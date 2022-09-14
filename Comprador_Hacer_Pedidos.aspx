<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comprador_Hacer_Pedidos.aspx.cs" Inherits="Sistema_de_Requisiciones.Comprador_Hacer_Pedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link  rel="stylesheet" href="styles.css"  type="text/css"/>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css"/>
    <title>Administracion</title>
    <style type="text/css">
        .auto-style1 {
            width: 600px;
            text-align: left;
        }

        .Estilo {
            font-size: 15px;
            color: red;
        }

        .auto-style2 {
            width: 1516px;
            text-align: left;
            height: 23px;
        }

        .auto-style3 {
            width: 756px;
            text-align: left;
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
                        <h3>
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre del Usuario"></asp:Label>
                        </h3>
                        <h4>Comprador</h4>
                    </div>

                </div>
                <ul>
                    <li><a href="Comprador_Ver_Pedidos.aspx" style="font-family: Arial; font-size: 16px">Ver Solicitudes</a></li>
                    <li><a href="Comprador_Hacer_Pedidos.aspx" style="font-family: Arial; font-size: 16px">Hacer Pedido</a></li>
                </ul>
            </nav>
            <div class="container">
                <h2>PRODUCTOS</h2>

                <div class="container-table">
                    <table style="width:600px">

                        <tr>
                            <td class="auto-style2">NOMBRE DEL PRODUCTO:</td>
                            <td class="auto-style3"><asp:TextBox ID="txtNProducto" runat="server"  style="width:300px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNProducto" ErrorMessage="Este campo es requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="txtNProducto" ErrorMessage="Ingrese un nonbre de producto" style="color: #FF3300">*</asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <td class="auto-style2">DESCRIPCIÓN:</td>    
                            <td class="auto-style3"><asp:TextBox ID="txtDescripcion" runat="server" style="width:300px"></asp:TextBox>                            
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Este campo es requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style2">PRECIO</td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtPrecio" runat="server" style="width:300px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Este campo es requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Ingrese un precio correcto" MaximumValue="100000000" MinimumValue="1" Type="Double" CssClass="auto-style1" ForeColor="Red">*</asp:RangeValidator>
                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style2">CANTIDAD:</td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtCantidad" runat="server" style="width:300px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Este campo es requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Cantidad no aceptable" MaximumValue="100" MinimumValue="1" style="color: #FF3300" Type="Integer">*</asp:RangeValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">COMENTARIOS:</td>
                            <td class="auto-style3"><asp:TextBox ID="txtComentarios" runat="server" Height="62px" style="width:300px"></asp:TextBox></td>
                        </tr>
                     
                        <tr>
                            <td class="auto-style1" colspan="2" style="text-align: center" rowspan="1">
                                <asp:Button ID="btnAgregar" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Agregar" OnClick="btnAgregar_Click" BorderColor="#5B639C" />
                                <asp:Button ID="btnPNuevo" runat="server" BackColor="#5b639c" ForeColor="White" Width="80px" Height="30PX" Text="Nuevo" OnClick="btnPNuevo_Click" BorderColor="#5B639C" />
                                <asp:Button ID="btnCerrar" runat="server" BackColor="Red" ForeColor="White" Width="80px" Height="30PX" Text="Cerrar" OnClick="btnCerrar_Click" BorderColor="Red" />
                                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color: #FF3300" />

                              

                            </td>
                        </tr>

                    </table>
                    <br/>
                    <br/>
                    <br/>
                    <br/>
                    <br/>
              </div>
               
            </div>
        </main>
       
    </form>
</body>
</html>
