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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        

        private void btnListarArbol_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvPermisos.Rows.Count <= 0) throw new Exception("No hay permisos para listar.");
                //DataGridViewRow filaSeleccionada = dgvPermisos.SelectedRows[0];
                //int idPermiso = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                
                treeView1.Nodes.Clear();

                BEPermiso p = new BEPermiso() { Id = 7, Nombre = "Gestionar usuarios", EsPadre = true };

                TreeNode root = new TreeNode(p.Nombre);
                root.Tag = p;
                treeView1.Nodes.Add(root);

                p.Hijos.Add(new BEPermiso() { Id = 4, Nombre = "Alta de usuario", EsPadre = false });
                p.Hijos.Add(new BEPermiso() { Id = 5, Nombre = "Baja de usuario", EsPadre = false });
                p.Hijos.Add(new BEPermiso() { Id = 6, Nombre = "Modificacion de usuario", EsPadre = false });

                foreach (var item in p.Hijos)
                    LlenarTreeNode(root, item);

                treeView1.ExpandAll();
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
    }
}
