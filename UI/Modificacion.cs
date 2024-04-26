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
    public partial class Modificacion : Form
    {
        private int idUsuario;

        public Modificacion(int id)
        {
            InitializeComponent();
            this.idUsuario = id;
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            BEUsuario usuario = BLLUsuario.ObtenerUsuario(idUsuario);
            labelId.Text = Convert.ToString(idUsuario);
            inputNombre.Text = usuario.Nombre;
            inputApellido.Text = usuario.Apellido;
            inputEmail.Text = usuario.Email;
            inputUsername.Text = usuario.Username;
            inputPsw.Text = usuario.Password;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = new BEUsuario(idUsuario);
                usuario.Nombre = inputNombre.Text;
                usuario.Apellido = inputApellido.Text;
                usuario.Email = inputEmail.Text;
                usuario.Username = inputUsername.Text;

                bool guardado = BLLUsuario.Guardar(usuario);

                if (guardado) this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
