
using System;
using System.Linq;
using sl_parcial3.Data;
using sl_parcial3.Models;

namespace sl_parcial3.Pages
{
    public partial class ClientesPage : System.Web.UI.Page
    {
        private readonly SaraLeeContext db = new SaraLeeContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvClientes.DataSource = db.SL_Clientes.ToList();
                gvClientes.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevo = new Models.Cliente
            {
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                FechaRegistro = DateTime.Now
            };

            db.SL_Clientes.Add(nuevo);
            db.SaveChanges();

            gvClientes.DataSource = db.SL_Clientes.ToList();
            gvClientes.DataBind();
        }
    }
}