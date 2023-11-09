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
    public partial class frmClientes : Form
    {
        private static frmClientes instancia = null;

        public static frmClientes ventanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmClientes();
                return instancia;
            }
            return instancia;
        }
        public frmClientes()
        {
            InitializeComponent();
            
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnLimpiarClientes_Click(object sender, EventArgs e)
        {
            txtApellidoCliente.Text = string.Empty;
            txtCiudadCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
            txtEdadCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;
            txtIdentificacionCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
            dtpFechaNacimientoCliente.Text = string.Empty;
            dtgClientes.DataSource = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtApellidoCliente.Text = string.Empty;
            txtCiudadCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
            txtEdadCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;
            txtIdentificacionCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
            dtpFechaNacimientoCliente.Text = string.Empty;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtIdentificacionCliente.Text == "")
                {
                    clsClientes p1 = new clsClientes ();
                    dtgClientes.DataSource = p1.consultarDatoClientes();

                }
                else
                {
                    clsProducto p1 = new clsProducto();
                    dtgClientes.DataSource = p1.seleccionarDatoProducto(Convert.ToInt32(txtIdentificacionCliente.Text));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

          private void btnAgregarClientes_Click(object sender, EventArgs e)
          {

                try
                {
                    clsConexion conexion = new clsConexion();
                    conexion.abrirConexion();

                    clsClientes p1 = new clsClientes(Convert.ToInt64(txtIdentificacionCliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text, txtCiudadCliente.Text, txtDireccionCliente.Text, Convert.ToInt64(txtTelefonoCliente.Text), txtEmailCliente.Text, dtpFechaNacimientoCliente.Value.Date, Convert.ToInt32(txtEdadCliente.Text));
                    p1.insertarDatoClintes();
                    MessageBox.Show("Datos Ingresados");

                    dtgClientes.DataSource = p1.consultarDatoClientes();
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Error al ingresar dato" + ex.Message);
                }


          }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsClientes p1 = new clsClientes(Convert.ToInt64(txtIdentificacionCliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text, txtCiudadCliente.Text, txtDireccionCliente.Text, Convert.ToInt64(txtTelefonoCliente.Text), txtEmailCliente.Text, dtpFechaNacimientoCliente.Value.Date, Convert.ToInt32(txtEdadCliente.Text));
                p1.modificarDatoClientes();
                MessageBox.Show("Datos modificados");
                dtgClientes.DataSource = p1.consultarDatoClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsClientes p1 = new clsClientes();
                p1.eliminarDatoClientes(Convert.ToInt64(txtIdentificacionCliente.Text));
                dtgClientes.DataSource = p1.consultarDatoClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro" + ex);


            }
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             
        }

        private void dtgClientes_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdentificacionCliente.Text = dtgClientes.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreCliente.Text = dtgClientes.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidoCliente.Text = dtgClientes.SelectedRows[0].Cells[2].Value.ToString();
            txtCiudadCliente.Text = dtgClientes.SelectedRows[0].Cells[3].Value.ToString();
            txtDireccionCliente.Text = dtgClientes.SelectedRows[0].Cells[4].Value.ToString();
            txtTelefonoCliente.Text = dtgClientes.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailCliente.Text = dtgClientes.SelectedRows[0].Cells[6].Value.ToString();
            dtpFechaNacimientoCliente.Text = dtgClientes.SelectedRows[0].Cells[7].Value.ToString();
            txtEdadCliente.Text = dtgClientes.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}