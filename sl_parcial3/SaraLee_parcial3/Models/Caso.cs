using System;

namespace sl_parcial3.Models
{
    public class Caso
    {
        public int CasoId { get; set; }
        public string Codigo { get; set; }          
        public string Titulo { get; set; }         
        public string Descripcion { get; set; }    

        
        public int ClienteId { get; set; }

       
        public int? AbogadoAsignadoId { get; set; }

       
        public string Estado { get; set; } = "Nuevo"; 

        
        public DateTime FechaInicio { get; set; } = DateTime.Today;
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaCierre { get; set; }

        // Prioridad
        public string Prioridad { get; set; } = "Normal";

        // Auditoría
        public DateTime CreadoEn { get; set; } = DateTime.UtcNow;
        public DateTime ActualizadoEn { get; set; } = DateTime.UtcNow;
    }
}