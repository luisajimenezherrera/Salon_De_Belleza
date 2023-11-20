using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
    class clsProfesional
    {
        public long bigintIdProfesional { get; set; }
        public string strNombreProfesional { get; set; }
        public string strApellidoProfesional { get; set; }
        public long bigintTelefonoProfesional { get; set; }
        public int intIdSedeP {  get; set; }
        public TimeSpan timeHoraInicioP{ get; set; }
        public TimeSpan timeHoraFinP { get; set; }
        public string strTiempoHoraInicioP { get; set; }
        public string strTiempoHoraFINP { get; set; }


        public clsProfesional() 
        {

        }

        public clsProfesional(long bigintIdProfesional, string strNombreProfesional, string strApellidoProfesional, long bigintTelefonoProfesional, int intIdSedeP, TimeSpan timeHoraInicioP, TimeSpan timeHoraFinP, string strTiempoHoraInicioP, string strTiempoHoraFINP)
        {
            this.bigintIdProfesional = bigintIdProfesional;
            this.strNombreProfesional = strNombreProfesional;
            this.strApellidoProfesional = strApellidoProfesional;
            this.bigintTelefonoProfesional = bigintTelefonoProfesional;
            this.intIdSedeP = intIdSedeP;
            this.timeHoraInicioP = timeHoraInicioP;
            this.timeHoraFinP = timeHoraFinP;
            this.strTiempoHoraInicioP = strTiempoHoraInicioP;
            this.strTiempoHoraFINP = strTiempoHoraFINP;

        }
        public DataTable ObtenerSedeP()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string consulta = "SELECT intIdSede FROM tblSedes";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            return dataTable;
        }


        public bool insertarDatoProfesional()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarPf = "insert into tblProfesional values (@bigintIdProfesional,@strNombreProfesional,@strApellidoProfesional,@bigintTelefonoProfesional,@intIdSedeP,@timeHoraInicioP,@timeHoraFinP,@strTiempoHoraInicioP,@strTiempoHoraFINP)";
            SqlCommand sql = new SqlCommand(insertarPf, conexion.conexion);

            sql.Parameters.AddWithValue("@bigintIdProfesional", this.bigintIdProfesional);
            sql.Parameters.AddWithValue("@strNombreProfesional", this.strNombreProfesional);
            sql.Parameters.AddWithValue("@strApellidoProfesional", this.strApellidoProfesional);
            sql.Parameters.AddWithValue("@bigintTelefonoProfesional", this.bigintTelefonoProfesional); 
            sql.Parameters.AddWithValue("@intIdSedeP", this.intIdSedeP);
            sql.Parameters.AddWithValue("@timeHoraInicioP", SqlDbType.Time).Value= this.timeHoraInicioP;
            sql.Parameters.AddWithValue("@timeHoraFinP", SqlDbType.Time).Value= this.timeHoraFinP;
            sql.Parameters.AddWithValue("@strTiempoHoraInicioP", this.strTiempoHoraInicioP);
             sql.Parameters.AddWithValue("@strTiempoHoraFINP", this.strTiempoHoraFINP);
            sql.ExecuteNonQuery();
            return true;
        }


        public DataTable consultarDatoProfesional()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaPf = "Select * from tblProfesional";
            SqlCommand cmd = new SqlCommand(consultaPf, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }


        public bool eliminarDatoProfesional(long bigintIdProfesional)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.bigintIdProfesional = bigintIdProfesional;
            string eliminarPf = "delete tblProfesional where bigintIdProfesional=@bigintIdProfesional";
            SqlCommand sql = new SqlCommand(eliminarPf, conexion.conexion);
            sql.Parameters.AddWithValue("@bigintIdProfesional", this.bigintIdProfesional);
            sql.ExecuteNonQuery();
            return true;
        }


        public bool modificarDatoProfesional()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarPf = "update tblProfesional set bigintIdProfesional=@bigintIdProfesional,strNombreProfesional=@strNombreProfesional,strApellidoProfesional=@strApellidoProfesional,bigintTelefonoProfesional=@bigintTelefonoProfesional,intIdSedeP=@intIdSedeP,timeHoraInicioP=@timeHoraInicioP,timeHoraFinP=@timeHoraFinP,@strTiempoHoraInicioP,@strTiempoHoraFINP where bigintIdProfesional=@bigintIdProfesional";
            SqlCommand sql = new SqlCommand(modificarPf, conexion.conexion);
            sql.Parameters.AddWithValue("@bigintIdProfesional", this.bigintIdProfesional);
            sql.Parameters.AddWithValue("@strNombreProfesional", this.strNombreProfesional);
            sql.Parameters.AddWithValue("@strApellidoProfesional", this.strApellidoProfesional);
            sql.Parameters.AddWithValue("@bigintTelefonoProfesional", this.bigintTelefonoProfesional);
            sql.Parameters.AddWithValue("@intIdSedeP", this.intIdSedeP);
            sql.Parameters.AddWithValue("@timeHoraInicioP", SqlDbType.Time).Value = this.timeHoraInicioP;
            sql.Parameters.AddWithValue("@timeHoraFinP", SqlDbType.Time).Value = this.timeHoraFinP;
            sql.Parameters.AddWithValue("@strTiempoHoraInicioP", this.strTiempoHoraInicioP);
            sql.Parameters.AddWithValue("@strTiempoHoraFINP", this.strTiempoHoraFINP);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoProfesional(long bigintIdProfesional)
        {

            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.bigintIdProfesional = bigintIdProfesional;
            DataTable dt = new DataTable();
            string seleccionarPf = "select * from tblProfesional where  bigintIdProfesional=@bigintIdProfesional";
            SqlCommand cmd = new SqlCommand(seleccionarPf, conexion.conexion);
            cmd.Parameters.AddWithValue("@bigintIdProfesional", this.bigintIdProfesional);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;
        }
    }
}

