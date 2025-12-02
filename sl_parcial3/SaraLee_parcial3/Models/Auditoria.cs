using System;

namespace sl_parcial3.Models
{
    public class Auditoria
    {
        public int AuditoriaId { get; set; }
        public string Entidad { get; set; }
        public string EntidadId { get; set; }
        public string Accion { get; set; } // Crear/Actualizar/Eliminar
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public string Cambios { get; set; }
    }
}