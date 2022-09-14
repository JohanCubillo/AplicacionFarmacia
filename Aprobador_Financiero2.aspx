<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aprobador_Financiero2.aspx.cs" Inherits="Sistema_de_Requisiciones.Aprobador_Financiero2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link  rel="stylesheet" href="styles.css"  type="text/css"/>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css"/>
    <title>Administracion</title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
            width: 157px;
        }
        .auto-style2 {
            width: 149px;
        }
        .auto-style3 {
            height: 22px;
            width: 149px;
        }
        .auto-style4 {
            width: 249px;
        }
        .auto-style5 {
            height: 22px;
            width: 249px;
        }
        .auto-style6 {
            width: 252px;
        }
        .auto-style7 {
            height: 22px;
            width: 252px;
        }
        .auto-style8 {
            width: 151px;
        }
        .auto-style9 {
            height: 22px;
            width: 151px;
        }
        .auto-style10 {
            width: 157px;
        }
        .auto-style11 {
            width: 22px;
            height: 23px;
        }
        .auto-style12 {
            width: 23px;
            height: 23px;
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
                           <asp:Label ID="lblNombre" runat="server" Text="Nombre de usuario"></asp:Label>
                        </h3>
                        <h4>Aprobador Financiero</h4>
                    </div>

                </div>
                <ul>
                    <li><a href="Comprador_Ver_Pedidos.aspx">Ver Solicitudes</a></li>
                    <li><a href="Login.aspx">Cerrar Sesion</a></li>
                </ul>
            </nav>
            <div class="container">
                <h2>SOLICITUDES / PEDIDOS&nbsp; -&nbsp; RANGO ENTRE 100.000 Y 1.000.000</h2>

                <div class="container-table">
                    <div class="accionesComprador">
                        <button class="btn-add">Nuevo</button>
                        <button class="btn-add">En proceso</button>
                        <button class="btn-add">Aprobadas</button>
                        <button class="btn-add">Rechazadas</button>
                        <div>
                            <label for="txtBuscar">Buscar</label>
                            <input type="text" name="txtBuscar" id="txtBuscar">
                        </div>
                    </div>
                    <table>
                        <thead>
                            <tr>
                                <th class="auto-style10">ID</th>
                                <th class="auto-style2">Comprador</th>
                                <th class="auto-style6">Producto</th>
                                <th class="auto-style4">Descripción</th>
                                <th class="auto-style8">Precio</th>
                                <th class="auto-style8">Cantidad</th>
                                <th class="auto-style8">Fecha de solicitud</th>
                                <th class="auto-style8">Comentarios</th>
                                <th class="auto-style8">Estado</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class="auto-style1">123</td>
                                <td class="auto-style3"></td>
                                <td class="auto-style7">Laptop</td>
                                <td class="auto-style5">DELL Latitud 4300</td>
                                <td class="auto-style9">$500</td>
                                <td class="auto-style9">2</td>
                                <td class="auto-style9">21/04/2022</td>
                                <td class="auto-style9"></td>
                                <td class="auto-style9">
                                    <a href="Login.aspx"><img src="img/equis.png" class="auto-style11"/></a>&nbsp; <a href="Login.aspx"><img src="img/check.png" class="auto-style12"/></a>    
                                    </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">234</td>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style6">Silla</td>
                                <td class="auto-style4">Silla Ejecutiva Palm Tapiz Tela Azul</td>
                                <td class="auto-style8">$285</td>
                                <td class="auto-style8">1</td>
                                <td class="auto-style8">15/04/2022</td>
                                <td class="auto-style8">&nbsp;</td>
                                <td class="auto-style8">
                                    <a href="Login.aspx"><img src="img/equis.png" class="auto-style11"/>&nbsp; <img src="img/check.png" class="auto-style12"/></a> </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                                <td class="auto-style5">&nbsp;</td>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style9">
                                    <a href="Login.aspx"><img src="img/equis.png" class="auto-style11"/>&nbsp; <img src="img/check.png" class="auto-style12"/></a> </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style4">&nbsp;</td>
                                <td class="auto-style8">&nbsp;</td>
                                <td class="auto-style8">&nbsp;</td>
                                <td class="auto-style8">&nbsp;</td>
                                <td class="auto-style8">&nbsp;</td>
                                <td class="auto-style8">
                                    <a href="Login.aspx"><img src="img/equis.png" class="auto-style11"/>&nbsp; <img src="img/check.png" class="auto-style12"/></a> </td>
                            </tr>
                        </tbody>
                    </table>
                </div>

            </div>
        </main>
    </form>
</body>
</html>
