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
    internal class Clientes_DAO
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

        public DataTable sp_GetClientes()
        {
            string msg = "";
            DataTable tablaResultado = new DataTable();
            try
            {
                conectar(); // Método tuyo para abrir conexión
                string qry = "sp_GetClientes";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(tablaResultado);
            }
            catch (SqlException e)
            {
                msg = "Error al obtener los datos de los clientes: \n" + e.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar(); // Método tuyo para cerrar conexión
            }
            return tablaResultado;
        }

        public void sp_GestionCliente(
          char opcion,
          string nombre,
          DateTime fechaNac,
          string correo,
          string edoCivil,
          string rfc,
          string tel,
          string cel,
          string ciudad,
          string estado,
          string pais
      )
        {
            string msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionClientes"; // Asegúrate de que este sea el nombre correcto de tu SP
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetros del procedimiento
                _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1).Value = opcion;
                _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = nombre;
                _comandosql.Parameters.Add("@fechanac", SqlDbType.Date).Value = fechaNac;
                _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 30).Value = correo;
                _comandosql.Parameters.Add("@edocivil", SqlDbType.VarChar, 20).Value = edoCivil ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@rfc", SqlDbType.VarChar, 20).Value = rfc ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@tel", SqlDbType.VarChar, 20).Value = tel ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@cel", SqlDbType.VarChar, 20).Value = cel ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@ciudad", SqlDbType.VarChar, 30).Value = ciudad ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@estado", SqlDbType.VarChar, 30).Value = estado ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@pais", SqlDbType.VarChar, 30).Value = pais ?? (object)DBNull.Value;

                // Ejecutar sin resultados
                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                msg = "Error al ejecutar el procedimiento SP_GESTION_CLIENTE:\n" + ex.Message;
                MessageBox.Show(msg, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
        }











        }
}
