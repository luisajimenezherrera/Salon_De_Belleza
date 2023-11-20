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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnIngresarAdm_Click(object sender, EventArgs e)
        {

            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string usuario = "";
            string contraseña = txtContraseña.Text;
            BorrarMensajeError();
            if (ValidarCampos() == true)
            {
                if (cmbstrUsuario.Text != null)
                {
                    usuario = cmbstrUsuario.Text;
                    string consultaLog = "select * from tblAdministrador where strUsuario=@usuario AND strContraseña=@contraseña";
                    SqlCommand queryLog = new SqlCommand(consultaLog, conexion.conexion);
                    queryLog.Parameters.AddWithValue("usuario", usuario);
                    queryLog.Parameters.AddWithValue("contraseña", contraseña);
                    SqlDataAdapter adapter = new SqlDataAdapter(queryLog);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {

                        frmPrincipal FrmPrincipal = new frmPrincipal();
                        FrmPrincipal.Show();
                        this.Hide();

                    }
                
                else
                {
                    MessageBox.Show("Datos incorrectos");

                }
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado un usuario");
                return;
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (cmbstrUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbstrUsuario, "Selecciona un usuario para ingresar");
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, "Ingrese la contraseña");
            }

            return ok;

        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtContraseña, "");
            errorProvider1.SetError(cmbstrUsuario, "");
            
        }
        //Obtener usuario 
        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            clsLogin conexionLogin = new clsLogin();
            DataTable dataTable = conexionLogin.ObtenerUsuarios();
            cmbstrUsuario.DataSource = dataTable;
            cmbstrUsuario.DisplayMember = "strUsuario";
            cmbstrUsuario.ValueMember = "strUsuario";
            this.KeyPreview = true;

        }
        //ingresar con enter
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresarAdm_Click(sender, e);
            }
        }
    }
}
