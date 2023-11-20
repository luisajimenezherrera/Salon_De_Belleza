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

       

        private void frmProfesional_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaProfesional = null;
        }

        private void btnLimpiarProfesional_Click(object sender, EventArgs e)
        {
            txtApellidoProfesional.Text=string.Empty;
            txtIdentificacionProfesional.Text = string.Empty;   
           cmbSedeP.Text= string.Empty;
            txtNombreProfesional.Text = string.Empty;
            txtTelefonoProfesional.Text = string.Empty;
            
            dtgProfesional.DataSource = null;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtApellidoProfesional.Text = string.Empty;
            txtIdentificacionProfesional.Text = string.Empty;
           cmbSedeP.Text = string.Empty;
            txtNombreProfesional.Text = string.Empty;
            txtTelefonoProfesional.Text = string.Empty;
           
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

                BorrarMensajeError();
                if (ValidarCampos() == true)
                {
                    clsConexion conexion = new clsConexion();
                    conexion.abrirConexion();

                    clsProfesional p1 = new clsProfesional(Convert.ToInt64(txtIdentificacionProfesional.Text), txtNombreProfesional.Text, txtApellidoProfesional.Text, Convert.ToInt64(txtTelefonoProfesional.Text), Convert.ToInt16(cmbSedeP.Text), dtpHorainicioP.Value.TimeOfDay, dtpHorafinP.Value.TimeOfDay, cmbAMPMHoraInicioProfesional.Text, cmbAmPMHoraFinProfesional.Text);
                    p1.insertarDatoProfesional();
                    dtgProfesional.DataSource = p1.consultarDatoProfesional();
                }
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
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNombreProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreProfesional, "Ingrese el nombre del profesional");
            }
            if (txtApellidoProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellidoProfesional, "Ingrese el apellido del Profesional");
            }
            if (txtIdentificacionProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdentificacionProfesional, "Por Favor ingrese la Identificacion");
            }
            if (txtTelefonoProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefonoProfesional, "Por Favor ingresa un numero de telefono");
            }
            if (cmbSedeP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbSedeP, "Por Favor ingrese una sede donde va a trabajar el profesional");
            }
            if (dtpHorainicioP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpHorainicioP, "Por Favor ingresar el horario de inicio de trabajo");
            }
            if (dtpHorafinP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpHorafinP, "Por Favor ingresar el horario de finalizacion del trabajo");
            }
            if (cmbAMPMHoraInicioProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbAMPMHoraInicioProfesional, "Por Favor ingresar si el horario inicial es desde la mañana o desde la tarde");
            }
            if (cmbAmPMHoraFinProfesional.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbAmPMHoraFinProfesional, "Por Favor ingresar si el horario final es desde la mañana o desde la tarde");
            }

            return ok;

        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombreProfesional, "");
            errorProvider1.SetError(txtApellidoProfesional, "");
            errorProvider1.SetError(txtIdentificacionProfesional, "");
            errorProvider1.SetError(txtTelefonoProfesional, "");
            errorProvider1.SetError(cmbSedeP, "");
            errorProvider1.SetError(dtpHorainicioP, "");
            errorProvider1.SetError(dtpHorafinP, "");
            errorProvider1.SetError(cmbAmPMHoraFinProfesional, "");
            errorProvider1.SetError(cmbAMPMHoraInicioProfesional, "");
        }

        private void btnModificarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsProfesional p1 = new clsProfesional(Convert.ToInt64(txtIdentificacionProfesional.Text), txtNombreProfesional.Text, txtApellidoProfesional.Text, Convert.ToInt64(txtTelefonoProfesional.Text), Convert.ToInt16(cmbSedeP.Text), dtpHorainicioP.Value.TimeOfDay, dtpHorafinP.Value.TimeOfDay,cmbAMPMHoraInicioProfesional.Text, cmbAmPMHoraFinProfesional.Text);
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
            cmbSedeP.Text= dtgProfesional.SelectedRows[0].Cells[4].Value.ToString();
            dtpHorainicioP.Text = dtgProfesional.SelectedRows[0].Cells[5].Value.ToString();
            dtpHorafinP.Text = dtgProfesional.SelectedRows[0].Cells[6].Value.ToString();
            cmbAMPMHoraInicioProfesional.Text = dtgProfesional.SelectedRows[0].Cells[7].Value.ToString();
            cmbAmPMHoraFinProfesional.Text = dtgProfesional.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void frmProfesional_Load(object sender, EventArgs e)
        {
            // Cambiar el formato de hora para incluir AM/PM
            dtpHorainicioP.CustomFormat = "hh:mm tt";
            dtpHorainicioP.Format = DateTimePickerFormat.Custom;

            dtpHorafinP.CustomFormat = "hh:mm tt";
            dtpHorafinP.Format = DateTimePickerFormat.Custom;

            clsProfesional profesional = new clsProfesional();
            DataTable dataTable = profesional.ObtenerSedeP();
           
            cmbSedeP.DataSource = dataTable;
            cmbSedeP.DisplayMember = "intIdSedeP";
            cmbSedeP.ValueMember = "intIdSede";
            this.KeyPreview = true;

        }

        private void txtIdentificacionProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
