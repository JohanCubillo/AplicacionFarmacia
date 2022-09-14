<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador_Rangos.aspx.cs" Inherits="Sistema_de_Requisiciones.Administrador_Rangos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="styles.css" type="text/css" />
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v2.1.6/css/unicons.css" />
    <title>Administracion Rangos</title>
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
                        <h4>Administrador</h4>
                    </div>



                </div>
                <ul>
                    <li>&nbsp; <a href="Administrador.aspx" style="font-family: Arial; font-size: 16px">Usuarios</a></li>
                    <li>&nbsp; <a href="Administrador_Rangos.aspx" style="font-family: Arial; font-size: 16px">Rangos</a></li>

                    <li>
                        <asp:Button ID="Button1" runat="server" Text="Cerrar sesion" OnClick="Button1_Click1" margin-left="none" outline="none" BackColor="#222833" BorderColor="#222833" ForeColor="White" BorderStyle="None" Font-Names="Arial" Font-Size="16px" Width="105px" />
                    </li>
                </ul>
            </nav>
            <div class="container">



               <h2>INFORMACION SOBRE RANGOS</h2>



               <div class="container-table">



                   <div style="margin-left:100px">
                        <asp:GridView ID="GridViewRango" runat="server" AutoGenerateColumns="False" DataKeyNames="financieroId" DataSourceID="SqlDataSourceRango" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:BoundField DataField="financieroId" HeaderText="financieroId" InsertVisible="False" ReadOnly="True" SortExpression="financieroId" />
                                <asp:BoundField DataField="limiteBajo" HeaderText="limiteBajo" SortExpression="limiteBajo" />
                                <asp:BoundField DataField="limiteAlto" HeaderText="limiteAlto" SortExpression="limiteAlto" />
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
                        <asp:SqlDataSource ID="SqlDataSourceRango" runat="server" ConnectionString="<%$ ConnectionStrings:RequisicionesConnectionString2 %>" DeleteCommand="DELETE FROM [rango] WHERE [financieroId] = @financieroId" InsertCommand="INSERT INTO [rango] ([limiteBajo], [limiteAlto]) VALUES (@limiteBajo, @limiteAlto)" SelectCommand="SELECT [financieroId], [limiteBajo], [limiteAlto] FROM [rango]" UpdateCommand="UPDATE [rango] SET [limiteBajo] = @limiteBajo, [limiteAlto] = @limiteAlto WHERE [financieroId] = @financieroId">
                            <DeleteParameters>
                                <asp:Parameter Name="financieroId" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="limiteBajo" Type="Decimal" />
                                <asp:Parameter Name="limiteAlto" Type="Decimal" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="limiteBajo" Type="Decimal" />
                                <asp:Parameter Name="limiteAlto" Type="Decimal" />
                                <asp:Parameter Name="financieroId" Type="Int32" />
                            </UpdateParameters>
                        </asp:SqlDataSource>



                   </div>
                    <br />
                    <br />
                    <div style="text-align:center">
                        <asp:Button ID="btnCerrar" runat="server" BackColor="Red" ForeColor="White" Width="80px" Height="30PX" Text="Cerrar" OnClick="btnCerrar_Click" BorderStyle="None" />
                    </div>
                </div>
           </div>
        </main>
    </form>
</body>
</html>
