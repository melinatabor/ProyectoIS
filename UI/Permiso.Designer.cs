namespace UI
{
    partial class Permiso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.dgvPermisos = new MetroFramework.Controls.MetroGrid();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dgvFamilia = new MetroFramework.Controls.MetroGrid();
            this.btnAgregarFamilia = new MaterialSkin.Controls.MaterialButton();
            this.txtFamilia = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPermiso = new MaterialSkin.Controls.MaterialButton();
            this.btnListarRecursivo = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(23, 363);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 50);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::UI.Properties.Resources.Registro;
            this.btnAgregar.Location = new System.Drawing.Point(329, 365);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(294, 55);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = true;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AllowUserToResizeRows = false;
            this.dgvPermisos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermisos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPermisos.EnableHeadersVisualStyles = false;
            this.dgvPermisos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPermisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPermisos.Location = new System.Drawing.Point(23, 75);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPermisos.RowHeadersWidth = 82;
            this.dgvPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPermisos.RowTemplate.Height = 33;
            this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisos.Size = new System.Drawing.Size(693, 268);
            this.dgvPermisos.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(796, 75);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(435, 669);
            this.treeView1.TabIndex = 10;
            // 
            // dgvFamilia
            // 
            this.dgvFamilia.AllowUserToAddRows = false;
            this.dgvFamilia.AllowUserToDeleteRows = false;
            this.dgvFamilia.AllowUserToResizeRows = false;
            this.dgvFamilia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamilia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFamilia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFamilia.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFamilia.EnableHeadersVisualStyles = false;
            this.dgvFamilia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFamilia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFamilia.Location = new System.Drawing.Point(11, 33);
            this.dgvFamilia.Name = "dgvFamilia";
            this.dgvFamilia.ReadOnly = true;
            this.dgvFamilia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilia.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFamilia.RowHeadersWidth = 82;
            this.dgvFamilia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFamilia.RowTemplate.Height = 33;
            this.dgvFamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilia.Size = new System.Drawing.Size(640, 268);
            this.dgvFamilia.TabIndex = 14;
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarFamilia.AutoSize = false;
            this.btnAgregarFamilia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarFamilia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarFamilia.Depth = 0;
            this.btnAgregarFamilia.HighEmphasis = true;
            this.btnAgregarFamilia.Icon = global::UI.Properties.Resources.Registro;
            this.btnAgregarFamilia.Location = new System.Drawing.Point(326, 301);
            this.btnAgregarFamilia.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnAgregarFamilia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarFamilia.Size = new System.Drawing.Size(193, 55);
            this.btnAgregarFamilia.TabIndex = 13;
            this.btnAgregarFamilia.Text = "Agregar Familia";
            this.btnAgregarFamilia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarFamilia.UseAccentColor = true;
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // txtFamilia
            // 
            this.txtFamilia.AnimateReadOnly = false;
            this.txtFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFamilia.Depth = 0;
            this.txtFamilia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFamilia.Hint = "Familia";
            this.txtFamilia.LeadingIcon = null;
            this.txtFamilia.Location = new System.Drawing.Point(11, 306);
            this.txtFamilia.MaxLength = 50;
            this.txtFamilia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFamilia.Multiline = false;
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(294, 50);
            this.txtFamilia.TabIndex = 12;
            this.txtFamilia.Text = "";
            this.txtFamilia.TrailingIcon = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarPermiso);
            this.groupBox1.Controls.Add(this.dgvFamilia);
            this.groupBox1.Controls.Add(this.txtFamilia);
            this.groupBox1.Controls.Add(this.btnAgregarFamilia);
            this.groupBox1.Location = new System.Drawing.Point(23, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 376);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familias";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarPermiso.AutoSize = false;
            this.btnAgregarPermiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPermiso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPermiso.Depth = 0;
            this.btnAgregarPermiso.HighEmphasis = true;
            this.btnAgregarPermiso.Icon = global::UI.Properties.Resources.Registro;
            this.btnAgregarPermiso.Location = new System.Drawing.Point(530, 301);
            this.btnAgregarPermiso.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnAgregarPermiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarPermiso.Size = new System.Drawing.Size(193, 55);
            this.btnAgregarPermiso.TabIndex = 15;
            this.btnAgregarPermiso.Text = "Agregar Permiso";
            this.btnAgregarPermiso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPermiso.UseAccentColor = true;
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnListarRecursivo
            // 
            this.btnListarRecursivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarRecursivo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListarRecursivo.Depth = 0;
            this.btnListarRecursivo.HighEmphasis = true;
            this.btnListarRecursivo.Icon = null;
            this.btnListarRecursivo.Location = new System.Drawing.Point(937, 753);
            this.btnListarRecursivo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListarRecursivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarRecursivo.Name = "btnListarRecursivo";
            this.btnListarRecursivo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListarRecursivo.Size = new System.Drawing.Size(152, 36);
            this.btnListarRecursivo.TabIndex = 16;
            this.btnListarRecursivo.Text = "Listar Arbol";
            this.btnListarRecursivo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListarRecursivo.UseAccentColor = false;
            this.btnListarRecursivo.UseVisualStyleBackColor = true;
            this.btnListarRecursivo.Click += new System.EventHandler(this.btnListarRecursivo_Click);
            // 
            // Permiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 1288);
            this.Controls.Add(this.btnListarRecursivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Permiso";
            this.Text = "Permiso";
            this.Load += new System.EventHandler(this.Permiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MetroFramework.Controls.MetroGrid dgvPermisos;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroGrid dgvFamilia;
        private MaterialSkin.Controls.MaterialButton btnAgregarFamilia;
        private MaterialSkin.Controls.MaterialTextBox txtFamilia;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnAgregarPermiso;
        private MaterialSkin.Controls.MaterialButton btnListarRecursivo;
    }
}