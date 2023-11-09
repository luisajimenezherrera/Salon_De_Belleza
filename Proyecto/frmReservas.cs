using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalonDeBelleza
{
    public partial class frmReservas : Form
    {
        private static frmReservas instanciaReservas = null;

        public static frmReservas ventanaReservas()
        {
            if (instanciaReservas == null)
            {
                instanciaReservas = new frmReservas();
                return instanciaReservas;
            }
            return instanciaReservas;
        }
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string consultaP = "Select strNombreProducto from tblProductos";
            using (SqlDataAdapter adapter = new SqlDataAdapter(consultaP, conexion.conexion))
            {
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dataTable);

                // Enlazar el ComboBox con los datos
                cmbSeleccionProducto.DataSource = dataTable;

            }

        }

        private void frmReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaReservas = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpFechaReserva.Text = string.Empty;
            txtIdClienteReservas.Text=string.Empty;
            txtIdSedeReservas.Text+=string.Empty;
            txtIdReserva.Text=string.Empty;
            txtPreferenciasReservas.Text=string.Empty;
            cmbSeleccionProducto.Text=string.Empty;
            cmbTipoServicio.Text = string.Empty;
            dtpHoraReserva.Text=string.Empty;    
            rdbFrecuenteReserva.Text=string.Empty;  
            rdbNoFrecuenteReserva.Text=string.Empty;   
        }

        private void btnLimpiarReservas_Click(object sender, EventArgs e)
        {
            dtpFechaReserva.Text = string.Empty;
            txtIdClienteReservas.Text = string.Empty;
            txtIdSedeReservas.Text = string.Empty;
            txtIdReserva.Text = string.Empty;
            txtPreferenciasReservas.Text = string.Empty;
            cmbSeleccionProducto.Text = string.Empty;
            cmbTipoServicio.Text = string.Empty;
            dtpHoraReserva.Text = string.Empty;
            rdbFrecuenteReserva.Text = string.Empty;
            rdbNoFrecuenteReserva.Text = string.Empty;
            dtgReservas.DataSource = null;
        }

        private void btnSalirReservas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarReservas_Click(object sender, EventArgs e)
        {

            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsReservas p1 = new clsReservas(Convert.ToInt16(txtIdReserva.Text), cmbTipoServicio.Text, dtpHoraReserva.Value.Date, dtpFechaReserva.Value.Date, rdbFrecuenteReserva.Text, txtPreferenciasReservas.Text, cmbSeleccionProducto.Text, Convert.ToInt64(txtIdClienteReservas.Text),Convert.ToInt16(txtIdSedeReservas.Text));
                p1.insertarDatoReservas();
                MessageBox.Show("Datos Ingresados");

                dtgReservas.DataSource = p1.consultarDatoReservas();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }

        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                if (txtIdReserva.Text == "")
                {
                    clsReservas p1 = new clsReservas();

                    dtgReservas.DataSource = p1.consultarDatoReservas();
                }

                else
                {
                    clsReservas p1 = new clsReservas();
                    dtgReservas.DataSource = p1.seleccionarDatoReservas(Convert.ToInt16(txtIdReserva.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar  dato" + ex.Message);

            }

        }

        private void btnModificarReservas_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsReservas p1 = new clsReservas(Convert.ToInt16(txtIdReserva.Text), cmbTipoServicio.Text, dtpHoraReserva.Value.Date, dtpFechaReserva.Value.Date, rdbFrecuenteReserva.Text, txtPreferenciasReservas.Text, cmbSeleccionProducto.Text, Convert.ToInt64(txtIdClienteReservas.Text), Convert.ToInt16(txtIdSedeReservas.Text));
                p1.modificarDatoReservas();
                MessageBox.Show("Datos modificados");
                dtgReservas.DataSource = p1.consultarDatoReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }
        }

        private void btnEliminarReservas_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsReservas p1 = new clsReservas();
                p1.eliminarDatoReservas(Convert.ToInt16(txtIdReserva.Text));
                dtgReservas.DataSource = p1.consultarDatoReservas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro" + ex);


            }
        }

        private void dtgReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgReservas_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdReserva.Text =dtgReservas.SelectedRows[0].Cells[0].Value.ToString();
            cmbTipoServicio.Text = dtgReservas.SelectedRows[0].Cells[1].Value.ToString();
            dtpHoraReserva.Text = dtgReservas.SelectedRows[0].Cells[2].Value.ToString();
            dtpFechaReserva.Text = dtgReservas.SelectedRows[0].Cells[3].Value.ToString();
            rdbFrecuenteReserva.Text = dtgReservas.SelectedRows[0].Cells[4].Value.ToString();
            txtPreferenciasReservas.Text = dtgReservas.SelectedRows[0].Cells[5].Value.ToString();
            cmbSeleccionProducto.Text = dtgReservas.SelectedRows[0].Cells[6].Value.ToString();
            txtIdClienteReservas.Text = dtgReservas.SelectedRows[0].Cells[7].Value.ToString();
            txtIdSedeReservas.Text = dtgReservas.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void cmbSeleccionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSeleccionProducto_MouseClick(object sender, MouseEventArgs e)
        {
           
            

        }
    }
}
