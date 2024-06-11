using BE;
using BLL;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class Permiso : MetroFramework.Forms.MetroForm
    {
        public Permiso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEPermiso permiso = new BEPermiso() { Nombre = txtNombre.Text };

                bool alta = BLLPermiso.AgregarPermisoSimple(permiso);

                if (alta)
                {
                    MetroMessageBox.Show(this, "Permiso agregado correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDGV();
                }
                
                Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Permiso_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ActualizarDGV()
        {
            try
            {
                dgvPermisos.DataSource = null;
                dgvPermisos.DataSource = BLLPermiso.ListarPermisos();


                dgvFamilia.DataSource = null;
                dgvFamilia.DataSource = BLLPermiso.ListarFamilias();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LlenarTreeNode(TreeNode tree, BEPermiso permiso)
        {
            TreeNode treenode = new TreeNode(permiso.Nombre);

            treenode.Tag = permiso;
            tree.Nodes.Add(treenode);
            if (permiso.Hijos != null)
                foreach (var item in permiso.Hijos)
                {
                    LlenarTreeNode(treenode, item);
                }

        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                BEPermiso permiso = new BEPermiso() { Nombre = txtFamilia.Text };

                bool alta = BLLPermiso.AgregarFamilia(permiso);

                if (alta)
                {
                    MetroMessageBox.Show(this, "Familia agregada correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDGV();
                }

                Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPermisos.SelectedRows.Count <= 0)    throw new Exception("Seleccione un permiso para agregar.");
                
                if (dgvFamilia.SelectedRows.Count <= 0)     throw new Exception("Seleccione una familia.");

                DataGridViewRow filaSeleccionada = dgvPermisos.SelectedRows[0];

                int idPermiso = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                BEPermiso permiso = BLLPermiso.BuscarPermiso(idPermiso);

                if (permiso == null) throw new Exception("El permiso no existe.");

                DataGridViewRow filaSeleccionadaFamilia = dgvFamilia.SelectedRows[0];

                int idFamilia = Convert.ToInt32(filaSeleccionadaFamilia.Cells[0].Value);

                BEPermiso familia = BLLPermiso.BuscarFamilia(idFamilia);

                if (familia == null) throw new Exception("La familia no existe.");

                bool alta = BLLPermiso.AgregarPermisoAFamilia(permiso, familia);

                if (alta)
                    MetroMessageBox.Show(this, "Permiso agregado a familia correctamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnListarRecursivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFamilia.SelectedRows.Count <= 0) throw new Exception("Seleccione una familia.");

                BEPermiso familiaSeleccionada = (BEPermiso)dgvFamilia.CurrentRow.DataBoundItem;

                ListarArbolRecursivo(familiaSeleccionada);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ListarArbolRecursivo(BEPermiso familia)
        {
            try
            {
                treeView1.Nodes.Clear();

                TreeNode root = new TreeNode(familia.Nombre);
                root.Tag = familia;
                treeView1.Nodes.Add(root);

                List<BEPermiso> hijos = BLLPermiso.ListarHijosRecursivo(familia);

                foreach (var item in hijos)
                    LlenarTreeNode(root, item);

                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
