using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonDeBelleza
{
    public partial class frmOpinion : Form
    {
        private static frmOpinion instanciaOpinion;
        public static frmOpinion ventanaOpinion()
        {
            if (instanciaOpinion == null)
            {
                instanciaOpinion = new frmOpinion();
                return instanciaOpinion;
            }
            return instanciaOpinion;
        }
        public frmOpinion()
        {
            InitializeComponent();
        }

        private void frmOpinion_Load(object sender, EventArgs e)
        {

        }

        private void frmOpinion_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaOpinion = null;   
        }

        private void btnLimpiarOpinion_Click(object sender, EventArgs e)
        {
            txtIdOpinion.Text = string.Empty;
            txtIdReservasOpinion.Text = string.Empty;
            txtOpinionGeneral.Text = string.Empty;
            dtgOpiniones.DataSource = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIdOpinion.Text = string.Empty;
            txtIdReservasOpinion.Text = string.Empty;
            txtOpinionGeneral.Text = string.Empty;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirOpinion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarOpinion_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsOpinion p1 = new clsOpinion(Convert.ToInt16(txtIdOpinion.Text), txtOpinionGeneral.Text,  Convert.ToInt16(txtIdReservasOpinion.Text));
                p1.insertarDatoOpinion();
                MessageBox.Show("Datos Ingresados");

                dtgOpiniones.DataSource = p1.consultarDatoOpinion();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }
        }

        private void btnConsultarOpinion_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                if (txtIdOpinion.Text == "")
                {
                    clsOpinion p1 = new clsOpinion();

                    dtgOpiniones.DataSource = p1.consultarDatoOpinion();
                }

                else
                {
                    clsOpinion p1 = new clsOpinion();
                    dtgOpiniones.DataSource = p1.seleccionarDatoOpinion(Convert.ToInt32(txtIdOpinion.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar  dato" + ex.Message);

            }
        }

        private void btnModificarOpinion_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsOpinion p1 = new clsOpinion(Convert.ToInt16(txtIdOpinion.Text), txtOpinionGeneral.Text, Convert.ToInt16(txtIdReservasOpinion.Text));
                p1.modificarDatoOpinion();
                MessageBox.Show("Datos modificados");
                dtgOpiniones.DataSource = p1.consultarDatoOpinion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }
        }

        private void btnEliminarOpinion_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsOpinion p1 = new clsOpinion();
                p1.eliminarDatoOpinion(Convert.ToInt16(txtIdOpinion.Text));
                dtgOpiniones.DataSource = p1.consultarDatoOpinion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro" + ex);


            }
        }

        private void frmOpinion_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dtgOpiniones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgOpiniones_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdOpinion.Text = dtgOpiniones.SelectedRows[0].Cells[0].Value.ToString();
            txtOpinionGeneral.Text = dtgOpiniones.SelectedRows[0].Cells[1].Value.ToString();
            txtIdReservasOpinion.Text = dtgOpiniones.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
