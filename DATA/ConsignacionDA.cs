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
    public class ConsignacionDA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        SqlCommand cmd = new SqlCommand();

        public List<ConsignacionE> ListadoConsignaciones()
        {
            List<ConsignacionE> listado = new List<ConsignacionE>();

            try
            {
                conn.Open();
                cmd = new SqlCommand("spListado_Consignaciones", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ConsignacionE consignacionE = new ConsignacionE();
                    consignacionE.Id_Consignacion = Convert.ToInt32(dr["ID_CONSIGNACION"]);
                    consignacionE.clienteE.Id_Cliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    consignacionE.Documento_Envia = Convert.ToInt64(dr["DOCUMENTO_ENVIA"]);
                    consignacionE.clienteE.Documento = Convert.ToInt64(dr["DOCUEMNTO_RECIBE"]);
                    consignacionE.clienteE.Num_Cuenta = Convert.ToInt64(dr["NUM_CUENTA"]);
                    consignacionE.Valor_Consignacion = Convert.ToDouble(dr["CONSIGNACION"]);

                    listado.Add(consignacionE);

                }
            }
            catch (Exception)
            {
                throw;
            }


            return listado;
        }

        public bool CrearConsignacion(ConsignacionE consignacionE)
        {
            bool consignacion = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("spCrearConsignacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter gIdCliente = new SqlParameter();
                gIdCliente.ParameterName = "@Id_Cliente";
                gIdCliente.SqlDbType = SqlDbType.Int;
                gIdCliente.SqlValue = consignacionE.clienteE.Id_Cliente;

                SqlParameter gDoc_Envia = new SqlParameter();
                gDoc_Envia.ParameterName = "@Documento_Envia";
                gDoc_Envia.SqlDbType = SqlDbType.BigInt;
                gDoc_Envia.SqlValue = consignacionE.Documento_Envia;


                SqlParameter gDoc_Cliente = new SqlParameter();
                gDoc_Cliente.ParameterName = "@Documento_Cliente";
                gDoc_Cliente.SqlDbType = SqlDbType.BigInt;
                gDoc_Cliente.SqlValue = consignacionE.clienteE.Documento;

                SqlParameter gCuenta = new SqlParameter();
                gCuenta.ParameterName = "@Num_Cuenta";
                gCuenta.SqlDbType = SqlDbType.BigInt;
                gCuenta.SqlValue = consignacionE.clienteE.Num_Cuenta;

                SqlParameter gConsigancion = new SqlParameter();
                gConsigancion.ParameterName = "@Valor_Consignacion";
                gConsigancion.SqlDbType = SqlDbType.Money;
                gConsigancion.SqlValue = consignacionE.Valor_Consignacion;


                cmd.Parameters.Add(gIdCliente);
                cmd.Parameters.Add(gDoc_Envia);
                cmd.Parameters.Add(gDoc_Cliente);
                cmd.Parameters.Add(gCuenta);
                cmd.Parameters.Add(gConsigancion);

                cmd.ExecuteNonQuery();


                consignacion = true;

            }
            catch (Exception)
            {
                throw;
            }

            return consignacion;
        }
    }
}
