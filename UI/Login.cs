using System;
using System.Windows.Forms;
using Abstraccion;
using BE;
using BLL;
using Servicios.SesionManager;
using static BE.BEBitacora;

namespace UI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(inputUsuario.Text.Trim()) ||
                String.IsNullOrEmpty(inputPsw.Text.Trim());
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposInvalidos()) throw new Exception("Los campos ingresados son incorrectos. Por favor vuelva a ingresarlos.");

                BEUsuario u = new BEUsuario()
                {
                    Username = inputUsuario.Text,
                    Password = inputPsw.Text
                };

                BEUsuario usuarioExistente = BLLUsuario.BuscarUsuario(u);

                if (usuarioExistente == null) throw new Exception("Credenciales incorrectas. Por favor vuelva a ingresar los datos.");

                IUsuario usuario = new BEUsuario
                {
                    Username = u.Username,
                    Password = u.Password
                };

                SesionManager.Login(usuario);

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioExistente.Id,
                    Tipo = BitacoraTipo.INFO,
                    Mensaje = "El usuario inició sesión"
                };

                BLLBitacora.Agregar(bitacora);

                MessageBox.Show(
                    $"Usuario logeado: {SesionManager.GetUsername()}",
                    "Logeado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Sistema sistema = new Sistema();
                sistema.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro formRegistro = new Registro();
            formRegistro.Show();
            Hide();
        }
    }
  
}
