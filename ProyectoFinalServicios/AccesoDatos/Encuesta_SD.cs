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
    public class Encuesta_SD : ClaseBase
    {
        public List<EncuestaModel> Listar()
        {
            List<EncuestaModel> lista = new List<EncuestaModel>();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT e.idEncuesta,e.idUsuario, u.nomUsu, e.nomEncuesta, e.contRespuestas, e.fchaCreacion, e.idEstado, te.nomEstado FROM encuesta e inner join usuario u on e.idUsuario = u.idUsuario inner join tipoestado te on e.idEstado = te.idEstado order by e.idEncuesta; ";

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
                    oEncuesta.ContRespuestas = reader.GetInt32(4);
                    oEncuesta.FchaCreacion = reader.GetString(5);
                    oEncuesta.TipoEstado.IdTipoEstado = reader.GetInt32(6);
                    oEncuesta.TipoEstado.NomTipoEstado = reader.GetString(7);

                    lista.Add(oEncuesta);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return lista;
        }
        public List<RespuestaModelo> ListarEncuestaCompleta(int id)
        {
            List<RespuestaModelo> lista = new List<RespuestaModelo>();

            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT e.idEncuesta,e.nomEncuesta, p.idPregunta,p.descPregunta,p.idTipoPregunta, r.idRespuesta,r.descRespuesta FROM pregunta p left join respuesta r on p.idPregunta=r.idPregunta inner JOIN encuesta e on p.idEncuesta=e.idEncuesta where e.idEncuesta = @param_id";
            command.Parameters.AddWithValue("@param_id", id);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RespuestaModelo oRespuesta = new RespuestaModelo();

                    oRespuesta.idRespuesta = reader.GetInt32(5);
                    oRespuesta.pregunta.idPregunta = reader.GetInt32(2);
                    oRespuesta.pregunta.encuesta.IdEncuesta = reader.GetInt32(0);
                    oRespuesta.pregunta.encuesta.NomEncuesta = reader.GetString(1);
                    oRespuesta.pregunta.descPregunta = reader.GetString(3);
                    oRespuesta.pregunta.tipoPregunta.idTipoPregunta = reader.GetInt32(4);
                    oRespuesta.descRespuesta = reader.GetString(6);



                    lista.Add(oRespuesta);
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
