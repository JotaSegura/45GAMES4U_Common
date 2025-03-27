using System;

namespace Entities
{
    public class AdministradorEntidad : PersonaEntidad
    {
        public DateTime FechaContratacion { get; set; }

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get => _nombreCompleto ?? $"{Nombre} {PrimerApellido} {SegundoApellido}";
            set => _nombreCompleto = value;
        }
    }
}