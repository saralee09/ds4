using sl_parcial3.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace sl_parcial3.Data
{
    public class SaraLeeContext : DbContext
    {
        public SaraLeeContext() : base("DefaultConnection") { }

        public DbSet<Cliente> SL_Clientes { get; set; }
        public DbSet<Abogado> SL_Abogados { get; set; }
        public DbSet<Caso> SL_Casos { get; set; }
        public DbSet<Documento> SL_Documentos { get; set; }
        public DbSet<Tarea> SL_Tareas { get; set; }
        public DbSet<Evento> SL_Eventos { get; set; }
        public DbSet<Alerta> SL_Alertas { get; set; }
        public DbSet<Auditoria> SL_Auditoria { get; set; }
    }
}