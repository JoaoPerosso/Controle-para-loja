using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Trabalho
{
    public class ProdutoDAO
    {
        //DAO - objeto de acesso aos dados
        public int gravar(Produto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into produto(descr,qtde,preco) values(@d,@q,@p)";
                bb.comando.Parameters.Add("@d", NpgsqlDbType.Varchar).Value = obj.descr;
                bb.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
                bb.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.preco;
                bb.comando.Prepare();  // junta os campos com o sql
                qtde = bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }

        }
        public int getQtde(Produto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select qtde from produto where codigo = @c";
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = obj.codigo;
                bb.comando.Prepare();
                qtde = (int)bb.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {

                throw new Exception("Problema ao resgatar a qtde do produto na inserção da quantidade no txtBOx" + ex.Message);
            }
        }


        public int alterar(Produto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Update produto set descr=@d, qtde=@q, preco=@p where codigo=@c";
                bb.comando.Parameters.Add("@d", NpgsqlDbType.Varchar).Value = obj.descr;
                bb.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
                bb.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.preco;
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = obj.codigo;
                bb.comando.Prepare();  // junta os campos com o sql
                qtde = bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar: " + ex.Message);
            }

        }


        public int remover(Produto obj)
        {
            Banco bb;
            int qtde;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Delete from produto where codigo=@c";
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = obj.codigo;
                bb.comando.Prepare();  // junta os campos com o sql
                qtde = bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
                return (qtde);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover: " + ex.Message);
            }

        }

        public DataTable listar()
        {
            Banco bb;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select codigo,descr,qtde,preco, qtde*preco as \"total\" from produto order by 1";
                bb.dreader = bb.comando.ExecuteReader(); //executa o sql e retorna uma tabela
                bb.tabela = new DataTable();
                bb.tabela.Load(bb.dreader);//carrega a tabela formato postgres 
                Banco.conexao.Close();
                return (bb.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar:" + ex.Message);
            }
        }
        // devolve o objeto com dados, quando encontrado no banco, ou null quando não
        public Produto preencher(int cod)
        {
            Banco bb;
            Produto obj = null;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select codigo,descr,qtde, preco from produto where codigo=@c";
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = cod;
                bb.comando.Prepare();
                bb.dreader = bb.comando.ExecuteReader();
                if (bb.dreader.Read()) //verifica a existência do próximo registro
                {
                    obj = new Produto();
                    obj.setCodigo((int)bb.dreader[0]);
                    if (bb.dreader[1] != null)
                        obj.setDescr(bb.dreader[1].ToString());
                    obj.setQtde((int)bb.dreader[2]);
                    obj.setPreco((double)bb.dreader[3]);
                }
                bb.dreader.Close();
                Banco.conexao.Close();
                return (obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher: " + ex.Message);
            }
        }
    
    
        public DataTable buscarParteNome(string pDescr)
        {
            Banco bb;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select codigo,descr,qtde, preco from produto where descr ilike @pn";
                bb.comando.Parameters.Add("@pn", NpgsqlDbType.Varchar).Value = "%" + pDescr.Trim() + "%";
                bb.comando.Prepare();
                bb.dreader = bb.comando.ExecuteReader();
                bb.tabela = new DataTable();
                bb.tabela.Load(bb.dreader);//converte o dataReader no DataTable
                Banco.conexao.Close();
                return (bb.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na busca por parte da descrição: " + ex.Message);
            }
        }
    }
}
