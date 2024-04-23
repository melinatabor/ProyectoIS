using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            inputPsw.PasswordChar = '*';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario nuevoUsuario = ObtenerDatos();

                if (nuevoUsuario is null) throw new Exception("Debe completar todos los campos, por favor.");

                bool alta = BLLUsuario.Agregar(nuevoUsuario);

                if (alta) MessageBox.Show("Usuario agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDgv();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDgv()
        {
            //dgvUsuarios.DataSource = null;
            //dgvUsuarios.DataSource = BLLUsuario.Listar();
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
                    Username = inputUsername.Text,
                    Password = inputPsw.Text,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(inputNombre.Text.Trim()) || 
                String.IsNullOrEmpty(inputApellido.Text.Trim()) || 
                String.IsNullOrEmpty(inputEmail.Text.Trim()) ||
                String.IsNullOrEmpty(inputUsername.Text.Trim()) ||
                String.IsNullOrEmpty(inputPsw.Text.Trim());
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void btnVerPsw_MouseDown(object sender, MouseEventArgs e)
        {
            // Mostrar la password al mantener presionado el boton
            inputPsw.PasswordChar = '\0';
        }

        private void btnVerPsw_MouseUp(object sender, MouseEventArgs e)
        {
            // Ocultar la password al soltar el boton
            inputPsw.PasswordChar = '*';  
        }

    }
}
