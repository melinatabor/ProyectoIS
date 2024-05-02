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
using System.Text.RegularExpressions;
using Servicios.SesionManager;
using Servicios.Validador;

namespace UI
{
    public partial class Registro : MetroFramework.Forms.MetroForm
    {
        private bool emailValido = false;

        public Registro()
        {
            InitializeComponent();
        }


        private BEUsuario ObtenerDatos()
        {
            try
            {
                if (CamposInvalidos()) throw new Exception("Los datos ingresados son incorrectos");
                return new BEUsuario()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPsw.Text,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(txtNombre.Text.Trim()) || 
                String.IsNullOrEmpty(txtApellido.Text.Trim()) || 
                String.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                String.IsNullOrEmpty(txtUsername.Text.Trim()) ||
                String.IsNullOrEmpty(txtPsw.Text.Trim());
        }


        private void RegistrarBitacora(BEUsuario usuario, string mensaje, BEBitacora.BitacoraTipo tipo = BEBitacora.BitacoraTipo.INFO)
        {
            try
            {
                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuario.Id,
                    Tipo = tipo,
                    Mensaje = mensaje
                };

                BLLBitacora.Agregar(bitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario nuevoUsuario = ObtenerDatos();

                if (nuevoUsuario is null) throw new Exception("Debe completar todos los campos, por favor.");
                if (!emailValido) throw new Exception("El email no es válido. Falta agregar el @ o el formato del email es incorrecto.");
                bool alta = BLLUsuario.Agregar(nuevoUsuario);

                if (alta)
                {
                    MessageBox.Show("Usuario agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevoUsuario = BLLUsuario.BuscarUsuarioPorUsername(nuevoUsuario.Username);
                    RegistrarBitacora(nuevoUsuario, $"Se ha registrado un nuevo usuario con Id: {nuevoUsuario.Id}");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Validador.Validar(txtEmail.Text.Trim(), Validador.TipoValidacion.Email))
                {
                    toolTip1.SetToolTip(txtEmail, "");
                    emailValido = true;
                }
                else
                {
                    toolTip1.SetToolTip(txtEmail, "Falta agregar el @ o el formato del email es incorrecto.");
                    emailValido = false;
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
