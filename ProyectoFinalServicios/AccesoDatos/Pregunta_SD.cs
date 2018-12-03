using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;
using AccesoDatos;

namespace AccesoDatos
{
    public class Pregunta_SD : ClaseBase
    {
        public List<EncuestaModel> Listar(int idEncuesta)
        {
            List<EncuestaModel> lista = new List<EncuestaModel>();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "STP_ListarEncuesta";
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EncuestaModel oEncuesta = new EncuestaModel();
                    oEncuesta.IdEncuesta = reader.GetInt32(0);
                    oEncuesta.Usuario.IdUsuario = reader.GetInt32(1);
                    oEncuesta.Usuario.NomUsu = reader.GetString(2);
                    oEncuesta.NomEncuesta = reader.GetString(3);
                    oEncuesta.FechaCreacion = reader.GetString(4);
                    oEncuesta.TipoEstado.IdTipoEstado = reader.GetInt32(5);
                    oEncuesta.TipoEstado.NomTipoEstado = reader.GetString(6);
                    oEncuesta.cantPreg = reader.GetInt32(7);

                    lista.Add(oEncuesta);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return lista;
        }
        public List<TipoPreguntaModelo> ListarTipos()
        {
            List<TipoPreguntaModelo> lista = new List<TipoPreguntaModelo>();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "STP_ListarTipoPregunta";
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoPreguntaModelo oTipoPregunta = new TipoPreguntaModelo();
                    oTipoPregunta.idTipoPregunta = reader.GetInt32(0);
                    oTipoPregunta.nomTipoPregunta = reader.GetString(1);
                    lista.Add(oTipoPregunta);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return lista;
        }

    }
}
