
using System;
using System.Linq;
using sl_parcial3.Data;
using sl_parcial3.Models;

namespace sl_parcial3.Pages
{
    public partial class Clientes : System.Web.UI.Page
    {
        private readonly SaraLeeContext _db = new SaraLeeContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvClientes.DataSource = _db.SL_Clientes.ToList();
                gvClientes.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                FechaRegistro = DateTime.Now
            };
            _db.SL_Clientes.Add(cliente);
            _db.SaveChanges();

            gvClientes.DataSource = _db.SL_Clientes.ToList();
            gvClientes.DataBind();
        }
    }
}