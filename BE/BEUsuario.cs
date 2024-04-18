
namespace BE
{
    public class BEUsuario
    {
    #region Propiedades
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        #endregion

        #region Constructor
        public BEUsuario() { }
    #endregion
    }
}
