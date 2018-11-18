using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;

namespace AccesoDatos
{
    public class Secundarios_SD : ClaseBase
    {
        public TipoUsuarioModel buscaTipoUsuario(int id)
        {
            TipoUsuarioModel oTipoUsuario = new TipoUsuarioModel();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from tipousuario where idTipoUsuario = @id";
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();


                oTipoUsuario.IdTipoUsuario = reader.GetInt32(0);
                oTipoUsuario.NomTipoUsuario = reader.GetString(1);


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
            return oTipoUsuario;
        }
        public TipoEmpresaModel buscaTipoEmpresa(int id)
        {

            TipoEmpresaModel oTipoEmpresa = new TipoEmpresaModel();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from tipoempresa where idTipoEmpresa = @id";
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                oTipoEmpresa.IdTipoEmpresa = reader.GetInt32(0);
                oTipoEmpresa.NomTipoEmpresa = reader.GetString(1);


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
            return oTipoEmpresa;
        }
        public TipoEstadoModelo buscaTipoEstado(int id)
        {

            TipoEstadoModelo oTipoEstado = new TipoEstadoModelo();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from tipoestado where idEstado = @id";
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                oTipoEstado.IdTipoEstado = reader.GetInt32(0);
                oTipoEstado.NomTipoEstado = reader.GetString(1);


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
            return oTipoEstado;
        }
    }
}
