using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;
using AccesoDatos;

namespace AccesoDatos
{
    public class Empresa_SD : ClaseBase
    {
        Secundarios_SD secundarios = new Secundarios_SD();
        public List<EmpresaModelo> Listar()
        {
            List<EmpresaModelo> lista = new List<EmpresaModelo>();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from empresa";

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmpresaModelo oEmpresa = new EmpresaModelo();
                    oEmpresa.IdEmpresa = reader.GetInt32(0);
                    oEmpresa.NomEmpresa = reader.GetString(1);
                    oEmpresa.TipoEmpresa = secundarios.buscaTipoEmpresa(reader.GetInt32(2));
                    oEmpresa.FchaCreacion = reader.GetString(3);
                    oEmpresa.TipoEstado = secundarios.buscaTipoEstado(reader.GetInt32(4));

                    lista.Add(oEmpresa);
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
        public EmpresaModelo buscarEmpresa(int id)
        {
            EmpresaModelo oEmpresa = new EmpresaModelo();
            MySqlConnection conn = new MySqlConnection(this.CadenaConexion());
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from empresa where idEmpresa = @id";
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    oEmpresa.IdEmpresa = reader.GetInt32(0);
                    oEmpresa.NomEmpresa = reader.GetString(1);
                    oEmpresa.TipoEmpresa = secundarios.buscaTipoEmpresa(reader.GetInt32(2));
                    oEmpresa.FchaCreacion = reader.GetString(3);
                    oEmpresa.TipoEstado = secundarios.buscaTipoEstado(reader.GetInt32(4));
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

            return oEmpresa;
        }
    }
}
