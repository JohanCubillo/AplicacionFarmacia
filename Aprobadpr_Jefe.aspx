﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aprobadpr_Jefe.aspx.cs" Inherits="Sistema_de_Requisiciones.Aprobador_Jefe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link  rel="stylesheet" href="styles.css"  type="text/css"/>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css"/>
    <title>Administracion</title>
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
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre del usuario"></asp:Label>
                        </h3>
                        <h4>Aprobador Jefe</h4>
                    </div>

                </div>
                <ul>
                    <li>&nbsp; <a href="Comprador_Ver_Pedidos.aspx" style="font-family: Arial; font-size: 16px">Ver Solicitudes</a></li>
                                        <li>
                        <asp:Button ID="Button1" runat="server" Text="Cerrar sesion" OnClick="Button1_Click1" margin-left="none" outline="none" BackColor="#222833" BorderColor="#222833" ForeColor="White" BorderStyle="None" Font-Names="Arial" Font-Size="16px" Width="105px" />
                    </li>
                  
                </ul>
            </nav>
            <div class="container">
                <h2>SOLICITUDES / PEDIDOS</h2>

                <div class="container-table">
                    <div class="acciones">
                        <asp:Button CssClass="btnFocus" ID="btnNueva" runat="server" Text="Nueva" Button="Active" Height="30px" OnClick="btnNueva_Click" BackColor="#5B639C" ForeColor="White" Width="80px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button CssClass="btnFocus" ID="btnAprobada" runat="server" Text="Aprobadas"  Button="Active" Height="30px" OnClick="btnAprobada_Click" BackColor="#5B639C" ForeColor="White" Width="100px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button CssClass="btnFocus" ID="btnRechazada" runat="server" Text="Rechazadas"  Button="Active" Height="30px" OnClick="btnRechazada_Click" BackColor="#5B639C" ForeColor="White" Width="100px"/>
                        <div style="height: 31px; width: 1275px">

                        </div>
                    </div>

                    <div id="divDeTabla">
                        <div style="width: 100%; height:616px; overflow: scroll">
                            <asp:GridView ID="gdSolicitudes" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gdSolicitudes_SelectedIndexChanged" OnRowCommand="gdSolicitudes_RowCommand">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="solicitudId" HeaderText="Solicitud Id" />
                                    <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                    <asp:BoundField DataField="nombre" HeaderText="Comprador" />
                                    <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                                    <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                                    <asp:BoundField DataField="comentarios" HeaderText="Comentarios" />
                                    <asp:ButtonField HeaderText="Aprobar" ImageUrl="~/images/check.png" ButtonType="Image" CommandName="aprobar" />
                                    <asp:ButtonField ButtonType="Image" HeaderText="Rechazar" ImageUrl="~/images/equis.png" CommandName="rechazar" />
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                        </div>
                    </div>


                </div>

            </div>
        </main>
    </form>
</body>
</html>
