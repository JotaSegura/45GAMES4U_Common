namespace Entities
{
    public class TiendaEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public AdministradorEntidad Administrador { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activa { get; set; }
    }
}