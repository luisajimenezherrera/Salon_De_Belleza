namespace SalonDeBelleza
{
    partial class frmReservas
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
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.lblTipoDeServicioReserva = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblIdClienteReserva = new System.Windows.Forms.Label();
            this.lblPreferenciasReservaas = new System.Windows.Forms.Label();
            this.lblHoraReserva = new System.Windows.Forms.Label();
            this.lblSeleccionProducto = new System.Windows.Forms.Label();
            this.lblIdSedeReservas = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdClienteReservas = new System.Windows.Forms.TextBox();
            this.txtPreferenciasReservas = new System.Windows.Forms.TextBox();
            this.txtIdSedeReservas = new System.Windows.Forms.TextBox();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.btnSalirReservas = new System.Windows.Forms.Button();
            this.btnLimpiarReservas = new System.Windows.Forms.Button();
            this.btnEliminarReservas = new System.Windows.Forms.Button();
            this.btnModificarReservas = new System.Windows.Forms.Button();
            this.btnConsultarReservas = new System.Windows.Forms.Button();
            this.btnAgregarReservas = new System.Windows.Forms.Button();
            this.dtgReservas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbFrecuenteReserva = new System.Windows.Forms.RadioButton();
            this.rdbNoFrecuenteReserva = new System.Windows.Forms.RadioButton();
            this.cmbSeleccionProducto = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Location = new System.Drawing.Point(12, 51);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(73, 16);
            this.lblIdReserva.TabIndex = 0;
            this.lblIdReserva.Text = "Id Reserva";
            // 
            // lblTipoDeServicioReserva
            // 
            this.lblTipoDeServicioReserva.AutoSize = true;
            this.lblTipoDeServicioReserva.Location = new System.Drawing.Point(769, 156);
            this.lblTipoDeServicioReserva.Name = "lblTipoDeServicioReserva";
            this.lblTipoDeServicioReserva.Size = new System.Drawing.Size(106, 16);
            this.lblTipoDeServicioReserva.TabIndex = 1;
            this.lblTipoDeServicioReserva.Text = "Tipo de Servicio";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(779, 62);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(96, 16);
            this.lblTipoCliente.TabIndex = 2;
            this.lblTipoCliente.Text = "Tipo de cliente";
            // 
            // lblIdClienteReserva
            // 
            this.lblIdClienteReserva.AutoSize = true;
            this.lblIdClienteReserva.Location = new System.Drawing.Point(480, 105);
            this.lblIdClienteReserva.Name = "lblIdClienteReserva";
            this.lblIdClienteReserva.Size = new System.Drawing.Size(62, 16);
            this.lblIdClienteReserva.TabIndex = 3;
            this.lblIdClienteReserva.Text = "Id Cliente";
            // 
            // lblPreferenciasReservaas
            // 
            this.lblPreferenciasReservaas.AutoSize = true;
            this.lblPreferenciasReservaas.Location = new System.Drawing.Point(450, 35);
            this.lblPreferenciasReservaas.Name = "lblPreferenciasReservaas";
            this.lblPreferenciasReservaas.Size = new System.Drawing.Size(83, 16);
            this.lblPreferenciasReservaas.TabIndex = 4;
            this.lblPreferenciasReservaas.Text = "Preferencias";
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Location = new System.Drawing.Point(12, 105);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(92, 16);
            this.lblHoraReserva.TabIndex = 5;
            this.lblHoraReserva.Text = "Hora Reserva";
            // 
            // lblSeleccionProducto
            // 
            this.lblSeleccionProducto.AutoSize = true;
            this.lblSeleccionProducto.Location = new System.Drawing.Point(391, 72);
            this.lblSeleccionProducto.Name = "lblSeleccionProducto";
            this.lblSeleccionProducto.Size = new System.Drawing.Size(148, 16);
            this.lblSeleccionProducto.TabIndex = 6;
            this.lblSeleccionProducto.Text = "Seleccione un producto";
            // 
            // lblIdSedeReservas
            // 
            this.lblIdSedeReservas.AutoSize = true;
            this.lblIdSedeReservas.Location = new System.Drawing.Point(480, 156);
            this.lblIdSedeReservas.Name = "lblIdSedeReservas";
            this.lblIdSedeReservas.Size = new System.Drawing.Size(54, 16);
            this.lblIdSedeReservas.TabIndex = 7;
            this.lblIdSedeReservas.Text = "Id Sede";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(12, 164);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(100, 16);
            this.lblFechaReserva.TabIndex = 8;
            this.lblFechaReserva.Text = "Fecha Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaReserva.Location = new System.Drawing.Point(127, 164);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(145, 22);
            this.dtpFechaReserva.TabIndex = 9;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(127, 106);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(145, 22);
            this.dtpHoraReserva.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 12;
            // 
            // txtIdClienteReservas
            // 
            this.txtIdClienteReservas.Location = new System.Drawing.Point(545, 104);
            this.txtIdClienteReservas.Name = "txtIdClienteReservas";
            this.txtIdClienteReservas.Size = new System.Drawing.Size(100, 22);
            this.txtIdClienteReservas.TabIndex = 14;
            // 
            // txtPreferenciasReservas
            // 
            this.txtPreferenciasReservas.Location = new System.Drawing.Point(545, 35);
            this.txtPreferenciasReservas.Name = "txtPreferenciasReservas";
            this.txtPreferenciasReservas.Size = new System.Drawing.Size(212, 22);
            this.txtPreferenciasReservas.TabIndex = 16;
            // 
            // txtIdSedeReservas
            // 
            this.txtIdSedeReservas.Location = new System.Drawing.Point(545, 157);
            this.txtIdSedeReservas.Name = "txtIdSedeReservas";
            this.txtIdSedeReservas.Size = new System.Drawing.Size(100, 22);
            this.txtIdSedeReservas.TabIndex = 17;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(127, 51);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(100, 22);
            this.txtIdReserva.TabIndex = 18;
            // 
            // btnSalirReservas
            // 
            this.btnSalirReservas.Location = new System.Drawing.Point(757, 227);
            this.btnSalirReservas.Name = "btnSalirReservas";
            this.btnSalirReservas.Size = new System.Drawing.Size(118, 31);
            this.btnSalirReservas.TabIndex = 36;
            this.btnSalirReservas.Text = "Salir";
            this.btnSalirReservas.UseVisualStyleBackColor = true;
            this.btnSalirReservas.Click += new System.EventHandler(this.btnSalirReservas_Click);
            // 
            // btnLimpiarReservas
            // 
            this.btnLimpiarReservas.Location = new System.Drawing.Point(623, 227);
            this.btnLimpiarReservas.Name = "btnLimpiarReservas";
            this.btnLimpiarReservas.Size = new System.Drawing.Size(118, 31);
            this.btnLimpiarReservas.TabIndex = 35;
            this.btnLimpiarReservas.Text = "Limpiar";
            this.btnLimpiarReservas.UseVisualStyleBackColor = true;
            this.btnLimpiarReservas.Click += new System.EventHandler(this.btnLimpiarReservas_Click);
            // 
            // btnEliminarReservas
            // 
            this.btnEliminarReservas.Location = new System.Drawing.Point(501, 227);
            this.btnEliminarReservas.Name = "btnEliminarReservas";
            this.btnEliminarReservas.Size = new System.Drawing.Size(118, 31);
            this.btnEliminarReservas.TabIndex = 34;
            this.btnEliminarReservas.Text = "Eliminar";
            this.btnEliminarReservas.UseVisualStyleBackColor = true;
            this.btnEliminarReservas.Click += new System.EventHandler(this.btnEliminarReservas_Click);
            // 
            // btnModificarReservas
            // 
            this.btnModificarReservas.Location = new System.Drawing.Point(379, 227);
            this.btnModificarReservas.Name = "btnModificarReservas";
            this.btnModificarReservas.Size = new System.Drawing.Size(118, 31);
            this.btnModificarReservas.TabIndex = 33;
            this.btnModificarReservas.Text = "Modificar";
            this.btnModificarReservas.UseVisualStyleBackColor = true;
            this.btnModificarReservas.Click += new System.EventHandler(this.btnModificarReservas_Click);
            // 
            // btnConsultarReservas
            // 
            this.btnConsultarReservas.Location = new System.Drawing.Point(259, 227);
            this.btnConsultarReservas.Name = "btnConsultarReservas";
            this.btnConsultarReservas.Size = new System.Drawing.Size(118, 31);
            this.btnConsultarReservas.TabIndex = 32;
            this.btnConsultarReservas.Text = "Consultar";
            this.btnConsultarReservas.UseVisualStyleBackColor = true;
            this.btnConsultarReservas.Click += new System.EventHandler(this.btnConsultarReservas_Click);
            // 
            // btnAgregarReservas
            // 
            this.btnAgregarReservas.Location = new System.Drawing.Point(137, 227);
            this.btnAgregarReservas.Name = "btnAgregarReservas";
            this.btnAgregarReservas.Size = new System.Drawing.Size(118, 31);
            this.btnAgregarReservas.TabIndex = 31;
            this.btnAgregarReservas.Text = "Agregar";
            this.btnAgregarReservas.UseVisualStyleBackColor = true;
            this.btnAgregarReservas.Click += new System.EventHandler(this.btnAgregarReservas_Click);
            // 
            // dtgReservas
            // 
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.Location = new System.Drawing.Point(0, 264);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.RowHeadersWidth = 51;
            this.dtgReservas.RowTemplate.Height = 24;
            this.dtgReservas.Size = new System.Drawing.Size(1079, 178);
            this.dtgReservas.TabIndex = 30;
            this.dtgReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReservas_CellContentClick);
            this.dtgReservas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgReservas_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 30);
            this.menuStrip1.TabIndex = 38;
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
            // rdbFrecuenteReserva
            // 
            this.rdbFrecuenteReserva.AutoSize = true;
            this.rdbFrecuenteReserva.Location = new System.Drawing.Point(881, 60);
            this.rdbFrecuenteReserva.Name = "rdbFrecuenteReserva";
            this.rdbFrecuenteReserva.Size = new System.Drawing.Size(88, 20);
            this.rdbFrecuenteReserva.TabIndex = 39;
            this.rdbFrecuenteReserva.TabStop = true;
            this.rdbFrecuenteReserva.Text = "Frecuente";
            this.rdbFrecuenteReserva.UseVisualStyleBackColor = true;
            // 
            // rdbNoFrecuenteReserva
            // 
            this.rdbNoFrecuenteReserva.AutoSize = true;
            this.rdbNoFrecuenteReserva.Location = new System.Drawing.Point(881, 86);
            this.rdbNoFrecuenteReserva.Name = "rdbNoFrecuenteReserva";
            this.rdbNoFrecuenteReserva.Size = new System.Drawing.Size(104, 20);
            this.rdbNoFrecuenteReserva.TabIndex = 40;
            this.rdbNoFrecuenteReserva.TabStop = true;
            this.rdbNoFrecuenteReserva.Text = "No frecuente";
            this.rdbNoFrecuenteReserva.UseVisualStyleBackColor = true;
            // 
            // cmbSeleccionProducto
            // 
            this.cmbSeleccionProducto.FormattingEnabled = true;
            this.cmbSeleccionProducto.Location = new System.Drawing.Point(545, 72);
            this.cmbSeleccionProducto.Name = "cmbSeleccionProducto";
            this.cmbSeleccionProducto.Size = new System.Drawing.Size(121, 24);
            this.cmbSeleccionProducto.TabIndex = 41;
            this.cmbSeleccionProducto.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionProducto_SelectedIndexChanged);
            this.cmbSeleccionProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSeleccionProducto_MouseClick);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(881, 153);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoServicio.TabIndex = 42;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.cmbSeleccionProducto);
            this.Controls.Add(this.rdbNoFrecuenteReserva);
            this.Controls.Add(this.rdbFrecuenteReserva);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSalirReservas);
            this.Controls.Add(this.btnLimpiarReservas);
            this.Controls.Add(this.btnEliminarReservas);
            this.Controls.Add(this.btnModificarReservas);
            this.Controls.Add(this.btnConsultarReservas);
            this.Controls.Add(this.btnAgregarReservas);
            this.Controls.Add(this.dtgReservas);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.txtIdSedeReservas);
            this.Controls.Add(this.txtPreferenciasReservas);
            this.Controls.Add(this.txtIdClienteReservas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpHoraReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.lblIdSedeReservas);
            this.Controls.Add(this.lblSeleccionProducto);
            this.Controls.Add(this.lblHoraReserva);
            this.Controls.Add(this.lblPreferenciasReservaas);
            this.Controls.Add(this.lblIdClienteReserva);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.lblTipoDeServicioReserva);
            this.Controls.Add(this.lblIdReserva);
            this.Name = "frmReservas";
            this.Text = "Reservas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReservas_FormClosing);
            this.Load += new System.EventHandler(this.frmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.Label lblTipoDeServicioReserva;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblIdClienteReserva;
        private System.Windows.Forms.Label lblPreferenciasReservaas;
        private System.Windows.Forms.Label lblHoraReserva;
        private System.Windows.Forms.Label lblSeleccionProducto;
        private System.Windows.Forms.Label lblIdSedeReservas;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpHoraReserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdClienteReservas;
        private System.Windows.Forms.TextBox txtPreferenciasReservas;
        private System.Windows.Forms.TextBox txtIdSedeReservas;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Button btnSalirReservas;
        private System.Windows.Forms.Button btnLimpiarReservas;
        private System.Windows.Forms.Button btnEliminarReservas;
        private System.Windows.Forms.Button btnModificarReservas;
        private System.Windows.Forms.Button btnConsultarReservas;
        private System.Windows.Forms.Button btnAgregarReservas;
        private System.Windows.Forms.DataGridView dtgReservas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbFrecuenteReserva;
        private System.Windows.Forms.RadioButton rdbNoFrecuenteReserva;
        private System.Windows.Forms.ComboBox cmbSeleccionProducto;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
    }
}