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
            Registro usuarios = new Registro();
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
    }
}
