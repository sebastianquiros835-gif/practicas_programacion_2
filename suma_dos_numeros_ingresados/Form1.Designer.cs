namespace suma_dos_numeros_ingresados
{
    partial class Form1
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
            this.lblsuma_de_dos_numeros = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.btsumar = new System.Windows.Forms.Button();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.lblsimbolo = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncerrrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsuma_de_dos_numeros
            // 
            this.lblsuma_de_dos_numeros.AutoSize = true;
            this.lblsuma_de_dos_numeros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblsuma_de_dos_numeros.Location = new System.Drawing.Point(209, 110);
            this.lblsuma_de_dos_numeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsuma_de_dos_numeros.Name = "lblsuma_de_dos_numeros";
            this.lblsuma_de_dos_numeros.Size = new System.Drawing.Size(228, 17);
            this.lblsuma_de_dos_numeros.TabIndex = 0;
            this.lblsuma_de_dos_numeros.Text = "Suma de dos numeros ingresados ";
            this.lblsuma_de_dos_numeros.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(203, 143);
            this.txtnumero1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(67, 23);
            this.txtnumero1.TabIndex = 1;
            this.txtnumero1.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // btsumar
            // 
            this.btsumar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btsumar.Location = new System.Drawing.Point(241, 202);
            this.btsumar.Margin = new System.Windows.Forms.Padding(4);
            this.btsumar.Name = "btsumar";
            this.btsumar.Size = new System.Drawing.Size(159, 50);
            this.btsumar.TabIndex = 2;
            this.btsumar.Text = "Toca aqui para sumar ";
            this.btsumar.UseVisualStyleBackColor = false;
            this.btsumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(299, 143);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(68, 23);
            this.txtnumero2.TabIndex = 3;
            this.txtnumero2.TextChanged += new System.EventHandler(this.txtnumero2_TextChanged);
            // 
            // lblsimbolo
            // 
            this.lblsimbolo.AutoSize = true;
            this.lblsimbolo.Location = new System.Drawing.Point(277, 143);
            this.lblsimbolo.Name = "lblsimbolo";
            this.lblsimbolo.Size = new System.Drawing.Size(16, 17);
            this.lblsimbolo.TabIndex = 4;
            this.lblsimbolo.Text = "+";
            this.lblsimbolo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbligual.Location = new System.Drawing.Point(387, 146);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(18, 20);
            this.lbligual.TabIndex = 6;
            this.lbligual.Text = "=";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(416, 143);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(90, 23);
            this.txtresultado.TabIndex = 8;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(241, 278);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 39);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncerrrar
            // 
            this.btncerrrar.Location = new System.Drawing.Point(324, 278);
            this.btncerrrar.Name = "btncerrrar";
            this.btncerrrar.Size = new System.Drawing.Size(76, 39);
            this.btncerrrar.TabIndex = 10;
            this.btncerrrar.Text = "Cerrar";
            this.btncerrrar.UseVisualStyleBackColor = true;
            this.btncerrrar.Click += new System.EventHandler(this.btncerrrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 391);
            this.Controls.Add(this.btncerrrar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblsimbolo);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.btsumar);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lblsuma_de_dos_numeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsuma_de_dos_numeros;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Button btsumar;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label lblsimbolo;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncerrrar;
    }
}

