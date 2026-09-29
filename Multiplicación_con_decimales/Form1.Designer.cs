namespace Multiplicación_con_decimales
{
    partial class Formmultiplicacion
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
            this.lbltexto = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.textresultado = new System.Windows.Forms.TextBox();
            this.lblmultiplicar = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltexto.Location = new System.Drawing.Point(294, 95);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(212, 20);
            this.lbltexto.TabIndex = 0;
            this.lbltexto.Text = "Multiplicación con decimales ";
            this.lbltexto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(282, 168);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(54, 20);
            this.txtnumero1.TabIndex = 1;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(364, 168);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(54, 20);
            this.txtnumero2.TabIndex = 2;
            this.txtnumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textresultado
            // 
            this.textresultado.Location = new System.Drawing.Point(455, 168);
            this.textresultado.Name = "textresultado";
            this.textresultado.Size = new System.Drawing.Size(76, 20);
            this.textresultado.TabIndex = 3;
            this.textresultado.TextChanged += new System.EventHandler(this.textresultado_TextChanged);
            // 
            // lblmultiplicar
            // 
            this.lblmultiplicar.AutoSize = true;
            this.lblmultiplicar.BackColor = System.Drawing.SystemColors.Control;
            this.lblmultiplicar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmultiplicar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmultiplicar.Location = new System.Drawing.Point(342, 168);
            this.lblmultiplicar.Name = "lblmultiplicar";
            this.lblmultiplicar.Size = new System.Drawing.Size(18, 22);
            this.lblmultiplicar.TabIndex = 4;
            this.lblmultiplicar.Text = "x";
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbligual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligual.Location = new System.Drawing.Point(431, 168);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(18, 20);
            this.lbligual.TabIndex = 5;
            this.lbligual.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Toca aqui para multiplicar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(298, 311);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(78, 36);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(426, 311);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(80, 38);
            this.btncerrar.TabIndex = 8;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Formmultiplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblmultiplicar);
            this.Controls.Add(this.textresultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lbltexto);
            this.Name = "Formmultiplicacion";
            this.Text = "Formmutiplicacion ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox textresultado;
        private System.Windows.Forms.Label lblmultiplicar;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncerrar;
    }
}

