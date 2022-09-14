using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_de_Requisiciones.Modelo;
using Sistema_de_Requisiciones.Controlador;
using System.Data;

namespace Sistema_de_Requisiciones
{
    public partial class Comprador_Ver_Pedidos : System.Web.UI.Page
    {
        UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
        CtrSolicitud solicitud = new CtrSolicitud();    
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (obj.usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (obj.usuario.TipoUsuarioId != 1 && obj.usuario.TipoUsuarioId != 2)
                {
                    Response.Redirect(obj.rutas[obj.usuario.TipoUsuarioId - 1]);
                }
            }
           /*DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitud();
            string s =tablaSolicitud.Rows[0].ItemArray[1].ToString();*/

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Hacer busqueda
            //Filtrar con el campo solicitudId....
            //los  % para que empiece una busqueda sin importar la posicion...

            SqlDataSource2.SelectCommand = "SELECT * FROM [solicitud] where solicitudId LIKE '%" + TxtBusca.Text + "%'";
            SqlDataSource2.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string fechaInicio = Session["fechaInicio"].ToString();
            string fechaFin = DateTime.Now.ToString();
            CtrHitorialLogin ctr = new CtrHitorialLogin();
            HistorialLogin login = new HistorialLogin();
            string[] inicio = fechaInicio.Split(' ');
            string[] fin = fechaFin.Split(' ');
            login.Fechainicial = inicio[0];
            login.Horainicial = inicio[1];
            login.Fechafinal = fin[0];
            login.Horafinal = fin[1];
            login.Usuarioid = obj.usuario.UsuarioId;
            ctr.insertarHistorialLogin(login);
            obj.usuario = null;
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {

        }
    }
}