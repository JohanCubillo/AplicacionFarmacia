using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Requisiciones
{
    public partial class Aprobador_Financiero2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
            if (obj.usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (obj.usuario.TipoUsuarioId != 1 && obj.usuario.TipoUsuarioId != 5)
                {
                    Response.Redirect(obj.rutas[obj.usuario.TipoUsuarioId - 1]);
                }
            }
            this.lblNombre.Text = obj.usuario.Nombre + " " + obj.usuario.Apellido;
        }
    }
}