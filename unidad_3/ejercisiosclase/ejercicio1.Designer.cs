namespace unidad_3
{
    partial class ejercicio1
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
            this.txtopcion = new System.Windows.Forms.TextBox();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtopcion
            // 
            this.txtopcion.Location = new System.Drawing.Point(136, 54);
            this.txtopcion.Name = "txtopcion";
            this.txtopcion.Size = new System.Drawing.Size(100, 20);
            this.txtopcion.TabIndex = 0;
            this.txtopcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(136, 115);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(91, 57);
            this.btnseleccionar.TabIndex = 1;
            this.btnseleccionar.Text = "Seleccionar ";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 188);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtopcion);
            this.Name = "ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtopcion;
        private System.Windows.Forms.Button btnseleccionar;
    }
}

