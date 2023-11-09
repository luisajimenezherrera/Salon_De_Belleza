using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
    class clsConexion
    {
        string cadenaConexion = "Data Source=CAROLINA-LAPTOP;Initial Catalog=dboSalonBelleza;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();

        public clsConexion()
        {
            conexion.ConnectionString = cadenaConexion;
        }

        public void abrirConexion()
        {
            try
            {

                conexion.Open();
                Console.WriteLine("Exitoso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion" + ex.Message);

            }


        }

        public void cerrarConexion()
        {
            conexion.Close();
        }



    }
}
