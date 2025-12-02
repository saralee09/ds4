using System;

using System;

namespace sl_parcial3.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public int CasoId { get; set; }
        public string Tipo { get; set; } = "Audiencia";
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? ResponsableAbogadoId { get; set; }
    }
}