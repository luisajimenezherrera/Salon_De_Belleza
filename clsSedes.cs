using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
    class clsSedes
    {
        public int intIdSede {  get; set; }
        public string strCiudadSede { get; set; }
        public string strDireccionSede { get; set; }
        public DateTime timeHorarioapertura { get; set; }
        public DateTime timeHorariocierre {  get; set; }


        public clsSedes () 
        { 

        }

        public clsSedes (int intIdSede, string strCiudadSede, string strDireccionSede, DateTime timeHorarioapertura, DateTime timeHorariocierre)
        {

            this.intIdSede = intIdSede;
            this.strCiudadSede = strCiudadSede;
            this.strDireccionSede = strDireccionSede;
            this.timeHorarioapertura = timeHorarioapertura;
            this.timeHorariocierre = timeHorariocierre;
           
        }


        public bool insertarDatoSedes()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarS = "insert into tblSedes values (@intIdSede,@strCiudadSede,@strDireccionSede,@timeHorarioapertura,@timeHorariocierre)";
            SqlCommand sql = new SqlCommand(insertarS, conexion.conexion);

            sql.Parameters.AddWithValue("@intIdSede", this.intIdSede);
            sql.Parameters.AddWithValue("@strCiudadSede", this.strCiudadSede);
            sql.Parameters.AddWithValue("@strDireccionSede", this.strDireccionSede);
            sql.Parameters.AddWithValue("@timeHorarioapertura", SqlDbType.Date).Value = this.timeHorarioapertura;
            sql.Parameters.AddWithValue("@timeHorariocierre", SqlDbType.Date).Value = this.timeHorariocierre;
            
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable consultarDatoSedes()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaS = "Select * from tblSedes";
            SqlCommand cmd = new SqlCommand(consultaS, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }
        public bool eliminarDatoSedes(int intIdSede)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdSede = intIdSede;
            string eliminarS = "delete tblSedes where intIdSede=@intIdSede";
            SqlCommand sql = new SqlCommand(eliminarS, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdSede", this.intIdSede);
            sql.ExecuteNonQuery();
            return true;
        }

        public bool modificarDatoSedes()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarS = "update tblSedes set intIdSede=@intIdSede,strCiudadSede=@strCiudadSede,strDireccionSede=@strDireccionSede,timeHorarioapertura=@timeHorarioapertura,timeHorariocierre=@timeHorariocierre where intIdSede=@intIdSede";
            SqlCommand sql = new SqlCommand(modificarS, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdSede", this.intIdSede);
            sql.Parameters.AddWithValue("@strCiudadSede", this.strCiudadSede);
            sql.Parameters.AddWithValue("@strDireccionSede", this.strDireccionSede);
            sql.Parameters.AddWithValue("@timeHorarioapertura", SqlDbType.Date).Value = this.timeHorarioapertura;
            sql.Parameters.AddWithValue("@timeHorariocierre", SqlDbType.Date).Value = this.timeHorariocierre;

            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoSedes(int intIdSede)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdSede = intIdSede;
            DataTable dt = new DataTable();
            string seleccionarS = "select * from tblSedes where  intIdSede=@intIdSede";
            SqlCommand cmd = new SqlCommand(seleccionarS, conexion.conexion);
            cmd.Parameters.AddWithValue("@intIdSede", this.intIdSede);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;
        }

        
    }


    
}
