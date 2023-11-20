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
        public void cargarDatos()
        {
        }
        public frmReservas()
        {
            InitializeComponent();

        }



        private void frmReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaReservas = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpFechaReserva.Text = string.Empty;
            txtIdClienteReservas.Text = string.Empty;

            txtIdReserva.Text = string.Empty;
            txtPreferenciasReservas.Text = string.Empty;
            cmbSeleccionProducto.Text = string.Empty;
            cmbTipoServicio.Text = string.Empty;
            dtpHorainicioR.Text = string.Empty;

        }

        private void btnLimpiarReservas_Click(object sender, EventArgs e)
        {
            dtpFechaReserva.Text = string.Empty;
            txtIdClienteReservas.Text = string.Empty;
            dtpHorafinR.Text = string.Empty;
            txtIdReserva.Text = string.Empty;
            txtPreferenciasReservas.Text = string.Empty;
            cmbSeleccionProducto.Text = string.Empty;
            cmbTipoServicio.Text = string.Empty;
            dtpHorainicioR.Text = string.Empty;
            cmbSeleccionarProfesional.Text = string.Empty;
            dtpHorainicioR.Text = string.Empty;
            cmbSedesReservas.Text = string.Empty;
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
            BorrarMensajeError();



            try
            {
                if (ValidarCampos() == true)
                {

                    clsConexion conexion = new clsConexion();
                    conexion.abrirConexion();

                    clsReservas p1 = new clsReservas(Convert.ToInt16(txtIdReserva.Text), dtpFechaReserva.Value.Date, cmbTipoCliente.Text, txtPreferenciasReservas.Text, cmbSeleccionProducto.Text, Convert.ToInt64(txtIdClienteReservas.Text), Convert.ToInt16(cmbSedesReservas.Text), Convert.ToInt64(cmbSeleccionarProfesional.Text), Convert.ToInt16(cmbTipoServicio.Text), dtpHorainicioR.Value.TimeOfDay, dtpHorafinR.Value.TimeOfDay, cmbAMPMHoraInicioCita.Text, cmbAmPmHoraFinCita.Text);

                    p1.insertarDatoReservas();
                    dtgReservas.DataSource = p1.consultarDatoReservas();
                    p1.insertarDatoReservas();
                    MessageBox.Show("Datos Ingresados");
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }

        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtIdReserva.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdReserva, "Ingrese un id reserva que no este ya ingresado");
            }
            if (cmbTipoServicio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbTipoServicio, "Ingrese el id del tipo de servicio que deseas");
            }
            if (cmbTipoCliente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbTipoCliente, "Por Favor ingrese que tipo de cliente es");
            }
            if (cmbSedesReservas.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbSedesReservas, "Por Favor selecciona el id de la sede donde deseas reservar");
            }
            if (cmbSeleccionProducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbSeleccionProducto, "Por Favor ingrese un Producto");
            }
            if (cmbSeleccionarProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbSeleccionarProfesional, "Por Favor selecciona el id del profesional");
            }
            if (txtIdClienteReservas.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdClienteReservas, "Por Favor ingrese el documento del cliente y que ya este registrado como cliente");
            }
            if (dtpFechaReserva.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpFechaReserva, "Por Favor ingrese la fecha de la reserva");
            }
            if (dtpHorainicioR.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpHorainicioR, "Por Favor ingrese la hora de inicio la reserva");
            }
            if (dtpHorafinR.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpHorafinR, "Por Favor ingrese la hora de finalizacion de la reserva");
            }
            if (cmbAmPmHoraFinCita.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbAmPmHoraFinCita, "Por Favor ingrese si la hora de finalizacion de la reserva es en la mañana o en la tarde");
            }
            if (cmbAMPMHoraInicioCita.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbAMPMHoraInicioCita, "Por Favor ingrese si la hora de inicio de la reserva es en la mañana o en la tarde");
            }
            return ok;

        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtIdReserva, "");
            errorProvider1.SetError(cmbTipoServicio, "");
            errorProvider1.SetError(cmbTipoCliente, "");
            errorProvider1.SetError(cmbSedesReservas, "");
            errorProvider1.SetError(cmbSeleccionProducto, "");
            errorProvider1.SetError(cmbSeleccionarProfesional, "");
            errorProvider1.SetError(txtIdClienteReservas, "");
            errorProvider1.SetError(dtpFechaReserva, "");
            errorProvider1.SetError(dtpHorainicioR, "");
            errorProvider1.SetError(dtpHorafinR, "");
            errorProvider1.SetError(cmbAmPmHoraFinCita, "");
            errorProvider1.SetError(cmbAMPMHoraInicioCita, "");
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

                clsReservas p1 = new clsReservas(Convert.ToInt16(txtIdReserva.Text), dtpFechaReserva.Value.Date, cmbTipoCliente.Text, txtPreferenciasReservas.Text, cmbSeleccionProducto.Text, Convert.ToInt64(txtIdClienteReservas.Text), Convert.ToInt16(cmbSedesReservas.Text), Convert.ToInt64(cmbSeleccionarProfesional.Text), Convert.ToInt16(cmbTipoServicio.Text), dtpHorainicioR.Value.TimeOfDay, dtpHorafinR.Value.TimeOfDay, cmbAMPMHoraInicioCita.Text, cmbAmPmHoraFinCita.Text);
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


        private void dtgReservas_MouseClick(object sender, MouseEventArgs e)
        {

            txtIdReserva.Text = dtgReservas.SelectedRows[0].Cells[0].Value.ToString();
            dtpFechaReserva.Text = dtgReservas.SelectedRows[0].Cells[1].Value.ToString();
            cmbTipoCliente.Text = dtgReservas.SelectedRows[0].Cells[2].Value.ToString();
            txtPreferenciasReservas.Text = dtgReservas.SelectedRows[0].Cells[3].Value.ToString();
            cmbSeleccionProducto.Text = dtgReservas.SelectedRows[0].Cells[4].Value.ToString();
            txtIdClienteReservas.Text = dtgReservas.SelectedRows[0].Cells[5].Value.ToString();
            cmbSedesReservas.Text = dtgReservas.SelectedRows[0].Cells[6].Value.ToString();
            cmbSeleccionarProfesional.Text = dtgReservas.SelectedRows[0].Cells[7].Value.ToString();
            cmbTipoServicio.Text = dtgReservas.SelectedRows[0].Cells[8].Value.ToString();
            dtpHorainicioR.Text = dtgReservas.SelectedRows[0].Cells[9].Value.ToString();
            dtpHorafinR.Text = dtgReservas.SelectedRows[0].Cells[10].Value.ToString();
            cmbAMPMHoraInicioCita.Text = dtgReservas.SelectedRows[0].Cells[11].Value.ToString();
            cmbAmPmHoraFinCita.Text = dtgReservas.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            dtpHorainicioR.CustomFormat = "hh:mm tt";
            dtpHorainicioR.Format = DateTimePickerFormat.Custom;

            dtpHorafinR.CustomFormat = "hh:mm tt";
            dtpHorafinR.Format = DateTimePickerFormat.Custom;

            clsReservas Reservas1 = new clsReservas();
            { 
            DataTable dataTable = Reservas1.ObtenerServicioR();

            cmbTipoServicio.DataSource = dataTable;
            cmbTipoServicio.DisplayMember = "intIdServicios";
            cmbTipoServicio.ValueMember = "intIdServicios";
            this.KeyPreview = true;
            }
            {
                clsReservas Reservas2 = new clsReservas();
                DataTable dataTable = Reservas2.ObtenerSedeP();

                cmbSedesReservas.DataSource = dataTable;
                cmbSedesReservas.DisplayMember = "intIdSedeR";
               cmbSedesReservas.ValueMember = "intIdSede";
                this.KeyPreview = true;
            }

            {
                clsReservas Reservas3 = new clsReservas();
                DataTable dataTable = Reservas3.ObtenerProfesional();

                cmbSeleccionarProfesional.DataSource = dataTable;
                cmbSeleccionarProfesional.DisplayMember = "bigintIdProfesional";
                cmbSeleccionarProfesional.ValueMember = "bigintIdProfesional";
                this.KeyPreview = true;
            }
        }

        private void txtIdReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtIdClienteReservas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        
    }
}
