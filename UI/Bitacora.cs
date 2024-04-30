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
    public partial class Bitacora : Form
    {
        private int _pagina = 1;
        private int _rowsPerPage = 5;

        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            try
            {
                labelPagina.Text = "Pagina: " + _pagina.ToString();

                dtDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                dtHasta.Value = DateTime.Now;

                dropdownTipo.Items.Clear();
                dropdownTipo.Items.Add(BEBitacora.BitacoraTipo.INFO);
                dropdownTipo.Items.Add(BEBitacora.BitacoraTipo.ERROR);
                dropdownTipo.Items.Add(BEBitacora.BitacoraTipo.ALL);

                dropdownUsuario.Items.Clear();
                foreach (BEUsuario usuario in BLLUsuario.Listar())
                    dropdownUsuario.Items.Add(usuario.Username);

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtDesde.Value,
                    Hasta = dtHasta.Value,
                    Tipo = null,
                    Usuario = null,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = BLLBitacora.Filtrar(criteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina = 1;

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde   = dtDesde.Value,
                    Hasta   = dtHasta.Value,
                    Tipo    = dropdownTipo.SelectedIndex + 1,
                    Usuario = dropdownUsuario.Text,
                    Page    = _pagina,
                    RowPerPage = _rowsPerPage
                };
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = BLLBitacora.Filtrar(criteria);

                labelPagina.Text = "Pagina: " + _pagina.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina -= 1;

                if (_pagina <= 1)
                {
                    button1.Enabled = false;
                }

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtDesde.Value,
                    Hasta = dtHasta.Value,
                    Tipo = dropdownTipo.SelectedIndex + 1,
                    Usuario = dropdownUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = BLLBitacora.Filtrar(criteria);

                button2.Enabled = true;

                labelPagina.Text = "Pagina: " + _pagina.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina += 1;

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtDesde.Value,
                    Hasta = dtHasta.Value,
                    Tipo = dropdownTipo.SelectedIndex + 1,
                    Usuario = dropdownUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };

                var results = BLLBitacora.Filtrar(criteria);

                if (results.Count < _rowsPerPage) 
                    button2.Enabled = false; 
                
                else
                    button2.Enabled = true;

                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = results;

                button1.Enabled = true;

                labelPagina.Text = "Pagina: " + _pagina.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
