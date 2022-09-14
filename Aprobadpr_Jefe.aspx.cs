using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_de_Requisiciones.Controlador;
using Sistema_de_Requisiciones.Modelo;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Requisiciones
{
    public partial class Aprobador_Jefe : System.Web.UI.Page
    {
        UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
        CtrSolicitud solicitud = new CtrSolicitud();
        bool mostrarAlertas = false;
        int usuarioIdActual;
        string mensajeDeCarga;
       // mensajeDeCarga = "Bienvenido!"; 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (obj.usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (obj.usuario.TipoUsuarioId != 1 && obj.usuario.TipoUsuarioId != 3)
                {
                    Response.Redirect(obj.rutas[obj.usuario.TipoUsuarioId - 1]);
                }
            }
            usuarioIdActual = obj.usuario.UsuarioId;
            this.lblNombre.Text = obj.usuario.Nombre + " " + obj.usuario.Apellido;
            DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitud("nueva");
            string s = tablaSolicitud.Rows[0].ItemArray[1].ToString();
            gdSolicitudes.DataSource = tablaSolicitud;
            gdSolicitudes.DataBind();
            gdSolicitudes.Columns[7].Visible = true;
            gdSolicitudes.Columns[8].Visible = true;
            if(mostrarAlertas)
                Response.Write("<script>alert('"+ mensajeDeCarga + "');</script>");
            mostrarAlertas = false;
            btnAprobada.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnNueva.BackColor = System.Drawing.Color.Gray;
            btnRechazada.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);

        }

        protected void gdSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {

            Response.Write("<script>alert('aqui no mas');</script>");

        }

        protected void gdSolicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "aprobar" || e.CommandName == "rechazar")
            {

                int clickRow;
                int solicitudId;
                Solicitud solicitudConsultada = new Solicitud();
                clickRow = Convert.ToInt32(e.CommandArgument.ToString());

                //Se modificara el campo tipo de mivimiento en tabla solicitud
                solicitudId = int.Parse(gdSolicitudes.Rows[clickRow].Cells[0].Text);
                solicitudConsultada = solicitud.consultarSolicitud(solicitudId);
                if (e.CommandName == "aprobar") { 
                    solicitudConsultada.TipoMovimiento = 2;
                    mensajeDeCarga = "La compra fue aprobada";
  
                }
                if (e.CommandName == "rechazar") { 
                    solicitudConsultada.TipoMovimiento = 3;
                    mensajeDeCarga = "La compra fue rechazada";
                }

                MessageBox.Show(mensajeDeCarga, "Proceso de requecisión",MessageBoxButtons.OK);

                solicitud.editarSolicitud(solicitudConsultada);

                //Se crea un registro al historial
                Historial nuevoHistorial = new Historial();
                nuevoHistorial.Fecha = DateTime.Now;
                nuevoHistorial.Solicitud = solicitudConsultada.Solicitudid;
                nuevoHistorial.Tipomovimientoid = solicitudConsultada.TipoMovimiento;
                nuevoHistorial.Usuarioid = usuarioIdActual;
                CtrHistorial.insertarHistorial(nuevoHistorial);
                mostrarAlertas = true;
                Response.Redirect("Aprobadpr_Jefe.aspx");
            }
        }

        protected void btnAprobada_Click(object sender, EventArgs e)
        {        
            DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitud("aprobada");
            gdSolicitudes.DataSource = tablaSolicitud;
            gdSolicitudes.DataBind();
            gdSolicitudes.Columns[7].Visible = false;
            gdSolicitudes.Columns[8].Visible = false;
            btnAprobada.BackColor = System.Drawing.Color.Green;
            btnNueva.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnRechazada.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);

        }

        protected void btnRechazada_Click(object sender, EventArgs e)
        {
            DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitud("rechazada");
            string s = tablaSolicitud.Rows[0].ItemArray[1].ToString();
            gdSolicitudes.DataSource = tablaSolicitud;
            gdSolicitudes.DataBind();
            gdSolicitudes.Columns[7].Visible = false;
            gdSolicitudes.Columns[8].Visible = false;
            btnAprobada.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnNueva.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnRechazada.BackColor = System.Drawing.Color.Red;
        }

        protected void btnNueva_Click(object sender, EventArgs e)
        {
            btnAprobada.BackColor = System.Drawing.Color.Gray;
            btnNueva.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnRechazada.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            Response.Redirect("Aprobadpr_Jefe.aspx");
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

        protected void btBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}