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
                    RegistrarBitacora("Ha registrado un nuevo usuario");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
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
            catch (Exception ex)
            {
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
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
                string email = inputEmail.Text.Trim();


                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    toolTip1.SetToolTip(inputEmail, "Falta agregar el @ o el formato del email es incorrecto.");
                    emailValido = false;
                }
                else
                {
                    toolTip1.SetToolTip(inputEmail, "");
                    emailValido = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegistrarBitacora(string mensaje, BEBitacora.BitacoraTipo tipo = BEBitacora.BitacoraTipo.INFO)
        {
            try
            {
                string username = SesionManager.GetUsername();

                BEUsuario usuarioActual = BLLUsuario.BuscarUsuarioPorUsername(username) ?? throw new Exception($"No existe el username: {username}");

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioActual.Id,
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
