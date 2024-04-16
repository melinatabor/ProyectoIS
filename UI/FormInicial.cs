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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Prueba();
        }

        private void Prueba()
        {
            BECliente c = new BECliente()
            {
                Nombre      = "Nombre Test",
                Apellido    = "Apellido Test",
                Email       = "Email Test",
            };
            BLLCliente.Agregar(c);
        }
    }
}
