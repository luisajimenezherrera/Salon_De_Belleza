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
    public partial class frmSedes : Form
    {
        private static frmSedes instanciaSedes = null;

        public static frmSedes ventanaSedes()
        {
            if (instanciaSedes == null)
            {
                instanciaSedes = new frmSedes();
                return instanciaSedes;
            }
            return instanciaSedes;
        }
        public frmSedes()
        {
            InitializeComponent();
        }

        private void frmSedes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaSedes = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCiudadSede.Text=string.Empty;
            txtDireccionSede.Text=string.Empty; 
            txtIdSede.Text=string.Empty; 
            dtpHorarioCierreSede.Text=string.Empty; 
            dtpHorarioAperturaSede.Text=string.Empty;   

        }

        private void btnLimpiarSedes_Click(object sender, EventArgs e)
        {
            txtCiudadSede.Text = string.Empty;
            txtDireccionSede.Text = string.Empty;
            txtIdSede.Text = string.Empty;
            dtpHorarioCierreSede.Text = string.Empty;
            dtpHorarioAperturaSede.Text = string.Empty;
            dtgSedes.DataSource = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirSedes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarSedes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsSedes p1 = new clsSedes(Convert.ToInt16(txtIdSede.Text), txtCiudadSede.Text,txtDireccionSede.Text, dtpHorarioAperturaSede.Value.Date, dtpHorarioCierreSede.Value.Date);
                p1.insertarDatoSedes();
                MessageBox.Show("Datos Ingresados");

                dtgSedes.DataSource = p1.consultarDatoSedes();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }

        }

        private void btnConsultarSedes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                if (txtIdSede.Text == "")
                {
                    clsSedes p1 = new clsSedes();

                    dtgSedes.DataSource = p1.consultarDatoSedes();
                }

                else
                {
                    clsSedes p1 = new clsSedes();
                    dtgSedes.DataSource = p1.seleccionarDatoSedes(Convert.ToInt16(txtIdSede.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar  dato" + ex.Message);

            }
        }

        private void btnModificarSedes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsSedes p1 = new clsSedes(Convert.ToInt16(txtIdSede.Text), txtCiudadSede.Text, txtDireccionSede.Text, dtpHorarioAperturaSede.Value.Date, dtpHorarioCierreSede.Value.Date);
                p1.modificarDatoSedes();
                MessageBox.Show("Datos modificados");
                dtgSedes.DataSource = p1.consultarDatoSedes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }
        }

        private void btnEliminarSedes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsSedes p1 = new clsSedes();
                p1.eliminarDatoSedes(Convert.ToInt16(txtIdSede.Text));
                dtgSedes.DataSource = p1.consultarDatoSedes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro" + ex);


            }
        }

        private void dtgSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgSedes_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdSede.Text = dtgSedes.SelectedRows[0].Cells[0].Value.ToString();
            txtCiudadSede.Text = dtgSedes.SelectedRows[0].Cells[1].Value.ToString();
            txtDireccionSede.Text = dtgSedes.SelectedRows[0].Cells[2].Value.ToString();
            dtpHorarioAperturaSede.Text=dtgSedes.SelectedRows[0].Cells[3].Value.ToString();
            dtpHorarioCierreSede.Text = dtgSedes.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
