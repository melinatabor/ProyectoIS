using Abstraccion;

namespace BE
{
    public class BEUsuario : IUsuario
    {
        #region Propiedades
        public string Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        #endregion

        #region Constructor
        public BEUsuario() { }
    #endregion
    }
}
