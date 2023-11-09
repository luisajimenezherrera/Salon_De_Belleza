using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
    class clsClientes
    {
        public long bigintIdIdentificacion { get; set; }
        public string strNombreCliente { get; set; }
        public string strApellidoCliente { get; set; }
        public string strCiudadCliente { get; set; }
        public string strDireccionCliente { get; set; }
        public long bigintTelefonoCliente { get; set; }
        public string stEmailCliente { get; set; }
        public DateTime DateFechaNacimientoCliente { get; set; }
        public int intEdadCliente { get; set; }

        public clsClientes()
        {
        }

        public clsClientes(long bigintIdIdentificacion, string strNombreCliente, string strApellidoCliente, string strCiudadCliente, string strDireccionCliente, long bigintTelefonoCliente, string stEmailCliente, DateTime DateFechaNacimientoCliente, int intEdadCliente)
        {
            this.bigintIdIdentificacion = bigintIdIdentificacion;
            this.strNombreCliente = strNombreCliente;
            this.strApellidoCliente = strApellidoCliente;
            this.strCiudadCliente = strCiudadCliente;
            this.strDireccionCliente = strDireccionCliente;
            this.bigintTelefonoCliente = bigintTelefonoCliente;
            this.stEmailCliente = stEmailCliente;
            this.DateFechaNacimientoCliente = DateFechaNacimientoCliente;
            this.intEdadCliente = intEdadCliente;
        }
        public bool insertarDatoClintes()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarCliente = "insert into tblClientes values (@bigintIdIdentificacion,@strNombreCliente,@strApellidoCliente,@strCiudadCliente,@strDireccionCliente,@bigintTelefonoCliente,@stEmailCliente,@DateFechaNacimientoCliente,@intEdadCliente)";
            SqlCommand sql = new SqlCommand(insertarCliente, conexion.conexion);
            sql.Parameters.AddWithValue("bigintIdIdentificacion", this.bigintIdIdentificacion);
            sql.Parameters.AddWithValue("strNombreCliente", this.strNombreCliente);
            sql.Parameters.AddWithValue("strApellidoCliente", this.strApellidoCliente);
            sql.Parameters.AddWithValue("strCiudadCliente", this.strCiudadCliente);
            sql.Parameters.AddWithValue("strDireccionCliente", this.strDireccionCliente);
            sql.Parameters.AddWithValue("bigintTelefonoCliente", this.bigintTelefonoCliente);
            sql.Parameters.AddWithValue("stEmailCliente", this.stEmailCliente);
            sql.Parameters.AddWithValue("DateFechaNacimientoCliente" , SqlDbType.Date).Value = this.DateFechaNacimientoCliente;
            sql.Parameters.AddWithValue("intEdadCliente", this.intEdadCliente);
            sql.ExecuteNonQuery();
            return true;
            


        }

        public DataTable consultarDatoClientes()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaC = "Select * from tblClientes";
            SqlCommand cmd = new SqlCommand(consultaC, conexion.conexion);
            SqlDataAdapter daC= new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }

        public bool eliminarDatoClientes(long bigintIdIdentificacion)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.bigintIdIdentificacion = bigintIdIdentificacion;
            string eliminarC = "delete tblClientes where bigintIdIdentificacion=@bigintIdIdentificacion";
            SqlCommand sql = new SqlCommand(eliminarC, conexion.conexion);
            sql.Parameters.AddWithValue("@bigintIdIdentificacion", this.bigintIdIdentificacion);
            sql.ExecuteNonQuery();
            return true;
        }

        public bool modificarDatoClientes()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarC = "update tblClientes set bigintIdIdentificacion=@bigintIdIdentificacion,strNombreCliente=@strNombreCliente,strApellidoCliente=@strApellidoCliente,strCiudadCliente=@strCiudadCliente,strDireccionCliente=@strDireccionCliente,bigintTelefonoCliente=@bigintTelefonoCliente,stEmailCliente=@stEmailCliente,DateFechaNacimientoCliente=@dateFechaNacimientoCliente,intEdadCliente=@intEdadCliente where bigintIdIdentificacion=@bigintIdIdentificacion";
            SqlCommand sql = new SqlCommand(modificarC, conexion.conexion);
            sql.Parameters.AddWithValue("bigintIdIdentificacion", this.bigintIdIdentificacion);
            sql.Parameters.AddWithValue("strNombreCliente", this.strNombreCliente);
            sql.Parameters.AddWithValue("strApellidoCliente", this.strApellidoCliente);
            sql.Parameters.AddWithValue("strCiudadCliente", this.strCiudadCliente);
            sql.Parameters.AddWithValue("strDireccionCliente", this.strDireccionCliente);
            sql.Parameters.AddWithValue("bigintTelefonoCliente", this.bigintTelefonoCliente);
            sql.Parameters.AddWithValue("stEmailCliente", this.stEmailCliente);
            sql.Parameters.AddWithValue("DateFechaNacimientoCliente",  SqlDbType.Date).Value = this.DateFechaNacimientoCliente;
            sql.Parameters.AddWithValue("intEdadCliente", this.intEdadCliente);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoClientes(long bigintIdIdentificacion)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.bigintIdIdentificacion = bigintIdIdentificacion;
            DataTable dt = new DataTable();
            string seleccionar = "select * from tblClientes where  bigintIdIdentificacion=@bigintIdIdentificacion";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion.conexion);
            cmd.Parameters.AddWithValue("@bigintIdIdentificacion", this.bigintIdIdentificacion);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;
        }
      
    }

   
}
