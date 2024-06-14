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
using Servicios.SesionManager;

namespace UI
{
    public partial class Idioma : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        private string _tag = "Traducción para ";

        public Idioma()
        {
            InitializeComponent();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgv();
                Subscribirse();
                Actualizar();

                ddIdiomas.DataSource = null;
                ddIdiomas.DataSource = BLLIdioma.Listar();
                ddIdiomas.DisplayMember = "Idioma";
                ddIdiomas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ActualizarDgv(int idIdioma = 1)
        {
            try
            {
                List<BETraduccion> lista = BLLTraduccion.Listar(idIdioma);

                dgvTraduccion.DataSource = null;
                dgvTraduccion.DataSource = lista;

                bool deshabilitarBtn = lista.Any(t => string.IsNullOrEmpty(t.Traduccion));
                btnCambiarIdioma.Enabled = !deshabilitarBtn;
            }
            catch (Exception ex)
            {
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
                    {
                        this.Text = palabra.Traduccion;
                        this.Refresh();
                    }
                }

                // Actualizar controles
                foreach (Control control in Controls)
                {
                    if (control.Tag != null && control.Tag.ToString() != "")
                    {
                        BEPalabra palabra = palabras.Find(pal => pal.Tag.Equals(control.Tag.ToString()));
                        if (palabra != null)
                        {
                            if (control is Label label && label.Name == "labelTag")
                            {
                                label.Text = _tag = palabra.Traduccion;
                            }
                            else if (control is MaterialSkin.Controls.MaterialComboBox materialComboBox)
                            {
                                materialComboBox.Hint = palabra.Traduccion;
                            }
                            else
                            {
                                control.Text = palabra.Traduccion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                BEIdioma idioma = (BEIdioma) ddIdiomas.SelectedItem;
                if (idioma != null)
                {
                    BLLIdioma.CambiarIdioma(idioma.Id);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Idioma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ddIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddIdiomas.SelectedValue != null && ddIdiomas.SelectedValue is int selectedId)
            {
                ActualizarDgv(selectedId);
            }
        }

        private void dgvTraduccion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTraduccion.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTraduccion.SelectedRows[0];

                string tag = selectedRow.Cells[1].Value.ToString();
                string traduccion = selectedRow.Cells[3].Value.ToString();

                labelTag.Text = _tag + tag + ":";
                txtTraduccion.Hint = traduccion;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvTraduccion.SelectedRows[0];
                int tag = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                int idioma = Convert.ToInt32(ddIdiomas.SelectedValue);
                bool isTraduccionActual = selectedRow.Cells[3].Value.ToString() != "";

                DialogResult result = MetroMessageBox.Show(this, "¿Está seguro que desea modificar la traducción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (isTraduccionActual) BLLTraduccion.Modificar(idioma, tag, txtTraduccion.Text);
                    else BLLTraduccion.Agregar(idioma, tag, txtTraduccion.Text);
                    ActualizarDgv(idioma);
                    txtTraduccion.Text = "";
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
