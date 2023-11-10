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
    public class ClienteDA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        SqlCommand cmd = new SqlCommand();  

        public List<ClienteE> ListadoClientes()
        {
            List<ClienteE> listado = new List<ClienteE>();
            try
            {
                conn.Open();
                cmd = new SqlCommand("spListar_Clientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteE clienteE = new ClienteE();
                    clienteE.Id_Cliente = Convert.ToInt32(dr["ID"]);
                    clienteE.Nombre = dr["NOMBRES"].ToString();
                    clienteE.Apellido = dr["APELLIDOS"].ToString();
                    clienteE.Documento = Convert.ToInt64(dr["DOCUMENTO"]);
                    clienteE.Tipo_Cliente = dr["TIPO CLIENTE"].ToString();
                    clienteE.Origen_Apertura_Cuenta = dr["ORIGEN CUENTA"].ToString();
                    clienteE.Num_Cuenta = Convert.ToInt64(dr["NUMERO CUENTA"]);
                    clienteE.Tipo_Cuenta = dr["TIPO CUENTA"].ToString();
                    clienteE.Tipo_Documento = dr["TIPO DOCUMENTO"].ToString();

                    listado.Add(clienteE);
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            return listado; 
        }

        public bool AgregarCliente (ClienteE clienteE)
        {
            bool respuesta = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("spAgregar_Clientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter CNombre = new SqlParameter();
                CNombre.ParameterName = "@Nombre";
                CNombre.SqlDbType = SqlDbType.VarChar;
                CNombre.Size = 30;
                CNombre.Value = clienteE.Nombre;

                SqlParameter CApellido = new SqlParameter();
                CApellido.ParameterName = "@Apellido";
                CApellido.SqlDbType = SqlDbType.VarChar;
                CApellido.Size = 30;
                CApellido.Value = clienteE.Apellido;

                SqlParameter CDocumento = new SqlParameter();
                CDocumento.ParameterName = "@Documento";
                CDocumento.SqlDbType = SqlDbType.BigInt;
                CDocumento.Value = clienteE.Documento;

                SqlParameter CTipoCuenta = new SqlParameter();
                CTipoCuenta.ParameterName = "@Tipo_Cuenta";
                CTipoCuenta.SqlDbType = SqlDbType.VarChar;
                CTipoCuenta.Size = 10;
                CTipoCuenta.Value = clienteE.Tipo_Cuenta;

                SqlParameter COrigenApertura = new SqlParameter();
                COrigenApertura.ParameterName = "@Origen_Apertura_cuenta";
                COrigenApertura.SqlDbType = SqlDbType.VarChar;
                COrigenApertura.Size = 50;
                COrigenApertura.Value = clienteE.Tipo_Cuenta;

                SqlParameter CNumCuenta = new SqlParameter();
                CNumCuenta.ParameterName = "@Num_Cuenta";
                CNumCuenta.SqlDbType = SqlDbType.BigInt;
                CNumCuenta.Value = clienteE.Num_Cuenta;


               /* SqlParameter CF_Creacion = new SqlParameter();
                CF_Creacion.ParameterName = "@F_Creacion_Cuenta";
                CF_Creacion.SqlDbType = SqlDbType.DateTime;
                CF_Creacion.Value = clienteE.Documento;*/


                SqlParameter CTipoCliente = new SqlParameter();
                CTipoCliente.ParameterName = "@Tipo_Cliente";
                CTipoCliente.SqlDbType = SqlDbType.VarChar;
                CTipoCliente.Size = 15;
                CTipoCliente.Value = clienteE.Tipo_Cliente;

                SqlParameter CTipoDocumento = new SqlParameter();
                CTipoDocumento.ParameterName = "@Tipo_Documento";
                CTipoDocumento.SqlDbType = SqlDbType.VarChar;
                CTipoDocumento.Size = 2;
                CTipoDocumento.Value = clienteE.Tipo_Cuenta;



                cmd.Parameters.Add(CNombre);
                cmd.Parameters.Add(CApellido);
                cmd.Parameters.Add(CDocumento);
                cmd.Parameters.Add(CTipoCuenta);
                //cmd.Parameters.Add(CF_Creacion);
                cmd.Parameters.Add(COrigenApertura);
                cmd.Parameters.Add(CNumCuenta);
                cmd.Parameters.Add(CTipoCliente);
                cmd.Parameters.Add(CTipoDocumento);

                cmd.ExecuteNonQuery();

                respuesta = true;

            }
            catch(Exception)
            {
                throw;
            }

            return respuesta;
        }

        public ClienteE BuscarId(int Id_Cliente)
        {
            ClienteE clienteE = new ClienteE();
            try
            {
                conn.Open();
                cmd = new SqlCommand("spBuscarId", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter cId_Cliente = new SqlParameter();
                cId_Cliente.ParameterName = "@Id_Cliente";
                cId_Cliente.SqlDbType = SqlDbType.Int;
                cId_Cliente.Value = Id_Cliente;

                cmd.Parameters.Add(cId_Cliente);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if(dr.HasRows)
                {
                    clienteE.Id_Cliente = Convert.ToInt32(dr["ID"]);
                    clienteE.Nombre = dr["NOMBRE"].ToString();
                    clienteE.Apellido = dr["APELLIDOS"].ToString();
                    clienteE.Documento = Convert.ToInt64(dr["DOCUMENTO"]);
                    clienteE.Tipo_Cliente = dr["TIPO CLIENTE"].ToString();
                    clienteE.Origen_Apertura_Cuenta = dr["ORIGEN CUENTA"].ToString();
                    clienteE.Tipo_Cuenta = dr["TIPO CUENTA"].ToString();
                    clienteE.Num_Cuenta = Convert.ToInt64(dr["NUMERO CUENTA"]);
                    clienteE.Tipo_Documento = dr["TIPO DOCUMENTO"].ToString();


                }

            }
            catch(Exception)
            {
                throw;
            }

            return clienteE;
        }

        public bool ActualizarCliente(ClienteE clienteE)
        {
            bool respuesta = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("spActualizarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter cId_Cliente = new SqlParameter();
                cId_Cliente.ParameterName = "@Id_Cliente";
                cId_Cliente.SqlDbType = SqlDbType.Int;
                cId_Cliente.Value = clienteE.Id_Cliente;

                SqlParameter CNombre = new SqlParameter();
                CNombre.ParameterName = "@Nombre";
                CNombre.SqlDbType = SqlDbType.VarChar;
                CNombre.Size = 30;
                CNombre.Value = clienteE.Nombre;

                SqlParameter CApellido = new SqlParameter();
                CApellido.ParameterName = "@Apellido";
                CApellido.SqlDbType = SqlDbType.VarChar;
                CApellido.Size = 30;
                CApellido.Value = clienteE.Apellido;

                SqlParameter CDocumento = new SqlParameter();
                CDocumento.ParameterName = "@Documento";
                CDocumento.SqlDbType = SqlDbType.BigInt;
                CDocumento.Value = clienteE.Documento;

                SqlParameter CTipoCuenta = new SqlParameter();
                CTipoCuenta.ParameterName = "@Tipo_Cuenta";
                CTipoCuenta.SqlDbType = SqlDbType.VarChar;
                CTipoCuenta.Size = 10;
                CTipoCuenta.Value = clienteE.Tipo_Cuenta;

                SqlParameter COrigenApertura = new SqlParameter();
                COrigenApertura.ParameterName = "@Origen_Apertura_cuenta";
                COrigenApertura.SqlDbType = SqlDbType.VarChar;
                COrigenApertura.Size = 50;
                COrigenApertura.Value = clienteE.Tipo_Cuenta;

                SqlParameter CNumCuenta = new SqlParameter();
                CNumCuenta.ParameterName = "@Num_Cuenta";
                CNumCuenta.SqlDbType = SqlDbType.BigInt;
                CNumCuenta.Value = clienteE.Num_Cuenta;


                /* SqlParameter CF_Creacion = new SqlParameter();
                 CF_Creacion.ParameterName = "@F_Creacion_Cuenta";
                 CF_Creacion.SqlDbType = SqlDbType.DateTime;
                 CF_Creacion.Value = clienteE.Documento;*/


                SqlParameter CTipoCliente = new SqlParameter();
                CTipoCliente.ParameterName = "@Tipo_Cliente";
                CTipoCliente.SqlDbType = SqlDbType.VarChar;
                CTipoCliente.Size = 15;
                CTipoCliente.Value = clienteE.Tipo_Cliente;

                SqlParameter CTipoDocumento = new SqlParameter();
                CTipoDocumento.ParameterName = "@Tipo_Documento";
                CTipoDocumento.SqlDbType = SqlDbType.VarChar;
                CTipoDocumento.Size = 2;
                CTipoDocumento.Value = clienteE.Tipo_Cuenta;


                cmd.Parameters.Add(cId_Cliente);
                cmd.Parameters.Add(CNombre);
                cmd.Parameters.Add(CApellido);
                cmd.Parameters.Add(CDocumento);
                cmd.Parameters.Add(CTipoCuenta);
                //cmd.Parameters.Add(CF_Creacion);
                cmd.Parameters.Add(COrigenApertura);
                cmd.Parameters.Add(CNumCuenta);
                cmd.Parameters.Add(CTipoCliente);
                cmd.Parameters.Add(CTipoDocumento);

                cmd.ExecuteNonQuery();

                respuesta = true;

            }
            catch (Exception)
            {
                throw;
            }

            return respuesta;
        }

        public bool EliminarCliente(int Id_Cliente)
        {
            bool eliminado = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("spEliminarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter cId_Cliente = new SqlParameter();
                cId_Cliente.ParameterName = "@Id_Cliente";
                cId_Cliente.SqlDbType = SqlDbType.Int;
                cId_Cliente.SqlValue = Id_Cliente;

                cmd.Parameters.Add(cId_Cliente);

                cmd.ExecuteNonQuery();

                eliminado = true;
            }
            catch(Exception)
            {
                throw;
            }


            return eliminado;
        }
    }
}
