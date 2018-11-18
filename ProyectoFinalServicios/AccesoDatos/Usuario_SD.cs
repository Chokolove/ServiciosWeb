using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using AccesoDatos;
using System.Data;

namespace AccesoDatos
{
    public class Usuario_SD : ClaseBase
    {
        Secundarios_SD secundarios = new Secundarios_SD();
        Empresa_SD empresa_SD = new Empresa_SD();

        public List<UsuarioModelo> Listar()
        {
            List<UsuarioModelo> lista = new List<UsuarioModelo>();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from usuario";

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UsuarioModelo oUsuario = new UsuarioModelo();
                    oUsuario.IdUsuario = reader.GetInt32(0);
                    oUsuario.NomUsu = reader.GetString(3);
                    oUsuario.Empresa = empresa_SD.buscarEmpresa(reader.GetInt32(4));
                    oUsuario.FchaCreacion = reader.GetString(5);
                    oUsuario.TipoUsuario = secundarios.buscaTipoUsuario(reader.GetInt32(6));
                    oUsuario.TipoEstado = secundarios.buscaTipoEstado(reader.GetInt32(7));
                    lista.Add(oUsuario);
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



        public UsuarioModelo buscarUsuario(int id)
        {
            UsuarioModelo oUsuario = new UsuarioModelo();

            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from usuario where idUsuario = @id";
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    oUsuario.IdUsuario = reader.GetInt32(0);
                    oUsuario.NomUsu = reader.GetString(3);
                    oUsuario.Empresa = empresa_SD.buscarEmpresa(reader.GetInt32(4));
                    oUsuario.FchaCreacion = reader.GetString(5);
                    oUsuario.TipoUsuario = secundarios.buscaTipoUsuario(reader.GetInt32(6));
                    oUsuario.TipoEstado = secundarios.buscaTipoEstado(reader.GetInt32(7));

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

            return oUsuario;
        }
    }
}
