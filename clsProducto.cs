using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
     class clsProducto
    {
        public int intIdProductos {  get; set; }
        public string strNombreProducto { get; set;}

        public string strSugerenciaProducto { get; set;}


        public clsProducto ()
        { 

        }

        public clsProducto (int intIdProductos, string strNombreProducto, string  strSugerenciaProducto)
        {
        this.intIdProductos = intIdProductos;
        this.strNombreProducto = strNombreProducto;
        this.strSugerenciaProducto = strSugerenciaProducto;
        }


        public bool insertarDatoProducto()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarP = "insert into tblProductos values (@intIdProductos,@strNombreProducto,@strSugerenciaProducto)";
            SqlCommand sql = new SqlCommand(insertarP, conexion.conexion);

            sql.Parameters.AddWithValue("@intIdProductos", this.intIdProductos);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@strSugerenciaProducto", this.strSugerenciaProducto);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable consultarDatoProducto()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaP = "Select * from tblProductos";
            SqlCommand cmd = new SqlCommand(consultaP, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }

        public bool eliminarDatoProducto(int intIdProductos)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdProductos = intIdProductos;
            string eliminarP = "delete tblProductos where intIdProductos=@intIdProductos";
            SqlCommand sql = new SqlCommand(eliminarP, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdProductos", this.intIdProductos);
            sql.ExecuteNonQuery();
            return true;
        }

        public bool modificarDatoProducto()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarP = "update tblProductos set intIdProductos=@intIdProductos,strNombreProducto=@strNombreProducto,strSugerenciaProducto=@strSugerenciaProducto where intIdProductos=@intIdProductos";
            SqlCommand sql = new SqlCommand(modificarP, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdProductos", this.intIdProductos);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@strSugerenciaProducto", this.strSugerenciaProducto);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoProducto(int intIdProductos)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdProductos = intIdProductos;
            DataTable dt = new DataTable();
            string seleccionarP = "select * from tblProductos where  intIdProductos=@intIdProductos";
            SqlCommand cmd = new SqlCommand(seleccionarP, conexion.conexion);
            cmd.Parameters.AddWithValue("@intIdProductos", this.intIdProductos);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;
        }

        
        
    }


}
