using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
    class clsOpinion
    {
        public int intIdOpinion {  get; set; }
        public string strOpinionGeneral { get; set; }

        public int intIdReservasO {  get; set; }


        public clsOpinion()
        { 

        }

        public clsOpinion(int intIdOpinion, string strOpinionGeneral,  int intIdReservasO)
        {
            this.intIdOpinion = intIdOpinion;
            this.strOpinionGeneral = strOpinionGeneral;
            this.intIdReservasO = intIdReservasO;
        }


        public bool insertarDatoOpinion()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertar = "insert into tblOpinion values (@intIdOpinion,@strOpinionGeneral,@intIdReservasO)";
            SqlCommand sql = new SqlCommand(insertar, conexion.conexion);

            sql.Parameters.AddWithValue("@intIdOpinion", this.intIdOpinion);
            sql.Parameters.AddWithValue("@strOpinionGeneral", this.strOpinionGeneral);
            sql.Parameters.AddWithValue("@intIdReservasO", this.intIdReservasO);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable consultarDatoOpinion()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaO = "Select * from tblOpinion";
            SqlCommand cmd = new SqlCommand(consultaO, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }


        public bool eliminarDatoOpinion(int intIdOpinion)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdOpinion = intIdOpinion;
            string eliminarO = "delete tblOpinion where intIdOpinion=@intIdOpinion";
            SqlCommand sql = new SqlCommand(eliminarO, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdOpinion", this.intIdOpinion);
            sql.ExecuteNonQuery();
            return true;
        }

        public bool modificarDatoOpinion()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarO = "update tblOpinion set intIdOpinion=@intIdOpinion,strOpinionGeneral=@strOpinionGeneral,intIdReservasO=@intIdReservasO where intIdOpinion=@intIdOpinion";
            SqlCommand sql = new SqlCommand(modificarO, conexion.conexion);
            sql.Parameters.AddWithValue("intIdOpinion", this.intIdOpinion);
            sql.Parameters.AddWithValue("strOpinionGeneral", this.strOpinionGeneral);
            sql.Parameters.AddWithValue("intIdReservasO", this.intIdReservasO);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoOpinion(int intIdOpinion)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdOpinion = intIdOpinion;
            DataTable dt = new DataTable();
            string seleccionarO = "select * from tblOpinion where  intIdOpinion=@intIdOpinion";
            SqlCommand cmd = new SqlCommand(seleccionarO, conexion.conexion);
            cmd.Parameters.AddWithValue("@intIdOpinion", this.intIdOpinion);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;
        }
       






    }
}
