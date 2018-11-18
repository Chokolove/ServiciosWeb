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
        Secundarios_SD secundarios = new Secundarios_SD();
        Usuario_SD usuario_SD = new Usuario_SD();
        public List<EncuestaModel> Listar()
        {
            List<EncuestaModel> lista = new List<EncuestaModel>();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from encuesta";

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    EncuestaModel oEncuesta = new EncuestaModel();
                    oEncuesta.IdEncuesta = reader.GetInt32(0);
                    oEncuesta.Usuario = usuario_SD.buscarUsuario( reader.GetInt32(1));
                    oEncuesta.NomEncuesta = reader.GetString(2);
                    oEncuesta.ContRespuestas = reader.GetInt32(3);
                    oEncuesta.FchaCreacion = reader.GetString(4);

              
                    oEncuesta.TipoEstado= secundarios.buscaTipoEstado( reader.GetInt32(5) );

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
    }
}
