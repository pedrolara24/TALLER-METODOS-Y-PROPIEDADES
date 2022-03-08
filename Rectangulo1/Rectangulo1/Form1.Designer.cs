
namespace Rectangulo1
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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lblXfinal = new System.Windows.Forms.Label();
            this.txtXfinal = new System.Windows.Forms.TextBox();
            this.txtYfinal = new System.Windows.Forms.TextBox();
            this.lblYfinal = new System.Windows.Forms.Label();
            this.lblXinicial = new System.Windows.Forms.Label();
            this.lblYinicial = new System.Windows.Forms.Label();
            this.txtXinicial = new System.Windows.Forms.TextBox();
            this.txtYinicial = new System.Windows.Forms.TextBox();
            this.lblCantidadLineas = new System.Windows.Forms.Label();
            this.txtCantidadLineas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(260, 286);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(247, 52);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar linea";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblXfinal
            // 
            this.lblXfinal.AutoSize = true;
            this.lblXfinal.Location = new System.Drawing.Point(212, 184);
            this.lblXfinal.Name = "lblXfinal";
            this.lblXfinal.Size = new System.Drawing.Size(47, 17);
            this.lblXfinal.TabIndex = 1;
            this.lblXfinal.Text = "X final";
            this.lblXfinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtXfinal
            // 
            this.txtXfinal.Location = new System.Drawing.Point(297, 184);
            this.txtXfinal.Name = "txtXfinal";
            this.txtXfinal.Size = new System.Drawing.Size(100, 22);
            this.txtXfinal.TabIndex = 2;
            this.txtXfinal.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtYfinal
            // 
            this.txtYfinal.Location = new System.Drawing.Point(557, 184);
            this.txtYfinal.Name = "txtYfinal";
            this.txtYfinal.Size = new System.Drawing.Size(100, 22);
            this.txtYfinal.TabIndex = 3;
            this.txtYfinal.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // lblYfinal
            // 
            this.lblYfinal.AutoSize = true;
            this.lblYfinal.Location = new System.Drawing.Point(470, 184);
            this.lblYfinal.Name = "lblYfinal";
            this.lblYfinal.Size = new System.Drawing.Size(47, 17);
            this.lblYfinal.TabIndex = 4;
            this.lblYfinal.Text = "Y final";
            // 
            // lblXinicial
            // 
            this.lblXinicial.AutoSize = true;
            this.lblXinicial.Location = new System.Drawing.Point(212, 143);
            this.lblXinicial.Name = "lblXinicial";
            this.lblXinicial.Size = new System.Drawing.Size(56, 17);
            this.lblXinicial.TabIndex = 5;
            this.lblXinicial.Text = "X inicial";
            // 
            // lblYinicial
            // 
            this.lblYinicial.AutoSize = true;
            this.lblYinicial.Location = new System.Drawing.Point(470, 143);
            this.lblYinicial.Name = "lblYinicial";
            this.lblYinicial.Size = new System.Drawing.Size(56, 17);
            this.lblYinicial.TabIndex = 6;
            this.lblYinicial.Text = "Y inicial";
            // 
            // txtXinicial
            // 
            this.txtXinicial.Location = new System.Drawing.Point(297, 140);
            this.txtXinicial.Name = "txtXinicial";
            this.txtXinicial.Size = new System.Drawing.Size(100, 22);
            this.txtXinicial.TabIndex = 7;
            // 
            // txtYinicial
            // 
            this.txtYinicial.Location = new System.Drawing.Point(557, 140);
            this.txtYinicial.Name = "txtYinicial";
            this.txtYinicial.Size = new System.Drawing.Size(100, 22);
            this.txtYinicial.TabIndex = 8;
            // 
            // lblCantidadLineas
            // 
            this.lblCantidadLineas.AutoSize = true;
            this.lblCantidadLineas.Location = new System.Drawing.Point(657, 286);
            this.lblCantidadLineas.Name = "lblCantidadLineas";
            this.lblCantidadLineas.Size = new System.Drawing.Size(125, 17);
            this.lblCantidadLineas.TabIndex = 9;
            this.lblCantidadLineas.Text = "Cantidad de lineas";
            this.lblCantidadLineas.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCantidadLineas
            // 
            this.txtCantidadLineas.Location = new System.Drawing.Point(660, 316);
            this.txtCantidadLineas.Name = "txtCantidadLineas";
            this.txtCantidadLineas.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadLineas.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 628);
            this.Controls.Add(this.txtCantidadLineas);
            this.Controls.Add(this.lblCantidadLineas);
            this.Controls.Add(this.txtYinicial);
            this.Controls.Add(this.txtXinicial);
            this.Controls.Add(this.lblYinicial);
            this.Controls.Add(this.lblXinicial);
            this.Controls.Add(this.lblYfinal);
            this.Controls.Add(this.txtYfinal);
            this.Controls.Add(this.txtXfinal);
            this.Controls.Add(this.lblXfinal);
            this.Controls.Add(this.btnDibujar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lblXfinal;
        private System.Windows.Forms.TextBox txtXfinal;
        private System.Windows.Forms.TextBox txtYfinal;
        private System.Windows.Forms.Label lblYfinal;
        private System.Windows.Forms.Label lblXinicial;
        private System.Windows.Forms.Label lblYinicial;
        private System.Windows.Forms.TextBox txtXinicial;
        private System.Windows.Forms.TextBox txtYinicial;
        private System.Windows.Forms.Label lblCantidadLineas;
        private System.Windows.Forms.TextBox txtCantidadLineas;
    }
}

