namespace UI
{
    partial class Modificacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.inputPsw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.inputPsw);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputUsername);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.inputEmail);
            this.groupBox1.Controls.Add(this.inputApellido);
            this.groupBox1.Controls.Add(this.inputNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(620, 554);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Usuario:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(192, 48);
            this.labelId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 25);
            this.labelId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(92, 438);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(436, 87);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // inputPsw
            // 
            this.inputPsw.Location = new System.Drawing.Point(196, 365);
            this.inputPsw.Margin = new System.Windows.Forms.Padding(6);
            this.inputPsw.Name = "inputPsw";
            this.inputPsw.PasswordChar = '*';
            this.inputPsw.ReadOnly = true;
            this.inputPsw.Size = new System.Drawing.Size(328, 31);
            this.inputPsw.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(194, 304);
            this.inputUsername.Margin = new System.Windows.Forms.Padding(6);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(330, 31);
            this.inputUsername.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(88, 310);
            this.Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(116, 25);
            this.Username.TabIndex = 9;
            this.Username.Text = "Username:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(192, 231);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(6);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(332, 31);
            this.inputEmail.TabIndex = 2;
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(192, 160);
            this.inputApellido.Margin = new System.Windows.Forms.Padding(6);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(332, 31);
            this.inputApellido.TabIndex = 1;
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(194, 102);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(6);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(330, 31);
            this.inputNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 673);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox inputPsw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label5;
    }
}