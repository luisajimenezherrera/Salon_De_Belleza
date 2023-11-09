using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            if (cmbUsuario.Text != null)
            {
                usuario = cmbUsuario.Text;
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
            else
            {
                MessageBox.Show("No se ha seleccionado un usuario");
                return;
            }


            
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
        }

            
        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       
    }
}




