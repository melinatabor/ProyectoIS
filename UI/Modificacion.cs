using BE;
using BLL;
using Servicios.SesionManager;
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
    public partial class Modificacion : MetroFramework.Forms.MetroForm
    {
        private int idUsuario;

        public Modificacion(int id)
        {
            InitializeComponent();
            this.idUsuario = id;
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = BLLUsuario.ObtenerUsuario(idUsuario);
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtEmail.Text = usuario.Email;
                txtUsername.Text = usuario.Username;
                txtPsw.Text = usuario.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = new BEUsuario(idUsuario);
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Email = txtEmail.Text;
                usuario.Username = txtUsername.Text;

                DialogResult respuesta = MessageBox.Show($"¿Esta seguro que desea modificar el usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    bool guardado = BLLUsuario.Editar(usuario);
                    if (guardado)
                    {
                        RegistrarBitacora($"El usuario ha modificado un usuario", BEBitacora.BitacoraTipo.INFO);
                        MessageBox.Show("Usuario modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
                return;
            }
        }
    }
}
