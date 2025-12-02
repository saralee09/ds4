using System;

namespace sl_parcial3.Models
{
    public class Alerta
    {
        public int AlertaId { get; set; }
        public string OrigenTipo { get; set; } // Tarea/Evento
        public int OrigenId { get; set; }
        public int CasoId { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaProgramada { get; set; }
        public bool Enviada { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string DestinoEmail { get; set; }
    }
}