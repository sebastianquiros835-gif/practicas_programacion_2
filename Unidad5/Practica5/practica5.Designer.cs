namespace Unidad5.Practica5
{
    partial class practica5
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAnoNacimiento = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAnoNacimiento = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTrabajador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAnoNacimiento
            // 
            this.lblAnoNacimiento.AutoSize = true;
            this.lblAnoNacimiento.Location = new System.Drawing.Point(20, 85);
            this.lblAnoNacimiento.Name = "lblAnoNacimiento";
            this.lblAnoNacimiento.Size = new System.Drawing.Size(98, 13);
            this.lblAnoNacimiento.TabIndex = 1;
            this.lblAnoNacimiento.Text = "Año de nacimiento ";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(35, 139);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(55, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtAnoNacimiento
            // 
            this.txtAnoNacimiento.Location = new System.Drawing.Point(55, 101);
            this.txtAnoNacimiento.Name = "txtAnoNacimiento";
            this.txtAnoNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNacimiento.TabIndex = 4;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(55, 155);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(198, 212);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvTrabajador
            // 
            this.dgvTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajador.Location = new System.Drawing.Point(254, 31);
            this.dgvTrabajador.Name = "dgvTrabajador";
            this.dgvTrabajador.Size = new System.Drawing.Size(240, 150);
            this.dgvTrabajador.TabIndex = 8;
            // 
            // practica5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 270);
            this.Controls.Add(this.dgvTrabajador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtAnoNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblAnoNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Name = "practica5";
            this.Text = "practica5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAnoNacimiento;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAnoNacimiento;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTrabajador;
    }
}