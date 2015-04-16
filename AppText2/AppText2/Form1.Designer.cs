namespace AppText2
{
    partial class From
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btbVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(42, 25);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(40, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave: ";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(88, 25);
            this.txtClave.MaxLength = 10;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(108, 20);
            this.txtClave.TabIndex = 1;
            // 
            // btbVerificar
            // 
            this.btbVerificar.Location = new System.Drawing.Point(88, 87);
            this.btbVerificar.Name = "btbVerificar";
            this.btbVerificar.Size = new System.Drawing.Size(108, 23);
            this.btbVerificar.TabIndex = 2;
            this.btbVerificar.Text = "Verificar Clave";
            this.btbVerificar.UseVisualStyleBackColor = true;
            this.btbVerificar.Click += new System.EventHandler(this.btbVerificar_Click);
            // 
            // From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btbVerificar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Name = "From";
            this.Text = "Programa Verificar Clave";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btbVerificar;
    }
}

