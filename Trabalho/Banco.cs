using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Trabalho
{

    public class Banco
    {
        //responsável pela conexão com o banco de dados
        public static NpgsqlConnection conexao;

        //envia sql para o banco
        public NpgsqlCommand comando;

        //tabela no formato postgres
        public NpgsqlDataReader dreader;

        //tabela no formato c#
        public DataTable tabela;

        public Banco()
        {
            try
            {
                if ((conexao == null) || (conexao.State != ConnectionState.Open))
                {
                    conexao = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=ifsp;Database=trabalhob3;");
                    conexao.Open();
                }
                comando = new NpgsqlCommand();
                comando.Connection = conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de conexão: " + ex.Message);
            }
        }
    }
}
