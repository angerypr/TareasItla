namespace CRUDenASPMVC.Web.Models.Entities
{
    public class Estudiante
    {
        public Guid Id { get; set;  }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Suscrito { get; set; }
    }
}
