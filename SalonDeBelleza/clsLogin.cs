using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
     class clsLogin
    {
        public DataTable ObtenerUsuarios()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string consulta = "SELECT * FROM tblAdministrador";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            return dataTable;
        }
    }
}
