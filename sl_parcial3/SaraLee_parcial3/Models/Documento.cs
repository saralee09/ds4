using System;

namespace sl_parcial3.Models
{
    public class Documento
    {
        public int DocumentoId { get; set; }
        public int CasoId { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaFisica { get; set; }
        public string Tipo { get; set; }
        public int Version { get; set; } = 1;
        public string Notas { get; set; }
        public DateTime FechaSubida { get; set; } = DateTime.UtcNow;
        public string SubidoPor { get; set; }
    }
}