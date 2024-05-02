namespace UI
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.txtPsw = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegistrarme = new MaterialSkin.Controls.MaterialButton();
            this.btnShowPsw = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(43, 150);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(340, 50);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.Tag = "";
            this.txtApellido.Text = "";
            this.tooltip.SetToolTip(this.txtApellido, "Aquí debes escribir tu apellido.");
            this.txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(43, 80);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 50);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.Tag = "";
            this.txtNombre.Text = "";
            this.tooltip.SetToolTip(this.txtNombre, "Aquí debes escribir tu nombre.");
            this.txtNombre.TrailingIcon = null;
            // 
            // tooltip
            // 
            this.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "Ayuda:";
            // 
            // txtPsw
            // 
            this.txtPsw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPsw.AnimateReadOnly = false;
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPsw.Depth = 0;
            this.txtPsw.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPsw.Hint = "Contraseña";
            this.txtPsw.LeadingIcon = global::UI.Properties.Resources.Password;
            this.txtPsw.Location = new System.Drawing.Point(43, 356);
            this.txtPsw.MaxLength = 50;
            this.txtPsw.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPsw.Multiline = false;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Password = true;
            this.txtPsw.Size = new System.Drawing.Size(278, 50);
            this.txtPsw.TabIndex = 16;
            this.txtPsw.Tag = "";
            this.txtPsw.Text = "";
            this.tooltip.SetToolTip(this.txtPsw, "Aquí debes escribir una contraseña.");
            this.txtPsw.TrailingIcon = null;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Usuario";
            this.txtUsername.LeadingIcon = global::UI.Properties.Resources.Username;
            this.txtUsername.Location = new System.Drawing.Point(43, 287);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(340, 50);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.Tag = "";
            this.txtUsername.Text = "";
            this.tooltip.SetToolTip(this.txtUsername, "Aquí debes escribir un nombre de usuario válido.");
            this.txtUsername.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = global::UI.Properties.Resources.Correo;
            this.txtEmail.Location = new System.Drawing.Point(43, 220);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 50);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Tag = "";
            this.txtEmail.Text = "";
            this.tooltip.SetToolTip(this.txtEmail, "Aquí debes escribir tu email.");
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrarme.AutoSize = false;
            this.btnRegistrarme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarme.Depth = 0;
            this.btnRegistrarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarme.HighEmphasis = true;
            this.btnRegistrarme.Icon = global::UI.Properties.Resources.Registro;
            this.btnRegistrarme.Location = new System.Drawing.Point(128, 435);
            this.btnRegistrarme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarme.Size = new System.Drawing.Size(161, 55);
            this.btnRegistrarme.TabIndex = 18;
            this.btnRegistrarme.Text = "Registrarme";
            this.btnRegistrarme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarme.UseAccentColor = true;
            this.btnRegistrarme.UseVisualStyleBackColor = true;
            this.btnRegistrarme.Click += new System.EventHandler(this.btnRegistrarme_Click);
            // 
            // btnShowPsw
            // 
            this.btnShowPsw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShowPsw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowPsw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPsw.Depth = 0;
            this.btnShowPsw.Icon = global::UI.Properties.Resources.Visible;
            this.btnShowPsw.Location = new System.Drawing.Point(327, 348);
            this.btnShowPsw.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowPsw.Name = "btnShowPsw";
            this.btnShowPsw.Size = new System.Drawing.Size(59, 69);
            this.btnShowPsw.TabIndex = 17;
            this.btnShowPsw.UseVisualStyleBackColor = true;
            this.btnShowPsw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPsw_MouseDown);
            this.btnShowPsw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPsw_MouseUp);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 512);
            this.Controls.Add(this.btnRegistrarme);
            this.Controls.Add(this.btnShowPsw);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registro";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Registro:";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tooltip;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPsw;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnShowPsw;
        private MaterialSkin.Controls.MaterialButton btnRegistrarme;
    }
}