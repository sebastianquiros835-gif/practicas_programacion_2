namespace unidad_3.ejercisiosclase
{
    partial class practica_programada3
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.lbldias = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(43, 48);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(138, 20);
            this.txtDia.TabIndex = 0;
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(57, 94);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(100, 41);
            this.btnMostrarDia.TabIndex = 1;
            this.btnMostrarDia.Text = "Mostrar día ";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            this.btnMostrarDia.Click += new System.EventHandler(this.btnMostrarDia_Click);
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Location = new System.Drawing.Point(20, 19);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(193, 13);
            this.lbldias.TabIndex = 2;
            this.lbldias.Text = "Digita el numero del día que desea ver ";
            this.lbldias.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(179, 112);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // practica_programada3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.btnMostrarDia);
            this.Controls.Add(this.txtDia);
            this.Name = "practica_programada3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnMostrarDia;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Button btnsalir;
    }
}