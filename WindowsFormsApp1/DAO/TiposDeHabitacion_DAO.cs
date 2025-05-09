using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using WindowsFormsApp1.MODELOS;

namespace PIA_VILLA
{
    internal class TiposDeHabitacion_DAO
    {
        private SqlConnection _conexion;
        private SqlCommand _comandosql;
        private SqlDataAdapter _adaptador;

        private void Conectar()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["WINAUTH"].ConnectionString;
            _conexion = new SqlConnection(cadenaConexion);
            _conexion.Open();
        }

        private void Desconectar()
        {
            if (_conexion != null && _conexion.State == ConnectionState.Open)
            {
                _conexion.Close();
            }
        }

        // Método nuevo para cargar datos en un CheckedListBox
        // En TiposDeHabitacion_DAO.cs
        public void CargarCLBAmenidades(CheckedListBox checkedListBox)
        {
            try
            {
                Conectar();
                string query = "SELECT IDAmenidad, NombreAmenidad FROM Amenidades ORDER BY NombreAmenidad";
                _comandosql = new SqlCommand(query, _conexion);
                SqlDataReader reader = _comandosql.ExecuteReader();

                checkedListBox.Items.Clear();
                checkedListBox.DisplayMember = "Nombre";  // Muestra el nombre
                checkedListBox.ValueMember = "ID";        // Valor interno (no usado directamente)

                while (reader.Read())
                {
                    Amenidades amenidad = new Amenidades
                    {
                        IDAmenidad = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    };
                    checkedListBox.Items.Add(amenidad);
                }
                reader.Close();
            }
            finally
            {
                Desconectar();
            }
        }
        public List<int> ObtenerAmenidadesIDsPorTipoHab(int idTipoHab)
        {
            List<int> amenidadesIDs = new List<int>();
            try
            {
                Conectar();
                string query = @"SELECT AH.IDAmenidad 
                         FROM AmenidadesHabitacion AH
                         WHERE AH.IDTipoHab = @IDTipoHab";
                _comandosql = new SqlCommand(query, _conexion);
                _comandosql.Parameters.AddWithValue("@IDTipoHab", idTipoHab);
                SqlDataReader reader = _comandosql.ExecuteReader();

                while (reader.Read())
                {
                    amenidadesIDs.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return amenidadesIDs;
        }

        // Dentro de tu clase TiposDeHabitacion_DAO
        public DataTable sp_GetTiposHabPorHotel(int idHotel, int opcion, int? idTipoHab = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                _comandosql = new SqlCommand("sp_GetTiposHab", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.Parameters.AddWithValue("@IDHotel", idHotel);
                _comandosql.Parameters.AddWithValue("@opcion", opcion);
                _comandosql.Parameters.AddWithValue("@IDTipoHab", (object)idTipoHab ?? DBNull.Value);
                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(dt);
            }
            finally { Desconectar(); }
            return dt;
        }

        public void GestionTipoHabitacion(char opcion, int? idTipoHab, int? idHotel, int? capacidad, string nivel, int? numCamas, string tipoCamas, decimal? costo, int? cantidad, string cadenaAmenidades,string cadenaCaracteristicas)
        {
            try
            {
                Conectar();
                _comandosql = new SqlCommand("sp_GestionTiposHabitacion", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.Parameters.AddWithValue("@opcion", SqlDbType.Char).Value = opcion;

                // Parámetros que pueden ser NULL
                _comandosql.Parameters.AddWithValue("@IDTipoHab", SqlDbType.Int).Value = idTipoHab.HasValue ? (object)idTipoHab.Value : DBNull.Value;
                _comandosql.Parameters.AddWithValue("@IDHotel", SqlDbType.Int).Value = idHotel.HasValue ? (object)idHotel.Value : DBNull.Value;
                _comandosql.Parameters.AddWithValue("@Capacidad", SqlDbType.Int).Value = capacidad.HasValue ? (object)capacidad.Value : DBNull.Value;
                _comandosql.Parameters.AddWithValue("@Nivel", SqlDbType.VarChar).Value = nivel ?? (object)DBNull.Value;
                _comandosql.Parameters.AddWithValue("@NumCamas", SqlDbType.Int).Value = numCamas.HasValue ? (object)numCamas.Value : DBNull.Value;
                _comandosql.Parameters.AddWithValue("@TipoCamas", SqlDbType.NVarChar).Value = tipoCamas ?? (object)DBNull.Value;
                _comandosql.Parameters.AddWithValue("@Costo", SqlDbType.Decimal).Value = costo.HasValue ? (object)costo.Value : DBNull.Value;
                _comandosql.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = cantidad.HasValue ? (object)cantidad.Value : DBNull.Value;
                _comandosql.Parameters.AddWithValue("@CadenaAmenidades", SqlDbType.NVarChar).Value = cadenaAmenidades ?? (object)DBNull.Value;
                _comandosql.Parameters.AddWithValue("@CadenaCaracteristicas",cadenaCaracteristicas ?? (object)DBNull.Value);

                _comandosql.ExecuteNonQuery();

                string mensaje = "";
                switch (opcion)
                {
                    case 'A':
                        mensaje = "Tipo de habitación añadido correctamente.";
                        break;
                    case 'M':
                        mensaje = "Tipo de habitación modificado correctamente.";
                        break;
                    case 'E':
                        mensaje = "Tipo de habitación eliminado correctamente.";
                        break;
                }
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al gestionar tipo de habitación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable ObtenerCaracteristicasPorTipoHab(int idTipoHab)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                _comandosql = new SqlCommand(
                    "SELECT Característica FROM CarTipoCuarto WHERE IDTipoHab = @IDTipoHab",
                    _conexion
                );
                _comandosql.Parameters.AddWithValue("@IDTipoHab", idTipoHab);
                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(dt);
            }
            finally { Desconectar(); }
            return dt;
        }

    }
}