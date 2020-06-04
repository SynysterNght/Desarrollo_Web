using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultarVentas
{
    public partial class frmConsultarVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            wsVenta.wsVenta obj = new wsVenta.wsVenta();
            gdvEmpresa.DataSource = obj.buscarVentaPorEmpresa(txtBuscarEmp.Text);
            gdvEmpresa.DataBind();
        }

        protected void btnBuscarFec_Click(object sender, EventArgs e)
        {
            wsVenta.wsVenta obj = new wsVenta.wsVenta();
            gdvFechas.DataSource = obj.buscarVentaPorFecha(txtFecha1.Text, txtFecha2.Text);
            gdvFechas.DataBind();
        }
    }
}