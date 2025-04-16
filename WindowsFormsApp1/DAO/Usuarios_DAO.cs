using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace WindowsFormsApp1.DAO
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

        public DataTable LoginUsuario(string numNomina, string contrasena)
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

        //public DataTable get_Usuarios()
        //{
        //    var msg = "";
        //    DataTable tabla = new DataTable();
        //    try
        //    {
        //        conectar();

        //        string qry = "Select Nombre, email, Fecha_modif from Usuarios where Activo = 0;";
        //        _comandosql = new SqlCommand(qry, _conexion);
        //        _comandosql.CommandType = CommandType.Text;
        //        _comandosql.CommandTimeout = 1200;

        //        _adaptador.SelectCommand = _comandosql;
        //        _adaptador.Fill(tabla);

        //    }
        //    catch (SqlException e)
        //    {
        //        msg = "Excepción de base de datos: \n";
        //        msg += e.Message;
        //        MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    }
        //    finally
        //    {
        //        desconectar();
        //    }

        //    return tabla;
        //}
    }
}
