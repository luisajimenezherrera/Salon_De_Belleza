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
            this.txtIdReservasOpinion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpiniones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOpiniones
            // 
            this.dtgOpiniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOpiniones.Location = new System.Drawing.Point(2, 285);
            this.dtgOpiniones.Name = "dtgOpiniones";
            this.dtgOpiniones.RowHeadersWidth = 51;
            this.dtgOpiniones.RowTemplate.Height = 24;
            this.dtgOpiniones.Size = new System.Drawing.Size(798, 171);
            this.dtgOpiniones.TabIndex = 31;
            this.dtgOpiniones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOpiniones_CellContentClick);
            this.dtgOpiniones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgOpiniones_MouseClick);
            // 
            // btnSalirOpinion
            // 
            this.btnSalirOpinion.Location = new System.Drawing.Point(659, 235);
            this.btnSalirOpinion.Name = "btnSalirOpinion";
            this.btnSalirOpinion.Size = new System.Drawing.Size(111, 31);
            this.btnSalirOpinion.TabIndex = 30;
            this.btnSalirOpinion.Text = "Salir";
            this.btnSalirOpinion.UseVisualStyleBackColor = true;
            this.btnSalirOpinion.Click += new System.EventHandler(this.btnSalirOpinion_Click);
            // 
            // btnLimpiarOpinion
            // 
            this.btnLimpiarOpinion.Location = new System.Drawing.Point(525, 235);
            this.btnLimpiarOpinion.Name = "btnLimpiarOpinion";
            this.btnLimpiarOpinion.Size = new System.Drawing.Size(111, 31);
            this.btnLimpiarOpinion.TabIndex = 29;
            this.btnLimpiarOpinion.Text = "Limpiar";
            this.btnLimpiarOpinion.UseVisualStyleBackColor = true;
            this.btnLimpiarOpinion.Click += new System.EventHandler(this.btnLimpiarOpinion_Click);
            // 
            // btnEliminarOpinion
            // 
            this.btnEliminarOpinion.Location = new System.Drawing.Point(403, 235);
            this.btnEliminarOpinion.Name = "btnEliminarOpinion";
            this.btnEliminarOpinion.Size = new System.Drawing.Size(111, 31);
            this.btnEliminarOpinion.TabIndex = 28;
            this.btnEliminarOpinion.Text = "Eliminar";
            this.btnEliminarOpinion.UseVisualStyleBackColor = true;
            this.btnEliminarOpinion.Click += new System.EventHandler(this.btnEliminarOpinion_Click);
            // 
            // btnModificarOpinion
            // 
            this.btnModificarOpinion.Location = new System.Drawing.Point(281, 235);
            this.btnModificarOpinion.Name = "btnModificarOpinion";
            this.btnModificarOpinion.Size = new System.Drawing.Size(111, 31);
            this.btnModificarOpinion.TabIndex = 27;
            this.btnModificarOpinion.Text = "Modificar";
            this.btnModificarOpinion.UseVisualStyleBackColor = true;
            this.btnModificarOpinion.Click += new System.EventHandler(this.btnModificarOpinion_Click);
            // 
            // btnConsultarOpinion
            // 
            this.btnConsultarOpinion.Location = new System.Drawing.Point(161, 235);
            this.btnConsultarOpinion.Name = "btnConsultarOpinion";
            this.btnConsultarOpinion.Size = new System.Drawing.Size(111, 31);
            this.btnConsultarOpinion.TabIndex = 26;
            this.btnConsultarOpinion.Text = "Consultar";
            this.btnConsultarOpinion.UseVisualStyleBackColor = true;
            this.btnConsultarOpinion.Click += new System.EventHandler(this.btnConsultarOpinion_Click);
            // 
            // btnAgregarOpinion
            // 
            this.btnAgregarOpinion.Location = new System.Drawing.Point(39, 235);
            this.btnAgregarOpinion.Name = "btnAgregarOpinion";
            this.btnAgregarOpinion.Size = new System.Drawing.Size(111, 31);
            this.btnAgregarOpinion.TabIndex = 25;
            this.btnAgregarOpinion.Text = "Agregar";
            this.btnAgregarOpinion.UseVisualStyleBackColor = true;
            this.btnAgregarOpinion.Click += new System.EventHandler(this.btnAgregarOpinion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // lblIdOpinion
            // 
            this.lblIdOpinion.AutoSize = true;
            this.lblIdOpinion.Location = new System.Drawing.Point(219, 54);
            this.lblIdOpinion.Name = "lblIdOpinion";
            this.lblIdOpinion.Size = new System.Drawing.Size(67, 16);
            this.lblIdOpinion.TabIndex = 40;
            this.lblIdOpinion.Text = "Id Opinion";
            // 
            // lblOpinion
            // 
            this.lblOpinion.AutoSize = true;
            this.lblOpinion.Location = new System.Drawing.Point(219, 92);
            this.lblOpinion.Name = "lblOpinion";
            this.lblOpinion.Size = new System.Drawing.Size(53, 16);
            this.lblOpinion.TabIndex = 41;
            this.lblOpinion.Text = "Opinion";
            // 
            // lblIdReservas
            // 
            this.lblIdReservas.AutoSize = true;
            this.lblIdReservas.Location = new System.Drawing.Point(219, 169);
            this.lblIdReservas.Name = "lblIdReservas";
            this.lblIdReservas.Size = new System.Drawing.Size(77, 16);
            this.lblIdReservas.TabIndex = 42;
            this.lblIdReservas.Text = "IdReservas";
            // 
            // txtIdOpinion
            // 
            this.txtIdOpinion.Location = new System.Drawing.Point(346, 54);
            this.txtIdOpinion.Name = "txtIdOpinion";
            this.txtIdOpinion.Size = new System.Drawing.Size(100, 22);
            this.txtIdOpinion.TabIndex = 43;
            // 
            // txtOpinionGeneral
            // 
            this.txtOpinionGeneral.Location = new System.Drawing.Point(346, 92);
            this.txtOpinionGeneral.Multiline = true;
            this.txtOpinionGeneral.Name = "txtOpinionGeneral";
            this.txtOpinionGeneral.Size = new System.Drawing.Size(347, 65);
            this.txtOpinionGeneral.TabIndex = 44;
            // 
            // txtIdReservasOpinion
            // 
            this.txtIdReservasOpinion.Location = new System.Drawing.Point(346, 166);
            this.txtIdReservasOpinion.Name = "txtIdReservasOpinion";
            this.txtIdReservasOpinion.Size = new System.Drawing.Size(100, 22);
            this.txtIdReservasOpinion.TabIndex = 45;
            // 
            // frmOpinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdReservasOpinion);
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
            this.Name = "frmOpinion";
            this.Text = "Opinion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpinion_FormClosing);
            this.Load += new System.EventHandler(this.frmOpinion_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmOpinion_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOpiniones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIdReservasOpinion;
    }
}