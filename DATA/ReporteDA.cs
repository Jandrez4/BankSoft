using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using para conexion a sql y modelos
using ENTIDAD;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DATA
{
    public class ReporteDA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        SqlCommand cmd = new SqlCommand();

        public List<ReporteE> ListadoReporteClientes()
        {
            List<ReporteE> listado = new List<ReporteE>();

            try
            {
                conn.Open();
                cmd = new SqlCommand("spListado_Reportes", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ReporteE reporteE = new ReporteE();
                    reporteE.Id_Reporte = Convert.ToInt32(dr["ID_Reporte"]);
                    reporteE.clienteE.Id_Cliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    reporteE.clienteE.Documento = Convert.ToInt64(dr["DOCUMENTO"]);
                    reporteE.clienteE.Num_Cuenta = Convert.ToInt64(dr["NUM_CUENTA"]);
                    reporteE.SaldoActual = Convert.ToDouble(dr["SALDO"]);

                    listado.Add(reporteE);

                }
            }
            catch (Exception)
            {
                throw;
            }


            return listado;
        }
    }
}
