using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonDeBelleza
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmCliente")==false)
            {
                frmClientes FrmClientes = frmClientes.ventanaUnica();
                FrmClientes.MdiParent = this;   
                FrmClientes.Show();
                FrmClientes.BringToFront();
            }
        }
        bool FormIsOpen(string strCliente) 
        {
            foreach (var Form_hijo in this.MdiChildren) 
            {
                if (Form_hijo.Text == strCliente)
                { 
                    Form_hijo.BringToFront();
                    return true;
                }
                return false;
            }
            return false;   
        }

        private void registrarSedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSedes FrmSedes =frmSedes.ventanaSedes(); 
            FrmSedes.MdiParent = this;  
            FrmSedes.Show(); 
            FrmSedes.BringToFront();   

        }

        private void registroProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto FrmProducto = frmProducto.ventanaProducto();
            FrmProducto.MdiParent = this;
            FrmProducto.Show();
            FrmProducto.BringToFront();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesional FrmProfesional = frmProfesional.ventanaProfesional();
            FrmProfesional.MdiParent = this;
            FrmProfesional.Show();
            FrmProfesional.BringToFront();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservas FrmReservas = frmReservas.ventanaReservas();
            FrmReservas.MdiParent = this;   
            FrmReservas.Show();
            FrmReservas.BringToFront();
        }

        private void opinionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpinion FrmOpinion = frmOpinion.ventanaOpinion();
            FrmOpinion.MdiParent = this;
            FrmOpinion.Show();
            FrmOpinion.BringToFront();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOpinion = this.ActiveMdiChild;
            Form frmClientes = this.ActiveMdiChild;
            Form frmProducto = this.ActiveMdiChild;
            Form frmProfesional = this.ActiveMdiChild;
            Form frmReservas = this.ActiveMdiChild;
            Form frmSedes = this.ActiveMdiChild;

            if (frmOpinion != null)
            {
                frmOpinion.Close();
            }
            else if (frmClientes != null)
            {
                frmClientes.Close();
            }
            else if (frmProducto != null)
            {
                frmProducto.Close();
            }
            else if (frmProfesional != null)
            {
                frmProfesional.Close();
            }
            else if (frmReservas != null)
            {
                frmReservas.Close();
            }
            else if (frmSedes != null)
            {
                frmSedes.Close();
            }
            else { this.Close(); }
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistroClientes_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmCliente") == false)
            {
                frmClientes FrmClientes = frmClientes.ventanaUnica();
                FrmClientes.MdiParent = this;
                FrmClientes.Show();
                FrmClientes.BringToFront();
            }
        }

        private void btnRegistroSedes_Click(object sender, EventArgs e)
        {
            frmSedes FrmSedes = frmSedes.ventanaSedes();
            FrmSedes.MdiParent = this;
            FrmSedes.Show();
            FrmSedes.BringToFront();
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
            frmProducto FrmProducto = frmProducto.ventanaProducto();
            FrmProducto.MdiParent = this;
            FrmProducto.Show();
            FrmProducto.BringToFront();
        }

        private void btnRegistroProfesional_Click(object sender, EventArgs e)
        {
            frmProfesional FrmProfesional = frmProfesional.ventanaProfesional();
            FrmProfesional.MdiParent = this;
            FrmProfesional.Show();
            FrmProfesional.BringToFront();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            frmReservas FrmReservas = frmReservas.ventanaReservas();
            FrmReservas.MdiParent = this;
            FrmReservas.Show();
            FrmReservas.BringToFront();
        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            frmOpinion FrmOpinion = frmOpinion.ventanaOpinion();
            FrmOpinion.MdiParent = this;
            FrmOpinion.Show();
            FrmOpinion.BringToFront();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form frmOpinion = this.ActiveMdiChild;
            Form frmClientes = this.ActiveMdiChild;
            Form frmProducto = this.ActiveMdiChild;
            Form frmProfesional = this.ActiveMdiChild;
            Form frmReservas = this.ActiveMdiChild;
            Form frmSedes = this.ActiveMdiChild;

            if (frmOpinion != null)
            {
                frmOpinion.Close();
            }
            else if (frmClientes != null)
            {
                frmClientes.Close();
            }
            else if (frmProducto != null)
            {
                frmProducto.Close();
            }
            else if (frmProfesional != null)
            {
                frmProfesional.Close();
            }
            else if (frmReservas != null)
            {
                frmReservas.Close();
            }
            else if (frmSedes != null)
            {
                frmSedes.Close();
            }
            else { this.Close(); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
