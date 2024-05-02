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
    public partial class Bitacora : MetroFramework.Forms.MetroForm
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

                dtFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
                dtTo.Value = DateTime.Now;

                comboBoxTipo.Items.Clear();
                comboBoxTipo.Items.Add(BEBitacora.BitacoraTipo.INFO);
                comboBoxTipo.Items.Add(BEBitacora.BitacoraTipo.ERROR);
                comboBoxTipo.Items.Add(BEBitacora.BitacoraTipo.ALL);

                comboBoxUsuario.Items.Clear();
                foreach (BEUsuario usuario in BLLUsuario.Listar())
                    comboBoxUsuario.Items.Add(usuario.Username);

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = null,
                    Usuario = null,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                gridBitacora.DataSource = null;
                gridBitacora.DataSource = BLLBitacora.Filtrar(criteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina -= 1;

                if (_pagina <= 1)
                {
                    btnLeft.Enabled = false;
                }

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = comboBoxTipo.SelectedIndex + 1,
                    Usuario = comboBoxUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                gridBitacora.DataSource = null;
                gridBitacora.DataSource = BLLBitacora.Filtrar(criteria);

                btnRight.Enabled = true;

                labelPagina.Text = "Pagina: " + _pagina.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                _pagina += 1;

                BEBitacoraCriteria criteria = new BEBitacoraCriteria()
                {
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = comboBoxTipo.SelectedIndex + 1,
                    Usuario = comboBoxUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };

                var results = BLLBitacora.Filtrar(criteria);

                if (results.Count < _rowsPerPage)
                    btnRight.Enabled = false;

                else
                    btnRight.Enabled = true;

                gridBitacora.DataSource = null;
                gridBitacora.DataSource = results;

                btnLeft.Enabled = true;

                labelPagina.Text = "Pagina: " + _pagina.ToString();
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
                    Desde = dtFrom.Value,
                    Hasta = dtTo.Value,
                    Tipo = comboBoxTipo.SelectedIndex + 1,
                    Usuario = comboBoxUsuario.Text,
                    Page = _pagina,
                    RowPerPage = _rowsPerPage
                };
                gridBitacora.DataSource = null;
                gridBitacora.DataSource = BLLBitacora.Filtrar(criteria);

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
