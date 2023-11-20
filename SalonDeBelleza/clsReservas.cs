using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonDeBelleza
{
    class clsReservas
    {
        public int intIdReservas { get; set; }
        public DateTime dateFechaReserva { get; set; }
        public string strPreferencia { get; set; }
        public string strTipocliente { get; set; }

        public string strSeleccionProducto { get; set; }
        public long bigintIdIdentificacionR { get; set; }
        public int intIdSedeR { get; set; }

        public long bigintIdProfesional { get; set; }
        public int intIdServicios { get; set; }
        public TimeSpan timeHoraInicioR { get; set; }
        public TimeSpan timeHoraFinR { get; set; }
        public string strTiempoHoraInicioCita { get; set; }
        public string strTiempoTimeHoraFinCita { get; set; }



        public clsReservas()
        {

        }

        public clsReservas(int intIdReservas, DateTime dateFechaReserva, string strTipocliente, string strPreferencia, string strSeleccionProducto, long bigintIdIdentificacionR, int intIdSedeR, long bigintIdProfesional, int intIdServicios, TimeSpan timeHoraInicioR, TimeSpan timeHoraFinR, string strTiempoHoraInicioCita, string strTiempoTimeHoraFinCita)
        {
            this.intIdReservas = intIdReservas;
            this.dateFechaReserva = dateFechaReserva;
            this.strTipocliente = strTipocliente;
            this.strPreferencia = strPreferencia;
            this.strSeleccionProducto = strSeleccionProducto;
            this.bigintIdIdentificacionR = bigintIdIdentificacionR;
            this.intIdSedeR = intIdSedeR;
            this.bigintIdProfesional = bigintIdProfesional;
            this.intIdServicios = intIdServicios;
            this.timeHoraInicioR = timeHoraInicioR;
            this.timeHoraFinR = timeHoraFinR;
            this.strTiempoHoraInicioCita = strTiempoHoraInicioCita;
            this.strTiempoTimeHoraFinCita = strTiempoTimeHoraFinCita;
        }

        public DataTable ObtenerServicioR()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string consulta = "SELECT intIdServicios FROM tblServicios";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            return dataTable;
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
        public DataTable ObtenerProfesional()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string consulta = "SELECT bigintIdProfesional FROM tblProfesional";
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            return dataTable;
        }


        public bool insertarDatoReservas()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarR = "insert into tblReservas values (@intIdReservas,@dateFechaReserva,@strTipocliente,@strPreferencia,@strSeleccionProducto,@bigintIdIdentificacionR,@intIdSedeR,@bigintIdProfesional,@intIdServicios,@timeHoraInicioR,@timeHoraFinR,@strTiempoHoraInicioCita,@strTiempoTimeHoraFinCita)";
            SqlCommand sql = new SqlCommand(insertarR, conexion.conexion);

            sql.Parameters.AddWithValue("@intIdReservas", this.intIdReservas);
            sql.Parameters.AddWithValue("@dateFechaReserva", SqlDbType.Date).Value = this.dateFechaReserva;
            sql.Parameters.AddWithValue("@strTipocliente", this.strTipocliente);
            sql.Parameters.AddWithValue("@strPreferencia", this.strPreferencia);
            sql.Parameters.AddWithValue("@strSeleccionProducto", this.strSeleccionProducto);
            sql.Parameters.AddWithValue("@bigintIdIdentificacionR", this.bigintIdIdentificacionR);
            sql.Parameters.AddWithValue("@intIdSedeR", this.intIdSedeR);
            sql.Parameters.AddWithValue("@bigintIdProfesional", this.bigintIdProfesional);
            sql.Parameters.AddWithValue("@intIdServicios", this.intIdServicios);
            sql.Parameters.AddWithValue("@timeHoraInicioR", SqlDbType.Time).Value = this.timeHoraInicioR;
            sql.Parameters.AddWithValue("@timeHoraFinR", SqlDbType.Time).Value = this.timeHoraFinR;
            sql.Parameters.AddWithValue("@strTiempoHoraInicioCita", this.strTiempoHoraInicioCita);
            sql.Parameters.AddWithValue("@strTiempoTimeHoraFinCita", this.strTiempoTimeHoraFinCita);

            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable consultarDatoReservas()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaR = "Select * from tblReservas";
            SqlCommand cmd = new SqlCommand(consultaR, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }

        public bool eliminarDatoReservas(int intIdReservas)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdReservas = intIdReservas;
            string eliminarR = "delete tblReservas where intIdReservas=@intIdReservas";
            SqlCommand sql = new SqlCommand(eliminarR, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdReservas", this.intIdReservas);
            sql.ExecuteNonQuery();
            return true;
        }


        public bool modificarDatoReservas()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarR = "update tblReservas set intIdReservas=@intIdReservas,dateFechaReserva=@dateFechaReserva,strTipocliente=@strTipocliente,strPreferencia=@strPreferencia,strSeleccionProducto=@strSeleccionProducto,bigintIdIdentificacionR=@bigintIdIdentificacionR,intIdSedeR=@intIdSedeR,bigintIdProfesional=@bigintIdProfesional,intIdServicios=@intIdServicios,timeHoraInicioR=@timeHoraInicioR,timeHoraFinR=@timeHoraFinR,strTiempoHoraInicioCita=@strTiempoHoraInicioCita,strTiempoTimeHoraFinCita=@strTiempoHoraInicioCita where intIdReservas=@intIdReservas";
            SqlCommand sql = new SqlCommand(modificarR, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdReservas", this.intIdReservas);
            sql.Parameters.AddWithValue("@dateFechaReserva", SqlDbType.Date).Value = this.dateFechaReserva;
            sql.Parameters.AddWithValue("@strTipocliente", this.strTipocliente);
            sql.Parameters.AddWithValue("@strPreferencia", this.strPreferencia);
            sql.Parameters.AddWithValue("@strSeleccionProducto", this.strSeleccionProducto);
            sql.Parameters.AddWithValue("@bigintIdIdentificacionR", this.bigintIdIdentificacionR);
            sql.Parameters.AddWithValue("@intIdSedeR", this.intIdSedeR);
            sql.Parameters.AddWithValue("@bigintIdProfesional", this.bigintIdProfesional);
            sql.Parameters.AddWithValue("@intIdServicios", this.intIdServicios);
            sql.Parameters.AddWithValue("@timeHoraInicioR", SqlDbType.Time).Value = this.timeHoraInicioR;
            sql.Parameters.AddWithValue("@timeHoraFinR", SqlDbType.Time).Value = this.timeHoraFinR;
            sql.Parameters.AddWithValue("@strTiempoHoraInicioCita", this.strTiempoHoraInicioCita);
            sql.Parameters.AddWithValue("@strTiempoTimeHoraFinCita", this.strTiempoTimeHoraFinCita);

            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoReservas(int intIdReservas)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdReservas = intIdReservas;
            DataTable dt = new DataTable();
            string seleccionarR = "select * from tblReservas where  intIdReservas=@intIdReservas";
            SqlCommand cmd = new SqlCommand(seleccionarR, conexion.conexion);
            cmd.Parameters.AddWithValue("@intIdReservas", this.intIdReservas);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;
        }
    }
}
