using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using MetroFramework;

namespace UI
{
    public partial class Idioma : MetroFramework.Forms.MetroForm
    {
        public Idioma()
        {
            InitializeComponent();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void ActualizarDgv()
        {
            try
            {
                gridIdiomas.DataSource = null;
                gridIdiomas.DataSource = BLLIdioma.Listar();
            }
            catch (Exception ex)
            {
                //RegistrarBitacora(ex.Message, BEBitacora.BitacoraTipo.ERROR);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
