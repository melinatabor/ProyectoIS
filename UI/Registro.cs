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
using MetroFramework;

namespace UI
{
    public partial class Registro : MetroFramework.Forms.MetroForm
    {
        private bool emailValido = false;
        private bool pswValida = false;

        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario nuevoUsuario = ObtenerDatos();

                if (nuevoUsuario is null) throw new Exception("Debe completar todos los campos, por favor.");
                if (!emailValido) throw new Exception("El email no es válido. Cumplir con el formato: usuario@example.com");
                if (!pswValida) throw new Exception("La contraseña no es válida.");
                bool alta = BLLUsuario.Agregar(nuevoUsuario);

                if (alta)
                {
                    MetroMessageBox.Show(this, "Usuario agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevoUsuario = BLLUsuario.BuscarUsuarioPorUsername(nuevoUsuario.Username);
                    RegistrarBitacora(nuevoUsuario, $"Se ha registrado un nuevo usuario con Id: {nuevoUsuario.Id}");
                }
                Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnShowPsw_MouseUp(object sender, MouseEventArgs e)
        {
            txtPsw.Password = true;
        }

        private void btnShowPsw_MouseDown(object sender, MouseEventArgs e)
        {
            txtPsw.Password = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Validador.Validar(txtEmail.Text.Trim(), Validador.TipoValidacion.Email))
                {
                    tooltip.SetToolTip(txtEmail, "");
                    emailValido = true;
                }
                else
                {
                    tooltip.SetToolTip(txtEmail, "Debe tener este formato usuario@example.com \r\n" +
                        "Agregue el @ y un dominio válido.");
                    emailValido = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Validador.Validar(txtPsw.Text.Trim(), Validador.TipoValidacion.Password))
                {
                    tooltip.SetToolTip(txtPsw, "");
                    pswValida = true;
                }
                else
                {
                    tooltip.SetToolTip(txtPsw, "Requiere al menos una letra minúscula.\r\n" +
                    "Requiere al menos una letra mayúscula.\r\n" +
                    "Requiere al menos un dígito.\r\n" +
                    "Requiere al menos un carácter especial entre @, $, !, %, *, ? o &.\r\n" +
                    "Debe tener al menos 8 caracteres de longitud.");
                    pswValida = false;

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
