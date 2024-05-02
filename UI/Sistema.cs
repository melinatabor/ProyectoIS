using BE;
using BLL;
using Servicios.SesionManager;
using System;
using System.Windows.Forms;
using MetroFramework;

namespace UI
{
    public partial class Sistema : MetroFramework.Forms.MetroForm
    {
        public Sistema()
        {
            try
            {
                InitializeComponent();
                usuarioLogeadoTxt.Text = $"Usuario: {SesionManager.GetUsername()}";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Gestion usuarios = new Gestion();
                usuarios.MdiParent = this;
                usuarios.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MetroMessageBox.Show(this, "Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    RegistrarBitacora();
                    SesionManager.Logout();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MetroMessageBox.Show(this, "Desea cerrar la sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegistrarBitacora()
        {
            try
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
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora bitacora = new Bitacora();
                bitacora.MdiParent = this;
                bitacora.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
