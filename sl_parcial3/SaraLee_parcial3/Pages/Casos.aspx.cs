using System;
using System.Linq;
using sl_parcial3.Data;
using sl_parcial3.Models;

namespace sl_parcial3.Pages
{
    public partial class Casos : System.Web.UI.Page
    {
        private readonly SaraLeeContext _db = new SaraLeeContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvCasos.DataSource = _db.SL_Casos.ToList();
                gvCasos.DataBind();
            }
        }

        protected void btnAgregarCaso_Click(object sender, EventArgs e)
        {
            var caso = new Caso
            {
                Codigo = "C-" + Guid.NewGuid().ToString().Substring(0, 5),
                Titulo = txtTitulo.Text,
                Estado = "Nuevo",
                FechaInicio = DateTime.Today
            };
            _db.SL_Casos.Add(caso);
            _db.SaveChanges();

            gvCasos.DataSource = _db.SL_Casos.ToList();
            gvCasos.DataBind();
        }
    }
}