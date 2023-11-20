namespace SalonDeBelleza
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.btnSalirProductos = new System.Windows.Forms.Button();
            this.btnLimpiarProductos = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnModificarProductos = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdProducto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdProducto.Location = new System.Drawing.Point(11, 47);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(75, 16);
            this.lblIdProducto.TabIndex = 0;
            this.lblIdProducto.Text = "Id Producto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreProducto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreProducto.Location = new System.Drawing.Point(14, 103);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(52, 16);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMarca.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Location = new System.Drawing.Point(305, 52);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 16);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdProducto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIdProducto.Location = new System.Drawing.Point(109, 44);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(109, 24);
            this.txtIdProducto.TabIndex = 3;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreProducto.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombreProducto.Location = new System.Drawing.Point(109, 95);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(121, 24);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMarca.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMarca.Location = new System.Drawing.Point(308, 81);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(112, 24);
            this.txtMarca.TabIndex = 5;
            // 
            // dtgProductos
            // 
            this.dtgProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgProductos.Location = new System.Drawing.Point(11, 235);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.RowTemplate.Height = 24;
            this.dtgProductos.Size = new System.Drawing.Size(513, 150);
            this.dtgProductos.TabIndex = 6;
            this.dtgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellContentClick);
            this.dtgProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgProductos_MouseClick);
            // 
            // btnSalirProductos
            // 
            this.btnSalirProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalirProductos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalirProductos.Location = new System.Drawing.Point(70, 206);
            this.btnSalirProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirProductos.Name = "btnSalirProductos";
            this.btnSalirProductos.Size = new System.Drawing.Size(84, 25);
            this.btnSalirProductos.TabIndex = 29;
            this.btnSalirProductos.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalirProductos, "Salir de este formulario");
            this.btnSalirProductos.UseVisualStyleBackColor = false;
            this.btnSalirProductos.Click += new System.EventHandler(this.btnSalirProductos_Click);
            // 
            // btnLimpiarProductos
            // 
            this.btnLimpiarProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarProductos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarProductos.Location = new System.Drawing.Point(238, 206);
            this.btnLimpiarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarProductos.Name = "btnLimpiarProductos";
            this.btnLimpiarProductos.Size = new System.Drawing.Size(84, 25);
            this.btnLimpiarProductos.TabIndex = 28;
            this.btnLimpiarProductos.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiarProductos, "Limpiar campos");
            this.btnLimpiarProductos.UseVisualStyleBackColor = false;
            this.btnLimpiarProductos.Click += new System.EventHandler(this.btnLimpiarProductos_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarProductos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarProductos.Location = new System.Drawing.Point(308, 157);
            this.btnEliminarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(84, 25);
            this.btnEliminarProductos.TabIndex = 27;
            this.btnEliminarProductos.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminarProductos, "SE ELIMINARA PERMANENTEMENTE");
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarProductos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarProductos.Location = new System.Drawing.Point(214, 157);
            this.btnModificarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(84, 25);
            this.btnModificarProductos.TabIndex = 26;
            this.btnModificarProductos.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificarProductos, "Modificar");
            this.btnModificarProductos.UseVisualStyleBackColor = false;
            this.btnModificarProductos.Click += new System.EventHandler(this.btnModificarProductos_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarProductos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarProductos.Location = new System.Drawing.Point(109, 157);
            this.btnConsultarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(84, 25);
            this.btnConsultarProductos.TabIndex = 25;
            this.btnConsultarProductos.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultarProductos, "Consultar Producto");
            this.btnConsultarProductos.UseVisualStyleBackColor = false;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProductos.Location = new System.Drawing.Point(3, 157);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(84, 25);
            this.btnAgregarProductos.TabIndex = 24;
            this.btnAgregarProductos.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregarProductos, "Ingresar Producto");
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip1.TabIndex = 31;
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.agregarToolStripMenuItem.Text = "&Menu Productos";
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
            this.pictureBox1.Size = new System.Drawing.Size(1122, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1122, 406);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSalirProductos);
            this.Controls.Add(this.btnLimpiarProductos);
            this.Controls.Add(this.btnEliminarProductos);
            this.Controls.Add(this.btnModificarProductos);
            this.Controls.Add(this.btnConsultarProductos);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProducto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Button btnSalirProductos;
        private System.Windows.Forms.Button btnLimpiarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnModificarProductos;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Button btnAgregarProductos;
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