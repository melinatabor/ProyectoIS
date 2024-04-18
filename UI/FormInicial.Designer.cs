namespace UI
{
    partial class FormInicial
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
            this.btnTestAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestAgregar
            // 
            this.btnTestAgregar.Location = new System.Drawing.Point(234, 128);
            this.btnTestAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestAgregar.Name = "btnTestAgregar";
            this.btnTestAgregar.Size = new System.Drawing.Size(87, 33);
            this.btnTestAgregar.TabIndex = 1;
            this.btnTestAgregar.Text = " Agregar";
            this.btnTestAgregar.UseVisualStyleBackColor = true;
            this.btnTestAgregar.Click += new System.EventHandler(this.btnTestAgregar_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.btnTestAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTestAgregar;
    }
}

