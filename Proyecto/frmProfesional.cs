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
    public partial class frmProfesional : Form
    {
        private static frmProfesional instanciaProfesional = null;

        public static frmProfesional ventanaProfesional()
        {
            if (instanciaProfesional == null)
            {
                instanciaProfesional = new frmProfesional();
                return instanciaProfesional;
            }
            return instanciaProfesional;
        }
        public frmProfesional()
        {
            InitializeComponent();
        }

        private void frmProfesional_Load(object sender, EventArgs e)
        {

        }

        private void frmProfesional_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaProfesional = null;
        }

        private void btnLimpiarProfesional_Click(object sender, EventArgs e)
        {
            txtApellidoProfesional.Text=string.Empty;
            txtIdentificacionProfesional.Text = string.Empty;   
            txtIdSedeProfesional.Text= string.Empty;
            txtNombreProfesional.Text = string.Empty;
            txtTelefonoProfesional.Text = string.Empty;
            dtpHorarioProfesionales.Text = string.Empty;
            dtgProfesional.DataSource = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtApellidoProfesional.Text = string.Empty;
            txtIdentificacionProfesional.Text = string.Empty;
            txtIdSedeProfesional.Text = string.Empty;
            txtNombreProfesional.Text = string.Empty;
            txtTelefonoProfesional.Text = string.Empty;
            dtpHorarioProfesionales.Text = string.Empty;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirProfesional_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProfesional p1 = new clsProfesional(Convert.ToInt64(txtIdentificacionProfesional.Text), txtNombreProfesional.Text, txtApellidoProfesional.Text, Convert.ToInt64(txtTelefonoProfesional.Text), dtpHorarioProfesionales.Value.Date, Convert.ToInt16(txtIdSedeProfesional.Text));
                p1.insertarDatoProfesional();
                MessageBox.Show("Datos Ingresados");

                dtgProfesional.DataSource = p1.consultarDatoProfesional();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }
        }

        private void btnConsultarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                if (txtIdentificacionProfesional.Text == "")
                {
                    clsProfesional p1 = new clsProfesional();

                    dtgProfesional.DataSource = p1.consultarDatoProfesional();
                }

                else
                {
                    clsProfesional p1 = new clsProfesional();
                    dtgProfesional.DataSource = p1.seleccionarDatoProfesional(Convert.ToInt32(txtIdentificacionProfesional.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar  dato" + ex.Message);

            }
        }

        private void btnModificarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProfesional p1 = new clsProfesional(Convert.ToInt64(txtIdentificacionProfesional.Text), txtNombreProfesional.Text, txtApellidoProfesional.Text, Convert.ToInt64(txtTelefonoProfesional.Text), dtpHorarioProfesionales.Value.Date, Convert.ToInt16(txtIdSedeProfesional.Text));
                p1.modificarDatoProfesional();
                MessageBox.Show("Datos modificados");
                dtgProfesional.DataSource = p1.consultarDatoProfesional();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }
        }

        private void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProfesional p1 = new clsProfesional();
                p1.eliminarDatoProfesional(Convert.ToInt64(txtIdentificacionProfesional.Text));
                dtgProfesional.DataSource = p1.consultarDatoProfesional();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro" + ex);


            }
        }

        private void dtgProfesional_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdentificacionProfesional.Text = dtgProfesional.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreProfesional.Text = dtgProfesional.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidoProfesional.Text = dtgProfesional.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefonoProfesional.Text = dtgProfesional.SelectedRows[0].Cells[3].Value.ToString();
            dtpHorarioProfesionales.Text = dtgProfesional.SelectedRows[0].Cells[4].Value.ToString();
            txtIdSedeProfesional.Text= dtgProfesional.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void dtgProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
