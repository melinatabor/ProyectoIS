using Abstraccion;
using BE;
using BLL;
using MetroFramework;
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
    public partial class UsuarioHistorico : MetroFramework.Forms.MetroForm, ISubscriptor
    {
        public UsuarioHistorico()
        {
            InitializeComponent();
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
                            control.Text = palabra.Traduccion;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Actualizar Usuarios Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UsuarioHistorico_Load(object sender, EventArgs e)
        {
            try
            {
                Subscribirse();
                Actualizar();
                //ActualizarDGV();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarDGV(List<BEUsuario> lista)
        {
            try
            {
                dgvUsuariosHistoricos.DataSource = null;
                dgvUsuariosHistoricos.DataSource = lista;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBuscarVersiones_Click(object sender, EventArgs e)
        {
            try
            {
                string username = inputUsuarios.Text;

                List<BEUsuario> lista = BLLUsuario.FiltrarHistoricosPorUsername(username);

                if (lista.Count > 0) 
                    ActualizarDGV(lista);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
