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
            inputNombre.Text = usuario.Nombre;
            inputApellido.Text = usuario.Apellido;
            inputEmail.Text = usuario.Email;
            inputUsername.Text = usuario.Username;
            inputPsw.Text = usuario.Password;
        }
    }
}
