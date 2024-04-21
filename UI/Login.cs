using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraccion;
using BE;
using BLL;
using Servicios.SesionManager;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario u = new BEUsuario()
                {
                    Username = inputUsuario.Text,
                    Password = inputPsw.Text
                };

                bool valido = BLLUsuario.Buscar(u);
                if (!valido)
                {
                    MessageBox.Show(
                        $"Credenciales incorrectas. Por favor vuelva a ingresar los datos.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                IUsuario usuario = new BEUsuario
                {
                    Username = u.Username,
                    Password = u.Password
                };

                SesionManager.Login(usuario);
                MessageBox.Show(
                    $"Usuario logeado: {SesionManager.ObtenerDatosUsuario()}",
                    "Logeado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Sistema sistema = new Sistema();
                sistema.Show();
                Hide();    
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro formRegistro = new Registro();
            formRegistro.Show();

        }
    }
  
}
