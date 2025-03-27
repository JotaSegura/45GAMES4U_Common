namespace Entities
{
    public class ClienteEntidad : PersonaEntidad
    {
        public bool JugadorEnLinea { get; set; }
        public string NombreCompleto => $"{Nombre} {PrimerApellido} {SegundoApellido}";
    }
}