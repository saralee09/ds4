using System;

namespace sl_parcial3.Models
{
    public class Abogado
    {
        public int AbogadoId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }
        public bool Activo { get; set; } = true;
    }
}