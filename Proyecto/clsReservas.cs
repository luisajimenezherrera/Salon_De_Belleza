using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza
{
     class clsReservas
    {
        public int intIdReservas {  get; set; }
        public string strTipoServicio { get; set; }
        public DateTime timeHoraReserva { get; set; }
        public DateTime dateFechaReserva { get; set; }
        public string strTipoCliente {  get; set; } 
        public string strPreferencia { get; set; }
        public string strSeleccionProducto { get; set; }
        public long bigintIdIdentificacionR {  get; set; }
        public int intIdSedeR { get; set; }


        public clsReservas() 
        {

        }

        public clsReservas(int intIdReservas, string strTipoServicio, DateTime timeHoraReserva, DateTime dateFechaReserva, string strTipoCliente, string strPreferencia, string strSeleccionProducto, long bigintIdIdentificacionR, int intIdSedeR)
        {
            this.intIdReservas = intIdReservas;
            this.strTipoServicio = strTipoServicio;
            this.timeHoraReserva = timeHoraReserva;
            this.dateFechaReserva = dateFechaReserva;
            this.strTipoCliente = strTipoCliente;
            this.strPreferencia = strPreferencia;
            this.strSeleccionProducto = strSeleccionProducto;
            this.bigintIdIdentificacionR = bigintIdIdentificacionR;
            this.intIdSedeR = intIdSedeR;
        }

        public bool insertarDatoReservas()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarR= "insert into tblReservas values (@intIdReservas,@strTipoServicio,@timeHoraReserva,@dateFechaReserva,@strTipoCliente,@strPreferencia,@strSeleccionProducto,@bigintIdIdentificacionR,@intIdSedeR)";
            SqlCommand sql = new SqlCommand(insertarR, conexion.conexion);

            sql.Parameters.AddWithValue("@intIdReservas", this.intIdReservas);
            sql.Parameters.AddWithValue("@strTipoServicio", this.strTipoServicio);
            sql.Parameters.AddWithValue("@timeHoraReserva", SqlDbType.Date).Value = this.timeHoraReserva;
            sql.Parameters.AddWithValue("@dateFechaReserva", SqlDbType.Date).Value = this.dateFechaReserva;
            sql.Parameters.AddWithValue("@strTipoCliente", this.strTipoCliente);
            sql.Parameters.AddWithValue("@strPreferencia", this.strPreferencia);
            sql.Parameters.AddWithValue("@strSeleccionProducto", this.strSeleccionProducto);
            sql.Parameters.AddWithValue("@bigintIdIdentificacionR", this.bigintIdIdentificacionR);
            sql.Parameters.AddWithValue("@intIdSedeR", this.intIdSedeR);
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


        public bool modificarDatoReservas ()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarR = "update tblReservas set intIdReservas=@intIdReservas,strTipoServicio=@strTipoServicio,timeHoraReserva=@timeHoraReserva,dateFechaReserva=@dateFechaReserva,strTipoCliente=@strTipoCliente,strPreferencia=@strPreferencia,strSeleccionProducto=@strSeleccionProducto,bigintIdIdentificacionR=@bigintIdIdentificacionR,intIdSedeR=@intIdSedeR where intIdReservas=@intIdReservas";
            SqlCommand sql = new SqlCommand(modificarR, conexion.conexion);
            sql.Parameters.AddWithValue("@intIdReservas", this.intIdReservas);
            sql.Parameters.AddWithValue("@strTipoServicio", this.strTipoServicio);
            sql.Parameters.AddWithValue("@timeHoraReserva", SqlDbType.Date).Value = this.timeHoraReserva;
            sql.Parameters.AddWithValue("@dateFechaReserva", SqlDbType.Date).Value = this.dateFechaReserva;
            sql.Parameters.AddWithValue("@strTipoCliente", this.strTipoCliente);
            sql.Parameters.AddWithValue("@strPreferencia", this.strPreferencia);
            sql.Parameters.AddWithValue("@strSeleccionProducto", this.strSeleccionProducto);
            sql.Parameters.AddWithValue("@bigintIdIdentificacionR", this.bigintIdIdentificacionR);
            sql.Parameters.AddWithValue("@intIdSedeR", this.intIdSedeR);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable seleccionarDatoReservas(int intIdReservas)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.intIdReservas=intIdReservas;
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
