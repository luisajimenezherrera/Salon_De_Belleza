namespace SalonDeBelleza
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opinionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistroClientes = new System.Windows.Forms.Button();
            this.btnRegistroSedes = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistroProfesional = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnOpinion = new System.Windows.Forms.Button();
            this.btnRegistroProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1451, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.registrarSedesToolStripMenuItem,
            this.registroProductoToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.reservarToolStripMenuItem,
            this.opinionToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.saToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.menuToolStripMenuItem.Text = "&Opciones";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registroClienteToolStripMenuItem.Text = "&Registro clientes ";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // registrarSedesToolStripMenuItem
            // 
            this.registrarSedesToolStripMenuItem.Name = "registrarSedesToolStripMenuItem";
            this.registrarSedesToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registrarSedesToolStripMenuItem.Text = "&Registro Sedes";
            this.registrarSedesToolStripMenuItem.Click += new System.EventHandler(this.registrarSedesToolStripMenuItem_Click);
            // 
            // registroProductoToolStripMenuItem
            // 
            this.registroProductoToolStripMenuItem.Name = "registroProductoToolStripMenuItem";
            this.registroProductoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registroProductoToolStripMenuItem.Text = "&Registro Producto";
            this.registroProductoToolStripMenuItem.Click += new System.EventHandler(this.registroProductoToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registroToolStripMenuItem.Text = "&Registro Profesional";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.reservarToolStripMenuItem.Text = "&Reservas";
            this.reservarToolStripMenuItem.Click += new System.EventHandler(this.reservarToolStripMenuItem_Click);
            // 
            // opinionToolStripMenuItem
            // 
            this.opinionToolStripMenuItem.Name = "opinionToolStripMenuItem";
            this.opinionToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.opinionToolStripMenuItem.Text = "&Opinion";
            this.opinionToolStripMenuItem.Click += new System.EventHandler(this.opinionToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.saToolStripMenuItem.Text = "&Salir";
            this.saToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click);
            // 
            // btnRegistroClientes
            // 
            this.btnRegistroClientes.Location = new System.Drawing.Point(153, 538);
            this.btnRegistroClientes.Name = "btnRegistroClientes";
            this.btnRegistroClientes.Size = new System.Drawing.Size(129, 42);
            this.btnRegistroClientes.TabIndex = 3;
            this.btnRegistroClientes.Text = "Registro Clientes";
            this.btnRegistroClientes.UseVisualStyleBackColor = true;
            this.btnRegistroClientes.Click += new System.EventHandler(this.btnRegistroClientes_Click);
            // 
            // btnRegistroSedes
            // 
            this.btnRegistroSedes.Location = new System.Drawing.Point(297, 538);
            this.btnRegistroSedes.Name = "btnRegistroSedes";
            this.btnRegistroSedes.Size = new System.Drawing.Size(129, 42);
            this.btnRegistroSedes.TabIndex = 4;
            this.btnRegistroSedes.Text = "Registro Sedes";
            this.btnRegistroSedes.UseVisualStyleBackColor = true;
            this.btnRegistroSedes.Click += new System.EventHandler(this.btnRegistroSedes_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(974, 538);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 42);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistroProfesional
            // 
            this.btnRegistroProfesional.Location = new System.Drawing.Point(569, 538);
            this.btnRegistroProfesional.Name = "btnRegistroProfesional";
            this.btnRegistroProfesional.Size = new System.Drawing.Size(129, 42);
            this.btnRegistroProfesional.TabIndex = 6;
            this.btnRegistroProfesional.Text = "Registro Profesional";
            this.btnRegistroProfesional.UseVisualStyleBackColor = true;
            this.btnRegistroProfesional.Click += new System.EventHandler(this.btnRegistroProfesional_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(704, 538);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(129, 42);
            this.btnReservas.TabIndex = 7;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnOpinion
            // 
            this.btnOpinion.Location = new System.Drawing.Point(839, 538);
            this.btnOpinion.Name = "btnOpinion";
            this.btnOpinion.Size = new System.Drawing.Size(129, 42);
            this.btnOpinion.TabIndex = 8;
            this.btnOpinion.Text = "Opinion";
            this.btnOpinion.UseVisualStyleBackColor = true;
            this.btnOpinion.Click += new System.EventHandler(this.btnOpinion_Click);
            // 
            // btnRegistroProducto
            // 
            this.btnRegistroProducto.Location = new System.Drawing.Point(432, 538);
            this.btnRegistroProducto.Name = "btnRegistroProducto";
            this.btnRegistroProducto.Size = new System.Drawing.Size(129, 42);
            this.btnRegistroProducto.TabIndex = 9;
            this.btnRegistroProducto.Text = "RegistroProducto";
            this.btnRegistroProducto.UseVisualStyleBackColor = true;
            this.btnRegistroProducto.Click += new System.EventHandler(this.btnRegistroProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1108, 538);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 42);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 592);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistroProducto);
            this.Controls.Add(this.btnOpinion);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnRegistroProfesional);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistroSedes);
            this.Controls.Add(this.btnRegistroClientes);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opinionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistroClientes;
        private System.Windows.Forms.Button btnRegistroSedes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistroProfesional;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnOpinion;
        private System.Windows.Forms.Button btnRegistroProducto;
        private System.Windows.Forms.Button btnSalir;
    }
}