namespace Unidad5.Validaciones_y_DialogResult
{
    partial class form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(135, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de estudiantes ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(112, 108);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(193, 108);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar ";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.Location = new System.Drawing.Point(307, 12);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(120, 95);
            this.lstEstudiantes.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(152, 154);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 233);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstEstudiantes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.Button btnSalir;
    }
}