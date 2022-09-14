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
    public partial class Aprobador_Financiero1 : System.Web.UI.Page
    {

        CtrSolicitud solicitud = new CtrSolicitud();
        bool mostrarAlertar = false; 
        int usuarioIdActual;
        int tipoUsuario;
        string mensajeDeCarga = "";
        UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
            if (obj.usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (obj.usuario.TipoUsuarioId != 1 && (obj.usuario.TipoUsuarioId!= 4 && obj.usuario.TipoUsuarioId != 5 && obj.usuario.TipoUsuarioId != 6))
                {
                    Response.Redirect(obj.rutas[obj.usuario.TipoUsuarioId - 1]);
                }
            }
            this.lblNombre.Text = obj.usuario.Nombre + " " + obj.usuario.Apellido;
            usuarioIdActual = obj.usuario.UsuarioId;
            tipoUsuario = obj.usuario.TipoUsuarioId;
            this.lblNombre.Text = obj.usuario.Nombre + " " + obj.usuario.Apellido;
            DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitudFinanciero("nueva", tipoUsuario);
            gdFinanciero1.DataSource = tablaSolicitud;
            gdFinanciero1.DataBind();
            gdFinanciero1.Columns[7].Visible = true;
            gdFinanciero1.Columns[8].Visible = true;
            if (tipoUsuario == 4)
            {
                lbNivelFinanciero.Text = " 1"; 
                lbRangoMin.Text = "1";
                lbRangoMax.Text = " 100000";
            }
            else
            if (tipoUsuario == 5)
            {
                lbNivelFinanciero.Text = " 2";
                lbRangoMin.Text = "100000";
                lbRangoMax.Text = "1000000";
            }
            else
            if (tipoUsuario == 6)
            {
                lbNivelFinanciero.Text = " 3";
                lbRangoMin.Text = "1000000";
                lbRangoMax.Text = "MAS";
            }
            if (mostrarAlertar)
                Response.Write("<script>alert('"+ mensajeDeCarga + "');</script>");
            mostrarAlertar = false;
            btnAprobadaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnNuevaF.BackColor = System.Drawing.Color.Gray;
            btnRechazadaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);


        }

        protected void btnProceso_Click(object sender, EventArgs e)
        {
               
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAprobada_Click(object sender, EventArgs e)
        {

            DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitudFinanciero("aprobada", tipoUsuario);
            gdFinanciero1.DataSource = tablaSolicitud;
            gdFinanciero1.DataBind();
            gdFinanciero1.Columns[7].Visible = false;
            gdFinanciero1.Columns[8].Visible = false;
            btnAprobadaF.BackColor = System.Drawing.Color.Green;
            btnNuevaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnRechazadaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
        }

        protected void btnRechazada_Click(object sender, EventArgs e)
        {
            DataTable tablaSolicitud = new DataTable();
            tablaSolicitud = solicitud.obtenerTablaSolicitudFinanciero("rechazada", tipoUsuario);
            gdFinanciero1.DataSource = tablaSolicitud;
            gdFinanciero1.DataBind();
            gdFinanciero1.Columns[7].Visible = false;
            gdFinanciero1.Columns[8].Visible = false;
            btnAprobadaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnNuevaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnRechazadaF.BackColor = System.Drawing.Color.Red;
        }

        protected void btnNueva_Click(object sender, EventArgs e)
        {
            btnAprobadaF.BackColor = System.Drawing.Color.Gray;
            btnNuevaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            btnRechazadaF.BackColor = System.Drawing.Color.FromArgb(91, 99, 156);
            Response.Redirect("Aprobador_Financiero1.aspx");
        }

        protected void gdFinanciero1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "aprobar" || e.CommandName == "rechazar")
            {

                Response.Write("<script>alert('login successful');</script>");

                string holi = Request.Form["holi"];

                int clickRow;
                int solicitudId;
                Solicitud solicitudConsultada = new Solicitud();
                clickRow = Convert.ToInt32(e.CommandArgument.ToString());

                //Se modificara el campo tipo de movimiento en tabla solicitud
                solicitudId = int.Parse(gdFinanciero1.Rows[clickRow].Cells[0].Text);
                solicitudConsultada = solicitud.consultarSolicitud(solicitudId);
                if (e.CommandName == "aprobar") {
                    mensajeDeCarga = "La compra fue aprobada";
                    solicitudConsultada.TipoMovimiento = 4;
                    
                }

                if (e.CommandName == "rechazar")                {
                    mensajeDeCarga = "La compra fue rechazada";
                    solicitudConsultada.TipoMovimiento = 5;
                }
                MessageBox.Show(mensajeDeCarga, "Proceso de requecisión", MessageBoxButtons.OK);

                solicitud.editarSolicitud(solicitudConsultada);
                
                //Se crea un registro al historial
                Historial nuevoHistorial = new Historial();
                nuevoHistorial.Fecha = DateTime.Now;
                nuevoHistorial.Tipomovimientoid = solicitudConsultada.TipoMovimiento;
                nuevoHistorial.Usuarioid = usuarioIdActual;
                nuevoHistorial.Solicitud = solicitudConsultada.Solicitudid;
                CtrHistorial.insertarHistorial(nuevoHistorial);

                mostrarAlertar = true;
                Response.Redirect("Aprobador_Financiero1.aspx");
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string fechaInicio = Session["fechaInicio"].ToString();
            string fechaFin = DateTime.Now.ToString();
            //myDateTime.ToString("yyyy-MM-dd");
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
    }
}