﻿namespace UI
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegistro = new MaterialSkin.Controls.MaterialButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPsw = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Ayuda:";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistro.AutoSize = false;
            this.btnRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistro.Depth = 0;
            this.btnRegistro.HighEmphasis = true;
            this.btnRegistro.Icon = global::UI.Properties.Resources.Registro;
            this.btnRegistro.Location = new System.Drawing.Point(152, 792);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistro.Size = new System.Drawing.Size(524, 129);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Tag = "btnRegistrarUsuario";
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistro.UseAccentColor = true;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(74, 140);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(684, 50);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Tag = "registroNombre";
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(74, 269);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(684, 50);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.Tag = "registroApellido";
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = global::UI.Properties.Resources.Correo;
            this.txtEmail.Location = new System.Drawing.Point(74, 400);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(684, 50);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Tag = "registroEmail";
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Usuario";
            this.txtUsername.LeadingIcon = global::UI.Properties.Resources.Username;
            this.txtUsername.Location = new System.Drawing.Point(74, 533);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(684, 50);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Tag = "registroUsuario";
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // txtPsw
            // 
            this.txtPsw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPsw.AnimateReadOnly = false;
            this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPsw.Depth = 0;
            this.txtPsw.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPsw.Hint = "Contraseña";
            this.txtPsw.LeadingIcon = global::UI.Properties.Resources.Password;
            this.txtPsw.Location = new System.Drawing.Point(74, 658);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPsw.MaxLength = 50;
            this.txtPsw.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPsw.Multiline = false;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(684, 50);
            this.txtPsw.TabIndex = 14;
            this.txtPsw.Tag = "registroContrasena";
            this.txtPsw.Text = "";
            this.txtPsw.TrailingIcon = null;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 987);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro";
            this.Padding = new System.Windows.Forms.Padding(20, 115, 20, 19);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Tag = "formRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialButton btnRegistro;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPsw;
    }
}