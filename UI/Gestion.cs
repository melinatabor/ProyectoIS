using Abstraccion;
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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void ActualizarDgv()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BLLUsuario.Listar();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.Rows.Count <= 0) throw new Exception("No hay usuarios para modificar.");
                if (dgvUsuarios.SelectedRows.Count <= 0) throw new Exception("Selecciona una fila para modificar.");

                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                Modificacion modificacion = new Modificacion(idUsuario);
                modificacion.Show();
                modificacion.FormClosed += (s, args) => ActualizarDgv();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.Rows.Count <= 0) throw new Exception("No hay usuarios para eliminar.");
                if (dgvUsuarios.SelectedRows.Count <= 0) throw new Exception("Selecciona una fila para eliminar.");
                BEUsuario usuario = (BEUsuario)dgvUsuarios.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show($"¿Esta seguro que desea eliminar el usuario de {usuario.Nombre} {usuario.Apellido}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
                if(respuesta == DialogResult.Yes)
                {
                    bool eliminado = BLLUsuario.Eliminar(usuario);
                    if (eliminado) ActualizarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Registro registro = new Registro();
                registro.Show();
                registro.FormClosed += (s, args) => ActualizarDgv();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
