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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.lblTipoDeServicioReserva = new System.Windows.Forms.Label();
            this.lblIdClienteReserva = new System.Windows.Forms.Label();
            this.lblPreferenciasReservaas = new System.Windows.Forms.Label();
            this.lblHoraReserva = new System.Windows.Forms.Label();
            this.lblSeleccionProducto = new System.Windows.Forms.Label();
            this.lblIdSedeReservas = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpHorainicioR = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdClienteReservas = new System.Windows.Forms.TextBox();
            this.txtPreferenciasReservas = new System.Windows.Forms.TextBox();
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
            this.cmbSeleccionProducto = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblHorafin = new System.Windows.Forms.Label();
            this.dtpHorafinR = new System.Windows.Forms.DateTimePicker();
            this.lblSeleccionarProfesional = new System.Windows.Forms.Label();
            this.cmbSeleccionarProfesional = new System.Windows.Forms.ComboBox();
            this.cmbSedesReservas = new System.Windows.Forms.ComboBox();
            this.cmbAmPmHoraFinCita = new System.Windows.Forms.ComboBox();
            this.cmbAMPMHoraInicioCita = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.BackColor = System.Drawing.Color.LightPink;
            this.lblIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReserva.Location = new System.Drawing.Point(11, 56);
            this.lblIdReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(69, 13);
            this.lblIdReserva.TabIndex = 0;
            this.lblIdReserva.Text = "Id Reserva";
            // 
            // lblTipoDeServicioReserva
            // 
            this.lblTipoDeServicioReserva.AutoSize = true;
            this.lblTipoDeServicioReserva.BackColor = System.Drawing.Color.LightPink;
            this.lblTipoDeServicioReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeServicioReserva.Location = new System.Drawing.Point(11, 106);
            this.lblTipoDeServicioReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDeServicioReserva.Name = "lblTipoDeServicioReserva";
            this.lblTipoDeServicioReserva.Size = new System.Drawing.Size(68, 13);
            this.lblTipoDeServicioReserva.TabIndex = 1;
            this.lblTipoDeServicioReserva.Text = "Id Servicio";
            // 
            // lblIdClienteReserva
            // 
            this.lblIdClienteReserva.AutoSize = true;
            this.lblIdClienteReserva.BackColor = System.Drawing.Color.LightPink;
            this.lblIdClienteReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClienteReserva.Location = new System.Drawing.Point(388, 88);
            this.lblIdClienteReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdClienteReserva.Name = "lblIdClienteReserva";
            this.lblIdClienteReserva.Size = new System.Drawing.Size(61, 13);
            this.lblIdClienteReserva.TabIndex = 3;
            this.lblIdClienteReserva.Text = "Id Cliente";
            // 
            // lblPreferenciasReservaas
            // 
            this.lblPreferenciasReservaas.AutoSize = true;
            this.lblPreferenciasReservaas.BackColor = System.Drawing.Color.LightPink;
            this.lblPreferenciasReservaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferenciasReservaas.Location = new System.Drawing.Point(374, 163);
            this.lblPreferenciasReservaas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreferenciasReservaas.Name = "lblPreferenciasReservaas";
            this.lblPreferenciasReservaas.Size = new System.Drawing.Size(147, 13);
            this.lblPreferenciasReservaas.TabIndex = 4;
            this.lblPreferenciasReservaas.Text = "Preferencias para tu cita";
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.BackColor = System.Drawing.Color.LightPink;
            this.lblHoraReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraReserva.Location = new System.Drawing.Point(407, 242);
            this.lblHoraReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(93, 13);
            this.lblHoraReserva.TabIndex = 5;
            this.lblHoraReserva.Text = "Hora inicio cita";
            // 
            // lblSeleccionProducto
            // 
            this.lblSeleccionProducto.AutoSize = true;
            this.lblSeleccionProducto.BackColor = System.Drawing.Color.LightPink;
            this.lblSeleccionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionProducto.Location = new System.Drawing.Point(11, 259);
            this.lblSeleccionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionProducto.Name = "lblSeleccionProducto";
            this.lblSeleccionProducto.Size = new System.Drawing.Size(142, 13);
            this.lblSeleccionProducto.TabIndex = 6;
            this.lblSeleccionProducto.Text = "Seleccione un producto";
            // 
            // lblIdSedeReservas
            // 
            this.lblIdSedeReservas.AutoSize = true;
            this.lblIdSedeReservas.BackColor = System.Drawing.Color.LightPink;
            this.lblIdSedeReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSedeReservas.Location = new System.Drawing.Point(11, 212);
            this.lblIdSedeReservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdSedeReservas.Name = "lblIdSedeReservas";
            this.lblIdSedeReservas.Size = new System.Drawing.Size(36, 13);
            this.lblIdSedeReservas.TabIndex = 7;
            this.lblIdSedeReservas.Text = "Sede";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.BackColor = System.Drawing.Color.LightPink;
            this.lblFechaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(11, 144);
            this.lblFechaReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(93, 13);
            this.lblFechaReserva.TabIndex = 8;
            this.lblFechaReserva.Text = "Fecha Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(179, 142);
            this.dtpFechaReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(96, 24);
            this.dtpFechaReserva.TabIndex = 9;
            // 
            // dtpHorainicioR
            // 
            this.dtpHorainicioR.CustomFormat = "hh:mm tt";
            this.dtpHorainicioR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorainicioR.Location = new System.Drawing.Point(545, 234);
            this.dtpHorainicioR.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHorainicioR.Name = "dtpHorainicioR";
            this.dtpHorainicioR.ShowUpDown = true;
            this.dtpHorainicioR.Size = new System.Drawing.Size(128, 24);
            this.dtpHorainicioR.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightPink;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 416);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 12;
            // 
            // txtIdClienteReservas
            // 
            this.txtIdClienteReservas.BackColor = System.Drawing.Color.LightPink;
            this.txtIdClienteReservas.Location = new System.Drawing.Point(556, 88);
            this.txtIdClienteReservas.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdClienteReservas.Name = "txtIdClienteReservas";
            this.txtIdClienteReservas.Size = new System.Drawing.Size(159, 24);
            this.txtIdClienteReservas.TabIndex = 14;
            this.txtIdClienteReservas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdClienteReservas_KeyPress);
            // 
            // txtPreferenciasReservas
            // 
            this.txtPreferenciasReservas.BackColor = System.Drawing.Color.LightPink;
            this.txtPreferenciasReservas.Location = new System.Drawing.Point(545, 139);
            this.txtPreferenciasReservas.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreferenciasReservas.Multiline = true;
            this.txtPreferenciasReservas.Name = "txtPreferenciasReservas";
            this.txtPreferenciasReservas.Size = new System.Drawing.Size(255, 50);
            this.txtPreferenciasReservas.TabIndex = 16;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.BackColor = System.Drawing.Color.LightPink;
            this.txtIdReserva.Location = new System.Drawing.Point(179, 56);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(115, 24);
            this.txtIdReserva.TabIndex = 18;
            this.txtIdReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdReserva_KeyPress);
            // 
            // btnSalirReservas
            // 
            this.btnSalirReservas.BackColor = System.Drawing.Color.LightPink;
            this.btnSalirReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirReservas.Location = new System.Drawing.Point(619, 318);
            this.btnSalirReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirReservas.Name = "btnSalirReservas";
            this.btnSalirReservas.Size = new System.Drawing.Size(94, 50);
            this.btnSalirReservas.TabIndex = 36;
            this.btnSalirReservas.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalirReservas, "Cerrar el formulario");
            this.btnSalirReservas.UseVisualStyleBackColor = false;
            this.btnSalirReservas.Click += new System.EventHandler(this.btnSalirReservas_Click);
            // 
            // btnLimpiarReservas
            // 
            this.btnLimpiarReservas.BackColor = System.Drawing.Color.LightPink;
            this.btnLimpiarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReservas.Location = new System.Drawing.Point(501, 318);
            this.btnLimpiarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarReservas.Name = "btnLimpiarReservas";
            this.btnLimpiarReservas.Size = new System.Drawing.Size(94, 50);
            this.btnLimpiarReservas.TabIndex = 35;
            this.btnLimpiarReservas.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiarReservas, "Limpiar campos");
            this.btnLimpiarReservas.UseVisualStyleBackColor = false;
            this.btnLimpiarReservas.Click += new System.EventHandler(this.btnLimpiarReservas_Click);
            // 
            // btnEliminarReservas
            // 
            this.btnEliminarReservas.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReservas.Location = new System.Drawing.Point(395, 318);
            this.btnEliminarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarReservas.Name = "btnEliminarReservas";
            this.btnEliminarReservas.Size = new System.Drawing.Size(94, 50);
            this.btnEliminarReservas.TabIndex = 34;
            this.btnEliminarReservas.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminarReservas, "Se eliminara permanentemente");
            this.btnEliminarReservas.UseVisualStyleBackColor = false;
            this.btnEliminarReservas.Click += new System.EventHandler(this.btnEliminarReservas_Click);
            // 
            // btnModificarReservas
            // 
            this.btnModificarReservas.BackColor = System.Drawing.Color.LightPink;
            this.btnModificarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReservas.Location = new System.Drawing.Point(287, 318);
            this.btnModificarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarReservas.Name = "btnModificarReservas";
            this.btnModificarReservas.Size = new System.Drawing.Size(94, 50);
            this.btnModificarReservas.TabIndex = 33;
            this.btnModificarReservas.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificarReservas, "Modificar registro");
            this.btnModificarReservas.UseVisualStyleBackColor = false;
            this.btnModificarReservas.Click += new System.EventHandler(this.btnModificarReservas_Click);
            // 
            // btnConsultarReservas
            // 
            this.btnConsultarReservas.BackColor = System.Drawing.Color.LightPink;
            this.btnConsultarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReservas.Location = new System.Drawing.Point(183, 318);
            this.btnConsultarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarReservas.Name = "btnConsultarReservas";
            this.btnConsultarReservas.Size = new System.Drawing.Size(94, 50);
            this.btnConsultarReservas.TabIndex = 32;
            this.btnConsultarReservas.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultarReservas, "Consultar reservas");
            this.btnConsultarReservas.UseVisualStyleBackColor = false;
            this.btnConsultarReservas.Click += new System.EventHandler(this.btnConsultarReservas_Click);
            // 
            // btnAgregarReservas
            // 
            this.btnAgregarReservas.BackColor = System.Drawing.Color.LightPink;
            this.btnAgregarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReservas.Location = new System.Drawing.Point(76, 318);
            this.btnAgregarReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarReservas.Name = "btnAgregarReservas";
            this.btnAgregarReservas.Size = new System.Drawing.Size(94, 50);
            this.btnAgregarReservas.TabIndex = 31;
            this.btnAgregarReservas.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregarReservas, "crear una reserva");
            this.btnAgregarReservas.UseVisualStyleBackColor = false;
            this.btnAgregarReservas.Click += new System.EventHandler(this.btnAgregarReservas_Click);
            // 
            // dtgReservas
            // 
            this.dtgReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.GridColor = System.Drawing.Color.White;
            this.dtgReservas.Location = new System.Drawing.Point(109, 382);
            this.dtgReservas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.RowHeadersWidth = 51;
            this.dtgReservas.RowTemplate.Height = 24;
            this.dtgReservas.Size = new System.Drawing.Size(604, 143);
            this.dtgReservas.TabIndex = 30;
            this.dtgReservas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgReservas_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.agregarToolStripMenuItem.Text = "&Menu Reservas";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem1.Text = "&Agregar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.limpiarToolStripMenuItem.Text = "&Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cmbSeleccionProducto
            // 
            this.cmbSeleccionProducto.BackColor = System.Drawing.Color.LightPink;
            this.cmbSeleccionProducto.FormattingEnabled = true;
            this.cmbSeleccionProducto.Location = new System.Drawing.Point(179, 254);
            this.cmbSeleccionProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSeleccionProducto.Name = "cmbSeleccionProducto";
            this.cmbSeleccionProducto.Size = new System.Drawing.Size(159, 24);
            this.cmbSeleccionProducto.TabIndex = 41;
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.BackColor = System.Drawing.Color.LightPink;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(179, 106);
            this.cmbTipoServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(115, 24);
            this.cmbTipoServicio.TabIndex = 42;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.BackColor = System.Drawing.Color.LightPink;
            this.lblTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCliente.Location = new System.Drawing.Point(11, 181);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(75, 13);
            this.lblTipoCliente.TabIndex = 43;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.BackColor = System.Drawing.Color.LightPink;
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Frecuente",
            "No Frecuente",
            "Primera Vez"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(179, 170);
            this.cmbTipoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(140, 24);
            this.cmbTipoCliente.TabIndex = 44;
            // 
            // lblHorafin
            // 
            this.lblHorafin.AutoSize = true;
            this.lblHorafin.BackColor = System.Drawing.Color.LightPink;
            this.lblHorafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorafin.Location = new System.Drawing.Point(407, 286);
            this.lblHorafin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorafin.Name = "lblHorafin";
            this.lblHorafin.Size = new System.Drawing.Size(77, 13);
            this.lblHorafin.TabIndex = 45;
            this.lblHorafin.Text = "Hora fin cita";
            // 
            // dtpHorafinR
            // 
            this.dtpHorafinR.CustomFormat = "hh:mm tt";
            this.dtpHorafinR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorafinR.Location = new System.Drawing.Point(545, 279);
            this.dtpHorafinR.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHorafinR.Name = "dtpHorafinR";
            this.dtpHorafinR.ShowUpDown = true;
            this.dtpHorafinR.Size = new System.Drawing.Size(128, 24);
            this.dtpHorafinR.TabIndex = 46;
            // 
            // lblSeleccionarProfesional
            // 
            this.lblSeleccionarProfesional.AutoSize = true;
            this.lblSeleccionarProfesional.BackColor = System.Drawing.Color.LightPink;
            this.lblSeleccionarProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarProfesional.Location = new System.Drawing.Point(388, 50);
            this.lblSeleccionarProfesional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarProfesional.Name = "lblSeleccionarProfesional";
            this.lblSeleccionarProfesional.Size = new System.Drawing.Size(138, 13);
            this.lblSeleccionarProfesional.TabIndex = 47;
            this.lblSeleccionarProfesional.Text = "seleccionar profesional";
            // 
            // cmbSeleccionarProfesional
            // 
            this.cmbSeleccionarProfesional.BackColor = System.Drawing.Color.LightPink;
            this.cmbSeleccionarProfesional.FormattingEnabled = true;
            this.cmbSeleccionarProfesional.Location = new System.Drawing.Point(556, 45);
            this.cmbSeleccionarProfesional.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSeleccionarProfesional.Name = "cmbSeleccionarProfesional";
            this.cmbSeleccionarProfesional.Size = new System.Drawing.Size(159, 24);
            this.cmbSeleccionarProfesional.TabIndex = 48;
            // 
            // cmbSedesReservas
            // 
            this.cmbSedesReservas.BackColor = System.Drawing.Color.LightPink;
            this.cmbSedesReservas.FormattingEnabled = true;
            this.cmbSedesReservas.Location = new System.Drawing.Point(179, 214);
            this.cmbSedesReservas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSedesReservas.Name = "cmbSedesReservas";
            this.cmbSedesReservas.Size = new System.Drawing.Size(140, 24);
            this.cmbSedesReservas.TabIndex = 49;
            // 
            // cmbAmPmHoraFinCita
            // 
            this.cmbAmPmHoraFinCita.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM"});
            this.cmbAmPmHoraFinCita.BackColor = System.Drawing.Color.LightPink;
            this.cmbAmPmHoraFinCita.FormattingEnabled = true;
            this.cmbAmPmHoraFinCita.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPmHoraFinCita.Location = new System.Drawing.Point(707, 279);
            this.cmbAmPmHoraFinCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAmPmHoraFinCita.Name = "cmbAmPmHoraFinCita";
            this.cmbAmPmHoraFinCita.Size = new System.Drawing.Size(63, 24);
            this.cmbAmPmHoraFinCita.TabIndex = 51;
            // 
            // cmbAMPMHoraInicioCita
            // 
            this.cmbAMPMHoraInicioCita.BackColor = System.Drawing.Color.LightPink;
            this.cmbAMPMHoraInicioCita.FormattingEnabled = true;
            this.cmbAMPMHoraInicioCita.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAMPMHoraInicioCita.Location = new System.Drawing.Point(707, 232);
            this.cmbAMPMHoraInicioCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAMPMHoraInicioCita.Name = "cmbAMPMHoraInicioCita";
            this.cmbAMPMHoraInicioCita.Size = new System.Drawing.Size(63, 24);
            this.cmbAMPMHoraInicioCita.TabIndex = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1375, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 550);
            this.Controls.Add(this.cmbAmPmHoraFinCita);
            this.Controls.Add(this.cmbAMPMHoraInicioCita);
            this.Controls.Add(this.cmbSedesReservas);
            this.Controls.Add(this.cmbSeleccionarProfesional);
            this.Controls.Add(this.lblSeleccionarProfesional);
            this.Controls.Add(this.dtpHorafinR);
            this.Controls.Add(this.lblHorafin);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.cmbSeleccionProducto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSalirReservas);
            this.Controls.Add(this.btnLimpiarReservas);
            this.Controls.Add(this.btnEliminarReservas);
            this.Controls.Add(this.btnModificarReservas);
            this.Controls.Add(this.btnConsultarReservas);
            this.Controls.Add(this.btnAgregarReservas);
            this.Controls.Add(this.dtgReservas);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.txtPreferenciasReservas);
            this.Controls.Add(this.txtIdClienteReservas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpHorainicioR);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.lblIdSedeReservas);
            this.Controls.Add(this.lblSeleccionProducto);
            this.Controls.Add(this.lblHoraReserva);
            this.Controls.Add(this.lblPreferenciasReservaas);
            this.Controls.Add(this.lblIdClienteReserva);
            this.Controls.Add(this.lblTipoDeServicioReserva);
            this.Controls.Add(this.lblIdReserva);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReservas";
            this.Text = "Reservas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReservas_FormClosing);
            this.Load += new System.EventHandler(this.frmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.Label lblTipoDeServicioReserva;
        private System.Windows.Forms.Label lblIdClienteReserva;
        private System.Windows.Forms.Label lblPreferenciasReservaas;
        private System.Windows.Forms.Label lblHoraReserva;
        private System.Windows.Forms.Label lblSeleccionProducto;
        private System.Windows.Forms.Label lblIdSedeReservas;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpHorainicioR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdClienteReservas;
        private System.Windows.Forms.TextBox txtPreferenciasReservas;
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
        private System.Windows.Forms.ComboBox cmbSeleccionProducto;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label lblHorafin;
        private System.Windows.Forms.DateTimePicker dtpHorafinR;
        private System.Windows.Forms.Label lblSeleccionarProfesional;
        private System.Windows.Forms.ComboBox cmbSeleccionarProfesional;
        private System.Windows.Forms.ComboBox cmbSedesReservas;
        private System.Windows.Forms.ComboBox cmbAmPmHoraFinCita;
        private System.Windows.Forms.ComboBox cmbAMPMHoraInicioCita;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}