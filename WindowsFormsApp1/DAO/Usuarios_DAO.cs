using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace PIA_VILLA
{
    internal class Usuarios_DAO
    {
        private SqlConnection _conexion;
        private SqlCommand _comandosql;
        private SqlDataAdapter _adaptador;

        private void conectar()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["WINAUTH"].ConnectionString;
            _conexion = new SqlConnection(cadenaConexion);
            _conexion.Open();
        }

        private void desconectar()
        {
            if (_conexion != null && _conexion.State == ConnectionState.Open)
            {
                _conexion.Close();
            }
        }

        public DataTable sp_LoginUsuario(string numNomina, string contrasena)
        {
            var msg = "";
            DataTable tablaResultado = new DataTable();
            try
            {
                conectar();
                string qry = "sp_LoginUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Agregar los parámetros al stored procedure
                _comandosql.Parameters.Add("@NumNomina", SqlDbType.VarChar, 10).Value = numNomina;
                _comandosql.Parameters.Add("@Contrasena", SqlDbType.VarChar, 20).Value = contrasena;

                // Utilizar el adaptador para llenar la tabla con el resultado del SP
                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(tablaResultado);
            }
            catch (SqlException e)
            {
                msg = "Error al intentar iniciar sesión: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return tablaResultado;
        }

        public DataTable sp_GetBlockUsers()
        {
            var msg = "";
            DataTable tablaResultado = new DataTable();
            try
            {
                conectar();
                string qry = "sp_GetBlockUsers";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(tablaResultado);
            }
            catch (SqlException e)
            {
                msg = "Error al obtener usuarios activos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return tablaResultado;
        }
        public DataTable sp_GetUsuarios()
        {
            var msg = "";
            DataTable tablaResultado = new DataTable();
            try
            {
                conectar();
                string qry = "sp_GetUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(tablaResultado);
            }
            catch (SqlException e)
            {
                msg = "Error al obtener usuarios activos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return tablaResultado;
        }

        public void sp_GestionEmpleado(char opcion, string nombre, DateTime fechaNac, string correo, string puesto, int numNomina, string tel, string contrasena)
        {
            string msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetros del procedimiento
                _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1).Value = opcion;
                _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = nombre;
                _comandosql.Parameters.Add("@fechanac", SqlDbType.Date).Value = fechaNac;
                _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 30).Value = correo;
                _comandosql.Parameters.Add("@puesto", SqlDbType.VarChar, 30).Value = puesto;
                _comandosql.Parameters.Add("@numnomina", SqlDbType.Int).Value = numNomina;
                _comandosql.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
                _comandosql.Parameters.Add("@contrasena", SqlDbType.VarChar, 20).Value = contrasena ?? (object)DBNull.Value;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                desconectar();
            }
        }

        public void HabilitarUsuario(int numNomina)
        {
            string msg = "";
            try
            {
                conectar();
                string qry = "UPDATE Usuarios SET Estatus = 1, IntentosFallidos = 0 WHERE NumNómina = @NumNomina";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.Parameters.Add("@NumNomina", SqlDbType.Int).Value = numNomina;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                msg = "Error al habilitar usuario:\n" + ex.Message;
                MessageBox.Show(msg, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
        }







    }
}
