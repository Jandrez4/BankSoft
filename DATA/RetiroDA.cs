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
    public class RetiroDA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        SqlCommand cmd = new SqlCommand();

        public List<RetiroE> ListadoRetiros()
        {
            List<RetiroE> listado = new List<RetiroE>();

            try
            {
                conn.Open();
                cmd = new SqlCommand("spListado_Retiros", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    RetiroE retiroE = new RetiroE();
                    retiroE.Id_Retiro = Convert.ToInt32(dr["ID_RETIRO"]);
                    retiroE.clienteE.Id_Cliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    retiroE.clienteE.Documento = Convert.ToInt64(dr["DOCUMENTO"]);
                    retiroE.clienteE.Num_Cuenta = Convert.ToInt64(dr["NUM_CUENTA"]);
                    retiroE.Valor_Retiro = Convert.ToDouble(dr["RETIRO"]);

                    listado.Add(retiroE);

                }
            }
            catch (Exception)
            {
                throw;
            }


            return listado;
        }

        public bool CrearRetiro(RetiroE retiroE)
        {
            bool retiro = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("spCrearRetiro", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter rDocCliente = new SqlParameter();
                rDocCliente.ParameterName = "@Id_Cliente";
                rDocCliente.SqlDbType = SqlDbType.Int;
                rDocCliente.SqlValue = retiroE.clienteE.Id_Cliente;

                SqlParameter rDocuemnto = new SqlParameter();
                rDocuemnto.ParameterName = "@Documento";
                rDocuemnto.SqlDbType = SqlDbType.BigInt;
                rDocuemnto.SqlValue = retiroE.clienteE.Documento;

                SqlParameter rCuenta = new SqlParameter();
                rCuenta.ParameterName = "@Num_Cuenta";
                rCuenta.SqlDbType = SqlDbType.BigInt;
                rCuenta.SqlValue = retiroE.clienteE.Num_Cuenta;

                SqlParameter vRetiro = new SqlParameter();
                vRetiro.ParameterName = "@Valor_Retiro";
                vRetiro.SqlDbType = SqlDbType.Money;
                vRetiro.SqlValue = retiroE.Valor_Retiro;

                cmd.Parameters.Add(rDocCliente);
                cmd.Parameters.Add(rDocuemnto);
                cmd.Parameters.Add(rCuenta);
                cmd.Parameters.Add(vRetiro);

                cmd.ExecuteNonQuery();


                retiro = true;

            }
            catch(Exception)
            {
                throw;
            }

            return retiro;
        }
    }
}
