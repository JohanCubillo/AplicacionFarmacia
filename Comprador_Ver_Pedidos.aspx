<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comprador_Ver_Pedidos.aspx.cs" Inherits="Sistema_de_Requisiciones.Comprador_Ver_Pedidos" %>

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
                        <h3>Nombre del Usuario</h3>
                        <h4>Comprador</h4>
                    </div>

                </div>
                <ul>
                    <li>&nbsp; <a href="Comprador_Ver_Pedidos.aspx" style="font-family: Arial; font-size: 16px">Ver Solicitudes</a></li>
                    <li>&nbsp; <a href="Comprador_Hacer_Pedidos.aspx" style="font-family: Arial; font-size: 16px">Hacer Pedido</a></li>
                    <li>
                        <asp:Button ID="Button2" runat="server" Text="Cerrar sesion" OnClick="Button1_Click1" margin-left="none" outline="none" BackColor="#222833" BorderColor="#222833" ForeColor="White" BorderStyle="None" Font-Names="Arial" Font-Size="16px" Width="105px" />
                    </li>
                </ul>
            </nav>
            <div class="container">
                <h2>SOLICITUDES</h2>

                <div class="container-table">
                    <div class="accionesComprador">
                        <div style="height: 296px">
                            <br />
    <br />
    <br />
                            <label for="txtBuscar">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" BackColor="#5B639C" BorderColor="#5B639C" ForeColor="White" Height="30px" Width="80px" />
&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TxtBusca" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</label>&nbsp;&nbsp;
                            <br />
                            <br />
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"  ForeColor="#333333" DataKeyNames="solicitudId" DataSourceID="SqlDataSource2" PageSize="3" CellPadding="4" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="solicitudId" HeaderText="solicitudId" InsertVisible="False" ReadOnly="True" SortExpression="solicitudId" />
                                    <asp:BoundField DataField="nombreProducto" HeaderText="nombreProducto" SortExpression="nombreProducto" />
                                    <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                                    <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                                    <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                                    <asp:BoundField DataField="comentarios" HeaderText="comentarios" SortExpression="comentarios" />
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
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:conexionPablo %>" DeleteCommand="DELETE FROM [solicitud] WHERE [solicitudId] = @original_solicitudId AND [nombreProducto] = @original_nombreProducto AND [descripcion] = @original_descripcion AND [precio] = @original_precio AND [cantidad] = @original_cantidad AND (([comentarios] = @original_comentarios) OR ([comentarios] IS NULL AND @original_comentarios IS NULL))" InsertCommand="INSERT INTO [solicitud] ([nombreProducto], [descripcion], [precio], [cantidad], [comentarios]) VALUES (@nombreProducto, @descripcion, @precio, @cantidad, @comentarios)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [solicitud]" UpdateCommand="UPDATE [solicitud] SET [nombreProducto] = @nombreProducto, [descripcion] = @descripcion, [precio] = @precio, [cantidad] = @cantidad, [comentarios] = @comentarios WHERE [solicitudId] = @original_solicitudId AND [nombreProducto] = @original_nombreProducto AND [descripcion] = @original_descripcion AND [precio] = @original_precio AND [cantidad] = @original_cantidad AND (([comentarios] = @original_comentarios) OR ([comentarios] IS NULL AND @original_comentarios IS NULL))">
                                <DeleteParameters>
                                    <asp:Parameter Name="original_solicitudId" Type="Int32" />
                                    <asp:Parameter Name="original_nombreProducto" Type="String" />
                                    <asp:Parameter Name="original_descripcion" Type="String" />
                                    <asp:Parameter Name="original_precio" Type="Decimal" />
                                    <asp:Parameter Name="original_cantidad" Type="Int32" />
                                    <asp:Parameter Name="original_comentarios" Type="String" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="nombreProducto" Type="String" />
                                    <asp:Parameter Name="descripcion" Type="String" />
                                    <asp:Parameter Name="precio" Type="Decimal" />
                                    <asp:Parameter Name="cantidad" Type="Int32" />
                                    <asp:Parameter Name="comentarios" Type="String" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="nombreProducto" Type="String" />
                                    <asp:Parameter Name="descripcion" Type="String" />
                                    <asp:Parameter Name="precio" Type="Decimal" />
                                    <asp:Parameter Name="cantidad" Type="Int32" />
                                    <asp:Parameter Name="comentarios" Type="String" />
                                    <asp:Parameter Name="original_solicitudId" Type="Int32" />
                                    <asp:Parameter Name="original_nombreProducto" Type="String" />
                                    <asp:Parameter Name="original_descripcion" Type="String" />
                                    <asp:Parameter Name="original_precio" Type="Decimal" />
                                    <asp:Parameter Name="original_cantidad" Type="Int32" />
                                    <asp:Parameter Name="original_comentarios" Type="String" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
                            <br />
    <div>                       </div>
    <div></div>
                            <br />
                            <br />
                            <br />
                            <br />
                           </div>
                        </div>
                   
              
                </div>
            </div>
        </main>
    </form>
                    </body>
</html>
