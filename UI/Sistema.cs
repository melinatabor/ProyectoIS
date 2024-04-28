using BE;
using BLL;
using Servicios.SesionManager;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
            usuarioLogeadoTxt.Text = $"Usuario: {SesionManager.GetUsername()}";
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion usuarios = new Gestion();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    RegistrarBitacora();
                    SesionManager.Logout();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Desea cerrar la sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    RegistrarBitacora();
                    SesionManager.Logout();
                    Login login = new Login();
                    login.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegistrarBitacora()
        {
            string username = SesionManager.GetUsername();

            BEUsuario usuarioActual = BLLUsuario.BuscarUsuarioPorUsername(username) ?? throw new Exception($"No existe el username: {username}");

            BEBitacora bitacora = new BEBitacora()
            {
                Usuario = usuarioActual.Id,
                Tipo = BEBitacora.BitacoraTipo.INFO,
                Mensaje = "El usuario finalizó la sesión"
            };

            BLLBitacora.Agregar(bitacora);
        }
    }
}
