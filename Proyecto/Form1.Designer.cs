namespace SalonDeBelleza
{
    partial class frmAdministrador
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresarAdm = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(225, 194);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(203, 238);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(285, 232);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(195, 22);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnIngresarAdm
            // 
            this.btnIngresarAdm.Location = new System.Drawing.Point(298, 328);
            this.btnIngresarAdm.Name = "btnIngresarAdm";
            this.btnIngresarAdm.Size = new System.Drawing.Size(170, 80);
            this.btnIngresarAdm.TabIndex = 4;
            this.btnIngresarAdm.Text = "Ingresar";
            this.btnIngresarAdm.UseVisualStyleBackColor = true;
            this.btnIngresarAdm.Click += new System.EventHandler(this.btnIngresarAdm_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(285, 191);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 24);
            this.cmbUsuario.TabIndex = 5;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnIngresarAdm);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmAdministrador";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresarAdm;
        private System.Windows.Forms.ComboBox cmbUsuario;
    }
}

