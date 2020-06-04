using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServicesVenta;

namespace proyectoVenta
{
    /// <summary>
    /// Summary description for wsVenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsVenta : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet buscarVentaPorEmpresa(string empresa)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select id_venta as Id_venta, empresa as Empresa, date_format(fecha, '%d-%m-%Y') as Fecha from cliente, venta where venta.id_cliente = cliente.id_cliente and empresa like concat('%" + empresa + "%')";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet buscarVentaPorFecha(string fecha1, string fecha2)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select id_venta, empresa, date_format(fecha, '%Y-%m-%d') as fecha from cliente, venta where venta.id_cliente=cliente.id_cliente and fecha between ('" + fecha1 + "') and ('" + fecha2 + "');";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }
    }
}
