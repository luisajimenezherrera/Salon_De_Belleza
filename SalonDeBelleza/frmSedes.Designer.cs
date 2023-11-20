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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSedes));
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
            this.cmbAMPMHoraApertura = new System.Windows.Forms.ComboBox();
            this.cmbAmPmHoraCierreS = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSedes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdSede
            // 
            this.lblIdSede.AutoSize = true;
            this.lblIdSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblIdSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSede.ForeColor = System.Drawing.Color.Black;
            this.lblIdSede.Location = new System.Drawing.Point(20, 44);
            this.lblIdSede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdSede.Name = "lblIdSede";
            this.lblIdSede.Size = new System.Drawing.Size(51, 13);
            this.lblIdSede.TabIndex = 0;
            this.lblIdSede.Text = "Id Sede";
            // 
            // lblCiudadSede
            // 
            this.lblCiudadSede.AutoSize = true;
            this.lblCiudadSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCiudadSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadSede.ForeColor = System.Drawing.Color.Black;
            this.lblCiudadSede.Location = new System.Drawing.Point(20, 85);
            this.lblCiudadSede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudadSede.Name = "lblCiudadSede";
            this.lblCiudadSede.Size = new System.Drawing.Size(46, 13);
            this.lblCiudadSede.TabIndex = 1;
            this.lblCiudadSede.Text = "Ciudad";
            // 
            // lblDireccionSede
            // 
            this.lblDireccionSede.AutoSize = true;
            this.lblDireccionSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDireccionSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionSede.ForeColor = System.Drawing.Color.Black;
            this.lblDireccionSede.Location = new System.Drawing.Point(20, 141);
            this.lblDireccionSede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionSede.Name = "lblDireccionSede";
            this.lblDireccionSede.Size = new System.Drawing.Size(61, 13);
            this.lblDireccionSede.TabIndex = 2;
            this.lblDireccionSede.Text = "Direccion";
            // 
            // lblHorarioAperturaSede
            // 
            this.lblHorarioAperturaSede.AutoSize = true;
            this.lblHorarioAperturaSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHorarioAperturaSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioAperturaSede.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioAperturaSede.Location = new System.Drawing.Point(20, 186);
            this.lblHorarioAperturaSede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorarioAperturaSede.Name = "lblHorarioAperturaSede";
            this.lblHorarioAperturaSede.Size = new System.Drawing.Size(100, 13);
            this.lblHorarioAperturaSede.TabIndex = 3;
            this.lblHorarioAperturaSede.Text = "Horario Apertura";
            // 
            // lblHorarioCierreSede
            // 
            this.lblHorarioCierreSede.AutoSize = true;
            this.lblHorarioCierreSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHorarioCierreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioCierreSede.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioCierreSede.Location = new System.Drawing.Point(20, 221);
            this.lblHorarioCierreSede.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorarioCierreSede.Name = "lblHorarioCierreSede";
            this.lblHorarioCierreSede.Size = new System.Drawing.Size(85, 13);
            this.lblHorarioCierreSede.TabIndex = 4;
            this.lblHorarioCierreSede.Text = "Horario Cierre";
            // 
            // dtpHorarioCierreSede
            // 
            this.dtpHorarioCierreSede.CalendarMonthBackground = System.Drawing.Color.LightPink;
            this.dtpHorarioCierreSede.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dtpHorarioCierreSede.CalendarTrailingForeColor = System.Drawing.Color.Pink;
            this.dtpHorarioCierreSede.CustomFormat = "hh:mm tt";
            this.dtpHorarioCierreSede.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioCierreSede.Location = new System.Drawing.Point(141, 223);
            this.dtpHorarioCierreSede.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHorarioCierreSede.Name = "dtpHorarioCierreSede";
            this.dtpHorarioCierreSede.ShowUpDown = true;
            this.dtpHorarioCierreSede.Size = new System.Drawing.Size(130, 24);
            this.dtpHorarioCierreSede.TabIndex = 5;
            // 
            // dtpHorarioAperturaSede
            // 
            this.dtpHorarioAperturaSede.CalendarMonthBackground = System.Drawing.Color.LightPink;
            this.dtpHorarioAperturaSede.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dtpHorarioAperturaSede.CalendarTrailingForeColor = System.Drawing.Color.Pink;
            this.dtpHorarioAperturaSede.CustomFormat = "hh:mm tt";
            this.dtpHorarioAperturaSede.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioAperturaSede.Location = new System.Drawing.Point(141, 186);
            this.dtpHorarioAperturaSede.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHorarioAperturaSede.Name = "dtpHorarioAperturaSede";
            this.dtpHorarioAperturaSede.ShowUpDown = true;
            this.dtpHorarioAperturaSede.Size = new System.Drawing.Size(130, 24);
            this.dtpHorarioAperturaSede.TabIndex = 6;
            // 
            // txtDireccionSede
            // 
            this.txtDireccionSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDireccionSede.Location = new System.Drawing.Point(141, 141);
            this.txtDireccionSede.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionSede.Name = "txtDireccionSede";
            this.txtDireccionSede.Size = new System.Drawing.Size(130, 24);
            this.txtDireccionSede.TabIndex = 7;
            // 
            // txtCiudadSede
            // 
            this.txtCiudadSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCiudadSede.Location = new System.Drawing.Point(141, 85);
            this.txtCiudadSede.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudadSede.Name = "txtCiudadSede";
            this.txtCiudadSede.Size = new System.Drawing.Size(130, 24);
            this.txtCiudadSede.TabIndex = 8;
            this.txtCiudadSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudadSede_KeyPress);
            // 
            // txtIdSede
            // 
            this.txtIdSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtIdSede.Location = new System.Drawing.Point(141, 33);
            this.txtIdSede.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdSede.Name = "txtIdSede";
            this.txtIdSede.Size = new System.Drawing.Size(130, 24);
            this.txtIdSede.TabIndex = 9;
            this.txtIdSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdSede_KeyPress);
            // 
            // dtgSedes
            // 
            this.dtgSedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSedes.Location = new System.Drawing.Point(390, 44);
            this.dtgSedes.Margin = new System.Windows.Forms.Padding(2);
            this.dtgSedes.Name = "dtgSedes";
            this.dtgSedes.RowHeadersWidth = 51;
            this.dtgSedes.RowTemplate.Height = 24;
            this.dtgSedes.Size = new System.Drawing.Size(785, 135);
            this.dtgSedes.TabIndex = 10;
            this.dtgSedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSedes_CellContentClick);
            this.dtgSedes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgSedes_MouseClick);
            // 
            // btnSalirSedes
            // 
            this.btnSalirSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalirSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirSedes.Location = new System.Drawing.Point(1067, 223);
            this.btnSalirSedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirSedes.Name = "btnSalirSedes";
            this.btnSalirSedes.Size = new System.Drawing.Size(98, 31);
            this.btnSalirSedes.TabIndex = 29;
            this.btnSalirSedes.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalirSedes, "Cerrar");
            this.btnSalirSedes.UseVisualStyleBackColor = false;
            this.btnSalirSedes.Click += new System.EventHandler(this.btnSalirSedes_Click);
            // 
            // btnLimpiarSedes
            // 
            this.btnLimpiarSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiarSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarSedes.Location = new System.Drawing.Point(950, 223);
            this.btnLimpiarSedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarSedes.Name = "btnLimpiarSedes";
            this.btnLimpiarSedes.Size = new System.Drawing.Size(98, 31);
            this.btnLimpiarSedes.TabIndex = 28;
            this.btnLimpiarSedes.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiarSedes, "Limpiar campos");
            this.btnLimpiarSedes.UseVisualStyleBackColor = false;
            this.btnLimpiarSedes.Click += new System.EventHandler(this.btnLimpiarSedes_Click);
            // 
            // btnEliminarSedes
            // 
            this.btnEliminarSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSedes.Location = new System.Drawing.Point(843, 223);
            this.btnEliminarSedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarSedes.Name = "btnEliminarSedes";
            this.btnEliminarSedes.Size = new System.Drawing.Size(98, 31);
            this.btnEliminarSedes.TabIndex = 27;
            this.btnEliminarSedes.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminarSedes, "Eliminar Permanentemente");
            this.btnEliminarSedes.UseVisualStyleBackColor = false;
            this.btnEliminarSedes.Click += new System.EventHandler(this.btnEliminarSedes_Click);
            // 
            // btnModificarSedes
            // 
            this.btnModificarSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificarSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSedes.Location = new System.Drawing.Point(737, 223);
            this.btnModificarSedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarSedes.Name = "btnModificarSedes";
            this.btnModificarSedes.Size = new System.Drawing.Size(98, 31);
            this.btnModificarSedes.TabIndex = 26;
            this.btnModificarSedes.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificarSedes, "Modifiar Sedes");
            this.btnModificarSedes.UseVisualStyleBackColor = false;
            this.btnModificarSedes.Click += new System.EventHandler(this.btnModificarSedes_Click);
            // 
            // btnConsultarSedes
            // 
            this.btnConsultarSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConsultarSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSedes.Location = new System.Drawing.Point(634, 223);
            this.btnConsultarSedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarSedes.Name = "btnConsultarSedes";
            this.btnConsultarSedes.Size = new System.Drawing.Size(98, 31);
            this.btnConsultarSedes.TabIndex = 25;
            this.btnConsultarSedes.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultarSedes, "Consultar Sedes");
            this.btnConsultarSedes.UseVisualStyleBackColor = false;
            this.btnConsultarSedes.Click += new System.EventHandler(this.btnConsultarSedes_Click);
            // 
            // btnAgregarSedes
            // 
            this.btnAgregarSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSedes.Location = new System.Drawing.Point(510, 223);
            this.btnAgregarSedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarSedes.Name = "btnAgregarSedes";
            this.btnAgregarSedes.Size = new System.Drawing.Size(98, 31);
            this.btnAgregarSedes.TabIndex = 24;
            this.btnAgregarSedes.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregarSedes, "Ingresas Sede");
            this.btnAgregarSedes.UseVisualStyleBackColor = false;
            this.btnAgregarSedes.Click += new System.EventHandler(this.btnAgregarSedes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.agregarToolStripMenuItem.Text = "&Menu Sedes";
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
            // cmbAMPMHoraApertura
            // 
            this.cmbAMPMHoraApertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbAMPMHoraApertura.FormattingEnabled = true;
            this.cmbAMPMHoraApertura.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAMPMHoraApertura.Location = new System.Drawing.Point(292, 186);
            this.cmbAMPMHoraApertura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAMPMHoraApertura.Name = "cmbAMPMHoraApertura";
            this.cmbAMPMHoraApertura.Size = new System.Drawing.Size(59, 24);
            this.cmbAMPMHoraApertura.TabIndex = 31;
            // 
            // cmbAmPmHoraCierreS
            // 
            this.cmbAmPmHoraCierreS.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM"});
            this.cmbAmPmHoraCierreS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbAmPmHoraCierreS.FormattingEnabled = true;
            this.cmbAmPmHoraCierreS.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPmHoraCierreS.Location = new System.Drawing.Point(292, 227);
            this.cmbAmPmHoraCierreS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAmPmHoraCierreS.Name = "cmbAmPmHoraCierreS";
            this.cmbAmPmHoraCierreS.Size = new System.Drawing.Size(59, 24);
            this.cmbAmPmHoraCierreS.TabIndex = 32;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
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
            this.pictureBox1.Size = new System.Drawing.Size(1226, 596);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frmSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.cmbAmPmHoraCierreS);
            this.Controls.Add(this.cmbAMPMHoraApertura);
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
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSedes";
            this.Text = "Sedes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSedes_FormClosing);
            this.Load += new System.EventHandler(this.frmSedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSedes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbAMPMHoraApertura;
        private System.Windows.Forms.ComboBox cmbAmPmHoraCierreS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}