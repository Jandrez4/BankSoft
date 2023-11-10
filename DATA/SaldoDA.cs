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
    public class SaldoDA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        SqlCommand cmd = new SqlCommand();

        public List<SaldoE> ListadoSaldoCliente()
        {
            List<SaldoE> listado = new List<SaldoE>();

            try
            {
                conn.Open();
                cmd = new SqlCommand("spListado_Saldo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SaldoE saldoE = new SaldoE();
                    saldoE.Id_Saldo = Convert.ToInt32(dr["ID_SALDO"]);
                    saldoE.clienteE.Id_Cliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    saldoE.clienteE.Documento = Convert.ToInt64(dr["DOCUMENTO"]);
                    saldoE.clienteE.Num_Cuenta = Convert.ToInt64(dr["NUM_CUENTA"]);
                    saldoE.Saldo_Actual = Convert.ToDouble(dr["SALDO"]);

                    listado.Add(saldoE);

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
