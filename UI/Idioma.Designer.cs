namespace UI
{
    partial class Idioma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ddIdiomas = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCambiarIdioma = new MetroFramework.Controls.MetroButton();
            this.dgvTraduccion = new MetroFramework.Controls.MetroGrid();
            this.labelTag = new System.Windows.Forms.Label();
            this.txtTraduccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // ddIdiomas
            // 
            this.ddIdiomas.AutoResize = false;
            this.ddIdiomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddIdiomas.Depth = 0;
            this.ddIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddIdiomas.DropDownHeight = 174;
            this.ddIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddIdiomas.DropDownWidth = 121;
            this.ddIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddIdiomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddIdiomas.FormattingEnabled = true;
            this.ddIdiomas.Hint = "Seleccionar Idioma";
            this.ddIdiomas.IntegralHeight = false;
            this.ddIdiomas.ItemHeight = 43;
            this.ddIdiomas.Location = new System.Drawing.Point(23, 63);
            this.ddIdiomas.MaxDropDownItems = 4;
            this.ddIdiomas.MouseState = MaterialSkin.MouseState.OUT;
            this.ddIdiomas.Name = "ddIdiomas";
            this.ddIdiomas.Size = new System.Drawing.Size(269, 49);
            this.ddIdiomas.StartIndex = 0;
            this.ddIdiomas.TabIndex = 1;
            this.ddIdiomas.Tag = "idiomasIdioma";
            this.ddIdiomas.SelectedIndexChanged += new System.EventHandler(this.ddIdiomas_SelectedIndexChanged);
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.Location = new System.Drawing.Point(298, 63);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(191, 49);
            this.btnCambiarIdioma.TabIndex = 2;
            this.btnCambiarIdioma.Tag = "btnCambiarIdioma";
            this.btnCambiarIdioma.Text = "Cambiar Idioma";
            this.btnCambiarIdioma.UseSelectable = true;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // dgvTraduccion
            // 
            this.dgvTraduccion.AllowUserToResizeRows = false;
            this.dgvTraduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTraduccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTraduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTraduccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTraduccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraduccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraduccion.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTraduccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTraduccion.EnableHeadersVisualStyles = false;
            this.dgvTraduccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTraduccion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTraduccion.Location = new System.Drawing.Point(23, 138);
            this.dgvTraduccion.MultiSelect = false;
            this.dgvTraduccion.Name = "dgvTraduccion";
            this.dgvTraduccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraduccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTraduccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTraduccion.RowTemplate.Height = 33;
            this.dgvTraduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraduccion.Size = new System.Drawing.Size(714, 416);
            this.dgvTraduccion.TabIndex = 3;
            this.dgvTraduccion.SelectionChanged += new System.EventHandler(this.dgvTraduccion_SelectionChanged);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(745, 138);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(55, 25);
            this.labelTag.TabIndex = 4;
            this.labelTag.Tag = "labelTag";
            this.labelTag.Text = "Tag:";
            // 
            // txtTraduccion
            // 
            this.txtTraduccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTraduccion.AnimateReadOnly = false;
            this.txtTraduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTraduccion.Depth = 0;
            this.txtTraduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTraduccion.LeadingIcon = null;
            this.txtTraduccion.Location = new System.Drawing.Point(748, 185);
            this.txtTraduccion.Margin = new System.Windows.Forms.Padding(6);
            this.txtTraduccion.MaxLength = 50;
            this.txtTraduccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTraduccion.Multiline = false;
            this.txtTraduccion.Name = "txtTraduccion";
            this.txtTraduccion.Size = new System.Drawing.Size(319, 50);
            this.txtTraduccion.TabIndex = 9;
            this.txtTraduccion.Tag = "";
            this.txtTraduccion.Text = "";
            this.txtTraduccion.TrailingIcon = null;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.AutoSize = false;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = global::UI.Properties.Resources.Right;
            this.btnModificar.Location = new System.Drawing.Point(748, 253);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(319, 91);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Tag = "btnIdiomasModificar";
            this.btnModificar.Text = "Modificar Traducción";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = true;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 633);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtTraduccion);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.dgvTraduccion);
            this.Controls.Add(this.btnCambiarIdioma);
            this.Controls.Add(this.ddIdiomas);
            this.Name = "Idioma";
            this.Tag = "formIdioma";
            this.Text = "Idiomas";
            this.Load += new System.EventHandler(this.Idioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox ddIdiomas;
        private MetroFramework.Controls.MetroButton btnCambiarIdioma;
        private MetroFramework.Controls.MetroGrid dgvTraduccion;
        private System.Windows.Forms.Label labelTag;
        private MaterialSkin.Controls.MaterialTextBox txtTraduccion;
        private MaterialSkin.Controls.MaterialButton btnModificar;
    }
}