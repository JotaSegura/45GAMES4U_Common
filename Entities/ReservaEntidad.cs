using System;

namespace Entities
{
    public class ReservaEntidad
    {
        public int Id { get; set; }
        public VideojuegosXTiendaEntidad VideojuegoPorTienda { get; set; }
        public ClienteEntidad Cliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Cantidad { get; set; }
    }
}