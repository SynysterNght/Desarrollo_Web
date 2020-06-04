<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsultarVentas.aspx.cs" Inherits="consultarVentas.frmConsultarVentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h3>CONSULTAS</h3>
        <div>
            <div>
                <h4>BUSCAR VENTAS POR EMPRESA</h4>
                <div>
                    Empresa<br />
                    <asp:TextBox ID="txtBuscarEmp" runat="server"></asp:TextBox>             
                    <asp:Button ID="btnBuscarEmp" runat="server" Text="Buscar Ventas por Empresa" OnClick="btnBuscarEmp_Click" />
                    <br />
                    <br />
                    <asp:GridView ID="gdvEmpresa" runat="server">
                    </asp:GridView>
                    <br />
                </div>
                <h4>BUSCAR VENTAS ENTRE FECHAS</h4>
                <div>
                    <asp:TableRow ID="TableRow1" runat="server">
                        <asp:TableCell>Primera fecha</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtFecha1" runat="server" type="date"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TableRow2" runat="server">
                        <asp:TableCell>Segunda fecha</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtFecha2" runat="server" type="date"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:Button ID="btnBuscarFec" runat="server" OnClick="btnBuscarFec_Click" Text="Buscar Ventas por Fecha" />
                    <br />
                    <asp:GridView ID="gdvFechas" runat="server">
                    </asp:GridView>
                    <br />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
