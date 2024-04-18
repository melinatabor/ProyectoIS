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

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void btnTestAgregar_Click(object sender, EventArgs e)
        {
            Prueba();
        }

        private void Prueba()
        {
            try
            {
                BECliente c = new BECliente()
                {
                    Nombre   = "Nombre Test",
                    Apellido = "Apellido Test",
                    Email    = "Email Test",
                };

                BLLCliente.Agregar(c);

                MessageBox.Show($"Nuevo usuario creado: {c.Nombre} {c.Apellido}", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
