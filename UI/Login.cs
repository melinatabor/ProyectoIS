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
                // Validar usuario
                


                IUsuario usuario = new BEUsuario
                {
                    Username = inputUsuario.Text,
                    Password = inputPsw.Text
                };

                SesionManager.Login(usuario);

                MessageBox.Show(
                    $"Usuario logeado papa: {SesionManager.ObtenerDatosUsuario()}",
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
