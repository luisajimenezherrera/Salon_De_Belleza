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
    public partial class frmProducto : Form
    {
        private static frmProducto instanciaProducto = null;

        public static frmProducto ventanaProducto()
        {
            if (instanciaProducto == null)
            {
                instanciaProducto = new frmProducto();
                return instanciaProducto;
            }
            return instanciaProducto;
        }
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaProducto = null;
        }

        private void btnLimpiarProductos_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            dtgProductos.DataSource = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProducto p1 = new clsProducto(Convert.ToInt16(txtIdProducto.Text), txtNombreProducto.Text, txtMarca.Text);
                p1.insertarDatoProducto();
                MessageBox.Show("Datos Ingresados");

                dtgProductos.DataSource = p1.consultarDatoProducto();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                if (txtIdProducto.Text == "")
                {
                    clsProducto p1 = new clsProducto();
                    dtgProductos.DataSource = p1.consultarDatoProducto();

                }
                else
                {
                    clsProducto p1 = new clsProducto();
                    dtgProductos.DataSource = p1.seleccionarDatoProducto(Convert.ToInt32(txtIdProducto.Text));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

        private void btnModificarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProducto p1 = new clsProducto(Convert.ToInt16(txtIdProducto.Text), txtNombreProducto.Text, txtMarca.Text);
                p1.modificarDatoProducto();
                MessageBox.Show("Datos modificados");
                dtgProductos.DataSource = p1.consultarDatoProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProducto p1 = new clsProducto();
                p1.eliminarDatoProducto(Convert.ToInt16(txtIdProducto.Text));
                dtgProductos.DataSource = p1.consultarDatoProducto();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro" + ex);


            }
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgProductos_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdProducto.Text = dtgProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtMarca.Text = dtgProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtNombreProducto.Text = dtgProductos.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
