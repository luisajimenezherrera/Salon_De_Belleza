using System;
using System.Data.SqlClient;

namespace SalonDeBelleza
{
    class clsConexion
    {
        string cadenaConexion = "Data Source=DESKTOP-40CORT5;Initial Catalog=dboSalonBelleza;Integrated Security=True";
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
