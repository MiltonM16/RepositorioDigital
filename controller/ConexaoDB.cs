using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RepositorioDigital.controller
{
	class ConexaoDB
	{
        public static MySqlConnection ObterConexao()
        {
            string servidor = "localhost";
            string usuario = "root";
            string senha = "";
            string bancoDados = "rdbd";

            string connectionString = $"Server={servidor};Database={bancoDados};Uid={usuario};Pwd={senha};";

            return new MySqlConnection(connectionString);
        }
    }
}
