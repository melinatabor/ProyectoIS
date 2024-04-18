using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnTestAgregar_Click(object sender, EventArgs e)
        {
            Prueba();
        }

        private void Prueba()
        {
            try
            {
                BEUsuario usuario = new BEUsuario()
                {
                    Nombre   = "Nombre Test",
                    Apellido = "Apellido Test",
                    Email    = "Email Test",
                };

                BLLUsuario.Agregar(usuario);

                MessageBox.Show($"Nuevo usuario creado: {usuario.Nombre} {usuario.Apellido}", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
