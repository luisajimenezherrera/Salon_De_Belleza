namespace SalonDeBelleza
{
    partial class frmOpinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpinion));
            this.dtgOpiniones = new System.Windows.Forms.DataGridView();
            this.btnSalirOpinion = new System.Windows.Forms.Button();
            this.btnLimpiarOpinion = new System.Windows.Forms.Button();
            this.btnEliminarOpinion = new System.Windows.Forms.Button();
            this.btnModificarOpinion = new System.Windows.Forms.Button();
            this.btnConsultarOpinion = new System.Windows.Forms.Button();
            this.btnAgregarOpinion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIdOpinion = new System.Windows.Forms.Label();
            this.lblOpinion = new System.Windows.Forms.Label();
            this.lblIdReservas = new System.Windows.Forms.Label();
            this.txtIdOpinion = new System.Windows.Forms.TextBox();
            this.txtOpinionGeneral = new System.Windows.Forms.TextBox();
            this.cmbReservasO = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpiniones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOpiniones
            // 
            this.dtgOpiniones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgOpiniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOpiniones.Location = new System.Drawing.Point(395, 517);
            this.dtgOpiniones.Margin = new System.Windows.Forms.Padding(2);
            this.dtgOpiniones.Name = "dtgOpiniones";
            this.dtgOpiniones.RowHeadersWidth = 51;
            this.dtgOpiniones.RowTemplate.Height = 24;
            this.dtgOpiniones.Size = new System.Drawing.Size(543, 123);
            this.dtgOpiniones.TabIndex = 31;
            this.dtgOpiniones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgOpiniones_MouseClick);
            // 
            // btnSalirOpinion
            // 
            this.btnSalirOpinion.BackColor = System.Drawing.Color.LightPink;
            this.btnSalirOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirOpinion.Location = new System.Drawing.Point(878, 455);
            this.btnSalirOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirOpinion.Name = "btnSalirOpinion";
            this.btnSalirOpinion.Size = new System.Drawing.Size(97, 46);
            this.btnSalirOpinion.TabIndex = 30;
            this.btnSalirOpinion.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalirOpinion, "Cerrar formulario");
            this.btnSalirOpinion.UseVisualStyleBackColor = false;
            this.btnSalirOpinion.Click += new System.EventHandler(this.btnSalirOpinion_Click);
            // 
            // btnLimpiarOpinion
            // 
            this.btnLimpiarOpinion.BackColor = System.Drawing.Color.LightPink;
            this.btnLimpiarOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarOpinion.Location = new System.Drawing.Point(762, 455);
            this.btnLimpiarOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarOpinion.Name = "btnLimpiarOpinion";
            this.btnLimpiarOpinion.Size = new System.Drawing.Size(97, 46);
            this.btnLimpiarOpinion.TabIndex = 29;
            this.btnLimpiarOpinion.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiarOpinion, "limpiar formulario");
            this.btnLimpiarOpinion.UseVisualStyleBackColor = false;
            this.btnLimpiarOpinion.Click += new System.EventHandler(this.btnLimpiarOpinion_Click);
            // 
            // btnEliminarOpinion
            // 
            this.btnEliminarOpinion.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminarOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOpinion.Location = new System.Drawing.Point(654, 455);
            this.btnEliminarOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarOpinion.Name = "btnEliminarOpinion";
            this.btnEliminarOpinion.Size = new System.Drawing.Size(97, 46);
            this.btnEliminarOpinion.TabIndex = 28;
            this.btnEliminarOpinion.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminarOpinion, "eliminar registro");
            this.btnEliminarOpinion.UseVisualStyleBackColor = false;
            this.btnEliminarOpinion.Click += new System.EventHandler(this.btnEliminarOpinion_Click);
            // 
            // btnModificarOpinion
            // 
            this.btnModificarOpinion.BackColor = System.Drawing.Color.LightPink;
            this.btnModificarOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOpinion.Location = new System.Drawing.Point(548, 455);
            this.btnModificarOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarOpinion.Name = "btnModificarOpinion";
            this.btnModificarOpinion.Size = new System.Drawing.Size(97, 46);
            this.btnModificarOpinion.TabIndex = 27;
            this.btnModificarOpinion.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificarOpinion, "Modificar Registros ya existentes");
            this.btnModificarOpinion.UseVisualStyleBackColor = false;
            this.btnModificarOpinion.Click += new System.EventHandler(this.btnModificarOpinion_Click);
            // 
            // btnConsultarOpinion
            // 
            this.btnConsultarOpinion.BackColor = System.Drawing.Color.LightPink;
            this.btnConsultarOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarOpinion.Location = new System.Drawing.Point(443, 455);
            this.btnConsultarOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarOpinion.Name = "btnConsultarOpinion";
            this.btnConsultarOpinion.Size = new System.Drawing.Size(97, 46);
            this.btnConsultarOpinion.TabIndex = 26;
            this.btnConsultarOpinion.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultarOpinion, "Consultar con un id opinion o todos");
            this.btnConsultarOpinion.UseVisualStyleBackColor = false;
            this.btnConsultarOpinion.Click += new System.EventHandler(this.btnConsultarOpinion_Click);
            // 
            // btnAgregarOpinion
            // 
            this.btnAgregarOpinion.BackColor = System.Drawing.Color.LightPink;
            this.btnAgregarOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOpinion.Location = new System.Drawing.Point(330, 455);
            this.btnAgregarOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarOpinion.Name = "btnAgregarOpinion";
            this.btnAgregarOpinion.Size = new System.Drawing.Size(97, 46);
            this.btnAgregarOpinion.TabIndex = 25;
            this.btnAgregarOpinion.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregarOpinion, "Ingresar Opinion");
            this.btnAgregarOpinion.UseVisualStyleBackColor = false;
            this.btnAgregarOpinion.Click += new System.EventHandler(this.btnAgregarOpinion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip1.TabIndex = 39;
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.agregarToolStripMenuItem.Text = "&Menu Opinion";
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
            // lblIdOpinion
            // 
            this.lblIdOpinion.AutoSize = true;
            this.lblIdOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOpinion.Location = new System.Drawing.Point(322, 335);
            this.lblIdOpinion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdOpinion.Name = "lblIdOpinion";
            this.lblIdOpinion.Size = new System.Drawing.Size(66, 16);
            this.lblIdOpinion.TabIndex = 40;
            this.lblIdOpinion.Text = "Id Opinion";
            // 
            // lblOpinion
            // 
            this.lblOpinion.AutoSize = true;
            this.lblOpinion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpinion.Location = new System.Drawing.Point(718, 256);
            this.lblOpinion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpinion.Name = "lblOpinion";
            this.lblOpinion.Size = new System.Drawing.Size(108, 16);
            this.lblOpinion.TabIndex = 41;
            this.lblOpinion.Text = "Opinion de la cita";
            // 
            // lblIdReservas
            // 
            this.lblIdReservas.AutoSize = true;
            this.lblIdReservas.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReservas.Location = new System.Drawing.Point(322, 387);
            this.lblIdReservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdReservas.Name = "lblIdReservas";
            this.lblIdReservas.Size = new System.Drawing.Size(74, 16);
            this.lblIdReservas.TabIndex = 42;
            this.lblIdReservas.Text = "IdReservas";
            // 
            // txtIdOpinion
            // 
            this.txtIdOpinion.BackColor = System.Drawing.Color.LightPink;
            this.txtIdOpinion.Location = new System.Drawing.Point(412, 335);
            this.txtIdOpinion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdOpinion.Name = "txtIdOpinion";
            this.txtIdOpinion.Size = new System.Drawing.Size(140, 24);
            this.txtIdOpinion.TabIndex = 43;
            this.txtIdOpinion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdOpinion_KeyPress);
            // 
            // txtOpinionGeneral
            // 
            this.txtOpinionGeneral.BackColor = System.Drawing.Color.LightPink;
            this.txtOpinionGeneral.Location = new System.Drawing.Point(576, 294);
            this.txtOpinionGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpinionGeneral.Multiline = true;
            this.txtOpinionGeneral.Name = "txtOpinionGeneral";
            this.txtOpinionGeneral.Size = new System.Drawing.Size(362, 109);
            this.txtOpinionGeneral.TabIndex = 44;
            this.txtOpinionGeneral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpinionGeneral_KeyPress);
            // 
            // cmbReservasO
            // 
            this.cmbReservasO.BackColor = System.Drawing.Color.LightPink;
            this.cmbReservasO.FormattingEnabled = true;
            this.cmbReservasO.Location = new System.Drawing.Point(412, 377);
            this.cmbReservasO.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReservasO.Name = "cmbReservasO";
            this.cmbReservasO.Size = new System.Drawing.Size(140, 24);
            this.cmbReservasO.TabIndex = 45;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1304, 756);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frmOpinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.cmbReservasO);
            this.Controls.Add(this.txtOpinionGeneral);
            this.Controls.Add(this.txtIdOpinion);
            this.Controls.Add(this.lblIdReservas);
            this.Controls.Add(this.lblOpinion);
            this.Controls.Add(this.lblIdOpinion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgOpiniones);
            this.Controls.Add(this.btnSalirOpinion);
            this.Controls.Add(this.btnLimpiarOpinion);
            this.Controls.Add(this.btnEliminarOpinion);
            this.Controls.Add(this.btnModificarOpinion);
            this.Controls.Add(this.btnConsultarOpinion);
            this.Controls.Add(this.btnAgregarOpinion);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOpinion";
            this.Text = "Opinion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpinion_FormClosing);
            this.Load += new System.EventHandler(this.frmOpinion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpiniones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOpiniones;
        private System.Windows.Forms.Button btnSalirOpinion;
        private System.Windows.Forms.Button btnLimpiarOpinion;
        private System.Windows.Forms.Button btnEliminarOpinion;
        private System.Windows.Forms.Button btnModificarOpinion;
        private System.Windows.Forms.Button btnConsultarOpinion;
        private System.Windows.Forms.Button btnAgregarOpinion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblIdOpinion;
        private System.Windows.Forms.Label lblOpinion;
        private System.Windows.Forms.Label lblIdReservas;
        private System.Windows.Forms.TextBox txtIdOpinion;
        private System.Windows.Forms.TextBox txtOpinionGeneral;
        private System.Windows.Forms.ComboBox cmbReservasO;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}