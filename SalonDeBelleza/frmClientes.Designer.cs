namespace SalonDeBelleza
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblIdentificacionCliente = new System.Windows.Forms.Label();
            this.lblCiudadCliente = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblFechaNacimientoCliente = new System.Windows.Forms.Label();
            this.lblEdadCliente = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoCliente = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.txtCiudadCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtEdadCliente = new System.Windows.Forms.TextBox();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnLimpiarClientes = new System.Windows.Forms.Button();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNombreCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(627, 83);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(58, 19);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblApellidoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(627, 121);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(60, 19);
            this.lblApellidoCliente.TabIndex = 1;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblIdentificacionCliente
            // 
            this.lblIdentificacionCliente.AutoSize = true;
            this.lblIdentificacionCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblIdentificacionCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacionCliente.Location = new System.Drawing.Point(627, 160);
            this.lblIdentificacionCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            this.lblIdentificacionCliente.Size = new System.Drawing.Size(98, 19);
            this.lblIdentificacionCliente.TabIndex = 2;
            this.lblIdentificacionCliente.Text = "Identificacion";
            // 
            // lblCiudadCliente
            // 
            this.lblCiudadCliente.AutoSize = true;
            this.lblCiudadCliente.BackColor = System.Drawing.Color.LightPink;
            this.lblCiudadCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadCliente.Location = new System.Drawing.Point(959, 77);
            this.lblCiudadCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudadCliente.Name = "lblCiudadCliente";
            this.lblCiudadCliente.Size = new System.Drawing.Size(51, 19);
            this.lblCiudadCliente.TabIndex = 3;
            this.lblCiudadCliente.Text = "Ciudad";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.BackColor = System.Drawing.Color.LightPink;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(956, 103);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(67, 19);
            this.lblDireccionCliente.TabIndex = 4;
            this.lblDireccionCliente.Text = "Direccion";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.BackColor = System.Drawing.Color.LightPink;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(959, 142);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(64, 19);
            this.lblTelefonoCliente.TabIndex = 5;
            this.lblTelefonoCliente.Text = "Telefono";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.LightPink;
            this.lblEmailCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(959, 179);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(42, 19);
            this.lblEmailCliente.TabIndex = 6;
            this.lblEmailCliente.Text = "Email";
            // 
            // lblFechaNacimientoCliente
            // 
            this.lblFechaNacimientoCliente.AutoSize = true;
            this.lblFechaNacimientoCliente.BackColor = System.Drawing.Color.LightPink;
            this.lblFechaNacimientoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimientoCliente.Location = new System.Drawing.Point(956, 230);
            this.lblFechaNacimientoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimientoCliente.Name = "lblFechaNacimientoCliente";
            this.lblFechaNacimientoCliente.Size = new System.Drawing.Size(139, 19);
            this.lblFechaNacimientoCliente.TabIndex = 7;
            this.lblFechaNacimientoCliente.Text = "Fecha de nacimiento";
            // 
            // lblEdadCliente
            // 
            this.lblEdadCliente.AutoSize = true;
            this.lblEdadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEdadCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadCliente.Location = new System.Drawing.Point(627, 193);
            this.lblEdadCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdadCliente.Name = "lblEdadCliente";
            this.lblEdadCliente.Size = new System.Drawing.Size(40, 19);
            this.lblEdadCliente.TabIndex = 8;
            this.lblEdadCliente.Text = "Edad";
            // 
            // dtpFechaNacimientoCliente
            // 
            this.dtpFechaNacimientoCliente.CalendarForeColor = System.Drawing.Color.LightPink;
            this.dtpFechaNacimientoCliente.CalendarMonthBackground = System.Drawing.Color.LightPink;
            this.dtpFechaNacimientoCliente.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dtpFechaNacimientoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimientoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoCliente.Location = new System.Drawing.Point(1116, 230);
            this.dtpFechaNacimientoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNacimientoCliente.Name = "dtpFechaNacimientoCliente";
            this.dtpFechaNacimientoCliente.Size = new System.Drawing.Size(99, 24);
            this.dtpFechaNacimientoCliente.TabIndex = 9;
            this.dtpFechaNacimientoCliente.Value = new System.DateTime(2023, 11, 3, 0, 0, 0, 0);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtNombreCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(731, 80);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(158, 24);
            this.txtNombreCliente.TabIndex = 10;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // txtIdentificacionCliente
            // 
            this.txtIdentificacionCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtIdentificacionCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacionCliente.Location = new System.Drawing.Point(731, 157);
            this.txtIdentificacionCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            this.txtIdentificacionCliente.Size = new System.Drawing.Size(158, 24);
            this.txtIdentificacionCliente.TabIndex = 11;
            this.txtIdentificacionCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionCliente_KeyPress);
            // 
            // txtCiudadCliente
            // 
            this.txtCiudadCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtCiudadCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudadCliente.Location = new System.Drawing.Point(1039, 75);
            this.txtCiudadCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudadCliente.Name = "txtCiudadCliente";
            this.txtCiudadCliente.Size = new System.Drawing.Size(158, 24);
            this.txtCiudadCliente.TabIndex = 12;
            this.txtCiudadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudadCliente_KeyPress);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtApellidoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(731, 120);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(158, 24);
            this.txtApellidoCliente.TabIndex = 13;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoCliente_KeyPress);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtDireccionCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(1039, 103);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(158, 24);
            this.txtDireccionCliente.TabIndex = 14;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(1039, 142);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(158, 24);
            this.txtTelefonoCliente.TabIndex = 15;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtEmailCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(1039, 179);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(158, 24);
            this.txtEmailCliente.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtEmailCliente, "ingresa un correo electronico ");
            // 
            // txtEdadCliente
            // 
            this.txtEdadCliente.BackColor = System.Drawing.Color.LightPink;
            this.txtEdadCliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadCliente.Location = new System.Drawing.Point(731, 190);
            this.txtEdadCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdadCliente.Name = "txtEdadCliente";
            this.txtEdadCliente.Size = new System.Drawing.Size(158, 24);
            this.txtEdadCliente.TabIndex = 17;
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.BackColor = System.Drawing.Color.LightPink;
            this.btnAgregarClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarClientes.Location = new System.Drawing.Point(567, 296);
            this.btnAgregarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(99, 42);
            this.btnAgregarClientes.TabIndex = 18;
            this.btnAgregarClientes.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregarClientes, "Guardar cliente");
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.BackColor = System.Drawing.Color.LightPink;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.Location = new System.Drawing.Point(706, 296);
            this.btnConsultarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(99, 42);
            this.btnConsultarClientes.TabIndex = 19;
            this.btnConsultarClientes.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultarClientes, "Visualizar Registros");
            this.btnConsultarClientes.UseVisualStyleBackColor = false;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.BackColor = System.Drawing.Color.LightPink;
            this.btnModificarClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarClientes.Location = new System.Drawing.Point(820, 296);
            this.btnModificarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Size = new System.Drawing.Size(99, 42);
            this.btnModificarClientes.TabIndex = 20;
            this.btnModificarClientes.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificarClientes, "Modificar Registro anterior");
            this.btnModificarClientes.UseVisualStyleBackColor = false;
            this.btnModificarClientes.Click += new System.EventHandler(this.btnModificarClientes_Click);
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminarClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClientes.Location = new System.Drawing.Point(952, 296);
            this.btnEliminarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(99, 42);
            this.btnEliminarClientes.TabIndex = 21;
            this.btnEliminarClientes.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminarClientes, "Se eliminara de forma permanente");
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            this.btnEliminarClientes.Click += new System.EventHandler(this.btnEliminarClientes_Click);
            // 
            // btnLimpiarClientes
            // 
            this.btnLimpiarClientes.BackColor = System.Drawing.Color.LightPink;
            this.btnLimpiarClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarClientes.Location = new System.Drawing.Point(1081, 296);
            this.btnLimpiarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarClientes.Name = "btnLimpiarClientes";
            this.btnLimpiarClientes.Size = new System.Drawing.Size(99, 42);
            this.btnLimpiarClientes.TabIndex = 22;
            this.btnLimpiarClientes.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiarClientes, "limpiar para ingresar nuevos datos");
            this.btnLimpiarClientes.UseVisualStyleBackColor = false;
            this.btnLimpiarClientes.Click += new System.EventHandler(this.btnLimpiarClientes_Click);
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.BackColor = System.Drawing.Color.LightPink;
            this.btnSalirClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirClientes.Location = new System.Drawing.Point(1211, 296);
            this.btnSalirClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(99, 42);
            this.btnSalirClientes.TabIndex = 23;
            this.btnSalirClientes.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalirClientes, "Cerrar este formulario");
            this.btnSalirClientes.UseVisualStyleBackColor = false;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgClientes.Location = new System.Drawing.Point(417, 406);
            this.dtgClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersWidth = 51;
            this.dtgClientes.RowTemplate.Height = 24;
            this.dtgClientes.Size = new System.Drawing.Size(923, 215);
            this.dtgClientes.TabIndex = 24;
            this.dtgClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgClientes_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "Escojer Opciones");
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agregarToolStripMenuItem.Text = "&Menu Clientes";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.agregarToolStripMenuItem1.MergeIndex = 1;
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem1.Text = "&Agregar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.consultarToolStripMenuItem.MergeIndex = 1;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.modificarToolStripMenuItem.MergeIndex = 1;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.eliminarToolStripMenuItem.MergeIndex = 1;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.limpiarToolStripMenuItem.MergeIndex = 1;
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limpiarToolStripMenuItem.Text = "&Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.salirToolStripMenuItem.MergeIndex = 1;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-206, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1576, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnLimpiarClientes);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnModificarClientes);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.btnAgregarClientes);
            this.Controls.Add(this.txtEdadCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtCiudadCliente);
            this.Controls.Add(this.txtIdentificacionCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.dtpFechaNacimientoCliente);
            this.Controls.Add(this.lblEdadCliente);
            this.Controls.Add(this.lblFechaNacimientoCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblTelefonoCliente);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.lblCiudadCliente);
            this.Controls.Add(this.lblIdentificacionCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClientes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblIdentificacionCliente;
        private System.Windows.Forms.Label lblCiudadCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblFechaNacimientoCliente;
        private System.Windows.Forms.Label lblEdadCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdentificacionCliente;
        private System.Windows.Forms.TextBox txtCiudadCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtEdadCliente;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnLimpiarClientes;
        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}