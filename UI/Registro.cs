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
using Servicios.ValidadorEmail;

namespace UI
{
    public partial class Registro : Form
    {
        private bool emailValido = false;

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


        private BEUsuario ObtenerDatos()
        {
            try
            {
                if (CamposInvalidos()) throw new Exception("Los datos ingresados son incorrectos");
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

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValidadorEmail.Validar(inputEmail.Text.Trim()))
                {
                    toolTip1.SetToolTip(inputEmail, "");
                    emailValido = true;
                } 
                else
                {
                    toolTip1.SetToolTip(inputEmail, "Falta agregar el @ o el formato del email es incorrecto.");
                    emailValido = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

    }
}
