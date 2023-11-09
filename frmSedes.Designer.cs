namespace SalonDeBelleza
{
    partial class frmSedes
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
            this.lblIdSede = new System.Windows.Forms.Label();
            this.lblCiudadSede = new System.Windows.Forms.Label();
            this.lblDireccionSede = new System.Windows.Forms.Label();
            this.lblHorarioAperturaSede = new System.Windows.Forms.Label();
            this.lblHorarioCierreSede = new System.Windows.Forms.Label();
            this.dtpHorarioCierreSede = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioAperturaSede = new System.Windows.Forms.DateTimePicker();
            this.txtDireccionSede = new System.Windows.Forms.TextBox();
            this.txtCiudadSede = new System.Windows.Forms.TextBox();
            this.txtIdSede = new System.Windows.Forms.TextBox();
            this.dtgSedes = new System.Windows.Forms.DataGridView();
            this.btnSalirSedes = new System.Windows.Forms.Button();
            this.btnLimpiarSedes = new System.Windows.Forms.Button();
            this.btnEliminarSedes = new System.Windows.Forms.Button();
            this.btnModificarSedes = new System.Windows.Forms.Button();
            this.btnConsultarSedes = new System.Windows.Forms.Button();
            this.btnAgregarSedes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSedes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdSede
            // 
            this.lblIdSede.AutoSize = true;
            this.lblIdSede.Location = new System.Drawing.Point(63, 41);
            this.lblIdSede.Name = "lblIdSede";
            this.lblIdSede.Size = new System.Drawing.Size(54, 16);
            this.lblIdSede.TabIndex = 0;
            this.lblIdSede.Text = "Id Sede";
            // 
            // lblCiudadSede
            // 
            this.lblCiudadSede.AutoSize = true;
            this.lblCiudadSede.Location = new System.Drawing.Point(63, 84);
            this.lblCiudadSede.Name = "lblCiudadSede";
            this.lblCiudadSede.Size = new System.Drawing.Size(50, 16);
            this.lblCiudadSede.TabIndex = 1;
            this.lblCiudadSede.Text = "Ciudad";
            // 
            // lblDireccionSede
            // 
            this.lblDireccionSede.AutoSize = true;
            this.lblDireccionSede.Location = new System.Drawing.Point(63, 138);
            this.lblDireccionSede.Name = "lblDireccionSede";
            this.lblDireccionSede.Size = new System.Drawing.Size(64, 16);
            this.lblDireccionSede.TabIndex = 2;
            this.lblDireccionSede.Text = "Direccion";
            // 
            // lblHorarioAperturaSede
            // 
            this.lblHorarioAperturaSede.AutoSize = true;
            this.lblHorarioAperturaSede.Location = new System.Drawing.Point(359, 72);
            this.lblHorarioAperturaSede.Name = "lblHorarioAperturaSede";
            this.lblHorarioAperturaSede.Size = new System.Drawing.Size(106, 16);
            this.lblHorarioAperturaSede.TabIndex = 3;
            this.lblHorarioAperturaSede.Text = "Horario Apertura";
            // 
            // lblHorarioCierreSede
            // 
            this.lblHorarioCierreSede.AutoSize = true;
            this.lblHorarioCierreSede.Location = new System.Drawing.Point(374, 107);
            this.lblHorarioCierreSede.Name = "lblHorarioCierreSede";
            this.lblHorarioCierreSede.Size = new System.Drawing.Size(91, 16);
            this.lblHorarioCierreSede.TabIndex = 4;
            this.lblHorarioCierreSede.Text = "Horario Cierre";
            // 
            // dtpHorarioCierreSede
            // 
            this.dtpHorarioCierreSede.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioCierreSede.Location = new System.Drawing.Point(471, 101);
            this.dtpHorarioCierreSede.Name = "dtpHorarioCierreSede";
            this.dtpHorarioCierreSede.Size = new System.Drawing.Size(148, 22);
            this.dtpHorarioCierreSede.TabIndex = 5;
            // 
            // dtpHorarioAperturaSede
            // 
            this.dtpHorarioAperturaSede.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioAperturaSede.Location = new System.Drawing.Point(471, 66);
            this.dtpHorarioAperturaSede.Name = "dtpHorarioAperturaSede";
            this.dtpHorarioAperturaSede.Size = new System.Drawing.Size(148, 22);
            this.dtpHorarioAperturaSede.TabIndex = 6;
            // 
            // txtDireccionSede
            // 
            this.txtDireccionSede.Location = new System.Drawing.Point(155, 138);
            this.txtDireccionSede.Name = "txtDireccionSede";
            this.txtDireccionSede.Size = new System.Drawing.Size(100, 22);
            this.txtDireccionSede.TabIndex = 7;
            // 
            // txtCiudadSede
            // 
            this.txtCiudadSede.Location = new System.Drawing.Point(155, 81);
            this.txtCiudadSede.Name = "txtCiudadSede";
            this.txtCiudadSede.Size = new System.Drawing.Size(100, 22);
            this.txtCiudadSede.TabIndex = 8;
            // 
            // txtIdSede
            // 
            this.txtIdSede.Location = new System.Drawing.Point(155, 41);
            this.txtIdSede.Name = "txtIdSede";
            this.txtIdSede.Size = new System.Drawing.Size(100, 22);
            this.txtIdSede.TabIndex = 9;
            // 
            // dtgSedes
            // 
            this.dtgSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSedes.Location = new System.Drawing.Point(12, 273);
            this.dtgSedes.Name = "dtgSedes";
            this.dtgSedes.RowHeadersWidth = 51;
            this.dtgSedes.RowTemplate.Height = 24;
            this.dtgSedes.Size = new System.Drawing.Size(776, 150);
            this.dtgSedes.TabIndex = 10;
            this.dtgSedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSedes_CellContentClick);
            this.dtgSedes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgSedes_MouseClick);
            // 
            // btnSalirSedes
            // 
            this.btnSalirSedes.Location = new System.Drawing.Point(654, 210);
            this.btnSalirSedes.Name = "btnSalirSedes";
            this.btnSalirSedes.Size = new System.Drawing.Size(112, 31);
            this.btnSalirSedes.TabIndex = 29;
            this.btnSalirSedes.Text = "Salir";
            this.btnSalirSedes.UseVisualStyleBackColor = true;
            this.btnSalirSedes.Click += new System.EventHandler(this.btnSalirSedes_Click);
            // 
            // btnLimpiarSedes
            // 
            this.btnLimpiarSedes.Location = new System.Drawing.Point(520, 210);
            this.btnLimpiarSedes.Name = "btnLimpiarSedes";
            this.btnLimpiarSedes.Size = new System.Drawing.Size(112, 31);
            this.btnLimpiarSedes.TabIndex = 28;
            this.btnLimpiarSedes.Text = "Limpiar";
            this.btnLimpiarSedes.UseVisualStyleBackColor = true;
            this.btnLimpiarSedes.Click += new System.EventHandler(this.btnLimpiarSedes_Click);
            // 
            // btnEliminarSedes
            // 
            this.btnEliminarSedes.Location = new System.Drawing.Point(398, 210);
            this.btnEliminarSedes.Name = "btnEliminarSedes";
            this.btnEliminarSedes.Size = new System.Drawing.Size(112, 31);
            this.btnEliminarSedes.TabIndex = 27;
            this.btnEliminarSedes.Text = "Eliminar";
            this.btnEliminarSedes.UseVisualStyleBackColor = true;
            this.btnEliminarSedes.Click += new System.EventHandler(this.btnEliminarSedes_Click);
            // 
            // btnModificarSedes
            // 
            this.btnModificarSedes.Location = new System.Drawing.Point(276, 210);
            this.btnModificarSedes.Name = "btnModificarSedes";
            this.btnModificarSedes.Size = new System.Drawing.Size(112, 31);
            this.btnModificarSedes.TabIndex = 26;
            this.btnModificarSedes.Text = "Modificar";
            this.btnModificarSedes.UseVisualStyleBackColor = true;
            this.btnModificarSedes.Click += new System.EventHandler(this.btnModificarSedes_Click);
            // 
            // btnConsultarSedes
            // 
            this.btnConsultarSedes.Location = new System.Drawing.Point(156, 210);
            this.btnConsultarSedes.Name = "btnConsultarSedes";
            this.btnConsultarSedes.Size = new System.Drawing.Size(112, 31);
            this.btnConsultarSedes.TabIndex = 25;
            this.btnConsultarSedes.Text = "Consultar";
            this.btnConsultarSedes.UseVisualStyleBackColor = true;
            this.btnConsultarSedes.Click += new System.EventHandler(this.btnConsultarSedes_Click);
            // 
            // btnAgregarSedes
            // 
            this.btnAgregarSedes.Location = new System.Drawing.Point(34, 210);
            this.btnAgregarSedes.Name = "btnAgregarSedes";
            this.btnAgregarSedes.Size = new System.Drawing.Size(112, 31);
            this.btnAgregarSedes.TabIndex = 24;
            this.btnAgregarSedes.Text = "Agregar";
            this.btnAgregarSedes.UseVisualStyleBackColor = true;
            this.btnAgregarSedes.Click += new System.EventHandler(this.btnAgregarSedes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.consultarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.agregarToolStripMenuItem.Text = "&Menu";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.agregarToolStripMenuItem1.Text = "&Agregar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.limpiarToolStripMenuItem.Text = "&Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSalirSedes);
            this.Controls.Add(this.btnLimpiarSedes);
            this.Controls.Add(this.btnEliminarSedes);
            this.Controls.Add(this.btnModificarSedes);
            this.Controls.Add(this.btnConsultarSedes);
            this.Controls.Add(this.btnAgregarSedes);
            this.Controls.Add(this.dtgSedes);
            this.Controls.Add(this.txtIdSede);
            this.Controls.Add(this.txtCiudadSede);
            this.Controls.Add(this.txtDireccionSede);
            this.Controls.Add(this.dtpHorarioAperturaSede);
            this.Controls.Add(this.dtpHorarioCierreSede);
            this.Controls.Add(this.lblHorarioCierreSede);
            this.Controls.Add(this.lblHorarioAperturaSede);
            this.Controls.Add(this.lblDireccionSede);
            this.Controls.Add(this.lblCiudadSede);
            this.Controls.Add(this.lblIdSede);
            this.Name = "frmSedes";
            this.Text = "Sedes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSedes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSedes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdSede;
        private System.Windows.Forms.Label lblCiudadSede;
        private System.Windows.Forms.Label lblDireccionSede;
        private System.Windows.Forms.Label lblHorarioAperturaSede;
        private System.Windows.Forms.Label lblHorarioCierreSede;
        private System.Windows.Forms.DateTimePicker dtpHorarioCierreSede;
        private System.Windows.Forms.DateTimePicker dtpHorarioAperturaSede;
        private System.Windows.Forms.TextBox txtDireccionSede;
        private System.Windows.Forms.TextBox txtCiudadSede;
        private System.Windows.Forms.TextBox txtIdSede;
        private System.Windows.Forms.DataGridView dtgSedes;
        private System.Windows.Forms.Button btnSalirSedes;
        private System.Windows.Forms.Button btnLimpiarSedes;
        private System.Windows.Forms.Button btnEliminarSedes;
        private System.Windows.Forms.Button btnModificarSedes;
        private System.Windows.Forms.Button btnConsultarSedes;
        private System.Windows.Forms.Button btnAgregarSedes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}