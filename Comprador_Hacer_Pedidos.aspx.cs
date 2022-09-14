using Sistema_de_Requisiciones.Controlador;
using Sistema_de_Requisiciones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Sistema_de_Requisiciones
{
    public partial class Comprador_Hacer_Pedidos : System.Web.UI.Page
    {
        int usuarioActual;
        UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
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
            this.lblNombre.Text = obj.usuario.Nombre+" "+ obj.usuario.Apellido;
            usuarioActual = obj.usuario.UsuarioId;
        }

        protected void btnPNuevo_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtComentarios.Text = "";
            txtDescripcion.Text = "";
            txtNProducto.Text = "";
            txtPrecio.Text = "";
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comprador_Ver_Pedidos.aspx");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud solicitud = new Solicitud();
                solicitud.Nombreproducto = txtNProducto.Text;
                solicitud.Descripcion = (txtDescripcion.Text.ToString());
                solicitud.Precio = Decimal.Parse(txtPrecio.Text);
                solicitud.Cantidad = int.Parse(txtCantidad.Text);
                solicitud.Comentarios = (txtComentarios.Text);
                solicitud.TipoMovimiento = 1;
                solicitud.UsuarioId = usuarioActual;
                CtrSolicitud.insertarSolicitud(solicitud);
                MessageBox.Show("La solicitud ha sido creada correctamente", "Solicitud", MessageBoxButtons.OK);
                //mensajeError.Text = "La solicitud ha sido creada correctamente";
                //mensajeError.ForeColor = System.Drawing.Color.Green;

            }catch (Exception)
            {
                //mensajeError.Text = "Error al guardar mensaje";
                //mensajeError.ForeColor = System.Drawing.Color.Red;
            }
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

        protected void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}