using System;

namespace unidad2
{
    partial class practica_clase2
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
            this.components = new System.ComponentModel.Container();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.contextMenuStrip07 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.listBoxColores = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnrojo = new System.Windows.Forms.Button();
            this.btnmorado = new System.Windows.Forms.Button();
            this.btnverde = new System.Windows.Forms.Button();
            this.contextMenuStrip07.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(365, 93);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "evaluar numero ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.ContextMenuStrip = this.contextMenuStrip07;
            this.lblnum1.Location = new System.Drawing.Point(285, 43);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(54, 13);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "numero 1 ";
            // 
            // contextMenuStrip07
            // 
            this.contextMenuStrip07.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip07.Name = "contextMenuStrip07";
            this.contextMenuStrip07.Size = new System.Drawing.Size(162, 48);
            // 
            // barraToolStripMenuItem
            // 
            this.barraToolStripMenuItem.Name = "barraToolStripMenuItem";
            this.barraToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.barraToolStripMenuItem.Text = "barra de colores ";
            this.barraToolStripMenuItem.Click += new System.EventHandler(this.barraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salirToolStripMenuItem.Text = "salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(288, 100);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(51, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "numero 2";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(365, 36);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 5;
            this.txtnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxColores
            // 
            this.listBoxColores.FormattingEnabled = true;
            this.listBoxColores.Location = new System.Drawing.Point(12, 12);
            this.listBoxColores.Name = "listBoxColores";
            this.listBoxColores.Size = new System.Drawing.Size(143, 95);
            this.listBoxColores.TabIndex = 7;
            this.listBoxColores.SelectedIndexChanged += new System.EventHandler(this.listBoxColores_SelectedIndexChanged);
            // 
            // btnrojo
            // 
            this.btnrojo.Location = new System.Drawing.Point(12, 113);
            this.btnrojo.Name = "btnrojo";
            this.btnrojo.Size = new System.Drawing.Size(75, 23);
            this.btnrojo.TabIndex = 9;
            this.btnrojo.Text = "Rojo";
            this.btnrojo.UseVisualStyleBackColor = true;
            this.btnrojo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmorado
            // 
            this.btnmorado.Location = new System.Drawing.Point(13, 142);
            this.btnmorado.Name = "btnmorado";
            this.btnmorado.Size = new System.Drawing.Size(75, 23);
            this.btnmorado.TabIndex = 10;
            this.btnmorado.Text = "Morado ";
            this.btnmorado.UseVisualStyleBackColor = true;
            this.btnmorado.Click += new System.EventHandler(this.btnmorado_Click);
            // 
            // btnverde
            // 
            this.btnverde.Location = new System.Drawing.Point(13, 171);
            this.btnverde.Name = "btnverde";
            this.btnverde.Size = new System.Drawing.Size(75, 23);
            this.btnverde.TabIndex = 11;
            this.btnverde.Text = "Verde ";
            this.btnverde.UseVisualStyleBackColor = true;
            this.btnverde.Click += new System.EventHandler(this.btnverde_Click_1);
            // 
            // practica_clase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 274);
            this.ContextMenuStrip = this.contextMenuStrip07;
            this.Controls.Add(this.btnverde);
            this.Controls.Add(this.btnmorado);
            this.Controls.Add(this.btnrojo);
            this.Controls.Add(this.listBoxColores);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumero2);
            this.Name = "practica_clase2";
            this.Text = "clase2";
            this.Load += new System.EventHandler(this.practica_clase2_Load);
            this.contextMenuStrip07.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.ListBox listBoxColores;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip07;
        private System.Windows.Forms.ToolStripMenuItem barraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnrojo;
        private System.Windows.Forms.Button btnmorado;
        private System.Windows.Forms.Button btnverde;
    }
}

