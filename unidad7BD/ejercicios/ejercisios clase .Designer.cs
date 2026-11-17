namespace Unidad_7BD
{
    partial class ejercisios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblInsertarClientes = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.brnModificar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(9, 290);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(105, 34);
            this.btnProbarConexion.TabIndex = 0;
            this.btnProbarConexion.Text = "Probar conexion ";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(15, 116);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = true;
            this.btnInsertar.Location = new System.Drawing.Point(9, 185);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 30);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "btnInsertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 61);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Location = new System.Drawing.Point(6, 100);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(38, 13);
            this.Correo.TabIndex = 5;
            this.Correo.Text = "Correo";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(15, 159);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 6;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 139);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 13);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "ID cliente";
            // 
            // lblInsertarClientes
            // 
            this.lblInsertarClientes.AutoSize = true;
            this.lblInsertarClientes.Location = new System.Drawing.Point(6, 28);
            this.lblInsertarClientes.Name = "lblInsertarClientes";
            this.lblInsertarClientes.Size = new System.Drawing.Size(84, 13);
            this.lblInsertarClientes.TabIndex = 8;
            this.lblInsertarClientes.Text = "Insertar clientes ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(146, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(252, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // brnModificar
            // 
            this.brnModificar.Location = new System.Drawing.Point(9, 221);
            this.brnModificar.Name = "brnModificar";
            this.brnModificar.Size = new System.Drawing.Size(105, 23);
            this.brnModificar.TabIndex = 12;
            this.brnModificar.Text = "Guardar cambios";
            this.brnModificar.UseVisualStyleBackColor = true;
            this.brnModificar.Click += new System.EventHandler(this.brnModificar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(169, 52);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 261);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ejercisios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 331);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.brnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblInsertarClientes);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnProbarConexion);
            this.Name = "ejercisios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ejercisios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblInsertarClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button brnModificar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

