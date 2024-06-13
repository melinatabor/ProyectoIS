namespace UI
{
    partial class UsuarioHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuariosHistoricos = new MetroFramework.Controls.MetroGrid();
            this.inputUsuarios = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscarVersiones = new MaterialSkin.Controls.MaterialButton();
            this.btnRestaurarVersion = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosHistoricos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosHistoricos
            // 
            this.dgvUsuariosHistoricos.AllowUserToAddRows = false;
            this.dgvUsuariosHistoricos.AllowUserToDeleteRows = false;
            this.dgvUsuariosHistoricos.AllowUserToResizeRows = false;
            this.dgvUsuariosHistoricos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuariosHistoricos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosHistoricos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuariosHistoricos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosHistoricos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuariosHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosHistoricos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuariosHistoricos.EnableHeadersVisualStyles = false;
            this.dgvUsuariosHistoricos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuariosHistoricos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuariosHistoricos.Location = new System.Drawing.Point(23, 160);
            this.dgvUsuariosHistoricos.Name = "dgvUsuariosHistoricos";
            this.dgvUsuariosHistoricos.ReadOnly = true;
            this.dgvUsuariosHistoricos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosHistoricos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuariosHistoricos.RowHeadersWidth = 82;
            this.dgvUsuariosHistoricos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuariosHistoricos.RowTemplate.Height = 33;
            this.dgvUsuariosHistoricos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosHistoricos.Size = new System.Drawing.Size(728, 267);
            this.dgvUsuariosHistoricos.TabIndex = 0;
            // 
            // inputUsuarios
            // 
            this.inputUsuarios.AnimateReadOnly = false;
            this.inputUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsuarios.Depth = 0;
            this.inputUsuarios.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputUsuarios.Hint = "Usuario";
            this.inputUsuarios.LeadingIcon = null;
            this.inputUsuarios.Location = new System.Drawing.Point(23, 95);
            this.inputUsuarios.MaxLength = 50;
            this.inputUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.inputUsuarios.Multiline = false;
            this.inputUsuarios.Name = "inputUsuarios";
            this.inputUsuarios.Size = new System.Drawing.Size(267, 50);
            this.inputUsuarios.TabIndex = 1;
            this.inputUsuarios.Text = "";
            this.inputUsuarios.TrailingIcon = null;
            // 
            // btnBuscarVersiones
            // 
            this.btnBuscarVersiones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarVersiones.Depth = 0;
            this.btnBuscarVersiones.HighEmphasis = true;
            this.btnBuscarVersiones.Icon = null;
            this.btnBuscarVersiones.Location = new System.Drawing.Point(297, 95);
            this.btnBuscarVersiones.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarVersiones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarVersiones.Name = "btnBuscarVersiones";
            this.btnBuscarVersiones.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarVersiones.Size = new System.Drawing.Size(223, 50);
            this.btnBuscarVersiones.TabIndex = 2;
            this.btnBuscarVersiones.Tag = "btnBuscar";
            this.btnBuscarVersiones.Text = "Buscar";
            this.btnBuscarVersiones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarVersiones.UseAccentColor = false;
            this.btnBuscarVersiones.UseVisualStyleBackColor = true;
            this.btnBuscarVersiones.Click += new System.EventHandler(this.btnBuscarVersiones_Click);
            // 
            // btnRestaurarVersion
            // 
            this.btnRestaurarVersion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRestaurarVersion.Depth = 0;
            this.btnRestaurarVersion.HighEmphasis = true;
            this.btnRestaurarVersion.Icon = null;
            this.btnRestaurarVersion.Location = new System.Drawing.Point(528, 95);
            this.btnRestaurarVersion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestaurarVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestaurarVersion.Name = "btnRestaurarVersion";
            this.btnRestaurarVersion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRestaurarVersion.Size = new System.Drawing.Size(223, 50);
            this.btnRestaurarVersion.TabIndex = 3;
            this.btnRestaurarVersion.Tag = "btnRestaurarVersion";
            this.btnRestaurarVersion.Text = "Restaurar Version";
            this.btnRestaurarVersion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRestaurarVersion.UseAccentColor = false;
            this.btnRestaurarVersion.UseVisualStyleBackColor = true;
            // 
            // UsuarioHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnRestaurarVersion);
            this.Controls.Add(this.btnBuscarVersiones);
            this.Controls.Add(this.inputUsuarios);
            this.Controls.Add(this.dgvUsuariosHistoricos);
            this.Name = "UsuarioHistorico";
            this.Tag = "formUsuarioHistorico";
            this.Text = "Usuarios Históricos";
            this.Load += new System.EventHandler(this.UsuarioHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosHistoricos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvUsuariosHistoricos;
        private MaterialSkin.Controls.MaterialTextBox inputUsuarios;
        private MaterialSkin.Controls.MaterialButton btnBuscarVersiones;
        private MaterialSkin.Controls.MaterialButton btnRestaurarVersion;
    }
}