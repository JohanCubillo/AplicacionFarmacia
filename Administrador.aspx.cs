using Sistema_de_Requisiciones.Controlador;
using Sistema_de_Requisiciones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Requisiciones
{
    public partial class Administrador : System.Web.UI.Page
    {
        UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
            if (obj.usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            else {
                if (obj.usuario.TipoUsuarioId!=1) {
                    Response.Redirect(obj.rutas[obj.usuario.TipoUsuarioId-1]);
                }
            }
            this.lblNombre.Text = obj.usuario.Nombre + " " + obj.usuario.Apellido;
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string fechaInicio = Session["fechaInicio"].ToString();
        //    string fechaFin = DateTime.Now.ToString();
        //    CtrHitorialLogin ctr = new CtrHitorialLogin();
        //    HistorialLogin login = new HistorialLogin();
        //    string[] inicio = fechaInicio.Split(' ');
        //    string[] fin = fechaFin.Split(' ');
        //    login.Fechainicial = inicio[0];
        //    login.Horainicial = inicio[1];
        //    login.Fechafinal = fin[0];
        //    login.Horafinal = fin[1];
        //    login.Usuarioid = obj.usuario.UsuarioId;
        //    ctr.insertarHistorialLogin(login);
        //    obj.usuario = null;
        //    Response.Redirect("Login.aspx");
        //}

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

        protected void btnBuscarClick(object sender, EventArgs e)
        {
            SqlDataSourceAdmin.SelectCommand = "SELECT * FROM [usuario] where usuarioId LIKE '%" + txtBuscar.Text + "%'";
            SqlDataSourceAdmin.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Nuevo_Usuario.aspx");
        }
    }
}