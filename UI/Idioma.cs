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
using MetroFramework;

namespace UI
{
    public partial class Idioma : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        public Idioma()
        {
            InitializeComponent();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
            Actualizar();
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

        public void Subscribirse()
        {
            try
            {
                BLLIdioma.RegistrarSubscriptor(this);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Subscriptor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Actualizar()
        {
            try
            {
                List<BEPalabra> palabras = BLLIdioma.ObtenerTags();

                // Actualizar el titulo del formulario
                if (this.Tag != null && this.Tag.ToString() != "")
                {
                    BEPalabra palabra = palabras.Find(pal => pal.Tag.Equals(this.Tag.ToString()));

                    if (palabra != null)
                        this.Text = palabra.Traduccion;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
