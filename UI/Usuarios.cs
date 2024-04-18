using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.Columns.Add("Id", "Id");
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Apellido", "Apellido");
            dgvUsuarios.Columns.Add("Email", "Email");
            ActualizarDgv();
        }

        private void ActualizarDgv()
        {
            dgvUsuarios.Rows.Clear();
            foreach (BEUsuario usuario in BLLUsuario.Listar())
            {
                dgvUsuarios.Rows.Add(usuario.Id, usuario.Nombre, usuario.Apellido, usuario.Email);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario nuevoCliente = ObtenerDatos();

                if (nuevoCliente is null) throw new Exception("Debe completar todos los campos, por favor.");

                bool alta = BLLUsuario.Agregar(nuevoCliente);

                if (alta) MessageBox.Show("Usuario agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BEUsuario ObtenerDatos()
        {
            try
            {
                if (CamposInvalidos()) throw new Exception();
                return new BEUsuario()
                {
                    Nombre = inputNombre.Text,
                    Apellido = inputApellido.Text,
                    Email = inputEmail.Text,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(inputNombre.Text.Trim()) || String.IsNullOrEmpty(inputApellido.Text.Trim()) || String.IsNullOrEmpty(inputEmail.Text.Trim());
        }
    }
}
