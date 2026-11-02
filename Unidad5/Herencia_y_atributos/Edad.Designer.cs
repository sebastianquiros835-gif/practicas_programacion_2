namespace Unidad5.Herencia_y_atributos
{
    partial class Edad
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
            this.lblAñonacimiento = new System.Windows.Forms.Label();
            this.txtAñoNacimiento = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAñonacimiento
            // 
            this.lblAñonacimiento.AutoSize = true;
            this.lblAñonacimiento.Location = new System.Drawing.Point(124, 73);
            this.lblAñonacimiento.Name = "lblAñonacimiento";
            this.lblAñonacimiento.Size = new System.Drawing.Size(98, 13);
            this.lblAñonacimiento.TabIndex = 0;
            this.lblAñonacimiento.Text = "Año de nacimiento ";
            // 
            // txtAñoNacimiento
            // 
            this.txtAñoNacimiento.Location = new System.Drawing.Point(122, 102);
            this.txtAñoNacimiento.Name = "txtAñoNacimiento";
            this.txtAñoNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtAñoNacimiento.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(127, 138);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 49);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar ";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Edad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 256);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtAñoNacimiento);
            this.Controls.Add(this.lblAñonacimiento);
            this.Name = "Edad";
            this.Text = "Edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAñonacimiento;
        private System.Windows.Forms.TextBox txtAñoNacimiento;
        private System.Windows.Forms.Button btnMostrar;
    }
}