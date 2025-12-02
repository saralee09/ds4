using System;

namespace sl_parcial3.Models
{
    public class Tarea
    {
        public int TareaId { get; set; }
        public int CasoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int? AsignadoAAbogadoId { get; set; }
        public DateTime FechaLimite { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string Prioridad { get; set; } = "Normal";
        public DateTime CreadoEn { get; set; } = DateTime.UtcNow;
        public DateTime ActualizadoEn { get; set; } = DateTime.UtcNow;
    }
}